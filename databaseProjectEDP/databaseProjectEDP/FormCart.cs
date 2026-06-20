using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace databaseProjectEDP
{
    public partial class FormCart : Form
    {
        public FormCart()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void totalLbl_Click(object sender, EventArgs e)
        {

        }

        private void cartLbl_Click(object sender, EventArgs e)
        {

        }

        private void rmtotalLbl_Click(object sender, EventArgs e)
        {
            decimal grandTotal = 0;

            foreach (DataGridViewRow row in dgvCart.Rows)
            {
                grandTotal += Convert.ToDecimal(row.Cells["Total"].Value);

            }
            totalLbl.Text = "RM " + grandTotal.ToString("0.00");

        }

        private void FormCart_Load(object sender, EventArgs e)
        {
            dgvCart.Rows.Add("Coca Cola", 2.50, 1, 2.50);
            dgvCart.Rows.Add("Milo", 3.00, 1, 3.00);
        }
    }
}
