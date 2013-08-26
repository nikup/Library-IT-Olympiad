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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeMyControl()
        {
            textBoxID.Text = "";
            textBoxEGN.Text = "";
            textBoxEGN.PasswordChar = '*';
            textBoxEGN.MaxLength = 14;
        }

        private void Clear()
        {
            textBoxID.Text = "";
            textBoxEGN.Text = "";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeMyControl();
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            LibraryEntities context = new LibraryEntities();
            var clients = context.Clients;

            bool flag = false;
            foreach (var item in clients)
            {
                if (int.Parse(textBoxID.Text) == item.ClientID && textBoxEGN.Text.Trim() == item.EGN.Trim())
                {
                    flag = true;
                }
            }
            if (flag == true)
            {
                Menu menu = new Menu(int.Parse(textBoxID.Text));
                menu.Show();
                InitializeMyControl();
                Clear();
            }
            else
            {
                MessageBox.Show("Грешка! Невалидна парола!");
                InitializeMyControl();
                Clear();
            }
        }
    }
}
