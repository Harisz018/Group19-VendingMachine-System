namespace databaseProjectEDP
{
    partial class FormAdminDashboard
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
            pnlSidebar = new Panel();
            btnLogout = new Button();
            btnSales = new Button();
            btnStock = new Button();
            btnProducts = new Button();
            btnDashboard = new Button();
            pnlMain = new Panel();
            panel1 = new Panel();
            panel7 = new Panel();
            label12 = new Label();
            panel6 = new Panel();
            label11 = new Label();
            label7 = new Label();
            panel5 = new Panel();
            label10 = new Label();
            label6 = new Label();
            panel4 = new Panel();
            label9 = new Label();
            label4 = new Label();
            panel3 = new Panel();
            label8 = new Label();
            label3 = new Label();
            panel2 = new Panel();
            label2 = new Label();
            label1 = new Label();
            pnlSidebar.SuspendLayout();
            pnlMain.SuspendLayout();
            panel1.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.DarkSlateBlue;
            pnlSidebar.Controls.Add(btnLogout);
            pnlSidebar.Controls.Add(btnSales);
            pnlSidebar.Controls.Add(btnStock);
            pnlSidebar.Controls.Add(btnProducts);
            pnlSidebar.Controls.Add(btnDashboard);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(228, 450);
            pnlSidebar.TabIndex = 0;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(39, 319);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(149, 29);
            btnLogout.TabIndex = 4;
            btnLogout.Text = "Log out";
            btnLogout.UseVisualStyleBackColor = true;
            // 
            // btnSales
            // 
            btnSales.Location = new Point(39, 261);
            btnSales.Name = "btnSales";
            btnSales.Size = new Size(149, 29);
            btnSales.TabIndex = 3;
            btnSales.Text = "View Sales";
            btnSales.UseVisualStyleBackColor = true;
            btnSales.Click += btnSales_Click;
            // 
            // btnStock
            // 
            btnStock.Location = new Point(39, 199);
            btnStock.Name = "btnStock";
            btnStock.Size = new Size(149, 29);
            btnStock.TabIndex = 2;
            btnStock.Text = "Manage Stock";
            btnStock.UseVisualStyleBackColor = true;
            btnStock.Click += btnStock_Click;
            // 
            // btnProducts
            // 
            btnProducts.Location = new Point(39, 138);
            btnProducts.Name = "btnProducts";
            btnProducts.Size = new Size(149, 29);
            btnProducts.TabIndex = 1;
            btnProducts.Text = "Manage Products";
            btnProducts.UseVisualStyleBackColor = true;
            btnProducts.Click += btnProducts_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.Location = new Point(39, 80);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(149, 29);
            btnDashboard.TabIndex = 0;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // pnlMain
            // 
            pnlMain.BackColor = Color.FromArgb(244, 246, 249);
            pnlMain.Controls.Add(panel1);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(228, 0);
            pnlMain.Name = "pnlMain";
            pnlMain.Padding = new Padding(10);
            pnlMain.Size = new Size(572, 450);
            pnlMain.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel7);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(10, 10);
            panel1.Name = "panel1";
            panel1.Size = new Size(552, 430);
            panel1.TabIndex = 0;
            // 
            // panel7
            // 
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Controls.Add(label12);
            panel7.Location = new Point(14, 234);
            panel7.Name = "panel7";
            panel7.Size = new Size(522, 194);
            panel7.TabIndex = 7;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Arial Rounded MT Bold", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(13, 13);
            label12.Name = "label12";
            label12.Size = new Size(138, 15);
            label12.TabIndex = 0;
            label12.Text = "SALES (THIS WEEK)";
            // 
            // panel6
            // 
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(label11);
            panel6.Controls.Add(label7);
            panel6.Location = new Point(431, 91);
            panel6.Name = "panel6";
            panel6.Size = new Size(105, 125);
            panel6.TabIndex = 5;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(46, 74);
            label11.Name = "label11";
            label11.Size = new Size(17, 20);
            label11.TabIndex = 8;
            label11.Text = "1";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Rounded MT Bold", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(6, 16);
            label7.Name = "label7";
            label7.Size = new Size(94, 15);
            label7.TabIndex = 7;
            label7.Text = "CATEGORIES";
            label7.Click += label7_Click;
            // 
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(label10);
            panel5.Controls.Add(label6);
            panel5.Location = new Point(307, 91);
            panel5.Name = "panel5";
            panel5.Size = new Size(118, 125);
            panel5.TabIndex = 4;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(53, 74);
            label10.Name = "label10";
            label10.Size = new Size(17, 20);
            label10.TabIndex = 8;
            label10.Text = "1";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(3, 16);
            label6.Name = "label6";
            label6.Size = new Size(111, 15);
            label6.TabIndex = 7;
            label6.Text = "TODAY'S SALES";
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(label9);
            panel4.Controls.Add(label4);
            panel4.Location = new Point(161, 91);
            panel4.Name = "panel4";
            panel4.Size = new Size(140, 125);
            panel4.TabIndex = 3;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(61, 74);
            label9.Name = "label9";
            label9.Size = new Size(17, 20);
            label9.TabIndex = 1;
            label9.Text = "1";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(-1, 16);
            label4.Name = "label4";
            label4.Size = new Size(140, 15);
            label4.TabIndex = 0;
            label4.Text = "LOW STOCKS ITEMS";
            label4.Click += label4_Click;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(14, 91);
            panel3.Name = "panel3";
            panel3.Size = new Size(141, 125);
            panel3.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(63, 74);
            label8.Name = "label8";
            label8.Size = new Size(17, 20);
            label8.TabIndex = 1;
            label8.Text = "1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(3, 16);
            label3.Name = "label3";
            label3.Size = new Size(128, 15);
            label3.TabIndex = 0;
            label3.Text = "TOTAL PRODUCTS";
            // 
            // panel2
            // 
            panel2.Controls.Add(label2);
            panel2.Location = new Point(404, 28);
            panel2.Name = "panel2";
            panel2.Size = new Size(131, 31);
            panel2.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(13, 8);
            label2.Name = "label2";
            label2.Size = new Size(106, 17);
            label2.TabIndex = 2;
            label2.Text = "20 June 2026";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(27, 36);
            label1.Name = "label1";
            label1.Size = new Size(140, 23);
            label1.TabIndex = 0;
            label1.Text = "DASHBOARD";
            // 
            // FormAdminDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlMain);
            Controls.Add(pnlSidebar);
            Name = "FormAdminDashboard";
            Text = "AdminForm";
            Load += FormAdminDashboard_Load;
            pnlSidebar.ResumeLayout(false);
            pnlMain.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSidebar;
        private Panel pnlMain;
        private Button btnLogout;
        private Button btnSales;
        private Button btnStock;
        private Button btnProducts;
        private Button btnDashboard;
        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private Panel panel6;
        private Panel panel5;
        private Panel panel4;
        private Label label4;
        private Panel panel3;
        private Label label3;
        private Label label7;
        private Label label6;
        private Panel panel7;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
    }
}