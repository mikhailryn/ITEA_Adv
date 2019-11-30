using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using Homework_Adv_9_02.Models;


namespace Homework_Adv_9_02
{
    public partial class Form1 : Form
    {
        CharacterContext dbContext;
        public Form1()
        {
            InitializeComponent();

            dbContext = new CharacterContext();
            dbContext.Characters.Load();

            CharacterGridView.DataSource = dbContext.Characters.Local.ToBindingList();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var name = tbFirstName.Text;
            var lastName = tbLastName.Text;
            var gender = bool.Parse(tbGender.Text);
            var age = int.Parse(tbAge.Text);

            dbContext.Characters.Add(new Character() { FirstName = name, LastName = lastName, Gender = gender, Age = age });
            dbContext.SaveChanges();
            CharacterGridView.Refresh();
        }

        private void TbFirstName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
