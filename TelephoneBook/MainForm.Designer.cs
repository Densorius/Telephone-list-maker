namespace TelephoneBookApp
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.DgvTelephoneBook = new System.Windows.Forms.DataGridView();
            this.ColName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTelephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAdress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TblInput = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TbAdress = new System.Windows.Forms.TextBox();
            this.LblAdress = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TbTelephone = new System.Windows.Forms.TextBox();
            this.LblTelephone = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TbName = new System.Windows.Forms.TextBox();
            this.LblName = new System.Windows.Forms.Label();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.CwGridMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mainMenu = new System.Windows.Forms.MainMenu(this.components);
            this.fileMenu = new System.Windows.Forms.MenuItem();
            this.menuItemNew = new System.Windows.Forms.MenuItem();
            this.MenuItemOpen = new System.Windows.Forms.MenuItem();
            this.menuItemSave = new System.Windows.Forms.MenuItem();
            this.menuItemSaveAs = new System.Windows.Forms.MenuItem();
            this.menuItem9 = new System.Windows.Forms.MenuItem();
            this.menuItemGenerateTelephoneList = new System.Windows.Forms.MenuItem();
            this.menuItem8 = new System.Windows.Forms.MenuItem();
            this.menuItemExit = new System.Windows.Forms.MenuItem();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItemAbout = new System.Windows.Forms.MenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTelephoneBook)).BeginInit();
            this.TblInput.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvTelephoneBook
            // 
            this.DgvTelephoneBook.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvTelephoneBook.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvTelephoneBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvTelephoneBook.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColName,
            this.ColTelephone,
            this.ColAdress});
            this.DgvTelephoneBook.Location = new System.Drawing.Point(12, 1);
            this.DgvTelephoneBook.Name = "DgvTelephoneBook";
            this.DgvTelephoneBook.Size = new System.Drawing.Size(750, 417);
            this.DgvTelephoneBook.TabIndex = 0;
            this.DgvTelephoneBook.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvTelephoneBook_CellValueChanged);
            this.DgvTelephoneBook.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DgvTelephoneBook_MouseClick);
            // 
            // ColName
            // 
            this.ColName.HeaderText = "Name";
            this.ColName.Name = "ColName";
            // 
            // ColTelephone
            // 
            this.ColTelephone.HeaderText = "Telephone";
            this.ColTelephone.Name = "ColTelephone";
            // 
            // ColAdress
            // 
            this.ColAdress.HeaderText = "Adress";
            this.ColAdress.Name = "ColAdress";
            // 
            // TblInput
            // 
            this.TblInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TblInput.ColumnCount = 4;
            this.TblInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TblInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.TblInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.TblInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 132F));
            this.TblInput.Controls.Add(this.panel3, 2, 0);
            this.TblInput.Controls.Add(this.panel2, 1, 0);
            this.TblInput.Controls.Add(this.panel1, 0, 0);
            this.TblInput.Controls.Add(this.BtnAdd, 3, 0);
            this.TblInput.Location = new System.Drawing.Point(12, 424);
            this.TblInput.Name = "TblInput";
            this.TblInput.RowCount = 1;
            this.TblInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TblInput.Size = new System.Drawing.Size(750, 47);
            this.TblInput.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.TbAdress);
            this.panel3.Controls.Add(this.LblAdress);
            this.panel3.Location = new System.Drawing.Point(414, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 41);
            this.panel3.TabIndex = 3;
            // 
            // TbAdress
            // 
            this.TbAdress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TbAdress.Location = new System.Drawing.Point(51, 11);
            this.TbAdress.Name = "TbAdress";
            this.TbAdress.Size = new System.Drawing.Size(146, 20);
            this.TbAdress.TabIndex = 2;
            // 
            // LblAdress
            // 
            this.LblAdress.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LblAdress.AutoSize = true;
            this.LblAdress.Location = new System.Drawing.Point(3, 14);
            this.LblAdress.Name = "LblAdress";
            this.LblAdress.Size = new System.Drawing.Size(42, 13);
            this.LblAdress.TabIndex = 2;
            this.LblAdress.Text = "Adress:";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.TbTelephone);
            this.panel2.Controls.Add(this.LblTelephone);
            this.panel2.Location = new System.Drawing.Point(208, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 41);
            this.panel2.TabIndex = 2;
            // 
            // TbTelephone
            // 
            this.TbTelephone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TbTelephone.Location = new System.Drawing.Point(70, 11);
            this.TbTelephone.Name = "TbTelephone";
            this.TbTelephone.Size = new System.Drawing.Size(127, 20);
            this.TbTelephone.TabIndex = 3;
            // 
            // LblTelephone
            // 
            this.LblTelephone.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LblTelephone.AutoSize = true;
            this.LblTelephone.Location = new System.Drawing.Point(3, 14);
            this.LblTelephone.Name = "LblTelephone";
            this.LblTelephone.Size = new System.Drawing.Size(61, 13);
            this.LblTelephone.TabIndex = 1;
            this.LblTelephone.Text = "Telephone:";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.TbName);
            this.panel1.Controls.Add(this.LblName);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(199, 41);
            this.panel1.TabIndex = 1;
            // 
            // TbName
            // 
            this.TbName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TbName.Location = new System.Drawing.Point(47, 11);
            this.TbName.Name = "TbName";
            this.TbName.Size = new System.Drawing.Size(149, 20);
            this.TbName.TabIndex = 1;
            // 
            // LblName
            // 
            this.LblName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(3, 14);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(38, 13);
            this.LblName.TabIndex = 0;
            this.LblName.Text = "Name:";
            // 
            // BtnAdd
            // 
            this.BtnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAdd.Location = new System.Drawing.Point(620, 12);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(127, 23);
            this.BtnAdd.TabIndex = 4;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // CwGridMenu
            // 
            this.CwGridMenu.Name = "CwGridMenu";
            this.CwGridMenu.Size = new System.Drawing.Size(61, 4);
            // 
            // mainMenu
            // 
            this.mainMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.fileMenu,
            this.menuItem1});
            // 
            // fileMenu
            // 
            this.fileMenu.Index = 0;
            this.fileMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItemNew,
            this.MenuItemOpen,
            this.menuItemSave,
            this.menuItemSaveAs,
            this.menuItem9,
            this.menuItemGenerateTelephoneList,
            this.menuItem8,
            this.menuItemExit});
            this.fileMenu.Text = "File";
            // 
            // menuItemNew
            // 
            this.menuItemNew.Index = 0;
            this.menuItemNew.Shortcut = System.Windows.Forms.Shortcut.CtrlN;
            this.menuItemNew.Text = "New";
            this.menuItemNew.Click += new System.EventHandler(this.MenuItemNew_Click);
            // 
            // MenuItemOpen
            // 
            this.MenuItemOpen.Index = 1;
            this.MenuItemOpen.Shortcut = System.Windows.Forms.Shortcut.CtrlO;
            this.MenuItemOpen.Text = "Open...";
            this.MenuItemOpen.Click += new System.EventHandler(this.MenuItemOpen_Click);
            // 
            // menuItemSave
            // 
            this.menuItemSave.Index = 2;
            this.menuItemSave.Shortcut = System.Windows.Forms.Shortcut.CtrlS;
            this.menuItemSave.Text = "Save";
            this.menuItemSave.Click += new System.EventHandler(this.MenuItemSave_Click);
            // 
            // menuItemSaveAs
            // 
            this.menuItemSaveAs.Index = 3;
            this.menuItemSaveAs.Text = "Save as...";
            this.menuItemSaveAs.Click += new System.EventHandler(this.MenuItemSaveAs_Click);
            // 
            // menuItem9
            // 
            this.menuItem9.Index = 4;
            this.menuItem9.Text = "-";
            // 
            // menuItemGenerateTelephoneList
            // 
            this.menuItemGenerateTelephoneList.Index = 5;
            this.menuItemGenerateTelephoneList.Text = "Generate telephone list...";
            this.menuItemGenerateTelephoneList.Click += new System.EventHandler(this.MenuItemGenerateTelephoneList_Click);
            // 
            // menuItem8
            // 
            this.menuItem8.Index = 6;
            this.menuItem8.Text = "-";
            // 
            // menuItemExit
            // 
            this.menuItemExit.Index = 7;
            this.menuItemExit.Text = "Exit";
            this.menuItemExit.Click += new System.EventHandler(this.MenuItemExit_Click);
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 1;
            this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItemAbout});
            this.menuItem1.Text = "Help";
            // 
            // menuItemAbout
            // 
            this.menuItemAbout.Index = 0;
            this.menuItemAbout.Text = "About";
            this.menuItemAbout.Click += new System.EventHandler(this.MenuItemAbout_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(774, 483);
            this.Controls.Add(this.TblInput);
            this.Controls.Add(this.DgvTelephoneBook);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Menu = this.mainMenu;
            this.Name = "MainForm";
            this.Text = "TelephoneBook";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.DgvTelephoneBook)).EndInit();
            this.TblInput.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvTelephoneBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTelephone;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAdress;
        private System.Windows.Forms.TableLayoutPanel TblInput;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label LblAdress;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LblTelephone;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.TextBox TbTelephone;
        private System.Windows.Forms.TextBox TbAdress;
        private System.Windows.Forms.TextBox TbName;
        private System.Windows.Forms.ContextMenuStrip CwGridMenu;
        private System.Windows.Forms.MainMenu mainMenu;
        private System.Windows.Forms.MenuItem fileMenu;
        private System.Windows.Forms.MenuItem menuItemNew;
        private System.Windows.Forms.MenuItem menuItemSave;
        private System.Windows.Forms.MenuItem menuItemSaveAs;
        private System.Windows.Forms.MenuItem MenuItemOpen;
        private System.Windows.Forms.MenuItem menuItem9;
        private System.Windows.Forms.MenuItem menuItemGenerateTelephoneList;
        private System.Windows.Forms.MenuItem menuItem8;
        private System.Windows.Forms.MenuItem menuItemExit;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItemAbout;
    }
}

