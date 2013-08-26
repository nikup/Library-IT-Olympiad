using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Library.Data;
using System.IO;

namespace Library
{
    public partial class FormAllBooks : Form
    {
        public FormAllBooks()
        {
            InitializeComponent();
        }

        #region RadioButtons

        private void radioButtonAll_CheckedChanged(object sender, EventArgs e)
        {
            LibraryEntities1 context = new LibraryEntities1();
            var books =
                from book in context.Books
                where book.Rejection == false
                select book;

            dataGridViewBooks.AutoGenerateColumns = false;
            dataGridViewBooks.DataSource = books;
        }

        private void radioButtonAvailable_CheckedChanged(object sender, EventArgs e)
        {
            LibraryEntities1 context = new LibraryEntities1();
            var booksTaken =
                from clientbook in context.ClientsBooks
                join book in context.Books on clientbook.BookID equals book.BookID
                where (clientbook.Returned == false) && (book.Rejection == false)
                select book;
            var books = context.Books.Except(booksTaken);
            dataGridViewBooks.AutoGenerateColumns = false;
            dataGridViewBooks.DataSource = books;
        }

        private void radioButtonTaken_CheckedChanged(object sender, EventArgs e)
        {
            LibraryEntities1 context = new LibraryEntities1();
            var books =
                (from clientbook in context.ClientsBooks
                join book in context.Books on clientbook.BookID equals book.BookID 
                where (clientbook.Returned == false) && (book.Rejection == false)
                select book).Distinct();
            dataGridViewBooks.AutoGenerateColumns = false;
            dataGridViewBooks.DataSource = books;
        }

        private void radioButtonBooked_CheckedChanged(object sender, EventArgs e)
        {
            LibraryEntities1 context = new LibraryEntities1();
            var books =
                from clientbook in context.ClientsBooks
                join book in context.Books on clientbook.BookID equals book.BookID 
                where (clientbook.Reservation == true) && (book.Rejection == false)
                select book;
            dataGridViewBooks.AutoGenerateColumns = false;
            dataGridViewBooks.DataSource = books;
        }
        #endregion

        private void FormBooks_Load(object sender, EventArgs e)
        {
            radioButtonAll.Checked = true;
        }


       
        private void radioButtonRejected_CheckedChanged(object sender, EventArgs e)
        {
            LibraryEntities1 context = new LibraryEntities1();
            var books =
                from book in context.Books
                where book.Rejection == true
                select book;

            dataGridViewBooks.AutoGenerateColumns = false;
            dataGridViewBooks.DataSource = books;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
