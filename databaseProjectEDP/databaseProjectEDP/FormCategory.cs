using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace databaseProjectEDP
{
    public partial class FormCategory : Form
    {
        public FormCategory()
        {
            InitializeComponent();
        }

        private void pictureBoxToys_Click(object sender, EventArgs e)
        {
            FormTOYS frm = new FormTOYS();
            frm.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnFoodDrink_Click(object sender, EventArgs e)
        {
            FormFOOD frm = new FormFOOD();
            frm.Show();
            this.Hide();
        }

        private void pictureBoxFood_Click(object sender, EventArgs e)
        {
            FormFOOD frm = new FormFOOD();
            frm.Show();
            this.Hide();
        }

        private void pictureBoxBeauty_Click(object sender, EventArgs e)
        {
            FormBEAUTY frm = new FormBEAUTY();
            frm.Show();
            this.Hide();
        }

        private void pictureBoxMedication_Click(object sender, EventArgs e)
        {
            FormMEDICATION frm = new FormMEDICATION();
            frm.Show();
            this.Hide();
        }

        private void pictureBoxEssential_Click(object sender, EventArgs e)
        {
            FormESSENTIALS frm = new FormESSENTIALS();
            frm.Show();
            this.Hide();
        }
    }
}
