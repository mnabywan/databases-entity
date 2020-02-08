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

namespace MyDataBase
{
    public partial class AddOrderForm : Form
    {

        private int categoryID;
        private int productID;
        public string companyName1;
        public ProdContext prodContext;
        private decimal sum;
        private decimal price;
        private int available;
        private int quantity;
        List<Product> products = new List<Product>();
        public AddOrderForm()
        {
            InitializeComponent();
            this.prodContext = new ProdContext();
            this.categoryComboBox.DataSource = prodContext.Categories.ToList();
            sum = 0;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void categoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCategory = categoryComboBox.GetItemText(categoryComboBox.SelectedItem);
            this.categoryID = prodContext.Categories.Where(c => c.Name == selectedCategory).Select(c => c.CategoryID).FirstOrDefault();

            this.productsComboBox.DataSource = prodContext.Products.Where(p => p.CategoryID == categoryID).Select(p => p).ToList();
            //this.productsComboBox.DisplayMembe

        }

        private void productsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedProduct = productsComboBox.GetItemText(productsComboBox.SelectedItem);
            this.productID = prodContext.Products.Where(p => p.Name == selectedProduct).Select(p => p.ProductId).FirstOrDefault();
            available = prodContext.Products.Where(p => p.ProductId == productID).Select(p => p.UnitsInStock).FirstOrDefault();

            this.unitsInStockTextBox.Text = available.ToString();
            Console.WriteLine(available);

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void AddOrderForm_Load(object sender, EventArgs e)
        {
            prodContext.Categories.Load();
            prodContext.Products.Load();
        }

        private void buyButton_Click(object sender, EventArgs e)
        {
            if (this.customerNameTextBox.Text == null)
            {
                MessageBox.Show("Put your customer data");
            }
            quantity = int.Parse(this.quantityTextBox.Text);
            if (quantity > this.available | quantity < 0)
            {
                MessageBox.Show("Invalid quantity");
            }

            companyName1 = customerNameTextBox.Text;
            Customer company = prodContext.Customers.Where(c => c.CompanyName == companyName1).Select(c => c).FirstOrDefault();
            if (company == null)
            {
                MessageBox.Show("Invalid company name");
                return;
            }

            price = prodContext.Products.Where(p => p.ProductId == productID).Select(p => p.UnitPrice).FirstOrDefault();
            string prodName = prodContext.Products.Where(p => p.ProductId == productID).Select(p => p.Name).FirstOrDefault();
            decimal value = price * quantity;
            this.sum += value;


            sumLabel1.Text = "Sum: " + sum.ToString() + " zl ";

            this.productsLabel.Text += prodName + " x" + quantity.ToString();

            Product product2 = new Product();
            product2.ProductId = productID;
            product2.Name = prodName;
            product2.UnitsInStock = quantity;
            product2.UnitPrice = price;
            products.Add(product2);

            Product product = (from p in prodContext.Products
                               where p.ProductId == productID
                               select p).FirstOrDefault();
            product.UnitsInStock = available - quantity;
            prodContext.SaveChanges();
        }



        private void orderButton_Click(object sender, EventArgs e)
        {
            Order order = new Order
            {
                Customer = new Customer { CompanyName = companyName1 },
                Products = products,
                Quantity = quantity,
                Price = this.price
            };

            prodContext.Orders.Add(order);
            prodContext.SaveChanges();
            MessageBox.Show("Dokonano zamówienia");
        }

        private void Cancell_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Zamowienie anulowane");
            return;
        }
    }
}

