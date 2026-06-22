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
            Cart.AddItem("Minyak Cap Kapak", 2.00m);
            MessageBox.Show("Minyak Cap Kapak added to cart!");
        }

        private void pictureBox8_Click(object sender, EventArgs e)
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

        }

        private void btnToys_Click(object sender, EventArgs e)
        {
            FormTOYS toys = new FormTOYS();
            toys.Show();
            this.Hide();
        }

        private void btnEssential_Click(object sender, EventArgs e)
        {
            FormESSENTIALS essentials = new FormESSENTIALS();
            essentials.Show();
            this.Hide();
        }

        private void buttonAdd1_Click(object sender, EventArgs e)
        {
            Cart.AddItem("Panadol", 5.00m);
            MessageBox.Show("Panadol added to cart!");
        }

        private void btnAdd2_Click(object sender, EventArgs e)
        {
            Cart.AddItem("Strepsils", 3.50m);
            MessageBox.Show("Strepsils added to cart!");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd3_Click(object sender, EventArgs e)
        {
            Cart.AddItem("Kool Fever", 4.50m);
            MessageBox.Show("Kool Fever added to cart!");
        }

        private void btnAdd4_Click(object sender, EventArgs e)
        {
            Cart.AddItem("Gaviscon", 7.00m);
            MessageBox.Show("Gaviscon added to cart!");
        }

        private void btnAdd6_Click(object sender, EventArgs e)
        {
            Cart.AddItem("Cream Antiseptic", 10.50m);
            MessageBox.Show("Cream Antiseptic added to cart!");
        }

        private void btnAdd7_Click(object sender, EventArgs e)
        {
            Cart.AddItem("Panadol Pink", 10.00m);
            MessageBox.Show("Panadol Pink added to cart!");
        }

        private void btnAdd8_Click(object sender, EventArgs e)
        {
            Cart.AddItem("EyeMo", 8.00m);
            MessageBox.Show("EyeMo added to cart!");
        }
    }
}
