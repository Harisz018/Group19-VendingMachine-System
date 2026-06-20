namespace databaseProjectEDP
{
    partial class FormViewSales
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
            dtpFromDate = new DateTimePicker();
            dtpToDate = new DateTimePicker();
            btnFilter = new Button();
            label2 = new Label();
            dgvSales = new DataGridView();
            panelTotalSales = new Panel();
            label4 = new Label();
            label3 = new Label();
            panelTransactions = new Panel();
            label5 = new Label();
            label6 = new Label();
            panelAverage = new Panel();
            label7 = new Label();
            label8 = new Label();
            btnExport = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSales).BeginInit();
            panelTotalSales.SuspendLayout();
            panelTransactions.SuspendLayout();
            panelAverage.SuspendLayout();
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
            panel1.TabIndex = 2;
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
            label1.Location = new Point(262, 46);
            label1.Name = "label1";
            label1.Size = new Size(132, 23);
            label1.TabIndex = 10;
            label1.Text = "VIEW SALES";
            // 
            // dtpFromDate
            // 
            dtpFromDate.Location = new Point(245, 77);
            dtpFromDate.Name = "dtpFromDate";
            dtpFromDate.Size = new Size(245, 27);
            dtpFromDate.TabIndex = 11;
            // 
            // dtpToDate
            // 
            dtpToDate.Location = new Point(528, 77);
            dtpToDate.Name = "dtpToDate";
            dtpToDate.Size = new Size(250, 27);
            dtpToDate.TabIndex = 12;
            // 
            // btnFilter
            // 
            btnFilter.BackColor = Color.DarkViolet;
            btnFilter.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFilter.ForeColor = Color.White;
            btnFilter.Location = new Point(684, 34);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(94, 37);
            btnFilter.TabIndex = 13;
            btnFilter.Text = "FILTER";
            btnFilter.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(496, 82);
            label2.Name = "label2";
            label2.Size = new Size(23, 20);
            label2.TabIndex = 14;
            label2.Text = "to";
            // 
            // dgvSales
            // 
            dgvSales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSales.Location = new Point(245, 119);
            dgvSales.Name = "dgvSales";
            dgvSales.RowHeadersVisible = false;
            dgvSales.RowHeadersWidth = 51;
            dgvSales.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSales.Size = new Size(533, 188);
            dgvSales.TabIndex = 15;
            // 
            // panelTotalSales
            // 
            panelTotalSales.Controls.Add(label4);
            panelTotalSales.Controls.Add(label3);
            panelTotalSales.Location = new Point(245, 325);
            panelTotalSales.Name = "panelTotalSales";
            panelTotalSales.Size = new Size(165, 84);
            panelTotalSales.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(42, 49);
            label4.Name = "label4";
            label4.Size = new Size(74, 20);
            label4.TabIndex = 1;
            label4.Text = "RM120.00";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(26, 16);
            label3.Name = "label3";
            label3.Size = new Size(97, 15);
            label3.TabIndex = 0;
            label3.Text = "TOTAL SALES";
            // 
            // panelTransactions
            // 
            panelTransactions.Controls.Add(label5);
            panelTransactions.Controls.Add(label6);
            panelTransactions.Location = new Point(416, 325);
            panelTransactions.Name = "panelTransactions";
            panelTransactions.Size = new Size(179, 84);
            panelTransactions.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(66, 49);
            label5.Name = "label5";
            label5.Size = new Size(25, 20);
            label5.TabIndex = 3;
            label5.Text = "16";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(18, 16);
            label6.Name = "label6";
            label6.Size = new Size(158, 15);
            label6.TabIndex = 2;
            label6.Text = "TOTAL TRANSACTIONS";
            // 
            // panelAverage
            // 
            panelAverage.Controls.Add(label7);
            panelAverage.Controls.Add(label8);
            panelAverage.Location = new Point(601, 325);
            panelAverage.Name = "panelAverage";
            panelAverage.Size = new Size(187, 84);
            panelAverage.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(44, 49);
            label7.Name = "label7";
            label7.Size = new Size(58, 20);
            label7.TabIndex = 5;
            label7.Text = "RM7.00";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial Rounded MT Bold", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(7, 16);
            label8.Name = "label8";
            label8.Size = new Size(170, 15);
            label8.TabIndex = 4;
            label8.Text = "AVERAGE TRANSACTION";
            // 
            // btnExport
            // 
            btnExport.BackColor = Color.DarkViolet;
            btnExport.Font = new Font("Arial Rounded MT Bold", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExport.ForeColor = Color.White;
            btnExport.Location = new Point(645, 415);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(143, 29);
            btnExport.TabIndex = 18;
            btnExport.Text = "EXPORT REPORT";
            btnExport.UseVisualStyleBackColor = false;
            // 
            // FormViewSales
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExport);
            Controls.Add(panelAverage);
            Controls.Add(panelTransactions);
            Controls.Add(panelTotalSales);
            Controls.Add(dgvSales);
            Controls.Add(label2);
            Controls.Add(btnFilter);
            Controls.Add(dtpToDate);
            Controls.Add(dtpFromDate);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "FormViewSales";
            Text = "FormViewSales";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSales).EndInit();
            panelTotalSales.ResumeLayout(false);
            panelTotalSales.PerformLayout();
            panelTransactions.ResumeLayout(false);
            panelTransactions.PerformLayout();
            panelAverage.ResumeLayout(false);
            panelAverage.PerformLayout();
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
        private DateTimePicker dtpFromDate;
        private DateTimePicker dtpToDate;
        private Button btnFilter;
        private Label label2;
        private DataGridView dgvSales;
        private Panel panelTotalSales;
        private Label label4;
        private Label label3;
        private Panel panelTransactions;
        private Label label5;
        private Label label6;
        private Panel panelAverage;
        private Label label7;
        private Label label8;
        private Button btnExport;
    }
}