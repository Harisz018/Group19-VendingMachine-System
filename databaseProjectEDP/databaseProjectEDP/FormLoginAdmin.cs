using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace databaseProjectEDP
{
    public partial class FormLoginAdmin : Form
    {
        public FormLoginAdmin()
        {
            InitializeComponent();
        }

        private void FormAdminLogin_Load(object sender, EventArgs e)
        {
            if (System.IO.File.Exists("user_creds.txt"))
            {
                string[] credentials = System.IO.File.ReadAllLines("user_creds.txt");
                txtAdminID.Text = credentials[0];
                txtPassword.Text = credentials[1];
                chkRemember.Checked = true;
            }
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            string correctID = "admin";
            string correctPass = "admin123";

            if (txtAdminID.Text == correctID && txtPassword.Text == correctPass)
            {
                if (chkRemember.Checked)
                {
                    string[] credentials = { txtAdminID.Text, txtPassword.Text };
                    System.IO.File.WriteAllLines("user_creds.txt", credentials);
                }
                else
                {
                    if (System.IO.File.Exists("user_creds.txt"))
                        System.IO.File.Delete("user_creds.txt");
                }

                FormAdminDashboard dashboard = new FormAdminDashboard();
                dashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid ID or Password. Please try again.",
                                "Access Denied",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                txtPassword.Clear();
                txtAdminID.Focus();
            }
        }

        private void lnkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormRegisterAdmin frm = new FormRegisterAdmin();
            frm.Show();
            this.Hide();
        }

        private void txtAdminID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
