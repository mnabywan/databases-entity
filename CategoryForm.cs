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
    public partial class CategoryForm : Form
    {

        public ProdContext prodContext;
        public DataGridView dataGridView1;
        //this.categoryBindingSource.DataSource = context.Categories.Local.ToBindingList();
        //this.productsBindingSource.DataSource = context.Products.Local.ToBindingList();
        //private object categoryGridView;

        public CategoryForm()
        {
            InitializeComponent();
        }


        private void saveButton_Click(object sender, EventArgs e)
        {
            prodContext.SaveChanges();
            prodContext.Categories.Load();
            prodContext.Products.Load();

            this.categoryDataGridView.Refresh();
            this.productsDataGridView.Refresh();
        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {
            BindingSource categoryBindingSource = new BindingSource();
            prodContext = new ProdContext();
            prodContext.Categories.Load();
            prodContext.Products.Load();
            this.categoryBindingSource.DataSource =
                                    prodContext.Categories.Local.ToBindingList();
            this.productsBindingSource.DataSource = prodContext.Products.Local.ToBindingList();
            //dataGridView1.AutoGenerateColumns = true;
            //dataGridView1.DataSource = categoryBindingSource;
            //this.dataGridView1.DataSource = this.categoryBindingSource;

        }

        private void categoryDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            Category category = (Category)this.categoryDataGridView.Rows[row].DataBoundItem;
            if (category != null)
            {                     
                this.productsBindingSource.DataSource = new BindingList<Product>(
                    prodContext.Products.Where(p => p.CategoryID == category.CategoryID).ToList());

            }

        }


        private void categoryDataGridView_CellContentClick2(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            Category category = (Category)this.categoryDataGridView.Rows[row].DataBoundItem;
            if (category != null)
            {
                this.productsBindingSource.DataSource =  (from p in prodContext.Products
                                                    where p.CategoryID == category.CategoryID
                                                     select p).ToList();

            }

        }

        private void categoryFilterButton_Click(object sender, EventArgs e)
        {
            ProdContext prodContext = new ProdContext();
            Boolean parse1;
            Boolean parse2;
            Decimal minPrice = 0;
            Decimal maxPrice = Decimal.MaxValue;
            if (this.minPriceTextBox.Text == "" || this.maxPriceTextBox.Text == "")
            {
                if (minPriceTextBox.Text == "")
                {
                    minPrice = 0;
                }
                if (maxPriceTextBox.Text == "")
                {
                    maxPrice = Decimal.MaxValue;
                }
            }
            else if (!Decimal.TryParse(this.minPriceTextBox.Text, out minPrice) ||
                !Decimal.TryParse(this.maxPriceTextBox.Text, out maxPrice) || minPrice > maxPrice)
            {
                MessageBox.Show("Bad price filters");
            };
                


            this.categoryDataGridView.DataSource = prodContext.Categories.Where(category => (filterButton.Text != "" &&
                    category.Name.ToString().Contains(categoryNameFilterTextBox.Text) == true)).ToList();

            if (checkBox1.Checked == true)
            {
                this.productsDataGridView.DataSource = prodContext.Products.Where(product => ((product.Name.ToString().Contains(this.productNameFiltertextBox.Text)) == true) &&
                    (product.UnitPrice > minPrice) && product.UnitPrice < maxPrice && product.UnitsInStock > 0).ToList();
            }
            else
            {
                this.productsDataGridView.DataSource = prodContext.Products.Where(product => ((product.Name.ToString().Contains(this.productNameFiltertextBox.Text)) == true) &&
                       (product.UnitPrice > minPrice) && product.UnitPrice < maxPrice).ToList();
            }

            this.categoryDataGridView.Update();
            this.productsDataGridView.Refresh();
            this.productsDataGridView.Update();
            this.categoryDataGridView.Refresh();

        }

        private void productsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void categoryNameFilterTextBox_TextChanged(object sender, EventArgs e)
        {
            this.categoryDataGridView.DataSource = prodContext.Categories.Where(category => (
            category.Name.ToString().Contains(this.categoryNameFilterTextBox.Text) == true)).ToList();
        }

        private void productNameFiltertextBox_TextChanged(object sender, EventArgs e)
        {
            this.productsDataGridView.DataSource = prodContext.Products.Where(prod => (
            prod.Name.ToString().Contains(this.productNameFiltertextBox.Text) == true)).ToList();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void minPriceTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            AddOrderForm addOrderForm = new AddOrderForm();
            addOrderForm.ShowDialog();

        }

        private void addProductButton_Click(object sender, EventArgs e)
        {
            AddProductForm addProductForm = new AddProductForm();
            addProductForm.ShowDialog();
        }

        private void addCategoryButton_Click(object sender, EventArgs e)
        {
            AddCategoryForm addCategoryForm = new AddCategoryForm();
            addCategoryForm.ShowDialog();
        }

        private void addCustomer_Click(object sender, EventArgs e)
        {
            AddCustomer addCustomer = new AddCustomer();
            addCustomer.ShowDialog();
        }

        private void orderHistoryButton_Click(object sender, EventArgs e)
        {
            OrderHistoryForm orderHistoryForm = new OrderHistoryForm();
            orderHistoryForm.ShowDialog();
        }
    }
}
