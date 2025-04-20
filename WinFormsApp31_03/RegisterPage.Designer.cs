namespace WinFormsApp31_03
{
    partial class RegisterPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterPage));
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
            QuayLai = new Button();
            RegisterBtn = new Button();
            txtRePassword = new TextBox();
            groupBox3 = new GroupBox();
            txtFullName = new TextBox();
            groupBox4 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(571, 142);
            pictureBox3.Margin = new Padding(4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(288, 264);
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
            label2.Location = new Point(120, 58);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(388, 20);
            label2.TabIndex = 11;
            label2.Text = "PHÂN HIỆU TẠI THÀNH PHỐ HỒ CHÍ MINH";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Navy;
            label1.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.ForeColor = SystemColors.HighlightText;
            label1.Location = new Point(126, 31);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(376, 20);
            label1.TabIndex = 10;
            label1.Text = "TRƯỜNG ĐẠI HỌC GIAO THÔNG VẬN TẢI";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Navy;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(14, 14);
            pictureBox2.Margin = new Padding(4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(119, 84);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Navy;
            pictureBox1.Location = new Point(1, 1);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1256, 114);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(1, 112);
            pictureBox4.Margin = new Padding(4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(1256, 794);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 15;
            pictureBox4.TabStop = false;
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtUsername.Location = new Point(8, 32);
            txtUsername.Margin = new Padding(4);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(434, 58);
            txtUsername.TabIndex = 16;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtUsername);
            groupBox1.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 163);
            groupBox1.Location = new Point(494, 341);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(442, 98);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tên đăng nhập";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtPassword);
            groupBox2.Location = new Point(494, 555);
            groupBox2.Margin = new Padding(4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4);
            groupBox2.Size = new Size(442, 98);
            groupBox2.TabIndex = 18;
            groupBox2.TabStop = false;
            groupBox2.Text = "Mật khẩu";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtPassword.Location = new Point(8, 42);
            txtPassword.Margin = new Padding(4);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(434, 56);
            txtPassword.TabIndex = 17;
            // 
            // QuayLai
            // 
            QuayLai.Location = new Point(831, 796);
            QuayLai.Margin = new Padding(4);
            QuayLai.Name = "QuayLai";
            QuayLai.Size = new Size(175, 50);
            QuayLai.TabIndex = 19;
            QuayLai.Text = "Quay lại";
            QuayLai.UseVisualStyleBackColor = true;
            // 
            // RegisterBtn
            // 
            RegisterBtn.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 163);
            RegisterBtn.Location = new Point(404, 796);
            RegisterBtn.Margin = new Padding(4);
            RegisterBtn.Name = "RegisterBtn";
            RegisterBtn.Size = new Size(184, 50);
            RegisterBtn.TabIndex = 20;
            RegisterBtn.Text = "Đăng ký";
            RegisterBtn.UseVisualStyleBackColor = true;
            RegisterBtn.Click += RegisterBtn_Click;
            // 
            // txtRePassword
            // 
            txtRePassword.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtRePassword.Location = new Point(8, 42);
            txtRePassword.Margin = new Padding(4);
            txtRePassword.Multiline = true;
            txtRePassword.Name = "txtRePassword";
            txtRePassword.Size = new Size(434, 56);
            txtRePassword.TabIndex = 17;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtRePassword);
            groupBox3.Location = new Point(494, 661);
            groupBox3.Margin = new Padding(4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4);
            groupBox3.Size = new Size(442, 98);
            groupBox3.TabIndex = 19;
            groupBox3.TabStop = false;
            groupBox3.Text = "Nhập lại mật khẩu";
            // 
            // txtFullName
            // 
            txtFullName.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtFullName.Location = new Point(8, 32);
            txtFullName.Margin = new Padding(4);
            txtFullName.Multiline = true;
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(434, 58);
            txtFullName.TabIndex = 16;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(txtFullName);
            groupBox4.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 163);
            groupBox4.Location = new Point(494, 449);
            groupBox4.Margin = new Padding(4);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(4);
            groupBox4.Size = new Size(442, 98);
            groupBox4.TabIndex = 18;
            groupBox4.TabStop = false;
            groupBox4.Text = "Tên người dùng";
            // 
            // RegisterPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1258, 908);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(RegisterBtn);
            Controls.Add(QuayLai);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox4);
            Margin = new Padding(4);
            Name = "RegisterPage";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
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
        private Button QuayLai;
        private Button RegisterBtn;
        private TextBox txtRePassword;
        private GroupBox groupBox3;
        private TextBox txtFullName;
        private GroupBox groupBox4;
    }
}