using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LibraryReader
{
    public partial class FormReturned : Form
    {
        int id;
        public FormReturned(int id1)
        {
            InitializeComponent();
            id = id1;
        }

        private void FormReturned_Load(object sender, EventArgs e)
        {
            LibraryEntities context = new LibraryEntities();
            var books =
                from cl in context.ClientsBooks
                join book in context.Books on cl.BookID equals book.BookID
                where (cl.ClientID == id) && (cl.Returned == true) && (cl.Reservation == false)
                select book;
            if (books != null)
            {
                dataGridViewReturned.AutoGenerateColumns = false;
                dataGridViewReturned.DataSource = books;
            }
        }
    }
}
