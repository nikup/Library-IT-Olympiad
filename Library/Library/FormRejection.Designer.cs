namespace Library
{
    partial class FormRejection
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
            this.InvNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rejection = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonRejection = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewBooks
            // 
            this.dataGridViewBooks.AllowUserToDeleteRows = false;
            this.dataGridViewBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.InvNum,
            this.Title,
            this.Rejection,
            this.BookID});
            this.dataGridViewBooks.Location = new System.Drawing.Point(15, 97);
            this.dataGridViewBooks.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewBooks.Name = "dataGridViewBooks";
            this.dataGridViewBooks.RowTemplate.Height = 24;
            this.dataGridViewBooks.Size = new System.Drawing.Size(494, 174);
            this.dataGridViewBooks.TabIndex = 9;
            this.dataGridViewBooks.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBooks_RowLeave);
            // 
            // InvNum
            // 
            this.InvNum.DataPropertyName = "InvNum";
            this.InvNum.HeaderText = "Инв. №";
            this.InvNum.Name = "InvNum";
            // 
            // Title
            // 
            this.Title.DataPropertyName = "Title";
            this.Title.HeaderText = "Заглавие";
            this.Title.Name = "Title";
            this.Title.Width = 340;
            // 
            // Rejection
            // 
            this.Rejection.DataPropertyName = "Rejection";
            this.Rejection.HeaderText = "Отчислена";
            this.Rejection.Name = "Rejection";
            this.Rejection.Visible = false;
            // 
            // BookID
            // 
            this.BookID.DataPropertyName = "BookID";
            this.BookID.HeaderText = "BookID";
            this.BookID.Name = "BookID";
            this.BookID.Visible = false;
            // 
            // buttonRejection
            // 
            this.buttonRejection.Location = new System.Drawing.Point(123, 296);
            this.buttonRejection.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRejection.Name = "buttonRejection";
            this.buttonRejection.Size = new System.Drawing.Size(95, 31);
            this.buttonRejection.TabIndex = 10;
            this.buttonRejection.Text = "Отчисли";
            this.buttonRejection.UseVisualStyleBackColor = true;
            this.buttonRejection.Click += new System.EventHandler(this.buttonRejection_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(425, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Въведи инвентарен № на книга и чрез клавиш Tab обходи реда";
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(279, 298);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(4);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(95, 31);
            this.buttonClose.TabIndex = 12;
            this.buttonClose.Text = "Затвори";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // FormRejection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(241)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(521, 358);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonRejection);
            this.Controls.Add(this.dataGridViewBooks);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormRejection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Отчисляване на книги";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewBooks;
        private System.Windows.Forms.Button buttonRejection;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rejection;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookID;
    }
}