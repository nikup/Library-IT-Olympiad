using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Library.Data;

namespace Library
{
    public partial class FormReturn : Form
    {
        int id;
        public FormReturn(int id1)
        {
            InitializeComponent();
            id = id1;
        }
        static Client GetClientByID(LibraryEntities1 context, int clientID)
        {
            Client cl = context.Clients.FirstOrDefault(
                p => p.ClientID == clientID);
            return cl;
        }
        private void CurrentClient_Load(object sender, EventArgs e)
        {
            LibraryEntities1 context = new LibraryEntities1();
            Client clients = GetClientByID(context, id);

            textBoxFName.Text = clients.FName;
            textBoxSName.Text = clients.SName;
            textBoxLName.Text = clients.LName;
            textBoxEGN.Text = clients.EGN;
            textBoxAdress.Text = clients.Adress;
            textBoxPhone.Text = clients.Phone;
            textBoxEmail.Text = clients.Email;
            textBoxLeaving.Text = clients.Leaving.ToString(); ;

            var books =
                from cl in context.ClientsBooks
                join book in context.Books on cl.BookID equals book.BookID
                where (cl.ClientID == id) && (cl.Returned == false) && (cl.Reservation == false)
                select book;
            if (books != null)
            {
                dataGridViewLoaned.AutoGenerateColumns = false;
                dataGridViewLoaned.DataSource = books;
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void buttonReLoan_Click(object sender, EventArgs e)
        {
            LibraryEntities1 context = new LibraryEntities1();

            List<int> books = new List<int>();

            foreach (DataGridViewRow row in dataGridViewLoaned.SelectedRows)
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

                foreach (ClientsBook cBook in client.ClientsBooks)
                {
                    if (books.Contains(cBook.BookID))
                    {
                        cBook.DateLoaned = DateTime.Now;
                        cBook.DateReturned = DateTime.Now.AddMonths(1);
                        MessageBox.Show("Презаписването е успешно!");
                    }
                }

                context.SaveChanges();
            }
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            LibraryEntities1 context = new LibraryEntities1();

            List<int> books = new List<int>();

            foreach (DataGridViewRow row in dataGridViewLoaned.SelectedRows)
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

                foreach (ClientsBook cBook in client.ClientsBooks)
                {
                    if (books.Contains(cBook.BookID))
                    {
                        cBook.Returned = true;
                        MessageBox.Show("Връщане - успешно!");
                    }
                }

                context.SaveChanges();
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            LibraryEntities1 context = new LibraryEntities1();
            var books =
                from cl in context.ClientsBooks
                join book in context.Books on cl.BookID equals book.BookID
                where (cl.ClientID == id) && (cl.Returned == false) && (cl.Reservation == false)
                select book;
            if (books!=null )
            {
                dataGridViewLoaned.AutoGenerateColumns = false;
                dataGridViewLoaned.DataSource = books;
            }
        }
    }
}
