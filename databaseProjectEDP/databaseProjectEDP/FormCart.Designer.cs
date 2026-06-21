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
            totalAmountLbl = new Label();
            totalLbl = new Label();
            paymentBtn = new Button();
            clearBtn = new Button();
            selectLbl = new Label();
            selectedItemLbl = new Label();
            minusBtn = new Button();
            qtyTxtBx = new TextBox();
            deleteBtn = new Button();
            addBtn = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvCart).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // cartLbl
            // 
            cartLbl.AutoSize = true;
            cartLbl.Font = new Font("Microsoft YaHei UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cartLbl.ForeColor = Color.Indigo;
            cartLbl.Location = new Point(274, 42);
            cartLbl.Name = "cartLbl";
            cartLbl.Size = new Size(262, 52);
            cartLbl.TabIndex = 3;
            cartLbl.Text = "YOUR CART";
            cartLbl.TextAlign = ContentAlignment.TopCenter;
            // 
            // contShopBtn
            // 
            contShopBtn.BackColor = Color.DarkOrchid;
            contShopBtn.Font = new Font("Microsoft YaHei UI", 8F, FontStyle.Bold);
            contShopBtn.ForeColor = Color.White;
            contShopBtn.Location = new Point(75, 614);
            contShopBtn.Name = "contShopBtn";
            contShopBtn.Size = new Size(252, 57);
            contShopBtn.TabIndex = 4;
            contShopBtn.Text = "< CONTINUE SHOPPING";
            contShopBtn.UseVisualStyleBackColor = false;
            contShopBtn.Click += contShopBtn_Click;
            // 
            // dgvCart
            // 
            dgvCart.AllowUserToAddRows = false;
            dgvCart.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCart.BackgroundColor = Color.White;
            dgvCart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCart.Columns.AddRange(new DataGridViewColumn[] { Item, Price, Quantity, Total });
            dgvCart.GridColor = Color.Indigo;
            dgvCart.Location = new Point(75, 116);
            dgvCart.MultiSelect = false;
            dgvCart.Name = "dgvCart";
            dgvCart.ReadOnly = true;
            dgvCart.RowHeadersWidth = 62;
            dgvCart.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCart.Size = new Size(642, 230);
            dgvCart.TabIndex = 5;
            dgvCart.CellContentClick += dgvCart_CellContentClick;
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
            // totalAmountLbl
            // 
            totalAmountLbl.AutoSize = true;
            totalAmountLbl.Font = new Font("Microsoft YaHei UI", 11F, FontStyle.Bold);
            totalAmountLbl.ForeColor = Color.Indigo;
            totalAmountLbl.Location = new Point(297, 21);
            totalAmountLbl.Name = "totalAmountLbl";
            totalAmountLbl.Size = new Size(216, 30);
            totalAmountLbl.TabIndex = 6;
            totalAmountLbl.Text = "TOTAL AMOUNT: ";
            // 
            // totalLbl
            // 
            totalLbl.AutoSize = true;
            totalLbl.Font = new Font("Microsoft YaHei UI", 11F, FontStyle.Bold);
            totalLbl.ForeColor = Color.Indigo;
            totalLbl.Location = new Point(511, 21);
            totalLbl.Name = "totalLbl";
            totalLbl.Size = new Size(106, 30);
            totalLbl.TabIndex = 7;
            totalLbl.Text = "RM 0.00";
            totalLbl.Click += rmtotalLbl_Click;
            // 
            // paymentBtn
            // 
            paymentBtn.BackColor = Color.DarkOrchid;
            paymentBtn.Font = new Font("Microsoft YaHei UI", 8F, FontStyle.Bold);
            paymentBtn.ForeColor = Color.White;
            paymentBtn.Location = new Point(465, 614);
            paymentBtn.Name = "paymentBtn";
            paymentBtn.Size = new Size(252, 57);
            paymentBtn.TabIndex = 8;
            paymentBtn.Text = "PROCEED TO PAYMENT >";
            paymentBtn.UseVisualStyleBackColor = false;
            paymentBtn.Click += paymentBtn_Click;
            // 
            // clearBtn
            // 
            clearBtn.BackColor = Color.LightGray;
            clearBtn.Font = new Font("Microsoft YaHei UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clearBtn.ForeColor = Color.Gray;
            clearBtn.Location = new Point(22, 18);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(137, 41);
            clearBtn.TabIndex = 9;
            clearBtn.Text = "Clear Cart";
            clearBtn.UseVisualStyleBackColor = false;
            clearBtn.Click += clearBtn_Click;
            // 
            // selectLbl
            // 
            selectLbl.AutoSize = true;
            selectLbl.Font = new Font("Microsoft YaHei UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            selectLbl.Location = new Point(22, 19);
            selectLbl.Name = "selectLbl";
            selectLbl.Size = new Size(125, 22);
            selectLbl.TabIndex = 10;
            selectLbl.Text = "Selected Item:";
            // 
            // selectedItemLbl
            // 
            selectedItemLbl.AutoSize = true;
            selectedItemLbl.Font = new Font("Microsoft YaHei UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            selectedItemLbl.ForeColor = Color.Green;
            selectedItemLbl.Location = new Point(170, 19);
            selectedItemLbl.Name = "selectedItemLbl";
            selectedItemLbl.Size = new Size(17, 22);
            selectedItemLbl.TabIndex = 11;
            selectedItemLbl.Text = "-";
            selectedItemLbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // minusBtn
            // 
            minusBtn.BackColor = Color.White;
            minusBtn.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            minusBtn.Location = new Point(39, 53);
            minusBtn.Name = "minusBtn";
            minusBtn.Size = new Size(56, 46);
            minusBtn.TabIndex = 12;
            minusBtn.Text = "-";
            minusBtn.UseVisualStyleBackColor = false;
            minusBtn.Click += minusBtn_Click;
            // 
            // qtyTxtBx
            // 
            qtyTxtBx.BackColor = Color.White;
            qtyTxtBx.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            qtyTxtBx.Location = new Point(124, 58);
            qtyTxtBx.Name = "qtyTxtBx";
            qtyTxtBx.ReadOnly = true;
            qtyTxtBx.Size = new Size(85, 38);
            qtyTxtBx.TabIndex = 14;
            qtyTxtBx.Text = "0";
            qtyTxtBx.TextAlign = HorizontalAlignment.Center;
            // 
            // deleteBtn
            // 
            deleteBtn.BackColor = Color.MistyRose;
            deleteBtn.Font = new Font("Microsoft YaHei UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deleteBtn.ForeColor = Color.Red;
            deleteBtn.Location = new Point(470, 53);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(147, 46);
            deleteBtn.TabIndex = 15;
            deleteBtn.Text = "Delete Item";
            deleteBtn.UseVisualStyleBackColor = false;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // addBtn
            // 
            addBtn.BackColor = Color.White;
            addBtn.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addBtn.Location = new Point(238, 53);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(56, 46);
            addBtn.TabIndex = 16;
            addBtn.Text = "+";
            addBtn.UseVisualStyleBackColor = false;
            addBtn.Click += addBtn_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Honeydew;
            panel1.Controls.Add(addBtn);
            panel1.Controls.Add(deleteBtn);
            panel1.Controls.Add(qtyTxtBx);
            panel1.Controls.Add(minusBtn);
            panel1.Controls.Add(selectedItemLbl);
            panel1.Controls.Add(selectLbl);
            panel1.Location = new Point(75, 367);
            panel1.Name = "panel1";
            panel1.Size = new Size(642, 126);
            panel1.TabIndex = 17;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Lavender;
            panel2.Controls.Add(clearBtn);
            panel2.Controls.Add(totalLbl);
            panel2.Controls.Add(totalAmountLbl);
            panel2.Location = new Point(75, 516);
            panel2.Name = "panel2";
            panel2.Size = new Size(642, 76);
            panel2.TabIndex = 18;
            // 
            // FormCart
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(800, 718);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(paymentBtn);
            Controls.Add(dgvCart);
            Controls.Add(contShopBtn);
            Controls.Add(cartLbl);
            Name = "FormCart";
            Text = "FormCart";
            Load += FormCart_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCart).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label cartLbl;
        private Button contShopBtn;
        private DataGridView dgvCart;
        private Label totalAmountLbl;
        private Label totalLbl;
        private Button paymentBtn;
        private Button clearBtn;
        private DataGridViewTextBoxColumn Item;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Total;
        private Label selectLbl;
        private Label selectedItemLbl;
        private Button minusBtn;
        private TextBox qtyTxtBx;
        private Button deleteBtn;
        private Button addBtn;
        private Panel panel1;
        private Panel panel2;
    }
}