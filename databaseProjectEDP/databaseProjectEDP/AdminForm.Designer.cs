namespace databaseProjectEDP
{
    partial class AdminForm
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
            dgvProducts = new DataGridView();
            txtProductName = new TextBox();
            txtPrice = new TextBox();
            txtStock = new TextBox();
            lblProductName = new Label();
            lblPrice = new Label();
            lblStock = new Label();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // dgvProducts
            // 
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(12, 55);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.Size = new Size(300, 188);
            dgvProducts.TabIndex = 0;
            dgvProducts.CellContentClick += dataGridView1_CellContentClick;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(329, 78);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(125, 27);
            txtProductName.TabIndex = 1;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(329, 141);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(125, 27);
            txtPrice.TabIndex = 2;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(329, 216);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(125, 27);
            txtStock.TabIndex = 3;
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Location = new Point(329, 55);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(104, 20);
            lblProductName.TabIndex = 4;
            lblProductName.Text = "Product Name";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(329, 118);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(80, 20);
            lblPrice.TabIndex = 5;
            lblPrice.Text = "Price (RM):";
            lblPrice.Click += label1_Click;
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Location = new Point(329, 193);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(107, 20);
            lblStock.TabIndex = 6;
            lblStock.Text = "Quantity/Stock";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(12, 352);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(111, 29);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Add product";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(129, 352);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(111, 29);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "Save Changes";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(246, 352);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(126, 29);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Remove Product";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(378, 352);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(107, 29);
            btnClear.TabIndex = 10;
            btnClear.Text = "Clear Fields";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(lblStock);
            Controls.Add(lblPrice);
            Controls.Add(lblProductName);
            Controls.Add(txtStock);
            Controls.Add(txtPrice);
            Controls.Add(txtProductName);
            Controls.Add(dgvProducts);
            Name = "AdminForm";
            Text = "AdminForm";
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvProducts;
        private TextBox txtProductName;
        private TextBox txtPrice;
        private TextBox txtStock;
        private Label lblProductName;
        private Label lblPrice;
        private Label lblStock;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
    }
}