namespace databaseProjectEDP
{
    partial class FormCart
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
            cartLbl = new Label();
            contShopBtn = new Button();
            dgvCart = new DataGridView();
            Item = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            totalLbl = new Label();
            rmtotalLbl = new Label();
            paymentBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCart).BeginInit();
            SuspendLayout();
            // 
            // cartLbl
            // 
            cartLbl.AutoSize = true;
            cartLbl.Font = new Font("Microsoft YaHei UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cartLbl.ForeColor = Color.Indigo;
            cartLbl.Location = new Point(274, 23);
            cartLbl.Name = "cartLbl";
            cartLbl.Size = new Size(262, 52);
            cartLbl.TabIndex = 3;
            cartLbl.Text = "YOUR CART";
            cartLbl.TextAlign = ContentAlignment.TopCenter;
            cartLbl.Click += cartLbl_Click;
            // 
            // contShopBtn
            // 
            contShopBtn.BackColor = Color.Purple;
            contShopBtn.Font = new Font("Microsoft YaHei UI", 8F, FontStyle.Bold);
            contShopBtn.ForeColor = Color.White;
            contShopBtn.Location = new Point(79, 400);
            contShopBtn.Name = "contShopBtn";
            contShopBtn.Size = new Size(252, 57);
            contShopBtn.TabIndex = 4;
            contShopBtn.Text = "< CONTINUE SHOPPING";
            contShopBtn.UseVisualStyleBackColor = false;
            // 
            // dgvCart
            // 
            dgvCart.AllowUserToAddRows = false;
            dgvCart.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCart.BackgroundColor = Color.Plum;
            dgvCart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCart.Columns.AddRange(new DataGridViewColumn[] { Item, Price, Quantity, Total });
            dgvCart.GridColor = Color.Indigo;
            dgvCart.Location = new Point(79, 99);
            dgvCart.Name = "dgvCart";
            dgvCart.ReadOnly = true;
            dgvCart.RowHeadersWidth = 62;
            dgvCart.Size = new Size(642, 230);
            dgvCart.TabIndex = 5;
            dgvCart.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Item
            // 
            Item.HeaderText = "Item";
            Item.MinimumWidth = 8;
            Item.Name = "Item";
            Item.ReadOnly = true;
            // 
            // Price
            // 
            Price.HeaderText = "Price";
            Price.MinimumWidth = 8;
            Price.Name = "Price";
            Price.ReadOnly = true;
            // 
            // Quantity
            // 
            Quantity.HeaderText = "Quantity";
            Quantity.MinimumWidth = 8;
            Quantity.Name = "Quantity";
            Quantity.ReadOnly = true;
            // 
            // Total
            // 
            Total.HeaderText = "Total";
            Total.MinimumWidth = 8;
            Total.Name = "Total";
            Total.ReadOnly = true;
            // 
            // totalLbl
            // 
            totalLbl.AutoSize = true;
            totalLbl.Font = new Font("Microsoft YaHei UI", 11F, FontStyle.Bold);
            totalLbl.ForeColor = Color.Indigo;
            totalLbl.Location = new Point(397, 348);
            totalLbl.Name = "totalLbl";
            totalLbl.Size = new Size(193, 30);
            totalLbl.TabIndex = 6;
            totalLbl.Text = "GRAND TOTAL: ";
            totalLbl.Click += totalLbl_Click;
            // 
            // rmtotalLbl
            // 
            rmtotalLbl.AutoSize = true;
            rmtotalLbl.Font = new Font("Microsoft YaHei UI", 11F, FontStyle.Bold);
            rmtotalLbl.ForeColor = Color.Indigo;
            rmtotalLbl.Location = new Point(611, 348);
            rmtotalLbl.Name = "rmtotalLbl";
            rmtotalLbl.Size = new Size(106, 30);
            rmtotalLbl.TabIndex = 7;
            rmtotalLbl.Text = "RM 0.00";
            rmtotalLbl.Click += rmtotalLbl_Click;
            // 
            // paymentBtn
            // 
            paymentBtn.BackColor = Color.Purple;
            paymentBtn.Font = new Font("Microsoft YaHei UI", 8F, FontStyle.Bold);
            paymentBtn.ForeColor = Color.White;
            paymentBtn.Location = new Point(469, 400);
            paymentBtn.Name = "paymentBtn";
            paymentBtn.Size = new Size(252, 57);
            paymentBtn.TabIndex = 8;
            paymentBtn.Text = "PROCEED TO PAYMENT >";
            paymentBtn.UseVisualStyleBackColor = false;
            // 
            // FormCart
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(800, 485);
            Controls.Add(paymentBtn);
            Controls.Add(rmtotalLbl);
            Controls.Add(totalLbl);
            Controls.Add(dgvCart);
            Controls.Add(contShopBtn);
            Controls.Add(cartLbl);
            Name = "FormCart";
            Text = "FormCart";
            Load += FormCart_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCart).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label cartLbl;
        private Button contShopBtn;
        private DataGridView dgvCart;
        private DataGridViewTextBoxColumn Item;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Total;
        private Label totalLbl;
        private Label rmtotalLbl;
        private Button paymentBtn;
    }
}