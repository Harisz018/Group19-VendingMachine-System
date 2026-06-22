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
    public partial class FormFOOD : Form
    {
        public FormFOOD()
        {
            InitializeComponent();
        }

        private void picBoxHome_Click(object sender, EventArgs e)
        {
            UserLoginForm login = new UserLoginForm();
            login.Show();
            this.Hide();
        }

        private void buttonAdd1_Click(object sender, EventArgs e)
        {
            Cart.AddItem("Mineral Water", 2.00m);
            MessageBox.Show("Mineral Water added to cart!");
        }

        private void btnAdd2_Click(object sender, EventArgs e)
        {
            Cart.AddItem("Milo", 3.00m);
            MessageBox.Show("Milo added to cart!");
        }

        private void btnAdd3_Click(object sender, EventArgs e)
        {
            Cart.AddItem("Nescafe", 4.50m);
            MessageBox.Show("Nescafe added to cart!");
        }

        private void btnAdd4_Click(object sender, EventArgs e)
        {
            Cart.AddItem("100PLUS", 4.00m);
            MessageBox.Show("100PLUS added to cart!");
        }

        private void btnAdd5_Click(object sender, EventArgs e)
        {
            Cart.AddItem("Gardenia Chocolate", 1.00m);
            MessageBox.Show("Gardenia Chocolate added to cart!");

        }

        private void btnAdd6_Click(object sender, EventArgs e)
        {
            Cart.AddItem("Choco Bar", 3.50m);
            MessageBox.Show("Choco Bar added to cart!");
        }

        private void btnAdd7_Click(object sender, EventArgs e)
        {
            Cart.AddItem("Potato Chips", 3.00m);
            MessageBox.Show("Potato Chips added to cart!");
        }

        private void btnAdd8_Click(object sender, EventArgs e)
        {
            Cart.AddItem("Tiger Original", 2.00m);
            MessageBox.Show("Tiger Original added to cart!");
        }

        private void pxBoxCart_Click(object sender, EventArgs e)
        {
            FormCart frm = new FormCart();
            frm.Show();
            this.Hide();
        }

        private void btnFood_Click(object sender, EventArgs e)
        {
            FormFOOD food = new FormFOOD();
            food.Show();
            this.Hide();
        }

        private void btnBeauty_Click(object sender, EventArgs e)
        {
            FormBEAUTY beauty = new FormBEAUTY();
            beauty.Show();
            this.Hide();
        }

        private void btnMedications_Click(object sender, EventArgs e)
        {

            FormMEDICATION medication = new FormMEDICATION();
            medication.Show();
            this.Hide();
        }

        private void btnToys_Click(object sender, EventArgs e)
        {
            FormTOYS toys = new FormTOYS();
            toys.Show();
            this.Hide();
        }

        private void btnEssentials_Click(object sender, EventArgs e)
        {

            FormESSENTIALS essentials = new FormESSENTIALS();
            essentials.Show();
            this.Hide();
        }
    }



}
