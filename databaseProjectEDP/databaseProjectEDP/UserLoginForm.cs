using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace databaseProjectEDP
{
    public partial class UserLoginForm : Form
    {
        public static string customerName;
        public static string matricNo;
        public UserLoginForm()
        {
            InitializeComponent();
        }

        private void startBtn_Click_1(object sender, EventArgs e)
        {
            if (nameTxtBx.Text == "")
            {
                MessageBox.Show("Please Enter Your Name");
                return;
            }
            
            if (matricTxtBx.Text == "")
            {
                MessageBox.Show("Please Enter Your Matric Number");

            }

            customerName = nameTxtBx.Text;
            matricNo = matricTxtBx.Text;

            //nanti tukar!
            FormCart category = new FormCart();
            category.Show();
            this.Hide();


        }

        private void nameTxtBx_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserLoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
