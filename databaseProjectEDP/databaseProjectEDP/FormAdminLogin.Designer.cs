namespace databaseProjectEDP
{
    partial class FormAdminLogin
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
            lblTitle = new Label();
            txtAdminID = new TextBox();
            txtPassword = new TextBox();
            chkRemember = new CheckBox();
            btnLogin = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.White;
            lblTitle.Font = new Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.DarkViolet;
            lblTitle.Location = new Point(307, 45);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(208, 46);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "UNIVEND";
            lblTitle.Click += lblTitle_Click;
            // 
            // txtAdminID
            // 
            txtAdminID.Location = new Point(267, 172);
            txtAdminID.Name = "txtAdminID";
            txtAdminID.Size = new Size(289, 27);
            txtAdminID.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(267, 229);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(289, 27);
            txtPassword.TabIndex = 2;
            // 
            // chkRemember
            // 
            chkRemember.AutoSize = true;
            chkRemember.Location = new Point(267, 275);
            chkRemember.Name = "chkRemember";
            chkRemember.Size = new Size(129, 24);
            chkRemember.TabIndex = 3;
            chkRemember.Text = "Remember Me";
            chkRemember.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.DarkViolet;
            btnLogin.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(267, 321);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(289, 45);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(255, 192, 255);
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = Properties.Resources.Vending;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(209, 450);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(314, 91);
            label1.Name = "label1";
            label1.Size = new Size(169, 31);
            label1.TabIndex = 6;
            label1.Text = "ADMIN LOGIN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(321, 122);
            label2.Name = "label2";
            label2.Size = new Size(162, 15);
            label2.TabIndex = 7;
            label2.Text = "Please login to continue";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(267, 154);
            label3.Name = "label3";
            label3.Size = new Size(65, 15);
            label3.TabIndex = 8;
            label3.Text = "Admin ID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(267, 210);
            label4.Name = "label4";
            label4.Size = new Size(71, 15);
            label4.TabIndex = 9;
            label4.Text = "Password";
            // 
            // FormAdminLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(btnLogin);
            Controls.Add(chkRemember);
            Controls.Add(txtPassword);
            Controls.Add(txtAdminID);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormAdminLogin";
            Text = "FormAdminLogin";
            Load += FormAdminLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private TextBox txtAdminID;
        private TextBox txtPassword;
        private CheckBox chkRemember;
        private Button btnLogin;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}