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
    public partial class AddProductForm : Form
    {
        public AddProductForm()
        {
            InitializeComponent();
        }


        private void AddProductForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void resetBoxes()
        {
            nameTextBox.Text = "";
            unitPriceTextBox.Text = "";
            categoryNameTextBox.Text = "";
            unitPriceTextBox.Text = "";
        }

        private void addProductButton_Click(object sender, EventArgs e)
        {
            String productName1 = nameTextBox.Text;
            int unitsInStock1 = 0;
            while (true)
            {
                if (!int.TryParse(unitsInStockTextBox.Text, out unitsInStock1))
                {
                    Console.WriteLine("Invalid input units in stock - must be a number");
                }
                else
                    break;
            }
            decimal unitPrice1 = 0;
            while (true)
            {
                if (!Decimal.TryParse(unitPriceTextBox.Text, out unitPrice1))
                {
                    Console.WriteLine("Invalid input units in stock - must be a number");
                }
                else
                    break;
            }

            String categoryName1 = categoryNameTextBox.Text;

            using (var db = new ProdContext())
            {
                var catID = from c in db.Categories
                            where c.Name == categoryName1 
                            select c.CategoryID;
                if (catID == null)
                {
                    Console.WriteLine("Invalid category name");
                    this.resetBoxes();
                }
                else
                {
                    Product product = new Product
                    {
                        Name = productName1,
                        UnitsInStock = unitsInStock1,
                        CategoryID = catID.First(),
                        UnitPrice = unitPrice1
                    };

                    db.Products.Add(product);
                    MessageBox.Show("Product added");
                    db.SaveChanges();
                    this.resetBoxes();
                }

            }

        }

        private void categoryNameTextBox_Click(object sender, EventArgs e)
        {

        }
    }
}