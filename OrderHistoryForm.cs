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
    public partial class OrderHistoryForm : Form
    {
        public ProdContext prodContext;
        public OrderHistoryForm()
        {
            InitializeComponent();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            this.orderDataGridView.DataSource =
                prodContext.Orders.Select(o => o).Where(c => c.CompanyName ==
                categoryNameTextBox.Text.ToString()).Select(company => company).ToList();
            
            this.orderDataGridView.Update();
            this.orderDataGridView.Refresh();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void OrderHistoryForm_Load(object sender, EventArgs e)
        {
            this.prodContext = new ProdContext();
            this.prodContext.Orders.Load();
            this.orderBindingSource.DataSource = prodContext.Orders.Local.ToBindingList();
        }

        private void orderDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
