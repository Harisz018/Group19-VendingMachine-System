using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace databaseProjectEDP
{
    public partial class FormPayment : Form
    {
        decimal totalAmount;
        public FormPayment(decimal total)
        {
            InitializeComponent();
            totalAmount = total;
        }

        private void FormPayment_Load(object sender, EventArgs e)
        {
            totalLbl.Text = "RM " + totalAmount.ToString("0.00"); 
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            string paymentMethod = "";
            if (cashRdo.Checked)
            {
                paymentMethod = "Cash";
            }
            else if (ewalletRdo.Checked)
            {
                paymentMethod = "E-Wallet";
            }
            else if (cardRdo.Checked)
            {
                paymentMethod = "Card";
            }
            else
            {
                MessageBox.Show("Please select a payment method");
                return;
            }

            MessageBox.Show("Payment Successful using " + paymentMethod);

            FormReceipt receipt = new FormReceipt(totalAmount, paymentMethod);
            receipt.Show();
            this.Hide();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            FormCart cart = new FormCart();
            cart.Show();
            this.Hide();
        }

    }
}
