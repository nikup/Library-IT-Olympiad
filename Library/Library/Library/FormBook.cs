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
    public partial class FormBook : Form
    {  
        int id;
        public FormBook(int id1)
        {
            InitializeComponent();
            id = id1;
        }
        static Book GetBookByID(LibraryEntities context, int bookID)
        {
            Book book = context.Book.FirstOrDefault(
                p => p.ID == bookID);
            return book;
        }

        #region FromLoad
        private void FormBook_Load(object sender, EventArgs e)
        {
            if (id == 0)
            {
                LibraryEntities context = new LibraryEntities();
                //Book book = GetBookByID(context, id);
                var categories =
                    from cat in context.Category
                    select cat;
                comboBoxCategory.DataSource = categories;
                comboBoxCategory.ValueMember = "ID";
                comboBoxCategory.DisplayMember = "Name";
                var languages =
                    from lan in context.Language
                    select lan;
                comboBoxLanguage.DataSource = languages;
                comboBoxLanguage.ValueMember = "ID";
                comboBoxLanguage.DisplayMember = "Name";
                var authors =
                    from author in context.Author
                    select author;
                comboBoxAuthor.DataSource = authors;
                comboBoxAuthor.ValueMember = "ID";
                comboBoxAuthor.DisplayMember = "LName";
                textBoxInvNum.Text = "";
                textBoxISBN.Text = "";
                textBoxTitle.Text = "";
                textBoxDescription.Text = "";
                textBoxYearPubl.Text = "";
                textBoxPrice.Text = "";
            }
            else
            {
                LibraryEntities context = new LibraryEntities();
                Book book = GetBookByID(context, id);
                var categories =
                    from cat in context.Category
                    select cat;
                comboBoxCategory.DataSource = categories;
                comboBoxCategory.ValueMember = "ID";
                comboBoxCategory.DisplayMember = "Name";
                var languages =
                    from lan in context.Language
                    select lan;
                comboBoxLanguage.DataSource = languages;
                comboBoxLanguage.ValueMember = "ID";
                comboBoxLanguage.DisplayMember = "Name";
                var authors =
                    from author in context.Author
                    select author;
                comboBoxAuthor.DataSource = authors;
                comboBoxAuthor.ValueMember = "ID";
                comboBoxAuthor.DisplayMember = "FName" + " " + "LName";
                textBoxInvNum.Text = book.InvNum;
                textBoxISBN.Text = book.ISBN;
                textBoxTitle.Text = book.Title;
                textBoxDescription.Text = book.Description;
                comboBoxCategory.ValueMember = "book.CategoryID";
                textBoxYearPubl.Text = book.YearPubl.ToString();
                comboBoxLanguage.ValueMember = "book.LanguageID";
                textBoxPrice.Text = book.Price.ToString();
            }
        }
        #endregion

        private void checkBoxRejection_CheckedChanged(object sender, EventArgs e)
        {
            LibraryEntities context = new LibraryEntities();
            Book book = GetBookByID(context, id);
            book.Rejection = true;
            context.SaveChanges();    
        }



        static void CreateNewBook(string invn, string isbn, string title,int authorID, string descr, int categID,
        int yearpubl, int langID, int price)
        {
            LibraryEntities context = new LibraryEntities();
            Author author = context.Author.FirstOrDefault(p => p.ID == authorID);
            Book newBook = new Book()
            {
                InvNum = invn,
                ISBN = isbn,
                Title = title,
                Description = descr,
                CategoryID = categID,
                YearPubl = yearpubl,
                LanguageID = langID,
                Price = price,
                Rejection = false
            };
            newBook.Author.Add(author);
            context.Book.AddObject(newBook);
            context.SaveChanges();
            //return newBook.ID;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            LibraryEntities context = new LibraryEntities();
            CreateNewBook(textBoxInvNum.Text, textBoxISBN.Text, textBoxTitle.Text,
                int.Parse(comboBoxAuthor.ValueMember), textBoxDescription.Text, 
                int.Parse(comboBoxCategory.ValueMember), int.Parse(textBoxYearPubl.Text),
                int.Parse(comboBoxLanguage.ValueMember), int.Parse(textBoxPrice.Text));
            if (MessageBox.Show("Ще въвеждате ли още?", "Добавяне на проект",
               MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                textBoxInvNum.Clear();
                textBoxISBN.Clear();
                textBoxTitle.Clear();
                textBoxDescription.Clear();
                textBoxYearPubl.Clear();
                textBoxPrice.Clear();
                textBoxInvNum.Focus();
            }
            else
            {
                this.Close();
            }
        }

        private void buttonNewAuthor_Click(object sender, EventArgs e)
        {
            FormAuthor f = new FormAuthor();
            f.Show();
            //this.Hide();
        }

        private void buttonNewCategory_Click(object sender, EventArgs e)
        {
            FormCategories f = new FormCategories();
            f.Show();
            //this.Hide();
        }

        private void buttonNewLanguage_Click(object sender, EventArgs e)
        {
            FormLanguages f = new FormLanguages();
            f.Show();
            //this.Hide();
        }
    }
}
