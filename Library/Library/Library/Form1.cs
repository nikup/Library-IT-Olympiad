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
    public partial class FormBooks : Form
    {
        public FormBooks()
        {
            InitializeComponent();
        }
        #region MenuStrip

        private void searchBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSearch f = new FormSearch();
            f.Show();
            this.Hide();
        }

        private void referenceBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FormBooks f = new FormBooks();
            //f.Show();
            //this.Hide();
        }

        private void bookReservationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBookReservation f = new FormBookReservation();
            f.Show();
            this.Hide();
        }

        private void addBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBook f = new FormBook(0);
            f.Show();
            this.Hide();
        }

        private void searchAuthorsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormSearch f = new FormSearch();
            f.Show();
            this.Hide();
        }
        private void referenceAuthorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAuthors f = new FormAuthors();
            f.Show();
            this.Hide();
        }

        private void addAuthorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormAuthor f = new FormAuthor();
            f.Show();
            this.Hide();
        }
        #endregion

        #region RadioButtons

        private void radioButtonAll_CheckedChanged(object sender, EventArgs e)
        {
            LibraryEntities context = new LibraryEntities();
            var books = context.Book;
            dataGridViewBooks.AutoGenerateColumns = false;
            dataGridViewBooks.DataSource = books;
        }

        private void radioButtonAvailable_CheckedChanged(object sender, EventArgs e)
        {
            LibraryEntities context = new LibraryEntities();
            var books =
                from clientbook in context.ClientBooks
                join book in context.Book on clientbook.BookID equals book.ID
                where clientbook.Returned == true
                select book;
            dataGridViewBooks.AutoGenerateColumns = false;
            dataGridViewBooks.DataSource = books;
        }

        private void radioButtonTaken_CheckedChanged(object sender, EventArgs e)
        {
            LibraryEntities context = new LibraryEntities();
            var books =
                from clientbook in context.ClientBooks
                join book in context.Book on clientbook.BookID equals book.ID
                where clientbook.Returned == false
                select book;
            dataGridViewBooks.AutoGenerateColumns = false;
            dataGridViewBooks.DataSource = books;
        }

        private void radioButtonBooked_CheckedChanged(object sender, EventArgs e)
        {
            LibraryEntities context = new LibraryEntities();
            var books =
                from clientbook in context.ClientBooks
                join book in context.Book on clientbook.BookID equals book.ID
                where clientbook.Reservation == true
                select book;
            dataGridViewBooks.AutoGenerateColumns = false;
            dataGridViewBooks.DataSource = books;
        }
        #endregion

        #region CheckBoxes
        private void checkBoxLanguage_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxLanguage.Enabled = true;
            LibraryEntities context = new LibraryEntities();
            var languages =
                from lan in context.Language
                select lan;
            comboBoxLanguage.DataSource = languages;
            comboBoxLanguage.ValueMember = "ID";
            comboBoxLanguage.DisplayMember = "Name";
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxCategory.Enabled = true;
            LibraryEntities context = new LibraryEntities();
            var categories =
                from cat in context.Category
                select cat;
            comboBoxCategory.DataSource = categories;
            comboBoxCategory.ValueMember = "ID";
            comboBoxCategory.DisplayMember = "Name";
        }
        #endregion

        #region ComboBoxes
        private void comboBoxLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            #region 1
            /*if (radioButtonAll.Checked == true)
            {
                LibraryEntities context = new LibraryEntities();
                var books =
                    from book in context.Book
                    where book.LanguageID == int.Parse(comboBoxLanguage.SelectedValue.ToString())
                    select book;
                dataGridViewBooks.AutoGenerateColumns = false;
                dataGridViewBooks.DataSource = books;
            }
            if (radioButtonAvailable.Checked == true)
            {
                LibraryEntities context = new LibraryEntities();
                var books =
                    from clientbook in context.ClientBooks
                    join book in context.Book on clientbook.BookID equals book.ID
                    where (clientbook.Returned == true) && (book.LanguageID == int.Parse(comboBoxLanguage.SelectedValue.ToString()))
                    select book;
                dataGridViewBooks.AutoGenerateColumns = false;
                dataGridViewBooks.DataSource = books;
            }
            if (radioButtonTaken.Checked == true)
            {
                LibraryEntities context = new LibraryEntities();
                var books =
                    from clientbook in context.ClientBooks
                    join book in context.Book on clientbook.BookID equals book.ID
                    where (clientbook.Returned == false) && (book.LanguageID == int.Parse(comboBoxLanguage.SelectedValue.ToString()))
                    select book;
                dataGridViewBooks.AutoGenerateColumns = false;
                dataGridViewBooks.DataSource = books;
            }
            if (radioButtonBooked.Checked == true)
            {
                LibraryEntities context = new LibraryEntities();
                var books =
                    from clientbook in context.ClientBooks
                    join book in context.Book on clientbook.BookID equals book.ID
                    where (clientbook.Reservation == true) && (book.LanguageID == int.Parse(comboBoxLanguage.SelectedValue.ToString()))
                    select book;
                dataGridViewBooks.AutoGenerateColumns = false;
                dataGridViewBooks.DataSource = books;
            }*/
            #endregion
            
            //var books =
        }


        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radioButtonAll.Checked == true)
            {
                LibraryEntities context = new LibraryEntities();
                var books =
                    from book in context.Book
                    where book.CategoryID == int.Parse(comboBoxCategory.SelectedValue.ToString())
                    select book;
                dataGridViewBooks.AutoGenerateColumns = false;
                dataGridViewBooks.DataSource = books;
            }
            if (radioButtonAvailable.Checked == true)
            {
                LibraryEntities context = new LibraryEntities();
                var books =
                    from clientbook in context.ClientBooks
                    join book in context.Book on clientbook.BookID equals book.ID
                    where (clientbook.Returned == true) && (book.CategoryID == int.Parse(comboBoxCategory.SelectedValue.ToString()))
                    select book;
                dataGridViewBooks.AutoGenerateColumns = false;
                dataGridViewBooks.DataSource = books;
            }
            if (radioButtonTaken.Checked == true)
            {
                LibraryEntities context = new LibraryEntities();
                var books =
                    from clientbook in context.ClientBooks
                    join book in context.Book on clientbook.BookID equals book.ID
                    where (clientbook.Returned == false) && (book.CategoryID == int.Parse(comboBoxCategory.SelectedValue.ToString()))
                    select book;
                dataGridViewBooks.AutoGenerateColumns = false;
                dataGridViewBooks.DataSource = books;
            }
            if (radioButtonBooked.Checked == true)
            {
                LibraryEntities context = new LibraryEntities();
                var books =
                    from clientbook in context.ClientBooks
                    join book in context.Book on clientbook.BookID equals book.ID
                    where (clientbook.Reservation == true) && (book.CategoryID == int.Parse(comboBoxCategory.SelectedValue.ToString()))
                    select book;
                dataGridViewBooks.AutoGenerateColumns = false;
                dataGridViewBooks.DataSource = books;
            }
        }
        #endregion
        private void FormBooks_Load(object sender, EventArgs e)
        {
            radioButtonAll.Checked = true;
        }
    }
}
