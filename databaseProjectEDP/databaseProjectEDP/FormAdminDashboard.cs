using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace databaseProjectEDP
{
    public partial class FormAdminDashboard : Form
    {
        public FormAdminDashboard()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Changes saved!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Item removed.");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        private void FormAdminDashboard_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            FormAdminDashboard dashboard = new FormAdminDashboard();
            dashboard.Show();
            this.Hide();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            FormManageProducts products = new FormManageProducts();
            products.Show();
            this.Hide();
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            FormManageStock stock = new FormManageStock();
            stock.Show();
            this.Hide();
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            FormViewSales sales = new FormViewSales();
            sales.Show();
            this.Hide();
        }
    }
}
