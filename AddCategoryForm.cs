using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyDataBase
{
    public partial class AddCategoryForm : Form
    {
        public AddCategoryForm()
        {
            InitializeComponent();
        }


        private void resetBoxes()
        {
            categoryNameTextBox.Text = "";
            descriptionTextBox.Text = "";
        }



        private void AddCategoryForm_Load(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            string categoryName1 = categoryNameTextBox.Text;
            string description1 = descriptionTextBox.Text;

            using(var db = new ProdContext())
            {
                var catID = from c in db.Categories
                            where c.Name == categoryName1
                            select c.CategoryID;

                if (catID == null)
                {
                    Category category = new Category
                    {
                        Name = categoryName1,
                        Description = description1
                    };
                    db.Categories.Add(category);
                    MessageBox.Show("Category added");
                    db.SaveChanges();
                    this.resetBoxes();
                }
                else
                {
                    MessageBox.Show("Category exists");

                }



            }
        }

        private void categoryNameTextBox_Click(object sender, EventArgs e)
        {

        }
    }
}
