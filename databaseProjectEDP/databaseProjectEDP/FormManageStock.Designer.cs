namespace databaseProjectEDP
{
    partial class FormManageStock
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
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
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            btnClear = new Button();
            btnUpdateStock = new Button();
            txtQuantity = new TextBox();
            label6 = new Label();
            label5 = new Label();
            cmbCurrentStock = new ComboBox();
            cmbProductName = new ComboBox();
            label4 = new Label();
            cmbProductID = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
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
            panel1.TabIndex = 1;
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
            label1.Size = new Size(176, 23);
            label1.TabIndex = 2;
            label1.Text = "MANAGE STOCK";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(257, 87);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(293, 348);
            dataGridView1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnClear);
            panel2.Controls.Add(btnUpdateStock);
            panel2.Controls.Add(txtQuantity);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(cmbCurrentStock);
            panel2.Controls.Add(cmbProductName);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(cmbProductID);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(556, 87);
            panel2.Name = "panel2";
            panel2.Size = new Size(232, 351);
            panel2.TabIndex = 4;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Arial Rounded MT Bold", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.DarkViolet;
            btnClear.Location = new Point(15, 313);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(194, 35);
            btnClear.TabIndex = 10;
            btnClear.Text = "CLEAR";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnUpdateStock
            // 
            btnUpdateStock.BackColor = Color.DarkViolet;
            btnUpdateStock.Font = new Font("Arial Rounded MT Bold", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdateStock.ForeColor = Color.White;
            btnUpdateStock.Location = new Point(15, 269);
            btnUpdateStock.Name = "btnUpdateStock";
            btnUpdateStock.Size = new Size(194, 44);
            btnUpdateStock.TabIndex = 9;
            btnUpdateStock.Text = "ADD / UPDATE STOCK";
            btnUpdateStock.UseVisualStyleBackColor = false;
            btnUpdateStock.Click += btnUpdateStock_Click;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(15, 236);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(194, 27);
            txtQuantity.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(13, 218);
            label6.Name = "label6";
            label6.Size = new Size(122, 15);
            label6.TabIndex = 7;
            label6.Text = "Add / Set Quantity";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(15, 159);
            label5.Name = "label5";
            label5.Size = new Size(98, 15);
            label5.TabIndex = 6;
            label5.Text = "Current Stock";
            // 
            // cmbCurrentStock
            // 
            cmbCurrentStock.FormattingEnabled = true;
            cmbCurrentStock.Location = new Point(15, 177);
            cmbCurrentStock.Name = "cmbCurrentStock";
            cmbCurrentStock.Size = new Size(194, 28);
            cmbCurrentStock.TabIndex = 5;
            // 
            // cmbProductName
            // 
            cmbProductName.FormattingEnabled = true;
            cmbProductName.Location = new Point(15, 117);
            cmbProductName.Name = "cmbProductName";
            cmbProductName.Size = new Size(194, 28);
            cmbProductName.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(13, 99);
            label4.Name = "label4";
            label4.Size = new Size(100, 15);
            label4.TabIndex = 3;
            label4.Text = "Product Name";
            // 
            // cmbProductID
            // 
            cmbProductID.FormattingEnabled = true;
            cmbProductID.Location = new Point(15, 57);
            cmbProductID.Name = "cmbProductID";
            cmbProductID.Size = new Size(194, 28);
            cmbProductID.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(15, 39);
            label3.Name = "label3";
            label3.Size = new Size(76, 15);
            label3.TabIndex = 1;
            label3.Text = "Product ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(15, 11);
            label2.Name = "label2";
            label2.Size = new Size(127, 17);
            label2.TabIndex = 0;
            label2.Text = "UPDATE STOCK";
            // 
            // FormManageStock
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "FormManageStock";
            Text = "Form1";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
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
        private DataGridView dataGridView1;
        private Panel panel2;
        private Label label2;
        private Button btnClear;
        private Button btnUpdateStock;
        private TextBox txtQuantity;
        private Label label6;
        private Label label5;
        private ComboBox cmbCurrentStock;
        private ComboBox cmbProductName;
        private Label label4;
        private ComboBox cmbProductID;
        private Label label3;
    }
}
