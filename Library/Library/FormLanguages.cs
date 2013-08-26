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
    public partial class FormLanguages : Form
    {
        public FormLanguages()
        {
            InitializeComponent();
        }

        private void FormLanguages_Load(object sender, EventArgs e)
        {
            LibraryEntities1 context = new LibraryEntities1();
            var languages = context.Languages ;
            dataGridViewLanguages.AutoGenerateColumns = false;
            dataGridViewLanguages.DataSource = languages;
            buttonAdd.Enabled  = false;
        }
        private void buttonNew_Click(object sender, EventArgs e)
        {
            if (dataGridViewLanguages.Rows.Count > 0)
            {
                int k = dataGridViewLanguages.RowCount; // намира броят на редевете 
                //ппоказалецът се установява на нов празен ред	
                dataGridViewLanguages.CurrentCell = dataGridViewLanguages.Rows[k - 1].Cells[0];
                dataGridViewLanguages.Rows[k - 1].Cells[0].Selected = true;
                //вземаме номера на последния въведен ред
                int categoryid = (int)dataGridViewLanguages.Rows[k - 2].Cells[0].Value;

                //увеличаваме номера с 1 и го присвояваме като номер на новия ред 
                dataGridViewLanguages.Rows[k - 1].Cells[0].Value = categoryid + 1;
            }
            buttonAdd.Enabled = true;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

            int i = dataGridViewLanguages.CurrentRow.Index;
            int LanguageID = (int)dataGridViewLanguages.Rows[i].Cells[0].Value;
            string lang = dataGridViewLanguages.Rows[i].Cells[1].Value.ToString();
            LibraryEntities1 context = new LibraryEntities1();
            if(LanguageID!=0)
            {
                Language newLanguage = new Language()
                {
                    LanguageName = lang
                };
                context.Languages.AddObject(newLanguage);
                context.SaveChanges();
                MessageBox.Show("Добавен е език!");
                buttonAdd.Enabled = false;
            }
            else
            {
                MessageBox.Show("Грешка! Не сте въвели език.");
                this.Close();
            }
        }

        private void button1Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
