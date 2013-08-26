namespace Library
{
    partial class FormBooks
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
            this.dataGridViewBooks = new System.Windows.Forms.DataGridView();
            this.radioButtonAll = new System.Windows.Forms.RadioButton();
            this.radioButtonAvailable = new System.Windows.Forms.RadioButton();
            this.radioButtonTaken = new System.Windows.Forms.RadioButton();
            this.comboBoxLanguage = new System.Windows.Forms.ComboBox();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.radioButtonBooked = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.booksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.referenceBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookReservationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.authorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchAuthorsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.referenceAuthorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAuthorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.checkBoxLanguage = new System.Windows.Forms.CheckBox();
            this.checkBoxCategory = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewBooks
            // 
            this.dataGridViewBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBooks.Location = new System.Drawing.Point(18, 139);
            this.dataGridViewBooks.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewBooks.Name = "dataGridViewBooks";
            this.dataGridViewBooks.RowTemplate.Height = 24;
            this.dataGridViewBooks.Size = new System.Drawing.Size(566, 281);
            this.dataGridViewBooks.TabIndex = 0;
            // 
            // radioButtonAll
            // 
            this.radioButtonAll.AutoSize = true;
            this.radioButtonAll.Location = new System.Drawing.Point(36, 35);
            this.radioButtonAll.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButtonAll.Name = "radioButtonAll";
            this.radioButtonAll.Size = new System.Drawing.Size(61, 17);
            this.radioButtonAll.TabIndex = 1;
            this.radioButtonAll.TabStop = true;
            this.radioButtonAll.Text = "Всички";
            this.radioButtonAll.UseVisualStyleBackColor = true;
            this.radioButtonAll.CheckedChanged += new System.EventHandler(this.radioButtonAll_CheckedChanged);
            // 
            // radioButtonAvailable
            // 
            this.radioButtonAvailable.AutoSize = true;
            this.radioButtonAvailable.Location = new System.Drawing.Point(36, 57);
            this.radioButtonAvailable.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButtonAvailable.Name = "radioButtonAvailable";
            this.radioButtonAvailable.Size = new System.Drawing.Size(68, 17);
            this.radioButtonAvailable.TabIndex = 2;
            this.radioButtonAvailable.TabStop = true;
            this.radioButtonAvailable.Text = "Налични";
            this.radioButtonAvailable.UseVisualStyleBackColor = true;
            this.radioButtonAvailable.CheckedChanged += new System.EventHandler(this.radioButtonAvailable_CheckedChanged);
            // 
            // radioButtonTaken
            // 
            this.radioButtonTaken.AutoSize = true;
            this.radioButtonTaken.Location = new System.Drawing.Point(36, 79);
            this.radioButtonTaken.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButtonTaken.Name = "radioButtonTaken";
            this.radioButtonTaken.Size = new System.Drawing.Size(55, 17);
            this.radioButtonTaken.TabIndex = 3;
            this.radioButtonTaken.TabStop = true;
            this.radioButtonTaken.Text = "Заети";
            this.radioButtonTaken.UseVisualStyleBackColor = true;
            this.radioButtonTaken.CheckedChanged += new System.EventHandler(this.radioButtonTaken_CheckedChanged);
            // 
            // comboBoxLanguage
            // 
            this.comboBoxLanguage.Enabled = false;
            this.comboBoxLanguage.FormattingEnabled = true;
            this.comboBoxLanguage.Location = new System.Drawing.Point(303, 50);
            this.comboBoxLanguage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxLanguage.Name = "comboBoxLanguage";
            this.comboBoxLanguage.Size = new System.Drawing.Size(92, 21);
            this.comboBoxLanguage.TabIndex = 5;
            this.comboBoxLanguage.SelectedIndexChanged += new System.EventHandler(this.comboBoxLanguage_SelectedIndexChanged);
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.Enabled = false;
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(303, 78);
            this.comboBoxCategory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(92, 21);
            this.comboBoxCategory.TabIndex = 7;
            this.comboBoxCategory.SelectedIndexChanged += new System.EventHandler(this.comboBoxCategory_SelectedIndexChanged);
            // 
            // radioButtonBooked
            // 
            this.radioButtonBooked.AutoSize = true;
            this.radioButtonBooked.Location = new System.Drawing.Point(36, 101);
            this.radioButtonBooked.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButtonBooked.Name = "radioButtonBooked";
            this.radioButtonBooked.Size = new System.Drawing.Size(92, 17);
            this.radioButtonBooked.TabIndex = 8;
            this.radioButtonBooked.TabStop = true;
            this.radioButtonBooked.Text = "Резервирани";
            this.radioButtonBooked.UseVisualStyleBackColor = true;
            this.radioButtonBooked.CheckedChanged += new System.EventHandler(this.radioButtonBooked_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.booksToolStripMenuItem,
            this.authorsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(604, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // booksToolStripMenuItem
            // 
            this.booksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchBooksToolStripMenuItem,
            this.referenceBooksToolStripMenuItem,
            this.bookReservationToolStripMenuItem,
            this.addBookToolStripMenuItem});
            this.booksToolStripMenuItem.Name = "booksToolStripMenuItem";
            this.booksToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.booksToolStripMenuItem.Text = "Книги";
            // 
            // searchBooksToolStripMenuItem
            // 
            this.searchBooksToolStripMenuItem.Name = "searchBooksToolStripMenuItem";
            this.searchBooksToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.searchBooksToolStripMenuItem.Text = "Търсене";
            this.searchBooksToolStripMenuItem.Click += new System.EventHandler(this.searchBooksToolStripMenuItem_Click);
            // 
            // referenceBooksToolStripMenuItem
            // 
            this.referenceBooksToolStripMenuItem.Name = "referenceBooksToolStripMenuItem";
            this.referenceBooksToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.referenceBooksToolStripMenuItem.Text = "Справка";
            this.referenceBooksToolStripMenuItem.Click += new System.EventHandler(this.referenceBooksToolStripMenuItem_Click);
            // 
            // bookReservationToolStripMenuItem
            // 
            this.bookReservationToolStripMenuItem.Name = "bookReservationToolStripMenuItem";
            this.bookReservationToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.bookReservationToolStripMenuItem.Text = "Резервиране";
            this.bookReservationToolStripMenuItem.Click += new System.EventHandler(this.bookReservationToolStripMenuItem_Click);
            // 
            // addBookToolStripMenuItem
            // 
            this.addBookToolStripMenuItem.Name = "addBookToolStripMenuItem";
            this.addBookToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.addBookToolStripMenuItem.Text = "Добавяне";
            this.addBookToolStripMenuItem.Click += new System.EventHandler(this.addBookToolStripMenuItem_Click);
            // 
            // authorsToolStripMenuItem
            // 
            this.authorsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchAuthorsToolStripMenuItem1,
            this.referenceAuthorsToolStripMenuItem,
            this.addAuthorToolStripMenuItem1});
            this.authorsToolStripMenuItem.Name = "authorsToolStripMenuItem";
            this.authorsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.authorsToolStripMenuItem.Text = "Автори";
            // 
            // searchAuthorsToolStripMenuItem1
            // 
            this.searchAuthorsToolStripMenuItem1.Name = "searchAuthorsToolStripMenuItem1";
            this.searchAuthorsToolStripMenuItem1.Size = new System.Drawing.Size(127, 22);
            this.searchAuthorsToolStripMenuItem1.Text = "Търсене";
            this.searchAuthorsToolStripMenuItem1.Click += new System.EventHandler(this.searchAuthorsToolStripMenuItem1_Click);
            // 
            // referenceAuthorsToolStripMenuItem
            // 
            this.referenceAuthorsToolStripMenuItem.Name = "referenceAuthorsToolStripMenuItem";
            this.referenceAuthorsToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.referenceAuthorsToolStripMenuItem.Text = "Справка";
            this.referenceAuthorsToolStripMenuItem.Click += new System.EventHandler(this.referenceAuthorsToolStripMenuItem_Click);
            // 
            // addAuthorToolStripMenuItem1
            // 
            this.addAuthorToolStripMenuItem1.Name = "addAuthorToolStripMenuItem1";
            this.addAuthorToolStripMenuItem1.Size = new System.Drawing.Size(127, 22);
            this.addAuthorToolStripMenuItem1.Text = "Добавяне";
            this.addAuthorToolStripMenuItem1.Click += new System.EventHandler(this.addAuthorToolStripMenuItem1_Click);
            // 
            // checkBoxLanguage
            // 
            this.checkBoxLanguage.AutoSize = true;
            this.checkBoxLanguage.Location = new System.Drawing.Point(172, 51);
            this.checkBoxLanguage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxLanguage.Name = "checkBoxLanguage";
            this.checkBoxLanguage.Size = new System.Drawing.Size(96, 17);
            this.checkBoxLanguage.TabIndex = 11;
            this.checkBoxLanguage.Text = "Според езика";
            this.checkBoxLanguage.UseVisualStyleBackColor = true;
            this.checkBoxLanguage.CheckedChanged += new System.EventHandler(this.checkBoxLanguage_CheckedChanged);
            // 
            // checkBoxCategory
            // 
            this.checkBoxCategory.AutoSize = true;
            this.checkBoxCategory.Location = new System.Drawing.Point(172, 79);
            this.checkBoxCategory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxCategory.Name = "checkBoxCategory";
            this.checkBoxCategory.Size = new System.Drawing.Size(129, 17);
            this.checkBoxCategory.TabIndex = 12;
            this.checkBoxCategory.Text = "Според категорията";
            this.checkBoxCategory.UseVisualStyleBackColor = true;
            this.checkBoxCategory.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // FormBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 444);
            this.Controls.Add(this.checkBoxCategory);
            this.Controls.Add(this.checkBoxLanguage);
            this.Controls.Add(this.radioButtonBooked);
            this.Controls.Add(this.comboBoxCategory);
            this.Controls.Add(this.comboBoxLanguage);
            this.Controls.Add(this.radioButtonTaken);
            this.Controls.Add(this.radioButtonAvailable);
            this.Controls.Add(this.radioButtonAll);
            this.Controls.Add(this.dataGridViewBooks);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormBooks";
            this.Text = "Справка за книги";
            this.Load += new System.EventHandler(this.FormBooks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewBooks;
        private System.Windows.Forms.RadioButton radioButtonAll;
        private System.Windows.Forms.RadioButton radioButtonAvailable;
        private System.Windows.Forms.RadioButton radioButtonTaken;
        private System.Windows.Forms.ComboBox comboBoxLanguage;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.RadioButton radioButtonBooked;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem booksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchBooksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem referenceBooksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookReservationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addBookToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkBoxLanguage;
        private System.Windows.Forms.CheckBox checkBoxCategory;
        private System.Windows.Forms.ToolStripMenuItem authorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchAuthorsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addAuthorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem referenceAuthorsToolStripMenuItem;
    }
}

