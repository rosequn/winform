namespace WinFormsApp31_03
{
    partial class LoginPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            pictureBox3 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox4 = new PictureBox();
            txtUsername = new TextBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            txtPassword = new TextBox();
            LoginBtn = new CustomButton();
            chkRememberMe = new CheckBox();
            RegisterBtn = new CustomButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(454, 98);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(230, 211);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 12;
            pictureBox3.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Navy;
            label2.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label2.ForeColor = Color.Gold;
            label2.Location = new Point(96, 46);
            label2.Name = "label2";
            label2.Size = new Size(331, 17);
            label2.TabIndex = 11;
            label2.Text = "PHÂN HIỆU TẠI THÀNH PHỐ HỒ CHÍ MINH";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Navy;
            label1.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.ForeColor = SystemColors.HighlightText;
            label1.Location = new Point(101, 25);
            label1.Name = "label1";
            label1.Size = new Size(317, 17);
            label1.TabIndex = 10;
            label1.Text = "TRƯỜNG ĐẠI HỌC GIAO THÔNG VẬN TẢI";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Navy;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(11, 11);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(95, 67);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Navy;
            pictureBox1.Location = new Point(1, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1005, 91);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(1, 90);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(1005, 635);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 15;
            pictureBox4.TabStop = false;
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtUsername.Location = new Point(3, 26);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(348, 33);
            txtUsername.TabIndex = 16;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtUsername);
            groupBox1.Font = new Font("Segoe UI", 9F);
            groupBox1.Location = new Point(395, 351);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(354, 62);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tên đăng nhập";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtPassword);
            groupBox2.Location = new Point(395, 444);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(354, 62);
            groupBox2.TabIndex = 18;
            groupBox2.TabStop = false;
            groupBox2.Text = "Mật khẩu";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtPassword.Location = new Point(2, 26);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(348, 33);
            txtPassword.TabIndex = 17;
            // 
            // LoginBtn
            // 
            LoginBtn.BackColor = Color.RoyalBlue;
            LoginBtn.BackgroundColor = Color.RoyalBlue;
            LoginBtn.BorderColor = Color.PaleVioletRed;
            LoginBtn.BorderRadius = 20;
            LoginBtn.BorderSize = 0;
            LoginBtn.FlatStyle = FlatStyle.Flat;
            LoginBtn.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 163);
            LoginBtn.ForeColor = Color.White;
            LoginBtn.Location = new Point(395, 565);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(158, 40);
            LoginBtn.TabIndex = 20;
            LoginBtn.Text = "Đăng nhập";
            LoginBtn.TextColor = Color.White;
            LoginBtn.UseVisualStyleBackColor = false;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // chkRememberMe
            // 
            chkRememberMe.AutoSize = true;
            chkRememberMe.Location = new Point(534, 528);
            chkRememberMe.Margin = new Padding(2);
            chkRememberMe.Name = "chkRememberMe";
            chkRememberMe.Size = new Size(221, 24);
            chkRememberMe.TabIndex = 21;
            chkRememberMe.Text = "Ghi nhớ thông tin đăng nhập";
            chkRememberMe.UseVisualStyleBackColor = true;
            // 
            // RegisterBtn
            // 
            RegisterBtn.BackColor = Color.RoyalBlue;
            RegisterBtn.BackgroundColor = Color.RoyalBlue;
            RegisterBtn.BorderColor = Color.PaleVioletRed;
            RegisterBtn.BorderRadius = 20;
            RegisterBtn.BorderSize = 0;
            RegisterBtn.FlatStyle = FlatStyle.Flat;
            RegisterBtn.Font = new Font("Times New Roman", 13.2000008F);
            RegisterBtn.ForeColor = SystemColors.Control;
            RegisterBtn.Location = new Point(609, 565);
            RegisterBtn.Name = "RegisterBtn";
            RegisterBtn.Size = new Size(158, 40);
            RegisterBtn.TabIndex = 19;
            RegisterBtn.Text = "Đăng ký";
            RegisterBtn.TextColor = SystemColors.Control;
            RegisterBtn.UseVisualStyleBackColor = false;
            RegisterBtn.Click += RegisterBtn_Click;
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1006, 726);
            Controls.Add(chkRememberMe);
            Controls.Add(LoginBtn);
            Controls.Add(RegisterBtn);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox4);
            Name = "LoginPage";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void LoginBtn_Click1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private PictureBox pictureBox3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox4;
        private TextBox txtUsername;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox txtPassword;
        private CustomButton LoginBtn;
        private CheckBox chkRememberMe;
        private CustomButton RegisterBtn;
    }
}