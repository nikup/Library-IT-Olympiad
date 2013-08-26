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
    public partial class FormCategories : Form
    {
        public FormCategories()
        {
            InitializeComponent();
        }

        private void FormCategories_Load(object sender, EventArgs e)
        {
            LibraryEntities1 context = new LibraryEntities1();
            var categories = context.Categories ;
            dataGridViewCategories.AutoGenerateColumns = false;
            dataGridViewCategories.DataSource = categories;
            buttonAdd.Enabled = false;
        }
        private void buttonNew_Click(object sender, EventArgs e)
        {
            if (dataGridViewCategories.Rows.Count > 0)
            {
                int k = dataGridViewCategories.RowCount; // намира броят на редевете 
                //ппоказалецът се установява на нов празен ред	
                dataGridViewCategories.CurrentCell = dataGridViewCategories.Rows[k - 1].Cells[0];
                dataGridViewCategories.Rows[k - 1].Cells[0].Selected = true;
                //вземаме номера на последния въведен ред
                int categoryid = (int)dataGridViewCategories.Rows[k - 2].Cells[0].Value;

                //увеличаваме номера с 1 и го присвояваме като номер на новия ред 
                dataGridViewCategories.Rows[k - 1].Cells[0].Value = categoryid + 1;
            }
            buttonAdd.Enabled  = true;
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int i = dataGridViewCategories.CurrentRow.Index;
            int categoryID = (int)dataGridViewCategories.Rows[i].Cells[0].Value;
            string category = dataGridViewCategories.Rows[i].Cells[1].Value.ToString();
            LibraryEntities1 context = new LibraryEntities1();
            if (categoryID != 0)
            {
                Category newCategory = new Category()
                {
                    CategoryName = category
                };
                context.Categories.AddObject(newCategory);
                context.SaveChanges();
                MessageBox.Show("Категорията е добавена!");
                buttonAdd.Enabled = false;

            }
            else
            {
                MessageBox.Show("Грешка! Не сте въвели категория.");
                this.Close();
            }
        }

        private void button1Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
