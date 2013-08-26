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
            this.buttonAdd = new System.Windows.Forms.Button();
            this.dataGridViewLanguages = new System.Windows.Forms.DataGridView();
            this.LanguageID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LanguageName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1Close = new System.Windows.Forms.Button();
            this.buttonNew = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLanguages)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(156, 273);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(88, 31);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Добави";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // dataGridViewLanguages
            // 
            this.dataGridViewLanguages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLanguages.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LanguageID,
            this.LanguageName});
            this.dataGridViewLanguages.Location = new System.Drawing.Point(27, 14);
            this.dataGridViewLanguages.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewLanguages.Name = "dataGridViewLanguages";
            this.dataGridViewLanguages.RowTemplate.Height = 24;
            this.dataGridViewLanguages.Size = new System.Drawing.Size(348, 234);
            this.dataGridViewLanguages.TabIndex = 3;
            // 
            // LanguageID
            // 
            this.LanguageID.DataPropertyName = "LanguageID";
            this.LanguageID.HeaderText = "№";
            this.LanguageID.Name = "LanguageID";
            this.LanguageID.Width = 80;
            // 
            // LanguageName
            // 
            this.LanguageName.DataPropertyName = "LanguageName";
            this.LanguageName.HeaderText = "Език";
            this.LanguageName.Name = "LanguageName";
            this.LanguageName.Width = 220;
            // 
            // button1Close
            // 
            this.button1Close.Location = new System.Drawing.Point(272, 273);
            this.button1Close.Margin = new System.Windows.Forms.Padding(4);
            this.button1Close.Name = "button1Close";
            this.button1Close.Size = new System.Drawing.Size(88, 31);
            this.button1Close.TabIndex = 5;
            this.button1Close.Text = "Затвори";
            this.button1Close.UseVisualStyleBackColor = true;
            this.button1Close.Click += new System.EventHandler(this.button1Close_Click);
            // 
            // buttonNew
            // 
            this.buttonNew.Location = new System.Drawing.Point(40, 273);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(88, 31);
            this.buttonNew.TabIndex = 6;
            this.buttonNew.Text = "Нов";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // FormLanguages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(241)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(404, 330);
            this.Controls.Add(this.buttonNew);
            this.Controls.Add(this.button1Close);
            this.Controls.Add(this.dataGridViewLanguages);
            this.Controls.Add(this.buttonAdd);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormLanguages";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Език";
            this.Load += new System.EventHandler(this.FormLanguages_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLanguages)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.DataGridView dataGridViewLanguages;
        private System.Windows.Forms.Button button1Close;
        private System.Windows.Forms.DataGridViewTextBoxColumn LanguageID;
        private System.Windows.Forms.DataGridViewTextBoxColumn LanguageName;
        private System.Windows.Forms.Button buttonNew;
    }
}