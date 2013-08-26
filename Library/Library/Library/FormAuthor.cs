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
    public partial class FormAuthor : Form
    {
        public FormAuthor()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            LibraryEntities context = new LibraryEntities();
            Author newAuthor = new Author()
            {
                FName = textBoxFName.Text,
                LName = textBoxLName.Text
            };
            context.Author.AddObject(newAuthor);
            context.SaveChanges();
        }
    }
}
