using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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
            LibraryEntities context = new LibraryEntities();
            var categories = context.Category;
            //dataGridViewLanguages.AutoGenerateColumns = false;
            dataGridViewCategories.DataSource = categories;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int i = dataGridViewCategories.CurrentRow.Index;
            string cat = dataGridViewCategories.Rows[i].Cells[1].Value.ToString();
            LibraryEntities context = new LibraryEntities();
            Category newCategory = new Category()
            {
                Name = cat
            };
            context.Category.AddObject(newCategory);
            context.SaveChanges();
        }
    }
}
