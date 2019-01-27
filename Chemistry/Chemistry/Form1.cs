using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chemistry
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            var db = new ChemistryContext();
            db.Ingredients.Load();
            dataGridView1.DataSource = db.Ingredients.Local.ToBindingList();

        }
        //Change
        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var db = new ChemistryContext();
                int index = dataGridView1.SelectedRows[0].Index;
                int id = 0;
                bool converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out id);
                if (converted == false)
                    return;

                Ingredient ingredient = db.Ingredients.Find(id);

                IngredientsForm ingForm = new IngredientsForm();
                ingredient.Name = ingForm.textBox1.Text;
                ingredient.Composition = ingForm.textBox2.Text;
                ingredient.Description = ingForm.textBox3.Text;
                ingredient.Amount = ingForm.textBox4.Text;

                List<Recipe> recipes = db.Recipes.ToList();
                ingForm.comboBox1.DataSource = recipes;
                ingForm.comboBox1.ValueMember = "Id";
                ingForm.comboBox1.DisplayMember = "Name";

                DialogResult result = ingForm.ShowDialog(this);

                //if (result == DialogResult.Cancel)
                //    return;

                ingredient.Name = ingForm.textBox1.Text;
                ingredient.Composition = ingForm.textBox2.Text;
                ingredient.Description = ingForm.textBox3.Text;
                ingredient.Amount = ingForm.textBox4.Text;
                ingredient.Recipe = (Recipe)ingForm.comboBox1.SelectedItem;

                db.Entry(ingredient).State = EntityState.Modified;
                db.SaveChanges();
                
                MessageBox.Show("Объект обновлен");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //Add
        private void button3_Click(object sender, EventArgs e)
        {
            var db = new ChemistryContext();
            IngredientsForm ingForm = new IngredientsForm();



            List<Recipe> recipes = db.Recipes.ToList();
            ingForm.comboBox1.DataSource = recipes;
            ingForm.comboBox1.ValueMember = "Id";
            ingForm.comboBox1.DisplayMember = "Name";

            


            DialogResult result = ingForm.ShowDialog(this);

            //if (result == DialogResult.Cancel)
            //    return;

            Ingredient ingredient = new Ingredient();
            ingredient.Name = ingForm.textBox1.Text;
            ingredient.Composition = ingForm.textBox2.Text;
            ingredient.Description = ingForm.textBox3.Text;
            ingredient.Amount = ingForm.textBox4.Text;
            ingredient.Recipe = (Recipe)ingForm.comboBox1.SelectedItem;

            db.Ingredients.Add(ingredient);
            db.SaveChanges();
            
            MessageBox.Show("New ingredient added");
        }
        //Delete
        private void button2_Click(object sender, EventArgs e)
        {
            var db = new ChemistryContext();
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                int id = 0;
                bool converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out id);
                if (converted == false)
                    return;

                Ingredient ingredient = db.Ingredients.Find(id);
                db.Ingredients.Remove(ingredient);
                db.SaveChanges();

                MessageBox.Show("Объект удален");
            }
        }
        //Recipe
        private void button4_Click(object sender, EventArgs e)
        {
            AllRecipes recipes = new AllRecipes();
            recipes.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var db = new ChemistryContext();
            db.Ingredients.Load();
            dataGridView1.DataSource = db.Ingredients.Local.ToBindingList();
        }
    }
}
