namespace databaseProjectEDP
{
    public partial class FormManageStock : Form
    {
        public FormManageStock()
        {
            InitializeComponent();
        }

        private void btnUpdateStock_Click(object sender, EventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            FormAdminDashboard dashboard = new FormAdminDashboard();
            dashboard.Show();
            this.Hide();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            FormManageProducts products = new FormManageProducts();
            products.Show();
            this.Hide();
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            FormManageStock stock = new FormManageStock();
            stock.Show();
            this.Hide();
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            FormViewSales sales = new FormViewSales();
            sales.Show();
            this.Hide();
        }
    }
}
