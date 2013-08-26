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
    public partial class FormRejection : Form
    {
        public FormRejection()
        {
            InitializeComponent();
        }

        private void buttonRejection_Click(object sender, EventArgs e)
        {
            LibraryEntities1 context = new LibraryEntities1();
            bool вooksRejection = false;
            foreach (DataGridViewRow item in dataGridViewBooks.Rows)
            {
                if (item.Cells[3].Value != null)
                {
                    int bookID = Convert.ToInt32(item.Cells[3].Value);
                    ModifyBookRejection(bookID, true);
                    вooksRejection = true;

                }
            }
            if (вooksRejection)
            {
                MessageBox.Show("Отчисляването е успешно!");
            }
           else MessageBox.Show("Грешка! Няма въведени данни!");
        }
        static Book GetBookByInvNumber(LibraryEntities1 context, string invNum)
        {
            Book book = context.Books.FirstOrDefault(
                p => p.InvNum == invNum);
            return book;
        }
        private void dataGridViewBooks_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            LibraryEntities1 context = new LibraryEntities1();
            //взема инв.№, въведен в клетката
            if (dataGridViewBooks.CurrentRow.Cells[0].Value != null)
            {
                string bookInvNumber = dataGridViewBooks.CurrentRow.Cells[0].Value.ToString();
                //намираме книга по този инв.№
                Book book = GetBookByInvNumber(context, bookInvNumber);

                if (book != null)
                {
                    dataGridViewBooks.CurrentRow.Cells[1].Value = book.Title.ToString();
                    dataGridViewBooks.CurrentRow.Cells[2].Value = book.Rejection;
                    dataGridViewBooks.CurrentRow.Cells[3].Value = book.BookID;
                }
                else
                {
                    MessageBox.Show("Грешен инвентарен номер! Книгата не е намерена.");
                }
            }
        }

        static void ModifyBookRejection(int bookID, bool newRejection)
        {
            LibraryEntities1 context = new LibraryEntities1();
            Book book = GetBookID(context, bookID);
            book.Rejection = newRejection;
            context.SaveChanges();

        }
        static Book  GetBookID(LibraryEntities1 context, int bookID)
        {
            Book book = context.Books.FirstOrDefault(
                p => p.BookID == bookID);
            return book;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
