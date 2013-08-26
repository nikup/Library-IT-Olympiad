using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Library.Data;
using System.Security.Cryptography;

namespace Library
{
    public partial class FormCreateAccaunt : Form
    {
        public FormCreateAccaunt()
        {
            InitializeComponent();
        }
        public static string CalculateSHA1(string text)
        {
            Encoding enc = Encoding.UTF8;
            byte[] buffer = enc.GetBytes(text);
            SHA1CryptoServiceProvider cryptoTransformSHA1 =
            new SHA1CryptoServiceProvider();
            string hash = BitConverter.ToString(
                cryptoTransformSHA1.ComputeHash(buffer)).Replace("-", "");

            return hash;
        }
        private void InitializeMyControl()
        {
            textBoxLogin.Text = "";
            textBoxPassword.Text = "";
            textBoxPassword.PasswordChar = '*';
            // Контролът не позвоява повече от 14 символа.
            textBoxPassword.MaxLength = 14;
        }
        private void Clear()
        {
            textBoxLogin.Clear();
            textBoxLogin.Focus();
            textBoxPassword.Clear();
            textBoxFName.Clear();
            textBoxLName.Clear();
        }
        
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            LibraryEntities1 context = new LibraryEntities1();
            Accaunt newAccaunt = new Accaunt()
            {
                Login = textBoxLogin.Text.Trim(),
                PasswordSHA1 =CalculateSHA1(textBoxLogin.Text).Trim(),
                FirstName = textBoxFName.Text.Trim(),
                LastName = textBoxLName.Text.Trim()
            };
            context.Accaunts.AddObject(newAccaunt);
            context.SaveChanges();
            MessageBox.Show("Добавянето е успешно.");
            Clear();

        }
        static Accaunt GetAccauntID(LibraryEntities1 context, int accauntID)
        {
            Accaunt  accaunt = context.Accaunts.FirstOrDefault(
                p => p.AccauntID == accauntID);
            return accaunt;
        }
        static void DeleteAccaunt(int accauntID)
        {
            LibraryEntities1 context = new LibraryEntities1();
            Accaunt accaunt = GetAccauntID(context, accauntID);
            context.Accaunts .DeleteObject(accaunt);
            context.SaveChanges();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            //намира номера на текущия ред
            int i = dataGridViewAccaunt.CurrentRow.Index;
            //извличаме accauntID 
            int accauntID = Int32.Parse(dataGridViewAccaunt.Rows[i].Cells[0].Value.ToString());
            DeleteAccaunt(accauntID);
            //изтрива избрания ред от dataGridViewAccaunt
            dataGridViewAccaunt.Rows.RemoveAt(i); 

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            LibraryEntities1 context = new LibraryEntities1();
            var accaunts = context.Accaunts;
            dataGridViewAccaunt.AutoGenerateColumns = false;
            dataGridViewAccaunt.DataSource = accaunts;
        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            textBoxLogin.Focus();
            LibraryEntities1 context = new LibraryEntities1();
            var accaunts = context.Accaunts;
            dataGridViewAccaunt.AutoGenerateColumns = false;
            dataGridViewAccaunt.DataSource = accaunts;
        }
   
    }
}
