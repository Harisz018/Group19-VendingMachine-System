using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace databaseProjectEDP
{
    public partial class FormManageProducts : Form
    {
        public FormManageProducts()
        {
            InitializeComponent();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            FormAdminDashboard dashboard = new FormAdminDashboard();
            dashboard.Show();
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            dgvProducts.Rows.Add(
            txtProductID.Text,
            txtProductName.Text,
            cmbCategory.Text,
            txtPrice.Text,
        "Active"
         );
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow != null)
            {
                dgvProducts.Rows.Remove(dgvProducts.CurrentRow);
            }
        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow != null)
            {
                dgvProducts.CurrentRow.Cells[0].Value = txtProductID.Text;
                dgvProducts.CurrentRow.Cells[1].Value = txtProductName.Text;
                dgvProducts.CurrentRow.Cells[2].Value = cmbCategory.Text;
                dgvProducts.CurrentRow.Cells[3].Value = txtPrice.Text;
            }
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
