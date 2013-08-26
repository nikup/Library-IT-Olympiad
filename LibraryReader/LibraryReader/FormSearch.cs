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
        int al,id;
        
        public FormSearch(int a,int id1)
        {
            InitializeComponent();
            al = a;
            id = id1;
        }
        

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (id == 0) buttonReserve.Visible = false;
            if (al == 0)
            {

                LibraryReader.LibraryEntities context = new LibraryReader.LibraryEntities();
                if (comboBoxSearch.SelectedItem.ToString().Trim() == "Автор")
                {
                    string authorLName = textBoxSearch.Text.Trim();
                    LibraryReader.Author author = context.Authors.FirstOrDefault(p => p.LName == authorLName);

                    if (author != null)
                    {
                        var books = context.Books.ToList();

                        var datasource = (from b in books
                                          where b.Authors.Contains(author)
                                          select b).ToList();

                        dataGridViewBooks.AutoGenerateColumns = false;
                        dataGridViewBooks.DataSource = datasource;
                    }
                    else
                    {
                        MessageBox.Show("Грешка! Няма автор с това име!");
                    }
                }

                else if (comboBoxSearch.SelectedItem.ToString().Trim() == "Заглавие")
                {
                    var books =
                        from book in context.Books
                        where book.Title.Trim() == textBoxSearch.Text.Trim()
                        select book;
                    if (books != null)
                    {
                        dataGridViewBooks.AutoGenerateColumns = false;
                        dataGridViewBooks.DataSource = books;
                    }
                    else 
                    {
                        MessageBox.Show("Грешка! Няма книга с това заглавие!");
                    }
                   
                }
                else if (comboBoxSearch.SelectedItem.ToString().Trim() == "Инвентарен номер")
                {
                    var books =
                        from book in context.Books
                        where book.InvNum.Trim() == textBoxSearch.Text.Trim()
                        select book;
                    if (books != null)
                    {
                        dataGridViewBooks.AutoGenerateColumns = false;
                        dataGridViewBooks.DataSource = books;
                    }
                    else
                    {
                        MessageBox.Show("Грешка! Няма книга с този инвентарен номер!");
                    }
                }
                else if (comboBoxSearch.SelectedItem.ToString().Trim() == "ISBN")
                {
                    var books =
                        from book in context.Books
                        where book.ISBN.Trim() == textBoxSearch.Text.Trim()
                        select book;
                    if (books != null)
                    {
                        dataGridViewBooks.AutoGenerateColumns = false;
                        dataGridViewBooks.DataSource = books;
                    }
                    else
                    {
                        MessageBox.Show("Грешка! Няма книга с този ISBN!");
                    }
                }

            }

        }


        private void FormSearch_Load(object sender, EventArgs e)
        {
            comboBoxSearch.Text = "Автор";
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonReserve_Click(object sender, EventArgs e)
        {
            LibraryReader.LibraryEntities context = new LibraryReader.LibraryEntities();

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
