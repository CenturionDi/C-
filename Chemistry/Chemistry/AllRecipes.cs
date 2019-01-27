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
    public partial class AllRecipes : Form
    {
        public AllRecipes()
        {
            InitializeComponent();
            var db = new ChemistryContext();
            db.Recipes.Load();
            dataGridView1.DataSource = db.Recipes.Local.ToBindingList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //ADd
        private void button4_Click(object sender, EventArgs e)
        {
            var db = new ChemistryContext();
            RecipeForm recForm = new RecipeForm();
            DialogResult result = recForm.ShowDialog(this);

            //if (result == DialogResult.Cancel)
            //    return;

            Recipe recipe = new Recipe();
            recipe.Name = recForm.textBox1.Text;
            recipe.Description = recForm.textBox2.Text;

            db.Recipes.Add(recipe);
            db.SaveChanges();
            MessageBox.Show("New recipe added");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var db = new ChemistryContext();
            if (dataGridView1.SelectedRows.Count > 0)
        {
            int index = dataGridView1.SelectedRows[0].Index;
            int id = 0;
            bool converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out id);
            if (converted == false)
                return;
 
            Recipe recipe = db.Recipes.Find(id);
            listBox1.DataSource = recipe.Ingredients.ToList();
            listBox1.DisplayMember = "Name";
        }
        }

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

                Recipe recipe = db.Recipes.Find(id);
                recipe.Ingredients.Clear();
                db.Recipes.Remove(recipe);
                db.SaveChanges();

                MessageBox.Show("Deleted");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var db = new ChemistryContext();
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                int id = 0;
                bool converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out id);
                if (converted == false)
                    return;

                Recipe recipe = db.Recipes.Find(id);

                RecipeForm recForm = new RecipeForm();
                recForm.textBox1.Text = recipe.Name;
                recForm.textBox2.Text = recipe.Description;

                DialogResult result = recForm.ShowDialog(this);


                recipe.Name = recForm.textBox1.Text;
                recipe.Description = recForm.textBox2.Text;

                db.Entry(recipe).State = EntityState.Modified;
                db.SaveChanges();
                MessageBox.Show("Updated");
            }
        }//Dimash
    }
}
