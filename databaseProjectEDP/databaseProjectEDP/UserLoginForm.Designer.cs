namespace databaseProjectEDP
{
    partial class UserLoginForm
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
            pictureBox1 = new PictureBox();
            welcomeLbl = new Label();
            label1 = new Label();
            sloganLbl = new Label();
            detailsLbl = new Label();
            nameLbl = new Label();
            nameTxtBx = new TextBox();
            matricLbl = new Label();
            matricTxtBx = new TextBox();
            panel1 = new Panel();
            startBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.machine;
            pictureBox1.Location = new Point(-8, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(375, 466);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // welcomeLbl
            // 
            welcomeLbl.AutoSize = true;
            welcomeLbl.Font = new Font("Microsoft YaHei UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            welcomeLbl.ForeColor = Color.DimGray;
            welcomeLbl.Location = new Point(475, 26);
            welcomeLbl.Name = "welcomeLbl";
            welcomeLbl.Size = new Size(152, 27);
            welcomeLbl.TabIndex = 1;
            welcomeLbl.Text = "WELCOME TO";
            welcomeLbl.Click += welcomeLbl_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 26F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Indigo;
            label1.Location = new Point(415, 53);
            label1.Name = "label1";
            label1.Size = new Size(283, 69);
            label1.TabIndex = 2;
            label1.Text = "UNIVEND";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // sloganLbl
            // 
            sloganLbl.AutoSize = true;
            sloganLbl.Font = new Font("Microsoft YaHei UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sloganLbl.ForeColor = Color.DimGray;
            sloganLbl.Location = new Point(426, 124);
            sloganLbl.Name = "sloganLbl";
            sloganLbl.Size = new Size(260, 21);
            sloganLbl.TabIndex = 3;
            sloganLbl.Text = "Your Campus Favourite Machine";
            // 
            // detailsLbl
            // 
            detailsLbl.AutoSize = true;
            detailsLbl.Font = new Font("Microsoft YaHei UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            detailsLbl.ForeColor = Color.Indigo;
            detailsLbl.Location = new Point(41, 21);
            detailsLbl.Name = "detailsLbl";
            detailsLbl.Size = new Size(313, 27);
            detailsLbl.TabIndex = 4;
            detailsLbl.Text = "PLEASE ENTER YOUR DETAILS";
            // 
            // nameLbl
            // 
            nameLbl.AutoSize = true;
            nameLbl.Font = new Font("Microsoft YaHei UI", 8F);
            nameLbl.ForeColor = Color.Black;
            nameLbl.Location = new Point(21, 79);
            nameLbl.Name = "nameLbl";
            nameLbl.Size = new Size(60, 21);
            nameLbl.TabIndex = 5;
            nameLbl.Text = "Name:";
            // 
            // nameTxtBx
            // 
            nameTxtBx.Location = new Point(161, 73);
            nameTxtBx.Name = "nameTxtBx";
            nameTxtBx.Size = new Size(209, 31);
            nameTxtBx.TabIndex = 6;
            // 
            // matricLbl
            // 
            matricLbl.AutoSize = true;
            matricLbl.Font = new Font("Microsoft YaHei UI", 8F);
            matricLbl.ForeColor = Color.Black;
            matricLbl.Location = new Point(22, 128);
            matricLbl.Name = "matricLbl";
            matricLbl.Size = new Size(131, 21);
            matricLbl.TabIndex = 7;
            matricLbl.Text = "Matric Number:";
            // 
            // matricTxtBx
            // 
            matricTxtBx.Location = new Point(161, 122);
            matricTxtBx.Name = "matricTxtBx";
            matricTxtBx.Size = new Size(209, 31);
            matricTxtBx.TabIndex = 8;
            matricTxtBx.TextChanged += matricTxtBx_TextChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Plum;
            panel1.Controls.Add(matricTxtBx);
            panel1.Controls.Add(matricLbl);
            panel1.Controls.Add(nameTxtBx);
            panel1.Controls.Add(nameLbl);
            panel1.Controls.Add(detailsLbl);
            panel1.Location = new Point(354, 163);
            panel1.Name = "panel1";
            panel1.Size = new Size(405, 182);
            panel1.TabIndex = 9;
            // 
            // startBtn
            // 
            startBtn.BackColor = Color.Purple;
            startBtn.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            startBtn.ForeColor = Color.White;
            startBtn.Location = new Point(422, 365);
            startBtn.Name = "startBtn";
            startBtn.Size = new Size(276, 75);
            startBtn.TabIndex = 10;
            startBtn.Text = "START BUTTON";
            startBtn.UseVisualStyleBackColor = false;
            startBtn.Click += startBtn_Click_1;
            // 
            // UserLoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(800, 475);
            Controls.Add(startBtn);
            Controls.Add(panel1);
            Controls.Add(sloganLbl);
            Controls.Add(label1);
            Controls.Add(welcomeLbl);
            Controls.Add(pictureBox1);
            Name = "UserLoginForm";
            Text = "Login Form";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label welcomeLbl;
        private Label label1;
        private Label sloganLbl;
        private Label detailsLbl;
        private Label nameLbl;
        private TextBox nameTxtBx;
        private Label matricLbl;
        private TextBox matricTxtBx;
        private Panel panel1;
        private Button startBtn;
    }
}