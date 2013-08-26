using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Library;

namespace LibraryReader
{
    public partial class Menu : Form
    {
        int id;
        public Menu(int id1)
        {
            InitializeComponent();
            id = id1;
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void всичкиКнигиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAllBooks fBs = new FormAllBooks(0);
            fBs.Show();
        }

        private void заНасToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutLibrary aboutLibrary = new AboutLibrary();
            aboutLibrary.Show();
        }

        private void изходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void търсенеНаКнигиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSearch fS = new FormSearch(0,0);
            fS.Show();
        }

        private void презаписванеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReturn fR = new FormReturn(id);
            fR.Show();
        }

        private void върнатиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReturned fR = new FormReturned(id);
            fR.Show();
        }

        private void резервиранеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAllBooks fBs = new FormAllBooks(1);
            fBs.Show();
        }

        private void резервираниToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReserved fR = new FormReserved(id);
            fR.Show();
        }
    }
}
