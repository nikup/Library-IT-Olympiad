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
    public partial class FindClient : Form
    {
        public FindClient()
        {
            InitializeComponent();
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            NewClient cl = new NewClient();
            cl.Show();
            this.Close();
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            LibraryEntities1 context = new LibraryEntities1();
            if (radioButtonID.Checked)
            {
                if (textBoxFind.Text!="")
                {
                    int find = int.Parse(textBoxFind.Text);
                    Client cl = context.Clients.FirstOrDefault(
                         p => p.ClientID == find);
                    if (cl != null)
                    {
                        FormTake fT = new FormTake(cl.ClientID);
                        fT.Show();
                        this.Close();
                    }
                    else MessageBox.Show("Няма читател с този читателски номер!");
                }
                else MessageBox.Show("Грешка! Няма въведени данни.");
                
            }
            else
            {
                if (textBoxFind.Text== "")
                {
                    MessageBox.Show("Грешка! Няма въведени данни.");
                }
                else
                {
                    string egn = textBoxFind.Text;

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
                        textBoxFind.Clear();
                        textBoxFind.Focus();

                    }
                    else
                    {

                        Client cl = context.Clients.FirstOrDefault(
                        p => p.EGN == egn);
                        if (cl != null)
                        {
                            FormTake fT = new FormTake(cl.ClientID);
                            fT.Show();
                            this.Close();
                        }
                    }
                }
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
        //за валидиране на ЕГН
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

        private void FindClient_Load(object sender, EventArgs e)
        {

        }
    }
}
