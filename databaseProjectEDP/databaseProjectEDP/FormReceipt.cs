using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace databaseProjectEDP
{
    public partial class FormReceipt : Form
    {
        decimal totalAmount;
        string paymentMethod;
        public FormReceipt(decimal total, string method)
        {
            InitializeComponent();
            totalAmount = total;
            paymentMethod = method;
        }

        private void FormReceipt_Load(object sender, EventArgs e)
        {
            orderIDLbl.Text = "ID" + DateTime.Now.ToString("yyyyMMddHHmmss");

            dateLbl.Text = DateTime.Now.ToString("dd/MM/yyyy hh:mm tt");

            nameLbl.Text = UserLoginForm.customerName;
            matricLbl.Text = UserLoginForm.matricNo;

            paymentMethodLbl.Text = paymentMethod;
            totalLbl.Text = "RM " + totalAmount.ToString("0.00");

            //dummy data
            itemsListBx.Items.Add("Coca Cola");
            itemsListBx.Items.Add("Milo");
            itemsListBx.Items.Add("KitKat");

        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            UserLoginForm login = new UserLoginForm();
            login.Show();
            this.Hide();
        }
    }
}
