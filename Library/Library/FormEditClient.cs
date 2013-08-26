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
    public partial class FormEditClient : Form
    {
        public FormEditClient()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        static Client  GetClientByEGN(LibraryEntities1 context, string  egn)
        {
            Client client = context.Clients.FirstOrDefault(
                c => c.EGN  == egn );
            return client ;
        }

        static Client GetClientByID(LibraryEntities1 context, int clientID)
        {
            Client client = context.Clients.FirstOrDefault(
                c => c.ClientID == clientID );
            return client;
        }

        static void ModifyClien(int clientID,string newFName, string newSName, string newLName, string newEgn, 
            string newAdress, string newPhone, string newEmail, int newLeaving, int newStatusID, int genderID)
        {
            LibraryEntities1 context = new LibraryEntities1();

            Client client = GetClientByID(context, clientID);
            client.FName = newFName;
            client.SName = newSName;
            client.LName = newLName;
            client.EGN  = newEgn ;
            client.Adress = newAdress;
            client.Phone = newPhone;
            client.Email = newEmail;
            client.Leaving = newLeaving;
            client.StatusID  = newStatusID;
            client.GenderID = genderID;
            context.SaveChanges();

        }

        private void Clear()
        {
            textBox1EGN.Clear();
            textBoxClient.Clear();
        }
        private void buttonModify_Click(object sender, EventArgs e)
        {
            if (textBox1EGN.Text != "" || textBoxClient.Text != "")
            {
                int clientID = Int32.Parse(textBoxClient.Text);
                string newFName = textBoxFName.Text;
                string newSName = textBoxSName.Text;
                string newLName = textBoxLName.Text;
                string newEgn = textBoxEGN.Text;
                string newAdress = textBoxAdress.Text;
                string newPhone = textBoxPhone.Text;
                string newEmail = textBoxEmail.Text;
                int newStatusID = Int32.Parse(comboBoxStatus.SelectedValue.ToString());
                int genderID = Int32.Parse(comboBoxGender.SelectedValue.ToString());
                int newLeaving;
                if (textBoxLeaving.Text == "")
                {
                    newLeaving = 0;
                }

                else
                {
                    newLeaving = int.Parse(textBoxLeaving.Text);
                    if (newLeaving < (DateTime.Now.Year))
                    {

                        newLeaving = DateTime.Now.Year;
                    }
                }

                ModifyClien(clientID, newFName, newSName, newLName, newEgn,
                            newAdress, newPhone, newEmail, newLeaving, newStatusID, genderID);
                MessageBox.Show("Данните са актуализиране!");
                Clear();
            }
            else MessageBox.Show("Грешка! Няма въведени данни!");

        }

        private void buttonSearchEGN_Click(object sender, EventArgs e)
        {
            string egn = textBox1EGN.Text;
           
            LibraryEntities1 context = new LibraryEntities1();

            if (egn != "")
            {

                Client client = context.Clients.FirstOrDefault(
                   p => p.EGN == egn);
                textBoxClient.Text = client.ClientID.ToString();
                textBoxFName.Text = client.FName.ToString();
                textBoxSName.Text = client.SName.ToString();
                textBoxLName.Text = client.LName.ToString();
                textBoxEGN.Text = client.EGN.ToString();
                textBoxAdress.Text = client.Adress.ToString();
                textBoxPhone.Text = client.Phone.ToString();
                textBoxEmail.Text = client.Email.ToString();
                textBoxLeaving.Text = client.Leaving.ToString();
                //int genderID= client.GenderID;
                //comboBoxGender.SelectedValue=genderID
            }
            else
            {
                MessageBox.Show("Несте въвели ЕГН!");
            }
        }

        private void FormEditClient_Load(object sender, EventArgs e)
        {
            LibraryEntities1 context = new LibraryEntities1();
            var status = context.Statys;
            comboBoxStatus.DataSource = status;
            comboBoxStatus.ValueMember = "StatusID";
            comboBoxStatus.DisplayMember = "Status";
            var gender = context.Genders;
            comboBoxGender.DataSource = gender;
            comboBoxGender.ValueMember = "GenderID";
            comboBoxGender.DisplayMember = "Gender1";
        }

        private void buttonSearchID_Click(object sender, EventArgs e)
        {
            LibraryEntities1 context = new LibraryEntities1();
            if (textBoxClient.Text != "")
            {

                int clientID = Int32.Parse(textBoxClient.Text);
                if (clientID != 0)
                {
                    Client client = context.Clients.FirstOrDefault(
                      p => p.ClientID == clientID);
                    textBoxFName.Text = client.FName.ToString();
                    textBoxSName.Text = client.SName.ToString();
                    textBoxLName.Text = client.LName.ToString();
                    textBoxEGN.Text = client.EGN.ToString();
                    textBoxAdress.Text = client.Adress.ToString();
                    textBoxPhone.Text = client.Phone.ToString();
                    textBoxEmail.Text = client.Email.ToString();
                    textBoxLeaving.Text = client.Leaving.ToString();
                }
            }
            else
            {
                MessageBox.Show("Несте въвели читателски номер!");
            }
        }

        private void textBox1EGN_Leave(object sender, EventArgs e)
        {
            string egn = textBox1EGN.Text;
            decimal idValue;
            int[] digits = null;

            bool flag = true;

            if (!string.IsNullOrEmpty(egn))
            {
                if (decimal.TryParse(egn, out idValue))
                {
                    digits = (from d in egn.ToCharArray()
                              select Convert.ToInt32(d.ToString())).ToArray();
                    if (digits.Length != 10 || !ValidateEGN(egn, digits))
                        flag = false;
                }
                else
                    flag = false;
            }

            if (!flag)
            {
                MessageBox.Show("Грешно ЕГН!!!");
                textBox1EGN.Clear();
                textBox1EGN.Focus();

            }
        }
            
        public virtual bool ValidateBirthDate(string id, int[] digits)
        {
            int[] days = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            //проверка за дата на раждане
            int dd = (digits[4] * 10) + digits[5],
                mm = (digits[2] * 10) + digits[3],
                yy = (digits[0] * 10) + digits[1],
                yyyy = 0;

            if (mm >= 1 && mm <= 12)
            {
                yyyy = 1900 + yy;
            }
            else if (mm >= 21 && mm <= 32)
            {
                mm -= 20;
                yyyy = 1800 + yy;
            }
            else if (mm >= 41 && mm <= 52)
            {
                mm -= 40;
                yyyy = 2000 + yy;
            }
            else
            {
                return false;
            }

            days[1] += DateTime.IsLeapYear(yyyy) ? 1 : 0;

            if (!(dd >= 1 && dd <= days[mm - 1]))
            {
                return false;
            }

            return true;
        }
        public virtual bool ValidateEGN(string id, int[] digits)
        {
            bool flag = true;

            int[] coeffs = { 2, 4, 8, 5, 10, 9, 7, 3, 6 };
            int[] days = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            //проверка за дата на раждане
            if (!ValidateBirthDate(id, digits))
            {
                return false;
            }

            //проверка за чексума
            int checksum = 0;

            for (int j = 0; j < coeffs.Length; j++)
            {
                checksum += digits[j] * coeffs[j];
            }
            checksum %= 11;
            if (10 == checksum)
            {
                checksum = 0;
            }

            if (digits[9] != checksum)
            {
                return false;
            }
            return flag;
        }
       

    }
}
