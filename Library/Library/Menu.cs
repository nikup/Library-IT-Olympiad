using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Library
{
    public partial class Menu : Form
    {
        public Menu(int fl)
        {
            InitializeComponent();
            if (fl == 0)
            {
                контролНаАкаунтиToolStripMenuItem.Visible = false;
            }
        }

        private void вземанеИВръщанеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FindClient fC = new FindClient();
            fC.Show();
        }

        private void контролНаАкаунтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCreateAccaunt fCA = new FormCreateAccaunt();
            fCA.Show();
        }

        private void търсенеНаКнигиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSearch fS = new FormSearch(0);
            fS.Show();
        }

        private void справкаКнигиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAllBooks fBs = new FormAllBooks();
            fBs.Show();
        }

        private void въвежданеНаНоваToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNewBook fB = new FormNewBook();
            fB.Show();
        }

        private void отчисляванеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRejection fR = new FormRejection();
            fR.Show();
        }

        private void справкаToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AllClients fAC = new AllClients(); ;
            fAC.Show();
        }

        private void регистрацияToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            NewClient fNC = new NewClient();
            fNC.Show();
        }

        private void връщанеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormClientReturned fCl = new FormClientReturned();
            fCl.Show();
        }

        private void заеманеРезервиранеНаКнигиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FindClient fC = new FindClient();
            fC.Show();
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

        private void редактиранеДанниНаЧитателToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEditClient fECl = new FormEditClient();
            fECl.Show();

        }

                                  
    }
}
