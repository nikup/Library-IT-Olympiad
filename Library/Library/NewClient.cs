using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Library.Data;
using System.Text.RegularExpressions;

namespace Library
{
    public partial class NewClient : Form
    {
        private string emailPattern = @"^([0-9a-zA-Z]([-.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$";
        private string namePattern = @"[A-ZА-Яa-zа-я]$";
        
        public NewClient()
        {
            InitializeComponent();
        }
        private static bool Validate(string text, string pattern)
        {
            return Regex.IsMatch(text, pattern);
        }

        static void CreateNewClient(string fName, string sName, string lName, string egn, string adress, string phone, string email, int leaving, int statusID, int genderID)
        {
            LibraryEntities1 context = new LibraryEntities1();
            Client newClient = new Client()
            {
                FName = fName,
                SName = sName,
                LName = lName,
                EGN = egn,
                Adress = adress,
                Phone = phone,
                Email = email,
                Leaving = leaving,
                StatusID = statusID,
                GenderID = genderID
            };
            context.Clients.AddObject(newClient);
            context.SaveChanges();
           
        }


        private void NewClient_Load(object sender, EventArgs e)
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
            textBoxLeaving.Text = DateTime.Now.Year.ToString();
           
        }
        

        private void Add_Click(object sender, EventArgs e)
        {
            
            string fName = textBoxFName.Text;
            string sName = textBoxSName.Text;
            string LName = textBoxLName.Text;
            string egn = textBoxEGN.Text.Trim();
            string adress = textBoxAdress.Text;
            string phone = textBoxPhone.Text;
            string email = textBoxEmail.Text;
            int leaving;
            if (textBoxLeaving.Text=="")
            {
               leaving=0; 
            }
           
            else 
            {
                leaving =int.Parse(textBoxLeaving.Text);
                if (leaving < (DateTime.Now.Year))
                {
                    
                    leaving = DateTime.Now.Year;
                }
            }
           
            int statusID = int.Parse(comboBoxStatus.SelectedValue.ToString());
            int genderID = int.Parse(comboBoxGender.SelectedValue.ToString());

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
                textBoxEGN.Clear();
                textBoxEGN.Focus();

            }
            else
            {
                if (fName != "" && sName != "" && LName != "" && egn != "")
                {
                    CreateNewClient(fName, sName, LName, egn, adress, phone, email, leaving, statusID, genderID);
                    MessageBox.Show("Читателят е добавен!");
                    printPreviewDialog1.ShowDialog();
                    this.Close();
                }
                else MessageBox.Show("Грешка! Няма достатъчно данни за читателя!");
                
            }
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

        private void textBoxSName_Validating(object sender, CancelEventArgs e)
        {
            if (!Validate(textBoxSName.Text, namePattern))
            {
                epInput.SetError(textBoxSName, "Невалидно собствено име !");
            }
            else
            {
                epInput.SetError(textBoxSName, "");
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

        private void textBoxEmail_Validating(object sender, CancelEventArgs e)
        {
            if (!Validate(textBoxEmail.Text, emailPattern))
            {
                epInput.SetError(textBoxEmail, "Невалиден Email адрес!");
            }
            else
            {
                epInput.SetError(textBoxEmail, "");
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
           /* int checksum = 0;

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
            }*/
            return flag;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string egn = textBoxEGN.Text;
            LibraryEntities1 context = new LibraryEntities1();
            Client cl = context.Clients.FirstOrDefault(
                        p => p.EGN == egn);
            string s = "Училищна библиотека\nЧитателска карта\n\n" + "Име: "+cl.FName + " " + cl.LName+"\n" + "Читателски номер: " +cl.ClientID;
            e.Graphics.DrawString(s, textBoxFName.Font , new SolidBrush(Color.Black), new Point(50, 50));
        }
    }
}
