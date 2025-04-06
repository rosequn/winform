namespace WinFormsApp31_03
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            pictureBox3 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox4 = new PictureBox();
            TenDangNhap = new TextBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            txtPassword = new TextBox();
            QuayLai = new Button();
            XacThuc = new Button();
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
            pictureBox3.Location = new Point(395, 119);
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
            // TenDangNhap
            // 
            TenDangNhap.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 163);
            TenDangNhap.Location = new Point(6, 26);
            TenDangNhap.Multiline = true;
            TenDangNhap.Name = "TenDangNhap";
            TenDangNhap.Size = new Size(218, 47);
            TenDangNhap.TabIndex = 16;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(TenDangNhap);
            groupBox1.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 163);
            groupBox1.Location = new Point(395, 351);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(230, 78);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tên đăng nhập";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtPassword);
            groupBox2.Location = new Point(395, 444);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(230, 78);
            groupBox2.TabIndex = 18;
            groupBox2.TabStop = false;
            groupBox2.Text = "Mật khẩu";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtPassword.Location = new Point(6, 26);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(218, 46);
            txtPassword.TabIndex = 17;
            // 
            // QuayLai
            // 
            QuayLai.Location = new Point(389, 608);
            QuayLai.Name = "QuayLai";
            QuayLai.Size = new Size(94, 40);
            QuayLai.TabIndex = 19;
            QuayLai.Text = "Quay lại";
            QuayLai.UseVisualStyleBackColor = true;
            // 
            // XacThuc
            // 
            XacThuc.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 163);
            XacThuc.Location = new Point(389, 542);
            XacThuc.Name = "XacThuc";
            XacThuc.Size = new Size(230, 48);
            XacThuc.TabIndex = 20;
            XacThuc.Text = "XÁC THỰC";
            XacThuc.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1006, 726);
            Controls.Add(XacThuc);
            Controls.Add(QuayLai);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox4);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load_1;
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

        #endregion

        private PictureBox pictureBox3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox4;
        private TextBox TenDangNhap;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox txtPassword;
        private Button QuayLai;
        private Button XacThuc;
    }
}