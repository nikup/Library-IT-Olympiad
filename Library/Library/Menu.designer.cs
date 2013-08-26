namespace Library
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
            this.работаСЧитателиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.регистрацияToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.редактиранеДанниНаЧитателToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заеманеРезервиранеНаКнигиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.връщанеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.търсенеНаКнигиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаКнигиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обработкаНаКнигиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.въвежданеНаНоваToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчисляванеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.контролНаАкаунтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заНасToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.работаСЧитателиToolStripMenuItem,
            this.обработкаНаКнигиToolStripMenuItem,
            this.контролНаАкаунтиToolStripMenuItem,
            this.заНасToolStripMenuItem,
            this.изходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(832, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // работаСЧитателиToolStripMenuItem
            // 
            this.работаСЧитателиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.регистрацияToolStripMenuItem1,
            this.редактиранеДанниНаЧитателToolStripMenuItem,
            this.заеманеРезервиранеНаКнигиToolStripMenuItem,
            this.връщанеToolStripMenuItem,
            this.справкаToolStripMenuItem1,
            this.търсенеНаКнигиToolStripMenuItem,
            this.справкаКнигиToolStripMenuItem});
            this.работаСЧитателиToolStripMenuItem.Name = "работаСЧитателиToolStripMenuItem";
            this.работаСЧитателиToolStripMenuItem.Size = new System.Drawing.Size(128, 21);
            this.работаСЧитателиToolStripMenuItem.Text = "Работа с читатели";
            // 
            // регистрацияToolStripMenuItem1
            // 
            this.регистрацияToolStripMenuItem1.Name = "регистрацияToolStripMenuItem1";
            this.регистрацияToolStripMenuItem1.Size = new System.Drawing.Size(288, 22);
            this.регистрацияToolStripMenuItem1.Text = "Регистрация на читател";
            this.регистрацияToolStripMenuItem1.Click += new System.EventHandler(this.регистрацияToolStripMenuItem1_Click);
            // 
            // редактиранеДанниНаЧитателToolStripMenuItem
            // 
            this.редактиранеДанниНаЧитателToolStripMenuItem.Name = "редактиранеДанниНаЧитателToolStripMenuItem";
            this.редактиранеДанниНаЧитателToolStripMenuItem.Size = new System.Drawing.Size(288, 22);
            this.редактиранеДанниНаЧитателToolStripMenuItem.Text = "Актуализиране на данни на читател";
            this.редактиранеДанниНаЧитателToolStripMenuItem.Click += new System.EventHandler(this.редактиранеДанниНаЧитателToolStripMenuItem_Click);
            // 
            // заеманеРезервиранеНаКнигиToolStripMenuItem
            // 
            this.заеманеРезервиранеНаКнигиToolStripMenuItem.Name = "заеманеРезервиранеНаКнигиToolStripMenuItem";
            this.заеманеРезервиранеНаКнигиToolStripMenuItem.Size = new System.Drawing.Size(288, 22);
            this.заеманеРезервиранеНаКнигиToolStripMenuItem.Text = "Заемане /Резервиране на книги";
            this.заеманеРезервиранеНаКнигиToolStripMenuItem.Click += new System.EventHandler(this.заеманеРезервиранеНаКнигиToolStripMenuItem_Click);
            // 
            // връщанеToolStripMenuItem
            // 
            this.връщанеToolStripMenuItem.Name = "връщанеToolStripMenuItem";
            this.връщанеToolStripMenuItem.Size = new System.Drawing.Size(288, 22);
            this.връщанеToolStripMenuItem.Text = "Връщане/Презаписване на книги";
            this.връщанеToolStripMenuItem.Click += new System.EventHandler(this.връщанеToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem1
            // 
            this.справкаToolStripMenuItem1.Name = "справкаToolStripMenuItem1";
            this.справкаToolStripMenuItem1.Size = new System.Drawing.Size(288, 22);
            this.справкаToolStripMenuItem1.Text = "Справка - читатели";
            this.справкаToolStripMenuItem1.Click += new System.EventHandler(this.справкаToolStripMenuItem1_Click);
            // 
            // търсенеНаКнигиToolStripMenuItem
            // 
            this.търсенеНаКнигиToolStripMenuItem.Name = "търсенеНаКнигиToolStripMenuItem";
            this.търсенеНаКнигиToolStripMenuItem.Size = new System.Drawing.Size(288, 22);
            this.търсенеНаКнигиToolStripMenuItem.Text = "Търсене на книги";
            this.търсенеНаКнигиToolStripMenuItem.Click += new System.EventHandler(this.търсенеНаКнигиToolStripMenuItem_Click);
            // 
            // справкаКнигиToolStripMenuItem
            // 
            this.справкаКнигиToolStripMenuItem.Name = "справкаКнигиToolStripMenuItem";
            this.справкаКнигиToolStripMenuItem.Size = new System.Drawing.Size(288, 22);
            this.справкаКнигиToolStripMenuItem.Text = "Справка - книги";
            this.справкаКнигиToolStripMenuItem.Click += new System.EventHandler(this.справкаКнигиToolStripMenuItem_Click);
            // 
            // обработкаНаКнигиToolStripMenuItem
            // 
            this.обработкаНаКнигиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.въвежданеНаНоваToolStripMenuItem,
            this.отчисляванеToolStripMenuItem});
            this.обработкаНаКнигиToolStripMenuItem.Name = "обработкаНаКнигиToolStripMenuItem";
            this.обработкаНаКнигиToolStripMenuItem.Size = new System.Drawing.Size(141, 21);
            this.обработкаНаКнигиToolStripMenuItem.Text = "Обработка на книги";
            // 
            // въвежданеНаНоваToolStripMenuItem
            // 
            this.въвежданеНаНоваToolStripMenuItem.Name = "въвежданеНаНоваToolStripMenuItem";
            this.въвежданеНаНоваToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.въвежданеНаНоваToolStripMenuItem.Text = "Въвеждане на нови книги";
            this.въвежданеНаНоваToolStripMenuItem.Click += new System.EventHandler(this.въвежданеНаНоваToolStripMenuItem_Click);
            // 
            // отчисляванеToolStripMenuItem
            // 
            this.отчисляванеToolStripMenuItem.Name = "отчисляванеToolStripMenuItem";
            this.отчисляванеToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.отчисляванеToolStripMenuItem.Text = "Отчисляване на книги";
            this.отчисляванеToolStripMenuItem.Click += new System.EventHandler(this.отчисляванеToolStripMenuItem_Click);
            // 
            // контролНаАкаунтиToolStripMenuItem
            // 
            this.контролНаАкаунтиToolStripMenuItem.Name = "контролНаАкаунтиToolStripMenuItem";
            this.контролНаАкаунтиToolStripMenuItem.Size = new System.Drawing.Size(138, 21);
            this.контролНаАкаунтиToolStripMenuItem.Text = "Контрол на акаунти";
            this.контролНаАкаунтиToolStripMenuItem.Click += new System.EventHandler(this.контролНаАкаунтиToolStripMenuItem_Click);
            // 
            // заНасToolStripMenuItem
            // 
            this.заНасToolStripMenuItem.Name = "заНасToolStripMenuItem";
            this.заНасToolStripMenuItem.Size = new System.Drawing.Size(58, 21);
            this.заНасToolStripMenuItem.Text = "За нас";
            this.заНасToolStripMenuItem.Click += new System.EventHandler(this.заНасToolStripMenuItem_Click);
            // 
            // изходToolStripMenuItem
            // 
            this.изходToolStripMenuItem.Name = "изходToolStripMenuItem";
            this.изходToolStripMenuItem.Size = new System.Drawing.Size(57, 21);
            this.изходToolStripMenuItem.Text = "Изход";
            this.изходToolStripMenuItem.Click += new System.EventHandler(this.изходToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Library.Properties.Resources.ver11;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(832, 378);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Училищна библиотека";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem работаСЧитателиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem търсенеНаКнигиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаКнигиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обработкаНаКнигиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem въвежданеНаНоваToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem контролНаАкаунтиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem регистрацияToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem отчисляванеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem връщанеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заеманеРезервиранеНаКнигиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заНасToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактиранеДанниНаЧитателToolStripMenuItem;
    }
}