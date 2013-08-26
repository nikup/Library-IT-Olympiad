namespace Library
{
    partial class FormLanguages
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
            this.dataGridViewLanguages = new System.Windows.Forms.DataGridView();
            this.buttonAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLanguages)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewLanguages
            // 
            this.dataGridViewLanguages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLanguages.Location = new System.Drawing.Point(12, 51);
            this.dataGridViewLanguages.Name = "dataGridViewLanguages";
            this.dataGridViewLanguages.RowTemplate.Height = 24;
            this.dataGridViewLanguages.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewLanguages.TabIndex = 0;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(176, 216);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Добави";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // FormLanguages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 251);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dataGridViewLanguages);
            this.Name = "FormLanguages";
            this.Text = "Езици";
            this.Load += new System.EventHandler(this.FormLanguages_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLanguages)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewLanguages;
        private System.Windows.Forms.Button buttonAdd;
    }
}