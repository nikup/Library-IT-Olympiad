﻿namespace LibraryReader
{
    partial class FormReturned
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
            this.dataGridViewReturned = new System.Windows.Forms.DataGridView();
            this.libraryEntitiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BookID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReturned)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryEntitiesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewReturned
            // 
            this.dataGridViewReturned.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReturned.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BookID,
            this.InvNum,
            this.Title});
            this.dataGridViewReturned.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewReturned.Name = "dataGridViewReturned";
            this.dataGridViewReturned.Size = new System.Drawing.Size(430, 284);
            this.dataGridViewReturned.TabIndex = 0;
            // 
            // libraryEntitiesBindingSource
            // 
            this.libraryEntitiesBindingSource.DataSource = typeof(LibraryReader.LibraryEntities);
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
            // FormReturned
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 308);
            this.Controls.Add(this.dataGridViewReturned);
            this.Name = "FormReturned";
            this.Text = "Върнати";
            this.Load += new System.EventHandler(this.FormReturned_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReturned)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryEntitiesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewReturned;
        private System.Windows.Forms.BindingSource libraryEntitiesBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookID;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
    }
}