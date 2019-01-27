using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chemistry
{
    public partial class IngredientsForm : Form
    {
        public IngredientsForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Close();
            //var db = new ChemistryContext();
            //Ingredient ingredient = new Ingredient();
            //ingredient.Name = this.textBox1.Text;
            //ingredient.Composition = this.textBox2.Text;
            //ingredient.Description = this.textBox3.Text;
            //ingredient.Amount = this.textBox4.Text;

            //db.Ingredients.Add(ingredient);
            //db.SaveChanges();

            //MessageBox.Show("New ingredient added");
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
