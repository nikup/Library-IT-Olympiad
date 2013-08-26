namespace LibraryReader
{
    partial class FormReserved
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
            this.dataGridViewReserved = new System.Windows.Forms.DataGridView();
            this.BookID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReserved)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewReserved
            // 
            this.dataGridViewReserved.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReserved.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BookID,
            this.InvNum,
            this.Title});
            this.dataGridViewReserved.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewReserved.Name = "dataGridViewReserved";
            this.dataGridViewReserved.Size = new System.Drawing.Size(492, 316);
            this.dataGridViewReserved.TabIndex = 0;
            // 
            // BookID
            // 
            this.BookID.DataPropertyName = "BookID";
            this.BookID.HeaderText = "BookID";
            this.BookID.Name = "BookID";
            // 
            // InvNum
            // 
            this.InvNum.DataPropertyName = "InvNum";
            this.InvNum.HeaderText = "Инвентарен номер";
            this.InvNum.Name = "InvNum";
            // 
            // Title
            // 
            this.Title.DataPropertyName = "Title";
            this.Title.HeaderText = "Заглавие";
            this.Title.Name = "Title";
            // 
            // FormReserved
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 340);
            this.Controls.Add(this.dataGridViewReserved);
            this.Name = "FormReserved";
            this.Text = "Резервирани - Справка";
            this.Load += new System.EventHandler(this.FormReserved_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReserved)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewReserved;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookID;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
    }
}