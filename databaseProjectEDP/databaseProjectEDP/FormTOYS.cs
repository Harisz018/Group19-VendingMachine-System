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
    public partial class FormTOYS : Form
    {
        public FormTOYS()
        {
            InitializeComponent();
        }

        private void picBoxHome_Click(object sender, EventArgs e)
        {
            FormCategory frm = new FormCategory();
            frm.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
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

        }

        private void btnEssential_Click(object sender, EventArgs e)
        {
            FormESSENTIALS essentials = new FormESSENTIALS();
            essentials.Show();
            this.Hide();
        }

        private void buttonAdd1_Click(object sender, EventArgs e)
        {

            Cart.AddItem("Teddy Bear", 5.00m);
            MessageBox.Show("Teddy Bear added to cart!");
        }

        private void btnAdd2_Click(object sender, EventArgs e)
        {
            Cart.AddItem("UNO Cards", 7.00m);
            MessageBox.Show("UNO Cards added to cart!");
        }

        private void btnAdd3_Click(object sender, EventArgs e)
        {
            Cart.AddItem("Blind Box", 10.00m);
            MessageBox.Show("Blind Box added to cart!");
        }

        private void btnAdd4_Click(object sender, EventArgs e)
        {
            Cart.AddItem("Block Tower", 7.00m);
            MessageBox.Show("Block Tower added to cart!");
        }

        private void btnAdd5_Click(object sender, EventArgs e)
        {
            Cart.AddItem("Barbie Doll", 18.00m);
            MessageBox.Show("Barbie Doll added to cart!");
        }

        private void btnAdd6_Click(object sender, EventArgs e)
        {

            Cart.AddItem("Control Car", 10.50m);
            MessageBox.Show("Control Car added to cart!");
        }

        private void btnAdd7_Click(object sender, EventArgs e)
        {
            Cart.AddItem("Puzzle Set", 10.00m);
            MessageBox.Show("Puzzle Set added to cart!");
        }

        private void btnAdd8_Click(object sender, EventArgs e)
        {
            Cart.AddItem("Monopoly Card", 8.00m);
            MessageBox.Show("Monopoly Card added to cart!");
        }
    }
}
