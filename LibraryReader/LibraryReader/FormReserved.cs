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
    public partial class FormReserved : Form
    {
        int id;
        public FormReserved(int id1)
        {
            InitializeComponent();
            id = id1;
        }

        private void FormReserved_Load(object sender, EventArgs e)
        {
            LibraryReader.LibraryEntities context = new LibraryReader.LibraryEntities();
            var books =
                from cl in context.ClientsBooks
                join book in context.Books on cl.BookID equals book.BookID
                where (cl.ClientID == id) && (cl.Returned == false) && (cl.Reservation == true)
                select book;
            if (books != null)
            {
                dataGridViewReserved.AutoGenerateColumns = false;
                dataGridViewReserved.DataSource = books;
            }

        }
    }
}
