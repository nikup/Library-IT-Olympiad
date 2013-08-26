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
    public partial class FormTake : Form
    {
        int clientId;
        public FormTake(int clientId)
        {
            InitializeComponent();
            this.clientId = clientId; 
            
        }
        static Client GetClientByID(LibraryEntities1 context, int clientID)
        {
            Client cl = context.Clients.FirstOrDefault(
                p => p.ClientID == clientID);
            return cl;
        }

        private void FormTake_Load(object sender, EventArgs e)
        {
            LibraryEntities1 context = new LibraryEntities1();
            Client clients = GetClientByID(context, clientId);

            textBoxFName.Text = clients.FName;
            textBoxSName.Text = clients.SName;
            textBoxLName.Text = clients.LName;
            textBoxEGN.Text = clients.EGN;
            textBoxAdress.Text = clients.Adress;
            textBoxPhone.Text = clients.Phone;
            textBoxEmail.Text = clients.Email;
            textBoxLeaving.Text = clients.Leaving.ToString();
            dataGridViewLoaned.AutoGenerateColumns = false;
            for (int i = 0; i < 20; i++)
            {
                dataGridViewLoaned.Rows.Add();
            }
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            LibraryEntities1 context = new LibraryEntities1();
            var client = (from c in context.Clients
                          where c.ClientID == clientId
                          select c).SingleOrDefault();

            bool hasBooks = false;

            foreach (DataGridViewRow item in dataGridViewLoaned.Rows)
            {
                if (item.Cells[4].Value != null)
                {
                    int bookID = Convert.ToInt32(item.Cells[4].Value);
                    DateTime dateL = Convert.ToDateTime(item.Cells[2].Value);
                    DateTime dateR = Convert.ToDateTime(item.Cells[3].Value);

                    ClientsBook cBook = new ClientsBook();
                    cBook.BookID = bookID;
                    cBook.ClientID = client.ClientID;
                    cBook.DateLoaned = dateL;
                    cBook.DateReturned = dateR;

                    client.ClientsBooks.Add(cBook);

                    hasBooks = true;
                }
            }

            if (hasBooks)
            {
                context.SaveChanges();
                MessageBox.Show("Книгите са записани - заети!");
            }
            else MessageBox.Show("Грешка! Няма въведени данни!");
        }

        static Book GetBookByInvNumber(LibraryEntities1 context, string invNum)
        {
            Book books = context.Books.FirstOrDefault(
                p => p.InvNum == invNum);
            return books;
        }

        //за заемане на книги
        private void dataGridViewLoaned_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            LibraryEntities1 context = new LibraryEntities1();
            //взема инв.№, въведен в клетката
            if (dataGridViewLoaned.CurrentRow.Cells[0].Value != null)
            {
                string bookInvNumber = dataGridViewLoaned.CurrentRow.Cells[0].Value.ToString();
                //намираме книга по този инв.№
                Book book = GetBookByInvNumber(context, bookInvNumber);

                if (book != null)
                {
                    dataGridViewLoaned.CurrentRow.Cells[1].Value = book.Title.ToString();
                    dataGridViewLoaned.CurrentRow.Cells[2].Value = DateTime.Now;
                    dataGridViewLoaned.CurrentRow.Cells[3].Value = DateTime.Now.AddMonths(1);
                    dataGridViewLoaned.CurrentRow.Cells[4].Value = book.BookID;
                }
                else
                {
                    MessageBox.Show("Грешен инвентарен номер! Книгата не е намерена.");
                }
            }
        }
        //за резервиране на книги
        private void buttonReserveNew_Click(object sender, EventArgs e)
        {
            LibraryEntities1 context = new LibraryEntities1();
            var client = (from c in context.Clients
                          where c.ClientID == clientId
                          select c).SingleOrDefault();

            bool hasBooks = false;

            foreach (DataGridViewRow item in dataGridViewLoaned.Rows)
            {
                if (item.Cells[4].Value != null)
                {
                    int bookID = Convert.ToInt32(item.Cells[4].Value);
                    DateTime dateL = Convert.ToDateTime(item.Cells[2].Value);
                    DateTime dateR = Convert.ToDateTime(item.Cells[3].Value);

                    ClientsBook cBook = new ClientsBook();
                    cBook.BookID = bookID;
                    cBook.ClientID = client.ClientID;
                    cBook.DateLoaned = dateL;
                    cBook.DateReturned = dateR;
                    cBook.Reservation = true;

                    client.ClientsBooks.Add(cBook);

                    hasBooks = true;
                }
            }

            if (hasBooks)
            {
                context.SaveChanges();
                MessageBox.Show("Книгата е резервирана!");
            }
            else MessageBox.Show("Грешка! Няма въведени данни!");

        }
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
