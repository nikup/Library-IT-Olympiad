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
    public partial class FormLanguages : Form
    {
        public FormLanguages()
        {
            InitializeComponent();
        }

        private void FormLanguages_Load(object sender, EventArgs e)
        {
            LibraryEntities context = new LibraryEntities();
            var languages = context.Language;
            //dataGridViewLanguages.AutoGenerateColumns = false;
            dataGridViewLanguages.DataSource = languages;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int i = dataGridViewLanguages.CurrentRow.Index;
            string lang = dataGridViewLanguages.Rows[i].Cells[1].Value.ToString();
            LibraryEntities context = new LibraryEntities();
            Language newLanguage = new Language()
            {
                Name = lang
            };
            context.Language.AddObject(newLanguage);
            context.SaveChanges();
        }
    }
}
