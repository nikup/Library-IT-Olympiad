using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Library.Data;

namespace Library
{
    public partial class FormNewBook : Form
    {

        private string pricePattern = @"^[0-9,]+$";
        private string invNumberPattern = @"^[A-ZА-Я0-9/]+$";
        private string iSBNPattern = @"^[0-9-]+$";
        private string yearPublPattern = @"^[0-9]+$";

        public FormNewBook()
        {
            InitializeComponent();
        }
        private static bool Validate(string text, string pattern)
        {
            return Regex.IsMatch(text, pattern);
        }
        static Book GetBookByID(LibraryEntities1 context, int bookID)
        {
            Book book = context.Books.FirstOrDefault(
                p => p.BookID == bookID);
            return book;
        }

        private void FormNewBook_Load(object sender, EventArgs e)
        {
            LibraryEntities1 context = new LibraryEntities1();
            dataGridViewAuthors.AutoGenerateColumns = false;
            dataGridViewAuthors.DataSource = from a in context.Authors
                                             orderby a.LName
                                             select a;
            foreach (DataGridViewRow row in dataGridViewAuthors.SelectedRows)
            {
                row.Selected = false;
            }


            //категории - зареждане на комбото
            var categories = context.Categories;
            comboBoxCategory.DataSource = categories;
            comboBoxCategory.ValueMember = "CategoryID";
            comboBoxCategory.DisplayMember = "CategoryName";
            //зареждане на комбото с език
            var languages = context.Languages;
            comboBoxLanguage.DataSource = languages;
            comboBoxLanguage.ValueMember = "LanguageID";
            comboBoxLanguage.DisplayMember = "LanguageName";

        }
        private void Clear()
        {
            textBoxInvNum.Clear();
            textBoxISBN.Clear();
            textBoxTitle.Clear();
            textBoxDescription.Clear();
            textBoxYearPubl.Clear();
            textBoxPrice.Clear();
            foreach (DataGridViewRow row in dataGridViewAuthors.SelectedRows)
            {
                row.Selected = false;
            }
            textBoxInvNum.Focus();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            LibraryEntities1 context = new LibraryEntities1();
            if (textBoxAuthor.Text != "")
            {

                string lastName = textBoxAuthor.Text;
                bool flag = false;
                foreach (DataGridViewRow row in dataGridViewAuthors.Rows)
                {
                    row.Selected = false;
                    if (row.Cells[2].Value != null && row.Cells[2].Value.ToString() == lastName)
                    {
                        row.Selected = true;
                        flag = true;
                        break;
                    }
                }
                if (!flag)
                {
                    MessageBox.Show("Този автор не съществува в базата!");
                }
            }
            else MessageBox.Show("Грешка! Не сте въвели данни за автара!");

        }

        private void buttonNewAuthor_Click(object sender, EventArgs e)
        {
            FormAuthor fa = new FormAuthor();
            fa.Show();

        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            LibraryEntities1 context = new LibraryEntities1();
            dataGridViewAuthors.AutoGenerateColumns = false;
            dataGridViewAuthors.DataSource = from a in context.Authors
                                             orderby a.LName
                                             select a;
            foreach (DataGridViewRow row in dataGridViewAuthors.SelectedRows)
            {
                row.Selected = false;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            LibraryEntities1 context = new LibraryEntities1();
            //създаваме нова книга чрез конструктора Books()
            try
            {
                if (textBoxInvNum.Text != "" && textBoxTitle.Text != "")
                {
                    Book newBook = new Book();
                    //на съответните полета присвояваме стойностите от текстовите кутии
                    newBook.InvNum = textBoxInvNum.Text;
                    newBook.ISBN = textBoxISBN.Text;
                    newBook.Title = textBoxTitle.Text;
                    newBook.Description = textBoxDescription.Text;
                    newBook.YearPub = Int32.Parse(textBoxYearPubl.Text);
                    newBook.Price = Decimal.Parse(textBoxPrice.Text);
                    newBook.Rejection = false;
                    newBook.CategoryID = Int32.Parse(comboBoxCategory.SelectedValue.ToString());
                    newBook.LanguageID = Int32.Parse(comboBoxLanguage.SelectedValue.ToString());
                    // обработка на селектираните редове от  DataGridViewAuthors - това са авторите на новата книга
                    int authorID;//локална променлива
                    foreach (DataGridViewRow row in dataGridViewAuthors.SelectedRows)
                    {
                        authorID = Convert.ToInt32(row.Cells[0].Value);//вземаме стойността Value на ID на автора от текущо селектирания ред - row.Cells[0].Value
                        //добавяне на данните за автора към свойството Authors на книгата, която обработваме
                        //свойството не е просто свойство, а е списък (List) от автори
                        newBook.Authors.Add(context.Authors.ToList().Find(a => a.AuthorID == authorID));
                    }
                    //добавяне на новата книга в базата и записване на промените
                    context.Books.AddObject(newBook);
                    context.SaveChanges();
                    MessageBox.Show("Книгата е добавена!");
                }
                else
                {
                    MessageBox.Show("Грешка! Не сте въвели данни.");
                }

            }
            catch (FormatException)
            {
                MessageBox.Show("Вие не сте въвели данни! " + "Книгата не е добавена!");
            }
            if (MessageBox.Show("Ще въвеждате ли други книги?", "Добавяне на книга",
                        MessageBoxButtons.YesNo) == DialogResult.No)
            {
                this.Close();
            }
            else
            {
                Clear();
            }

        }

        private void textBoxInvNum_Validating(object sender, CancelEventArgs e)
        {
            if (!Validate(textBoxInvNum.Text, invNumberPattern))
            {
                epInput.SetError(textBoxInvNum, "Невалиден номер!");
            }
            else
            {
                epInput.SetError(textBoxInvNum, "");
            }
        }

        private void textBoxISBN_Validating(object sender, CancelEventArgs e)
        {
            if (!Validate(textBoxISBN.Text, iSBNPattern))
            {
                epInput.SetError(textBoxISBN, "Невалиден ISBN!");
            }
            else
            {
                epInput.SetError(textBoxISBN, "");
            }
        }

        private void textBoxYearPubl_Validating(object sender, CancelEventArgs e)
        {
            if (!Validate(textBoxYearPubl.Text, yearPublPattern))
            {
                epInput.SetError(textBoxYearPubl, "Невалидна година на издаване!");
            }
            else
            {
                epInput.SetError(textBoxYearPubl, "");
            }
        }

        private void textBoxPrice_Validating(object sender, CancelEventArgs e)
        {
            if (!Validate(textBoxPrice.Text, pricePattern))
            {
                epInput.SetError(textBoxPrice, "Невалидна цена! Използвай десетична запетая!");

            }
            else
            {
                epInput.SetError(textBoxPrice, "");
            }
        }

        private void buttonNewCategory_Click(object sender, EventArgs e)
        {
            FormCategories fk = new FormCategories();
            fk.Show();
        }

        private void buttonNewLanguage_Click(object sender, EventArgs e)
        {
            FormLanguages fl = new FormLanguages();
            fl.Show();
        }

        private void button1Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
