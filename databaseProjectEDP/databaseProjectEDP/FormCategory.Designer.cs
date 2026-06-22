namespace databaseProjectEDP
{
    partial class FormCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCategory));
            labelTitle = new Label();
            labelQuestion = new Label();
            pictureBoxFood = new PictureBox();
            pictureBoxBeauty = new PictureBox();
            pictureBoxMedication = new PictureBox();
            pictureBoxToys = new PictureBox();
            pictureBoxEssential = new PictureBox();
            labelFood = new Label();
            labelBeauty = new Label();
            labelMedication = new Label();
            labelToys = new Label();
            labelEssentials = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFood).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBeauty).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMedication).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxToys).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxEssential).BeginInit();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Microsoft YaHei UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitle.ForeColor = Color.Purple;
            labelTitle.Location = new Point(189, 21);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(435, 50);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "CHOOSE A CATEGORY";
            // 
            // labelQuestion
            // 
            labelQuestion.AutoSize = true;
            labelQuestion.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelQuestion.ForeColor = Color.Fuchsia;
            labelQuestion.Location = new Point(288, 75);
            labelQuestion.Name = "labelQuestion";
            labelQuestion.Size = new Size(242, 20);
            labelQuestion.TabIndex = 1;
            labelQuestion.Text = "What are you looking for today?";
            // 
            // pictureBoxFood
            // 
            pictureBoxFood.Cursor = Cursors.Hand;
            pictureBoxFood.Image = (Image)resources.GetObject("pictureBoxFood.Image");
            pictureBoxFood.Location = new Point(128, 114);
            pictureBoxFood.Name = "pictureBoxFood";
            pictureBoxFood.Size = new Size(179, 141);
            pictureBoxFood.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxFood.TabIndex = 2;
            pictureBoxFood.TabStop = false;
            pictureBoxFood.Click += pictureBoxFood_Click;
            // 
            // pictureBoxBeauty
            // 
            pictureBoxBeauty.Cursor = Cursors.Hand;
            pictureBoxBeauty.Image = (Image)resources.GetObject("pictureBoxBeauty.Image");
            pictureBoxBeauty.Location = new Point(318, 114);
            pictureBoxBeauty.Name = "pictureBoxBeauty";
            pictureBoxBeauty.Size = new Size(179, 141);
            pictureBoxBeauty.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxBeauty.TabIndex = 3;
            pictureBoxBeauty.TabStop = false;
            pictureBoxBeauty.Click += pictureBoxBeauty_Click;
            // 
            // pictureBoxMedication
            // 
            pictureBoxMedication.Cursor = Cursors.Hand;
            pictureBoxMedication.Image = (Image)resources.GetObject("pictureBoxMedication.Image");
            pictureBoxMedication.Location = new Point(498, 123);
            pictureBoxMedication.Name = "pictureBoxMedication";
            pictureBoxMedication.Size = new Size(179, 141);
            pictureBoxMedication.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxMedication.TabIndex = 4;
            pictureBoxMedication.TabStop = false;
            pictureBoxMedication.Click += pictureBoxMedication_Click;
            // 
            // pictureBoxToys
            // 
            pictureBoxToys.Cursor = Cursors.Hand;
            pictureBoxToys.Image = (Image)resources.GetObject("pictureBoxToys.Image");
            pictureBoxToys.Location = new Point(214, 261);
            pictureBoxToys.Name = "pictureBoxToys";
            pictureBoxToys.Size = new Size(179, 141);
            pictureBoxToys.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxToys.TabIndex = 5;
            pictureBoxToys.TabStop = false;
            pictureBoxToys.Click += pictureBoxToys_Click;
            // 
            // pictureBoxEssential
            // 
            pictureBoxEssential.Cursor = Cursors.Hand;
            pictureBoxEssential.Image = (Image)resources.GetObject("pictureBoxEssential.Image");
            pictureBoxEssential.Location = new Point(400, 261);
            pictureBoxEssential.Name = "pictureBoxEssential";
            pictureBoxEssential.Size = new Size(164, 141);
            pictureBoxEssential.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxEssential.TabIndex = 6;
            pictureBoxEssential.TabStop = false;
            pictureBoxEssential.Click += pictureBoxEssential_Click;
            // 
            // labelFood
            // 
            labelFood.AutoSize = true;
            labelFood.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelFood.ForeColor = Color.MediumVioletRed;
            labelFood.Location = new Point(152, 232);
            labelFood.Name = "labelFood";
            labelFood.Size = new Size(134, 19);
            labelFood.TabIndex = 7;
            labelFood.Text = "Food And Drinks";
            // 
            // labelBeauty
            // 
            labelBeauty.AutoSize = true;
            labelBeauty.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelBeauty.ForeColor = Color.MediumVioletRed;
            labelBeauty.Location = new Point(372, 233);
            labelBeauty.Name = "labelBeauty";
            labelBeauty.Size = new Size(62, 19);
            labelBeauty.TabIndex = 8;
            labelBeauty.Text = "Beauty";
            labelBeauty.Click += label1_Click;
            // 
            // labelMedication
            // 
            labelMedication.AutoSize = true;
            labelMedication.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelMedication.ForeColor = Color.MediumVioletRed;
            labelMedication.Location = new Point(538, 232);
            labelMedication.Name = "labelMedication";
            labelMedication.Size = new Size(94, 19);
            labelMedication.TabIndex = 9;
            labelMedication.Text = "Medication";
            // 
            // labelToys
            // 
            labelToys.AutoSize = true;
            labelToys.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelToys.ForeColor = Color.MediumVioletRed;
            labelToys.Location = new Point(280, 374);
            labelToys.Name = "labelToys";
            labelToys.Size = new Size(44, 19);
            labelToys.TabIndex = 10;
            labelToys.Text = "Toys";
            // 
            // labelEssentials
            // 
            labelEssentials.AutoSize = true;
            labelEssentials.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelEssentials.ForeColor = Color.MediumVioletRed;
            labelEssentials.Location = new Point(437, 374);
            labelEssentials.Name = "labelEssentials";
            labelEssentials.Size = new Size(81, 19);
            labelEssentials.TabIndex = 11;
            labelEssentials.Text = "Essentials";
            // 
            // FormCategory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(800, 450);
            Controls.Add(labelEssentials);
            Controls.Add(labelToys);
            Controls.Add(labelMedication);
            Controls.Add(labelBeauty);
            Controls.Add(labelFood);
            Controls.Add(pictureBoxEssential);
            Controls.Add(pictureBoxToys);
            Controls.Add(pictureBoxMedication);
            Controls.Add(pictureBoxBeauty);
            Controls.Add(pictureBoxFood);
            Controls.Add(labelQuestion);
            Controls.Add(labelTitle);
            Name = "FormCategory";
            Text = "Form Category";
            ((System.ComponentModel.ISupportInitialize)pictureBoxFood).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBeauty).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMedication).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxToys).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxEssential).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitle;
        private Label labelQuestion;
        private PictureBox pictureBoxFood;
        private PictureBox pictureBoxBeauty;
        private PictureBox pictureBoxMedication;
        private PictureBox pictureBoxToys;
        private PictureBox pictureBoxEssential;
        private Label labelFood;
        private Label labelBeauty;
        private Label labelMedication;
        private Label labelToys;
        private Label labelEssentials;
    }
}