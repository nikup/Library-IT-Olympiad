using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Library.Data;
using System.Text.RegularExpressions;

namespace Library
{
    public partial class FormAuthor : Form
    {
        private string namePattern = @"[A-ZА-Яa-zа-я]$";
        public FormAuthor()
        {
            InitializeComponent();
        }
        private static bool Validate(string text, string pattern)
        {
            return Regex.IsMatch(text, pattern);
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            LibraryEntities1 context = new LibraryEntities1();
            if (textBoxLName.Text!="")
            {
                Author newAuthor = new Author()
                {
                    FName = textBoxFName.Text,
                    LName = textBoxLName.Text
                };

                context.Authors.AddObject(newAuthor);
                context.SaveChanges();
                MessageBox.Show("Авторът е добавен.");  
            }
            else MessageBox.Show("Грешка! Няма въведени данни.");
            
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxFName_Validating(object sender, CancelEventArgs e)
        {
            if (!Validate(textBoxFName.Text, namePattern))
            {
                epInput.SetError(textBoxFName, "Невалидно име!");
            }
            else
            {
                epInput.SetError(textBoxFName, "");
            }
        }

        private void textBoxLName_Validating(object sender, CancelEventArgs e)
        {
            if (!Validate(textBoxLName.Text, namePattern))
            {
                epInput.SetError(textBoxLName, "Невалидна фамилия!");
            }
            else
            {
                epInput.SetError(textBoxLName, "");
            }
        }
    }
}
