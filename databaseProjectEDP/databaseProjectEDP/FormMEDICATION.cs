using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace databaseProjectEDP
{
    public partial class FormMEDICATION : Form
    {
        public FormMEDICATION()
        {
            InitializeComponent();
        }

        private void picBoxHome_Click(object sender, EventArgs e)
        {
            FormCategory frm = new FormCategory();
            frm.Show();
            this.Hide();
        }

        private void btnAdd5_Click(object sender, EventArgs e)
        {

        }
    }
}
