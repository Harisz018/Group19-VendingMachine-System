namespace databaseProjectEDP
{
    partial class FormPayment
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
            paymentLbl = new Label();
            totalAmountLbl = new Label();
            totalLbl = new Label();
            ewalletRdo = new RadioButton();
            cardRdo = new RadioButton();
            cashRdo = new RadioButton();
            sloganLbl = new Label();
            panel1 = new Panel();
            backBtn = new Button();
            confirmBtn = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // paymentLbl
            // 
            paymentLbl.AutoSize = true;
            paymentLbl.Font = new Font("Microsoft YaHei UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            paymentLbl.ForeColor = Color.Indigo;
            paymentLbl.Location = new Point(288, 44);
            paymentLbl.Name = "paymentLbl";
            paymentLbl.Size = new Size(227, 52);
            paymentLbl.TabIndex = 4;
            paymentLbl.Text = "PAYMENT";
            paymentLbl.TextAlign = ContentAlignment.TopCenter;
            // 
            // totalAmountLbl
            // 
            totalAmountLbl.AutoSize = true;
            totalAmountLbl.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            totalAmountLbl.ForeColor = Color.DimGray;
            totalAmountLbl.Location = new Point(318, 113);
            totalAmountLbl.Name = "totalAmountLbl";
            totalAmountLbl.Size = new Size(166, 25);
            totalAmountLbl.TabIndex = 5;
            totalAmountLbl.Text = "TOTAL AMOUNT";
            // 
            // totalLbl
            // 
            totalLbl.AutoSize = true;
            totalLbl.Font = new Font("Microsoft YaHei UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            totalLbl.ForeColor = Color.Indigo;
            totalLbl.Location = new Point(322, 138);
            totalLbl.Name = "totalLbl";
            totalLbl.Size = new Size(152, 42);
            totalLbl.TabIndex = 6;
            totalLbl.Text = "RM 0.00";
            totalLbl.TextAlign = ContentAlignment.TopCenter;
            // 
            // ewalletRdo
            // 
            ewalletRdo.AutoSize = true;
            ewalletRdo.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ewalletRdo.Location = new Point(229, 84);
            ewalletRdo.Name = "ewalletRdo";
            ewalletRdo.Size = new Size(141, 35);
            ewalletRdo.TabIndex = 7;
            ewalletRdo.TabStop = true;
            ewalletRdo.Text = "E-Wallet";
            ewalletRdo.UseVisualStyleBackColor = true;
            // 
            // cardRdo
            // 
            cardRdo.AutoSize = true;
            cardRdo.BackColor = Color.Transparent;
            cardRdo.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cardRdo.Location = new Point(423, 84);
            cardRdo.Name = "cardRdo";
            cardRdo.Size = new Size(95, 35);
            cardRdo.TabIndex = 8;
            cardRdo.TabStop = true;
            cardRdo.Text = "Card";
            cardRdo.UseVisualStyleBackColor = false;
            // 
            // cashRdo
            // 
            cashRdo.AutoSize = true;
            cashRdo.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cashRdo.Location = new Point(75, 84);
            cashRdo.Name = "cashRdo";
            cashRdo.Size = new Size(97, 35);
            cashRdo.TabIndex = 9;
            cashRdo.TabStop = true;
            cashRdo.Text = "Cash";
            cashRdo.UseVisualStyleBackColor = true;
            // 
            // sloganLbl
            // 
            sloganLbl.AutoSize = true;
            sloganLbl.Font = new Font("Microsoft YaHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sloganLbl.ForeColor = Color.Black;
            sloganLbl.Location = new Point(172, 29);
            sloganLbl.Name = "sloganLbl";
            sloganLbl.Size = new Size(239, 27);
            sloganLbl.TabIndex = 10;
            sloganLbl.Text = "Select Payment Method";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Thistle;
            panel1.Controls.Add(sloganLbl);
            panel1.Controls.Add(cashRdo);
            panel1.Controls.Add(cardRdo);
            panel1.Controls.Add(ewalletRdo);
            panel1.Location = new Point(104, 212);
            panel1.Name = "panel1";
            panel1.Size = new Size(590, 156);
            panel1.TabIndex = 11;
            // 
            // backBtn
            // 
            backBtn.BackColor = Color.LightGray;
            backBtn.Font = new Font("Microsoft YaHei UI", 8F, FontStyle.Bold);
            backBtn.ForeColor = Color.Gray;
            backBtn.Location = new Point(38, 28);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(109, 52);
            backBtn.TabIndex = 11;
            backBtn.Text = "< Back";
            backBtn.UseVisualStyleBackColor = false;
            backBtn.Click += backBtn_Click;
            // 
            // confirmBtn
            // 
            confirmBtn.BackColor = Color.DarkOrchid;
            confirmBtn.Font = new Font("Microsoft YaHei UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            confirmBtn.ForeColor = Color.White;
            confirmBtn.Location = new Point(221, 399);
            confirmBtn.Name = "confirmBtn";
            confirmBtn.Size = new Size(352, 75);
            confirmBtn.TabIndex = 12;
            confirmBtn.Text = "CONFIRM PAYMENT";
            confirmBtn.UseVisualStyleBackColor = false;
            confirmBtn.Click += confirmBtn_Click;
            // 
            // FormPayment
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(800, 526);
            Controls.Add(confirmBtn);
            Controls.Add(backBtn);
            Controls.Add(panel1);
            Controls.Add(totalLbl);
            Controls.Add(totalAmountLbl);
            Controls.Add(paymentLbl);
            Name = "FormPayment";
            Text = "FormPayment";
            Load += FormPayment_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label paymentLbl;
        private Label totalAmountLbl;
        private Label totalLbl;
        private RadioButton ewalletRdo;
        private RadioButton cardRdo;
        private RadioButton cashRdo;
        private Label sloganLbl;
        private Panel panel1;
        private Button backBtn;
        private Button confirmBtn;
    }
}