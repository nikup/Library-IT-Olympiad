using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Library.Data;

namespace Library
{
    public partial class AllClients : Form
    {
        public AllClients()
        {
            InitializeComponent();
        }

        private void AllClients_Load_1(object sender, EventArgs e)
        {
            LibraryEntities1 context = new LibraryEntities1();
            var clients = context.Clients;
            dataGridViewClients.AutoGenerateColumns = false;
            dataGridViewClients.DataSource = clients;

        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            NewClient cl = new NewClient();
            cl.Show();
            LibraryEntities1 context = new LibraryEntities1();
            var clients = context.Clients;
            dataGridViewClients.AutoGenerateColumns = false;
            dataGridViewClients.DataSource = clients;

        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            LibraryEntities1 context = new LibraryEntities1();
            var clients = context.Clients;
            dataGridViewClients.AutoGenerateColumns = false;
            dataGridViewClients.DataSource = clients;
        }

        void dataGridViewClients_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            int id = (int)dataGridViewClients.Rows[e.RowIndex].Cells[0].Value;
            FormReturn cu = new FormReturn(id);
            cu.Show();
        }

        private void radioButtonAll_CheckedChanged(object sender, EventArgs e)
        {
            LibraryEntities1 context = new LibraryEntities1();
            var clients = context.Clients;
            dataGridViewClients.AutoGenerateColumns = false;
            dataGridViewClients.DataSource = clients;
        }

        private void radioButtonNotReturned_CheckedChanged(object sender, EventArgs e)
        {
            LibraryEntities1 context = new LibraryEntities1();
            var clients =
                (from client in context.Clients
                 join clientbook in context.ClientsBooks on client.ClientID equals clientbook.ClientID
                 join book in context.Books on clientbook.BookID equals book.BookID
                 where clientbook.Returned == false
                 select client).Distinct();
            dataGridViewClients.AutoGenerateColumns = false;
            dataGridViewClients.DataSource = clients;
        }
        private void radioButtonLate_CheckedChanged(object sender, EventArgs e)
        {
            LibraryEntities1 context = new LibraryEntities1();
            var cBooks = context.ClientsBooks.ToList().FindAll(c => c.DateLoaned.AddMonths(1) < DateTime.Now);
            var clients = context.Clients.ToList();
            var dataSource = clients.FindAll(c => cBooks.Exists(cb => cb.ClientID == c.ClientID));

            dataGridViewClients.AutoGenerateColumns = false;
            dataGridViewClients.DataSource = dataSource;
        }



        private void radioButtonReserved_CheckedChanged(object sender, EventArgs e)
        {
            LibraryEntities1 context = new LibraryEntities1();
            var clients =
                from clientbook in context.ClientsBooks
                join client in context.Clients on clientbook.ClientID equals client.ClientID
                where clientbook.Reservation == true
                select client;
            dataGridViewClients.AutoGenerateColumns = false;
            dataGridViewClients.DataSource = clients;
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            FindClient fc = new FindClient();
            fc.Show();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
