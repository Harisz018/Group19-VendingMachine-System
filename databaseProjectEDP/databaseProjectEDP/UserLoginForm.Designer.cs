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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.machine;
            pictureBox1.Location = new Point(12, -14);
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
            welcomeLbl.Location = new Point(504, 53);
            welcomeLbl.Name = "welcomeLbl";
            welcomeLbl.Size = new Size(152, 27);
            welcomeLbl.TabIndex = 1;
            welcomeLbl.Text = "WELCOME TO";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Indigo;
            label1.Location = new Point(452, 81);
            label1.Name = "label1";
            label1.Size = new Size(261, 64);
            label1.TabIndex = 2;
            label1.Text = "UNIVEND";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // UserLoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(welcomeLbl);
            Controls.Add(pictureBox1);
            Name = "UserLoginForm";
            Text = "Login Form";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label welcomeLbl;
        private Label label1;
    }
}