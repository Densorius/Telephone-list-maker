using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TelephoneBookApp.Classes;

namespace TelephoneBookApp
{
    public partial class MainForm : Form
    {
        private FileManager _fileManager;
        private TelephoneBook _telephoneBook;
        private string _versionCode;

        public MainForm()
        {
            _fileManager = new FileManager();
            _telephoneBook = new TelephoneBook();
            _versionCode = "1.1";

            InitializeComponent();

            CwGridMenu.Items.Add("Remove row").Click += (sender, eventArgs) => 
            {
                for (var i = 0; i < DgvTelephoneBook.SelectedRows.Count; i++)
                {
                    try
                    {
                        DgvTelephoneBook.Rows.Remove(DgvTelephoneBook.SelectedRows[i]);
                    }
                    catch (InvalidOperationException) { }
                }
            };

            DgvTelephoneBook.TabStop = false;
            _fileManager.FileSaved = true;
        }

        private void GenerateTelephoneBook()
        {
            _telephoneBook.Entries.Clear();

            for (var i = 0; i < DgvTelephoneBook.Rows.Count - 1; i++)
            {
                var index = 0;

                var name = string.Empty;
                var telephoneNumber = string.Empty;
                var adress = string.Empty;

                foreach (DataGridViewCell cell in DgvTelephoneBook.Rows[i].Cells)
                {
                    switch (index)
                    {
                        case 0:
                            name = cell.Value.ToString();
                            break;
                        case 1:
                            telephoneNumber = cell.Value.ToString();
                            break;
                        case 2:
                            adress = cell.Value.ToString();
                            break;
                    }

                    index++;
                }

                _telephoneBook.AddEntry(name, telephoneNumber, adress);
            }
        }

        /// <summary>
        /// Saves the telephonebook
        /// </summary>
        /// <returns>Last dialog result of shown dialog</returns>
        private DialogResult SaveNewTelephoneBook()
        {
            PrepareForSaving();

            return _fileManager.SaveNewTelephoneBook();
        }

        /// <summary>
        /// Prepares the telephonebook for saving and creates the list
        /// </summary>
        private void PrepareForSaving()
        {
            GenerateTelephoneBook();
            _fileManager.CreateTelephoneBookList(_telephoneBook.Entries);
        }

        /// <summary>
        /// Asks the user for saving
        /// </summary>
        /// <returns>false if canceled</returns>
        private bool AskForSavingAndSave()
        {
            bool canceled = false;

            DialogResult dialogResult = MessageBox.Show("Do you want to save changes?", "Save?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Cancel)
                canceled = true;

            if (dialogResult == DialogResult.OK || dialogResult == DialogResult.Yes)
            {
                if (_fileManager.FileName.Equals(String.Empty)) {
                    DialogResult saveDialogResult = SaveNewTelephoneBook();

                    if (saveDialogResult != DialogResult.OK)
                        canceled = true;
                }
                else
                {
                    PrepareForSaving();
                    _fileManager.SaveTelephoneBook();
                }
            }

            return canceled;
        }

        private void BtnAdd_Click(object sender, EventArgs eventArgs)
        {
            string name = TbName.Text.Trim();
            string telephone = TbTelephone.Text.Trim();

            // toggle saved state
            _fileManager.FileSaved = false;

            if (!name.Equals(String.Empty) && !telephone.Equals(String.Empty))
            {
                DgvTelephoneBook.Rows.Add(name, telephone, TbAdress.Text.Trim());

                TbName.Clear();
                TbTelephone.Clear();
                TbAdress.Clear();
            }

            TbName.Focus();
        }

        private void DgvTelephoneBook_MouseClick(object sender, MouseEventArgs eventArgs)
        {
            if (eventArgs.Button == MouseButtons.Right)
            {
                for (var i = 0; i < DgvTelephoneBook.SelectedCells.Count; i++)
                {
                    DgvTelephoneBook.Rows[DgvTelephoneBook.SelectedCells[i].RowIndex].Selected = true;
                }
                CwGridMenu.Show(DgvTelephoneBook, eventArgs.Location);
            }
        }

        private void MenuItemNew_Click(object sender, EventArgs eventArgs)
        {
            bool canceled = false;

            if (!_fileManager.FileSaved)
            {
                canceled = AskForSavingAndSave();
            }

            if (!canceled)
            {
                DgvTelephoneBook.Rows.Clear();
            }
        }

        private void MenuItemOpen_Click(object sender, EventArgs eventArgs)
        {
            bool canceled = false;
            if (!_fileManager.FileSaved)
            {
                canceled = AskForSavingAndSave();
            }

            if (!canceled)
            {
                List<Entry> entries = _fileManager.OpenTelephoneBook();

                DgvTelephoneBook.Rows.Clear();
                entries.ForEach(entry =>
                {
                    DgvTelephoneBook.Rows.Add(entry.Name, entry.TelephoneNumber, entry.Adress);
                });
            }
        }

        private void MenuItemSave_Click(object sender, EventArgs eventArgs)
        {
            if (_fileManager.FileName.Equals(String.Empty))
            {
                SaveNewTelephoneBook();
            }
            else
            {
                PrepareForSaving();
                _fileManager.SaveTelephoneBook();
            }
        }

        private void MenuItemSaveAs_Click(object sender, EventArgs eventArgs)
        {
            SaveNewTelephoneBook();
        }


        private void MenuItemGenerateTelephoneList_Click(object sender, EventArgs eventArgs)
        {
            if (!_fileManager.FileSaved)
            {
                PrepareForSaving();
                _fileManager.SaveTelephoneBook();
            }

            GenerateTelephoneBook();
            _telephoneBook.CompileList();

            _fileManager.SaveTelephoneList(_telephoneBook.FullText);
        }

        private void MenuItemExit_Click(object sender, EventArgs eventArgs)
        {
            Close();
        }

        private void MenuItemAbout_Click(object sender, EventArgs eventArgs)
        {
            var aboutForm = new AboutForm(_versionCode)
            {
                StartPosition = FormStartPosition.CenterParent
            };
            aboutForm.ShowDialog();
        }

        private void DgvTelephoneBook_CellValueChanged(object sender, DataGridViewCellEventArgs eventArgs)
        {
            _fileManager.FileSaved = false;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs eventArgs)
        {
            if (!_fileManager.FileSaved)
                eventArgs.Cancel = AskForSavingAndSave();
        }
    }
}
