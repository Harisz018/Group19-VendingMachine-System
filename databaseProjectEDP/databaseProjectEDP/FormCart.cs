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

        private void calculateTotal()
        {
            decimal total = 0;
            
            foreach (DataGridViewRow row in dgvCart.Rows)
            {
                if (row.Cells[3].Value != null)
                {
                    total += Convert.ToDecimal(row.Cells[3].Value);
                }
            }
            totalLbl.Text = "RM " + total.ToString("0.00");
        }

        private void updateCartItems()
        {
            Cart.Items.Clear();

            foreach (DataGridViewRow row in dgvCart.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    Cart.Items.Add(new CartItem
                    {
                        Name = row.Cells[0].Value.ToString(),
                        Price = Convert.ToDecimal(row.Cells[1].Value),
                        Quantity = Convert.ToInt32(row.Cells[2].Value)
                    });
                }
            }
        }
        private void rmtotalLbl_Click(object sender, EventArgs e)
        {
            decimal totalAmount = 0;

            foreach (DataGridViewRow row in dgvCart.Rows)
            {
                totalAmount += Convert.ToDecimal(row.Cells["Total"].Value);

            }
            totalAmountLbl.Text = "RM " + totalAmount.ToString("0.00");

        }

        private void FormCart_Load(object sender, EventArgs e)
        {
            dgvCart.Rows.Clear();

            foreach (CartItem item in Cart.Items)
            {
                dgvCart.Rows.Add(item.Name, item.Price, item.Quantity, item.Total);
            }

            calculateTotal();
        } 

        private void dgvCart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedItemLbl.Text = dgvCart.Rows[e.RowIndex].Cells[0].Value.ToString();
                qtyTxtBx.Text = dgvCart.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            dgvCart.Rows.Clear();

            selectedItemLbl.Text = "-";
            qtyTxtBx.Text = "0";
            totalLbl.Text = "RM 0.00";
            Cart.Items.Clear();

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (dgvCart.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvCart.SelectedRows[0];

                int qty = Convert.ToInt32(row.Cells[2].Value);
                decimal price = Convert.ToDecimal(row.Cells[1].Value);

                qty++;

                row.Cells[2].Value = qty;
                row.Cells[3].Value = qty * price;
                qtyTxtBx.Text = qty.ToString();

                calculateTotal();
                updateCartItems();
            }
        }

        private void minusBtn_Click(object sender, EventArgs e)
        {
            if (dgvCart.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvCart.SelectedRows[0];

                int qty = Convert.ToInt32(row.Cells[2].Value);
                decimal price = Convert.ToDecimal(row.Cells[1].Value);

                if (qty > 1)
                {
                    qty--;

                    row.Cells[2].Value = qty;
                    row.Cells[3].Value = qty * price;
                    qtyTxtBx.Text = qty.ToString();

                    calculateTotal();
                    updateCartItems();
                }
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (dgvCart.SelectedRows.Count > 0)
            {
                dgvCart.Rows.RemoveAt(dgvCart.SelectedRows[0].Index);

                selectedItemLbl.Text = "-";
                qtyTxtBx.Text = "0";

                calculateTotal();
                updateCartItems();
            }
        }

        private void contShopBtn_Click(object sender, EventArgs e)
        {
            FormFOOD food = new FormFOOD();
            food.Show();
            this.Hide();
        }

        private void paymentBtn_Click(object sender, EventArgs e)
        {
            decimal totalAmount = 0;

            foreach (DataGridViewRow row in dgvCart.Rows)
            {
                if (row.Cells[3].Value != null)
                {
                    totalAmount += Convert.ToDecimal(row.Cells[3].Value);
                }
            }

            FormPayment payment = new FormPayment(totalAmount);
            payment.Show();
            this.Hide();
        }
    }
}
