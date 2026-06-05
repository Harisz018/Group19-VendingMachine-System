using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace databaseProjectEDP
{
    public partial class AdminForm : Form
    {
        public AdminForm()
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
            MessageBox.Show("Adding " + txtProductName.Text + " to database...");
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
            txtProductName.Clear();
            txtPrice.Clear();
            txtStock.Clear();
        }
    }
}
