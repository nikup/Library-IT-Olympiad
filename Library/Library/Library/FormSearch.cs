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
    public partial class FormSearch : Form
    {
        public FormSearch()
        {
            InitializeComponent();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            LibraryEntities context = new LibraryEntities();
            string authorFName = textBoxAuthor.Text;
            Author author = context.Author.FirstOrDefault(p => p.FName == authorFName);
            var books =
                from book in context.Book
                where (book.Title == textBoxTitle.Text) || (book.Author.Contains(author)) || (book.Description.Contains(textBoxDescription.Text))
                select book;
            dataGridViewBooks.DataSource = books;
        }
    }
}
