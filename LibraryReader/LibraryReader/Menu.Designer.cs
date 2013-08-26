namespace LibraryReader
{
    partial class Menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.презаписванеНаКнигиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.презаписванеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.резервиранеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.върнатиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.резервираниToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.книгиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.всичкиКнигиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.търсенеНаКнигиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заНасToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.презаписванеНаКнигиToolStripMenuItem,
            this.книгиToolStripMenuItem,
            this.заНасToolStripMenuItem,
            this.изходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(622, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // презаписванеНаКнигиToolStripMenuItem
            // 
            this.презаписванеНаКнигиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.презаписванеToolStripMenuItem,
            this.резервиранеToolStripMenuItem,
            this.върнатиToolStripMenuItem,
            this.резервираниToolStripMenuItem});
            this.презаписванеНаКнигиToolStripMenuItem.Name = "презаписванеНаКнигиToolStripMenuItem";
            this.презаписванеНаКнигиToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.презаписванеНаКнигиToolStripMenuItem.Text = "Моите книги";
            // 
            // презаписванеToolStripMenuItem
            // 
            this.презаписванеToolStripMenuItem.Name = "презаписванеToolStripMenuItem";
            this.презаписванеToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.презаписванеToolStripMenuItem.Text = "Презаписване";
            this.презаписванеToolStripMenuItem.Click += new System.EventHandler(this.презаписванеToolStripMenuItem_Click);
            // 
            // резервиранеToolStripMenuItem
            // 
            this.резервиранеToolStripMenuItem.Name = "резервиранеToolStripMenuItem";
            this.резервиранеToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.резервиранеToolStripMenuItem.Text = "Резервиране";
            this.резервиранеToolStripMenuItem.Click += new System.EventHandler(this.резервиранеToolStripMenuItem_Click);
            // 
            // върнатиToolStripMenuItem
            // 
            this.върнатиToolStripMenuItem.Name = "върнатиToolStripMenuItem";
            this.върнатиToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.върнатиToolStripMenuItem.Text = "Върнати";
            this.върнатиToolStripMenuItem.Click += new System.EventHandler(this.върнатиToolStripMenuItem_Click);
            // 
            // резервираниToolStripMenuItem
            // 
            this.резервираниToolStripMenuItem.Name = "резервираниToolStripMenuItem";
            this.резервираниToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.резервираниToolStripMenuItem.Text = "Резервирани - справка";
            this.резервираниToolStripMenuItem.Click += new System.EventHandler(this.резервираниToolStripMenuItem_Click);
            // 
            // книгиToolStripMenuItem
            // 
            this.книгиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.всичкиКнигиToolStripMenuItem,
            this.търсенеНаКнигиToolStripMenuItem});
            this.книгиToolStripMenuItem.Name = "книгиToolStripMenuItem";
            this.книгиToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.книгиToolStripMenuItem.Text = "Книги";
            // 
            // всичкиКнигиToolStripMenuItem
            // 
            this.всичкиКнигиToolStripMenuItem.Name = "всичкиКнигиToolStripMenuItem";
            this.всичкиКнигиToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.всичкиКнигиToolStripMenuItem.Text = "Всички книги";
            this.всичкиКнигиToolStripMenuItem.Click += new System.EventHandler(this.всичкиКнигиToolStripMenuItem_Click);
            // 
            // търсенеНаКнигиToolStripMenuItem
            // 
            this.търсенеНаКнигиToolStripMenuItem.Name = "търсенеНаКнигиToolStripMenuItem";
            this.търсенеНаКнигиToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.търсенеНаКнигиToolStripMenuItem.Text = "Търсене на книги";
            this.търсенеНаКнигиToolStripMenuItem.Click += new System.EventHandler(this.търсенеНаКнигиToolStripMenuItem_Click);
            // 
            // заНасToolStripMenuItem
            // 
            this.заНасToolStripMenuItem.Name = "заНасToolStripMenuItem";
            this.заНасToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.заНасToolStripMenuItem.Text = "За нас";
            this.заНасToolStripMenuItem.Click += new System.EventHandler(this.заНасToolStripMenuItem_Click);
            // 
            // изходToolStripMenuItem
            // 
            this.изходToolStripMenuItem.Name = "изходToolStripMenuItem";
            this.изходToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.изходToolStripMenuItem.Text = "Изход";
            this.изходToolStripMenuItem.Click += new System.EventHandler(this.изходToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LibraryReader.Properties.Resources.ver11;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(622, 375);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Text = "Училищна библиотека - Меню";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem презаписванеНаКнигиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem презаписванеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem резервиранеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem върнатиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem резервираниToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem книгиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem всичкиКнигиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem търсенеНаКнигиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заНасToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изходToolStripMenuItem;
    }
}