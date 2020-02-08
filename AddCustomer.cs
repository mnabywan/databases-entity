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
    public partial class AddCustomer : Form
    {
        public ProdContext prodContext;
        public AddCustomer()
        {
            InitializeComponent();
            this.prodContext = new ProdContext();
        }

        private void AddCustomer_Load(object sender, EventArgs e)
        {
            prodContext = new ProdContext();
            prodContext.Customers.Load();
            this.customerBindingSource.DataSource = prodContext.Customers.Local.ToBindingList();

        }

        private void addCustomerButton_Click(object sender, EventArgs e)
        {
            if(this.companyNameTextBox.Text == "" | this.cityTextBox.Text == "" | this.addressTextBox.Text =="" |
               this.cityTextBox.Text == "" | this.postalCodeTextBox.Text == "" )
            {
                MessageBox.Show("Fullfill all boxes");

            }

            Customer customer = (from c in prodContext.Customers
                                 where c.CompanyName == companyNameTextBox.Text
                                 select c).FirstOrDefault();
            if(customer != null)
            {
                MessageBox.Show("This customer already exists");
            }

            Customer customer1 = new Customer
            {
                CompanyName = this.companyNameTextBox.Text,
                Description = this.descriptionTextBox.Text,
                Address = this.addressTextBox.Text,
                PostalCode = this.postalCodeTextBox.Text,
                City = this.cityTextBox.Text,
                Mail = this.cityTextBox.Text,
                Phone = this.cityTextBox.Text
            };
            
            prodContext.Customers.Add(customer1);
            prodContext.SaveChanges();
            this.customerDataGridView.Visible = true;
            this.customerDataGridView.Update();
            this.customerDataGridView.Refresh();
            //prodContext.SaveChanges();
            MessageBox.Show("Customer added");


        }

        private void customerDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
