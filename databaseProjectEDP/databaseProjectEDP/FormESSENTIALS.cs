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
    public partial class FormESSENTIALS : Form
    {
        public FormESSENTIALS()
        {
            InitializeComponent();
        }

        private void picBoxHome_Click(object sender, EventArgs e)
        {
            FormCategory frm = new FormCategory();
            frm.Show();
            this.Hide();
        }

        private void FormESSENTIALS_Load(object sender, EventArgs e)
        {

        }

        private void picBoxHome_Click_1(object sender, EventArgs e)
        {

            UserLoginForm login = new UserLoginForm();
            login.Show();
            this.Hide();
        }

        private void pxBoxCart_Click(object sender, EventArgs e)
        {
            FormCart cart = new FormCart();
            cart.Show();
            this.Hide();
        }

        private void buttonAdd1_Click(object sender, EventArgs e)
        {
            Cart.AddItem("Tissue Box", 3.00m);
            MessageBox.Show("Tissue Box added to cart!");
        }

        private void btnAdd2_Click(object sender, EventArgs e)
        {
            Cart.AddItem("Bath Soap", 4.00m);
            MessageBox.Show("Bath Soap added to cart!");
        }

        private void btnAdd3_Click(object sender, EventArgs e)
        {
            Cart.AddItem("Toothpaste", 4.50m);
            MessageBox.Show("Toothpaste added to cart!");
        }

        private void btnAdd4_Click(object sender, EventArgs e)
        {
            Cart.AddItem("Shampoo", 7.00m);
            MessageBox.Show("Shampoo added to cart!");
        }

        private void btnAdd5_Click(object sender, EventArgs e)
        {
            Cart.AddItem("Sanitary Pad", 4.00m);
            MessageBox.Show("Sanitary Pad added to cart!");
        }

        private void btnAdd6_Click(object sender, EventArgs e)
        {
            Cart.AddItem("DishWash", 7.00m);
            MessageBox.Show("DishWash added to cart!");
        }

        private void btnAdd7_Click(object sender, EventArgs e)
        {
            Cart.AddItem("Plaster", 5.00m);
            MessageBox.Show("Plaster added to cart!");
        }

        private void btnAdd8_Click(object sender, EventArgs e)
        {
            Cart.AddItem("Pen", 2.00m);
            MessageBox.Show("Pen added to cart!");
        }
    }
}
