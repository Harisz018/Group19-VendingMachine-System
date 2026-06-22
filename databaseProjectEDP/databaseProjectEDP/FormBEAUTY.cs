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
    public partial class FormBEAUTY : Form
    {
        public FormBEAUTY()
        {
            InitializeComponent();
        }

        private void picBoxHome_Click(object sender, EventArgs e)
        {
            FormCategory frm = new FormCategory();
            frm.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void FormBEAUTY_Load(object sender, EventArgs e)
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

        private void btnEssential_Click(object sender, EventArgs e)
        {
            FormESSENTIALS essentials = new FormESSENTIALS();
            essentials.Show();
            this.Hide();
        }

        private void buttonAdd1_Click(object sender, EventArgs e)
        {
            Cart.AddItem("Lip Balm", 5.00m);
            MessageBox.Show("Lip Balm added to cart!");
        }

        private void btnAdd2_Click(object sender, EventArgs e)
        {
            Cart.AddItem("Face Wash", 8.00m);
            MessageBox.Show("Face Wash added to cart!");
        }

        private void btnAdd3_Click(object sender, EventArgs e)
        {
            Cart.AddItem("Sunscreen", 4.50m);
            MessageBox.Show("Sunscreen added to cart!");
        }

        private void btnAdd4_Click(object sender, EventArgs e)
        {
            Cart.AddItem("Hand Cream", 7.00m);
            MessageBox.Show("Hand Cream added to cart!");
        }

        private void btnAdd5_Click(object sender, EventArgs e)
        {
            Cart.AddItem("Wet Tissue", 2.00m);
            MessageBox.Show("Wet Tissue added to cart!");
        }

        private void btnAdd6_Click(object sender, EventArgs e)
        {
            Cart.AddItem("Perfume", 10.50m);
            MessageBox.Show("Perfume added to cart!");
        }

        private void btnAdd7_Click(object sender, EventArgs e)
        {
            Cart.AddItem("Compact Powder", 17.00m);
            MessageBox.Show("Compact Powder added to cart!");
        }

        private void btnAdd8_Click(object sender, EventArgs e)
        {
            Cart.AddItem("Hair Tie", 2.00m);
            MessageBox.Show("Hair Tie added to cart!");
        }
    }
}
