using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using Library.Data;

namespace Library
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void InitializeMyControl()
        {
            textBoxLogin.Text = "";
            textBoxPassword.Text = "";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.MaxLength = 14;
        }

        private void Clear()
        {
            textBoxLogin.Text = "";
            textBoxPassword.Text = "";
        }

        //SHA1 hash calculation in C#
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
        private void FormLogin_Load(object sender, EventArgs e)
        {
            InitializeMyControl();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
             
            LibraryEntities1 context = new LibraryEntities1();
            var accaunts = context.Accaunts;
              
          
            bool flag = false;
            foreach (var item in accaunts)
            {
                if (textBoxLogin.Text.Trim() == item.Login.Trim()  &&  CalculateSHA1(textBoxPassword.Text).Trim()== item.PasswordSHA1.Trim())
                {

                    flag = true;
                    Menu formMenu = new Menu(0);
                    
                    formMenu.Show();
                   
                }
                if (textBoxLogin.Text.Trim() == "administrator".Trim () && CalculateSHA1(textBoxPassword.Text).Trim() == item.PasswordSHA1.Trim())
                {
                    flag = true;
                    Menu formMenu = new Menu(1);
                    formMenu.Show();
                }
            }
            if (!flag)
            {
                MessageBox.Show("Грешка! Невалидна парола!");
                InitializeMyControl();
                Clear();
            }
            Clear();
        }
    }
}


       