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
        public UserLoginForm()
        {
            InitializeComponent();
        }

        private void welcomeLbl_Click(object sender, EventArgs e)
        {

        }

        private void matricTxtBx_TextChanged(object sender, EventArgs e)
        {

        }

        private void startBtn_Click_1(object sender, EventArgs e)
        {
            if (nameTxtBx.Text == "" || matricTxtBx.Text == "")
            { MessageBox.Show("Please fill in all fields");
                return;

            }
        }
    }
}
