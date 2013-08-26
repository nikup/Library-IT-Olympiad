using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using LibraryReader;

namespace Library
{
    public partial class FormAllBooks : Form
    {
        int id;
        public FormAllBooks(int id1)
        {
            InitializeComponent();
            id = id1;
        }

        #region RadioButtons

        private void radioButtonAll_CheckedChanged(object sender, EventArgs e)
        {
            LibraryReader.LibraryEntities context = new LibraryReader.LibraryEntities();
            var books =
                from book in context.Books
                where book.Rejection == false
                select book;

            dataGridViewBooks.AutoGenerateColumns = false;
            dataGridViewBooks.DataSource = books;
        }

        private void radioButtonAvailable_CheckedChanged(object sender, EventArgs e)
        {
            LibraryReader.LibraryEntities context = new LibraryReader.LibraryEntities();
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
            LibraryReader.LibraryEntities context = new LibraryReader.LibraryEntities();
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
            LibraryReader.LibraryEntities context = new LibraryReader.LibraryEntities();
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
            if (id == 0) buttonReserve.Visible = false;
            radioButtonAll.Checked = true;
        }


       
        private void radioButtonRejected_CheckedChanged(object sender, EventArgs e)
        {
            LibraryReader.LibraryEntities context = new LibraryReader.LibraryEntities();
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

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            FormSearch fS = new FormSearch(0,1);
            fS.Show();
        }

        private void buttonReserve_Click(object sender, EventArgs e)
        {
            LibraryEntities context = new LibraryEntities();

            List<int> books = new List<int>();

            foreach (DataGridViewRow row in dataGridViewBooks.SelectedRows)
            {
                if (row.Cells[0].Value != null)
                {
                    books.Add(Convert.ToInt32(row.Cells[0].Value));
                }
            }

            if (books.Count > 0)
            {

                var client = (from c in context.Clients
                              where c.ClientID == id
                              select c).SingleOrDefault();

                foreach (LibraryReader.ClientsBook cBook in client.ClientsBooks)
                {
                    if (books.Contains(cBook.BookID))
                    {
                        cBook.Reservation = true;
                        MessageBox.Show("Резервирането е успешно!");
                    }
                }

                context.SaveChanges();
            }
        }

    }
}
