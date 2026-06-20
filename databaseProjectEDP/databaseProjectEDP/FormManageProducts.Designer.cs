namespace databaseProjectEDP
{
    partial class FormManageProducts
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnLogout = new Button();
            btnProducts = new Button();
            btnSales = new Button();
            btnDashboard = new Button();
            btnStock = new Button();
            label1 = new Label();
            btnNewProduct = new Button();
            dgvProducts = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtProductID = new TextBox();
            txtProductName = new TextBox();
            txtPrice = new TextBox();
            cmbCategory = new ComboBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateBlue;
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(btnProducts);
            panel1.Controls.Add(btnSales);
            panel1.Controls.Add(btnDashboard);
            panel1.Controls.Add(btnStock);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(228, 450);
            panel1.TabIndex = 0;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(38, 317);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(149, 29);
            btnLogout.TabIndex = 9;
            btnLogout.Text = "Log out";
            btnLogout.UseVisualStyleBackColor = true;
            // 
            // btnProducts
            // 
            btnProducts.Location = new Point(38, 136);
            btnProducts.Name = "btnProducts";
            btnProducts.Size = new Size(149, 29);
            btnProducts.TabIndex = 6;
            btnProducts.Text = "Manage Products";
            btnProducts.UseVisualStyleBackColor = true;
            btnProducts.Click += btnProducts_Click;
            // 
            // btnSales
            // 
            btnSales.Location = new Point(38, 259);
            btnSales.Name = "btnSales";
            btnSales.Size = new Size(149, 29);
            btnSales.TabIndex = 8;
            btnSales.Text = "View Sales";
            btnSales.UseVisualStyleBackColor = true;
            btnSales.Click += btnSales_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.Location = new Point(38, 78);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(149, 29);
            btnDashboard.TabIndex = 5;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // btnStock
            // 
            btnStock.Location = new Point(38, 197);
            btnStock.Name = "btnStock";
            btnStock.Size = new Size(149, 29);
            btnStock.TabIndex = 7;
            btnStock.Text = "Manage Stock";
            btnStock.UseVisualStyleBackColor = true;
            btnStock.Click += btnStock_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(265, 47);
            label1.Name = "label1";
            label1.Size = new Size(218, 23);
            label1.TabIndex = 10;
            label1.Text = "MANAGE PRODUCTS";
            // 
            // btnNewProduct
            // 
            btnNewProduct.BackColor = Color.DarkViolet;
            btnNewProduct.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNewProduct.ForeColor = Color.White;
            btnNewProduct.Location = new Point(589, 31);
            btnNewProduct.Name = "btnNewProduct";
            btnNewProduct.Size = new Size(199, 39);
            btnNewProduct.TabIndex = 11;
            btnNewProduct.Text = "+ ADD NEW PRODUCT";
            btnNewProduct.UseVisualStyleBackColor = false;
            // 
            // dgvProducts
            // 
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(265, 95);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.RowHeadersVisible = false;
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Size = new Size(523, 193);
            dgvProducts.TabIndex = 12;
            dgvProducts.CellContentClick += dgvProducts_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(265, 307);
            label2.Name = "label2";
            label2.Size = new Size(86, 17);
            label2.TabIndex = 13;
            label2.Text = "Product ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(265, 340);
            label3.Name = "label3";
            label3.Size = new Size(112, 17);
            label3.TabIndex = 14;
            label3.Text = "Product Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(265, 373);
            label4.Name = "label4";
            label4.Size = new Size(75, 17);
            label4.TabIndex = 15;
            label4.Text = "Category";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(265, 408);
            label5.Name = "label5";
            label5.Size = new Size(80, 17);
            label5.TabIndex = 16;
            label5.Text = "Price(RM)";
            // 
            // txtProductID
            // 
            txtProductID.Location = new Point(407, 302);
            txtProductID.Name = "txtProductID";
            txtProductID.PlaceholderText = "e.g P001";
            txtProductID.Size = new Size(193, 27);
            txtProductID.TabIndex = 17;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(407, 335);
            txtProductName.Name = "txtProductName";
            txtProductName.PlaceholderText = "Enter Product Name";
            txtProductName.Size = new Size(193, 27);
            txtProductName.TabIndex = 18;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(407, 403);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(193, 27);
            txtPrice.TabIndex = 20;
            // 
            // cmbCategory
            // 
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(407, 368);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(193, 28);
            cmbCategory.TabIndex = 21;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.DarkViolet;
            btnAdd.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(642, 302);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(135, 39);
            btnAdd.TabIndex = 22;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.DarkViolet;
            btnUpdate.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(642, 351);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(135, 39);
            btnUpdate.TabIndex = 23;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.DarkViolet;
            btnDelete.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(642, 397);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(135, 39);
            btnDelete.TabIndex = 24;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // FormManageProducts
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(cmbCategory);
            Controls.Add(txtPrice);
            Controls.Add(txtProductName);
            Controls.Add(txtProductID);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dgvProducts);
            Controls.Add(btnNewProduct);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "FormManageProducts";
            Text = "FormManageProducts";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnLogout;
        private Button btnProducts;
        private Button btnSales;
        private Button btnDashboard;
        private Button btnStock;
        private Label label1;
        private Button btnNewProduct;
        private DataGridView dgvProducts;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtProductID;
        private TextBox txtProductName;
        private TextBox txtPrice;
        private ComboBox cmbCategory;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
    }
}