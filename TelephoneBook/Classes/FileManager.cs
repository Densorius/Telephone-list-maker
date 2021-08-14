using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelephoneBookApp.Classes
{
    public class FileManager
    {
        private readonly string _extention;

        private List<string> _lines;

        private delegate void PerformSaving(string fileName);

        public string FileName { get; private set; }
        public bool FileSaved { get; set; }

        public FileManager()
        {
            _extention = ".phbk";

            _lines = new List<string>();

            FileSaved = true;
            FileName = String.Empty;
        }

        /// <summary>
        /// Creates the telephoneBook list
        /// </summary>
        public void CreateTelephoneBookList(List<Entry> entries)
        {
            _lines.Clear();

            entries.ForEach(entry =>
            {
                var builder = new StringBuilder();

                builder.Append(entry.Name);
                builder.Append(',');
                builder.Append(entry.TelephoneNumber);
                builder.Append(',');
                builder.Append(entry.Adress);

                _lines.Add(builder.ToString());
            });
        }

        /// <summary>
        /// Open a telephonebook using an <see cref="OpenFileDialog"/>.
        /// </summary>
        /// <returns><see cref="List{Entry}"/>of entries</returns>
        public List<Entry> OpenTelephoneBook()
        {
            var entries = new List<Entry>();

            using (var openFileDialog = new OpenFileDialog
            {
                Filter = $"Telephonebook|*{_extention}",
                Title = "Open a telephonebook"
            })
            {
                DialogResult dialogResult = openFileDialog.ShowDialog();

                if (dialogResult == DialogResult.OK)
                {
                    FileName = openFileDialog.FileName;

                    string[] lines = File.ReadAllLines(FileName);

                    entries = ConvertLinesToEntriesList(lines);

                    FileSaved = true;
                }
            }

            return entries;
        }

        /// <summary>
        /// Save the current telephone book
        /// </summary>
        public void SaveTelephoneBook() {
            if (FileName != String.Empty)
            {
                File.WriteAllLines(FileName, _lines);
                FileSaved = true;
            }   
            else
                SaveNewTelephoneBook();
        }

        public DialogResult SaveTelephoneList(string generatedList)
        {
            return SaveFile($"Full telephonebook|*.txt", "Save generated telephonebook", tempFileName =>
            {
                File.WriteAllText(tempFileName, generatedList);
            });
        }

        /// <summary>
        /// Save a new telephone book using a <seealso cref="SaveFileDialog"/>
        /// </summary>
        /// <returns><see cref="DialogResult"/></returns>
        public DialogResult SaveNewTelephoneBook()
        {
            return SaveFile($"Telephonebook|*{_extention}", "Save a telephonebook", tempFileName =>
            {
                FileName = tempFileName;

                File.WriteAllLines(tempFileName, _lines);

                FileSaved = true;
            });
        }

        private DialogResult SaveFile(string filter, string title, PerformSaving performSaving)
        {
            DialogResult dialogResult;

            using (var saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = filter;
                saveFileDialog.Title = title;

                dialogResult = saveFileDialog.ShowDialog();

                string tempFileName = saveFileDialog.FileName;

                if (!tempFileName.Equals(String.Empty))
                    performSaving(tempFileName);
            }

            return dialogResult;
        }

        /// <summary>
        /// Converts a string of lines containing 2 comma's to entries
        /// </summary>
        /// <param name="lines">string array of lines</param>
        /// <returns><see cref="List{Entry}"/>of entries</returns>
        private List<Entry> ConvertLinesToEntriesList(string[] lines)
        {
            var entries = new List<Entry>();

            foreach (string line in lines)
            {
                string[] values = line.Split(new char[] { ',' }, 3);

                entries.Add(new Entry(values[0], values[1], values[2]));
            }

            return entries;
        }
    }
}
