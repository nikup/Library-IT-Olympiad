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
    public partial class FormAuthors : Form
    {
        public FormAuthors()
        {
            InitializeComponent();
        }

        private void FormAuthors_Load(object sender, EventArgs e)
        {
            LibraryEntities context = new LibraryEntities();
            var authors = context.Author;
            //dataGridViewAuthors.AutoGenerateColumns = false;
            dataGridViewAuthors.DataSource = authors;
        }
    }
}
