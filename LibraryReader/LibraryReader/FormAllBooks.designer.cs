namespace Library
{
    partial class FormAllBooks
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
            this.radioButtonBooked = new System.Windows.Forms.RadioButton();
            this.radioButtonRejected = new System.Windows.Forms.RadioButton();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonReserve = new System.Windows.Forms.Button();
            this.BookID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YearPub = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewBooks
            // 
            this.dataGridViewBooks.AllowUserToAddRows = false;
            this.dataGridViewBooks.AllowUserToDeleteRows = false;
            this.dataGridViewBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BookID,
            this.InvNum,
            this.ISBN,
            this.Title,
            this.YearPub,
            this.Price});
            this.dataGridViewBooks.Location = new System.Drawing.Point(15, 188);
            this.dataGridViewBooks.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewBooks.Name = "dataGridViewBooks";
            this.dataGridViewBooks.ReadOnly = true;
            this.dataGridViewBooks.RowTemplate.Height = 24;
            this.dataGridViewBooks.Size = new System.Drawing.Size(840, 346);
            this.dataGridViewBooks.TabIndex = 0;
            // 
            // radioButtonAll
            // 
            this.radioButtonAll.AutoSize = true;
            this.radioButtonAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonAll.Location = new System.Drawing.Point(48, 25);
            this.radioButtonAll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonAll.Name = "radioButtonAll";
            this.radioButtonAll.Size = new System.Drawing.Size(73, 20);
            this.radioButtonAll.TabIndex = 1;
            this.radioButtonAll.TabStop = true;
            this.radioButtonAll.Text = "Всички";
            this.radioButtonAll.UseVisualStyleBackColor = true;
            this.radioButtonAll.CheckedChanged += new System.EventHandler(this.radioButtonAll_CheckedChanged);
            // 
            // radioButtonAvailable
            // 
            this.radioButtonAvailable.AutoSize = true;
            this.radioButtonAvailable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonAvailable.Location = new System.Drawing.Point(48, 52);
            this.radioButtonAvailable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonAvailable.Name = "radioButtonAvailable";
            this.radioButtonAvailable.Size = new System.Drawing.Size(84, 20);
            this.radioButtonAvailable.TabIndex = 2;
            this.radioButtonAvailable.TabStop = true;
            this.radioButtonAvailable.Text = "Налични";
            this.radioButtonAvailable.UseVisualStyleBackColor = true;
            this.radioButtonAvailable.CheckedChanged += new System.EventHandler(this.radioButtonAvailable_CheckedChanged);
            // 
            // radioButtonTaken
            // 
            this.radioButtonTaken.AutoSize = true;
            this.radioButtonTaken.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonTaken.Location = new System.Drawing.Point(48, 79);
            this.radioButtonTaken.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonTaken.Name = "radioButtonTaken";
            this.radioButtonTaken.Size = new System.Drawing.Size(66, 20);
            this.radioButtonTaken.TabIndex = 3;
            this.radioButtonTaken.TabStop = true;
            this.radioButtonTaken.Text = "Заети";
            this.radioButtonTaken.UseVisualStyleBackColor = true;
            this.radioButtonTaken.CheckedChanged += new System.EventHandler(this.radioButtonTaken_CheckedChanged);
            // 
            // radioButtonBooked
            // 
            this.radioButtonBooked.AutoSize = true;
            this.radioButtonBooked.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonBooked.Location = new System.Drawing.Point(48, 106);
            this.radioButtonBooked.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonBooked.Name = "radioButtonBooked";
            this.radioButtonBooked.Size = new System.Drawing.Size(115, 20);
            this.radioButtonBooked.TabIndex = 8;
            this.radioButtonBooked.TabStop = true;
            this.radioButtonBooked.Text = "Резервирани";
            this.radioButtonBooked.UseVisualStyleBackColor = true;
            this.radioButtonBooked.CheckedChanged += new System.EventHandler(this.radioButtonBooked_CheckedChanged);
            // 
            // radioButtonRejected
            // 
            this.radioButtonRejected.AutoSize = true;
            this.radioButtonRejected.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonRejected.Location = new System.Drawing.Point(48, 133);
            this.radioButtonRejected.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonRejected.Name = "radioButtonRejected";
            this.radioButtonRejected.Size = new System.Drawing.Size(98, 20);
            this.radioButtonRejected.TabIndex = 9;
            this.radioButtonRejected.TabStop = true;
            this.radioButtonRejected.Text = "Бракувани";
            this.radioButtonRejected.UseVisualStyleBackColor = true;
            this.radioButtonRejected.CheckedChanged += new System.EventHandler(this.radioButtonRejected_CheckedChanged);
            // 
            // buttonClose
            // 
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClose.Location = new System.Drawing.Point(755, 552);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(4);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(100, 28);
            this.buttonClose.TabIndex = 10;
            this.buttonClose.Text = "Затвори";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(653, 552);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(95, 28);
            this.buttonSearch.TabIndex = 11;
            this.buttonSearch.Text = "Търси";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonReserve
            // 
            this.buttonReserve.Location = new System.Drawing.Point(540, 552);
            this.buttonReserve.Name = "buttonReserve";
            this.buttonReserve.Size = new System.Drawing.Size(107, 28);
            this.buttonReserve.TabIndex = 12;
            this.buttonReserve.Text = "Резервирай";
            this.buttonReserve.UseVisualStyleBackColor = true;
            this.buttonReserve.Click += new System.EventHandler(this.buttonReserve_Click);
            // 
            // BookID
            // 
            this.BookID.DataPropertyName = "BookID";
            this.BookID.HeaderText = "BookID";
            this.BookID.Name = "BookID";
            this.BookID.ReadOnly = true;
            this.BookID.Visible = false;
            // 
            // InvNum
            // 
            this.InvNum.DataPropertyName = "InvNum";
            this.InvNum.HeaderText = "Инвентарен №";
            this.InvNum.Name = "InvNum";
            this.InvNum.ReadOnly = true;
            this.InvNum.Width = 140;
            // 
            // ISBN
            // 
            this.ISBN.DataPropertyName = "ISBN";
            this.ISBN.HeaderText = "ISBN";
            this.ISBN.Name = "ISBN";
            this.ISBN.ReadOnly = true;
            // 
            // Title
            // 
            this.Title.DataPropertyName = "Title";
            this.Title.HeaderText = "Заглавие";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            this.Title.Width = 350;
            // 
            // YearPub
            // 
            this.YearPub.DataPropertyName = "YearPub";
            this.YearPub.HeaderText = "Дата на публикуване";
            this.YearPub.Name = "YearPub";
            this.YearPub.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Цена";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // FormAllBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(241)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(869, 597);
            this.Controls.Add(this.buttonReserve);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.radioButtonRejected);
            this.Controls.Add(this.radioButtonBooked);
            this.Controls.Add(this.radioButtonTaken);
            this.Controls.Add(this.radioButtonAvailable);
            this.Controls.Add(this.radioButtonAll);
            this.Controls.Add(this.dataGridViewBooks);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormAllBooks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Справка за книги";
            this.Load += new System.EventHandler(this.FormBooks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewBooks;
        private System.Windows.Forms.RadioButton radioButtonAll;
        private System.Windows.Forms.RadioButton radioButtonAvailable;
        private System.Windows.Forms.RadioButton radioButtonTaken;
        private System.Windows.Forms.RadioButton radioButtonBooked;
        private System.Windows.Forms.RadioButton radioButtonRejected;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonReserve;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookID;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn YearPub;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
    }
}

