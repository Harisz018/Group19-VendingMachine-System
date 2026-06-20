using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace databaseProjectEDP
{
    public partial class FormRegisterAdmin : Form
    {
        public FormRegisterAdmin()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("Enter Name");
                return;
            }

            if (txtUsername.Text == "")
            {
                MessageBox.Show("Enter Username");
                return;
            }

            if (txtPassword.Text == "")
            {
                MessageBox.Show("Enter Password");
                return;
            }

            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Passwords Do Not Match");
                return;
            }

            MessageBox.Show("Admin Registered");
        }
    }
}
