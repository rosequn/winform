namespace WinFormsApp31_03
{
    partial class UserCreatePage
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
            label1 = new Label();
            ResetBtn = new CustomButton();
            SaveBtn = new CustomButton();
            BackBtn = new CustomButton();
            label2 = new Label();
            txtUsername = new TextBox();
            label3 = new Label();
            txtFullName = new TextBox();
            label4 = new Label();
            cbUserRole = new ComboBox();
            txtPhoneNumber = new TextBox();
            label8 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.Location = new Point(88, 9);
            label1.Name = "label1";
            label1.Size = new Size(315, 35);
            label1.TabIndex = 0;
            label1.Text = "THÊM NGƯỜI DÙNG";
            // 
            // ResetBtn
            // 
            ResetBtn.BackColor = Color.MediumSlateBlue;
            ResetBtn.BackgroundColor = Color.MediumSlateBlue;
            ResetBtn.BorderColor = Color.PaleVioletRed;
            ResetBtn.BorderRadius = 20;
            ResetBtn.BorderSize = 0;
            ResetBtn.FlatStyle = FlatStyle.Flat;
            ResetBtn.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 163);
            ResetBtn.ForeColor = Color.White;
            ResetBtn.Location = new Point(180, 275);
            ResetBtn.Name = "ResetBtn";
            ResetBtn.Size = new Size(120, 40);
            ResetBtn.TabIndex = 19;
            ResetBtn.Text = "Đặt lại";
            ResetBtn.TextColor = Color.White;
            ResetBtn.UseVisualStyleBackColor = true;
            ResetBtn.Click += ResetBtn_Click;
            // 
            // SaveBtn
            // 
            SaveBtn.BackColor = Color.MediumSlateBlue;
            SaveBtn.BackgroundColor = Color.MediumSlateBlue;
            SaveBtn.BorderColor = Color.PaleVioletRed;
            SaveBtn.BorderRadius = 20;
            SaveBtn.BorderSize = 0;
            SaveBtn.FlatStyle = FlatStyle.Flat;
            SaveBtn.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 163);
            SaveBtn.ForeColor = Color.White;
            SaveBtn.Location = new Point(17, 275);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(120, 40);
            SaveBtn.TabIndex = 17;
            SaveBtn.Text = "Lưu";
            SaveBtn.TextColor = Color.White;
            SaveBtn.UseVisualStyleBackColor = true;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // BackBtn
            // 
            BackBtn.BackColor = Color.MediumSlateBlue;
            BackBtn.BackgroundColor = Color.MediumSlateBlue;
            BackBtn.BorderColor = Color.PaleVioletRed;
            BackBtn.BorderRadius = 20;
            BackBtn.BorderSize = 0;
            BackBtn.FlatStyle = FlatStyle.Flat;
            BackBtn.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 163);
            BackBtn.ForeColor = Color.White;
            BackBtn.Location = new Point(345, 275);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(120, 40);
            BackBtn.TabIndex = 21;
            BackBtn.Text = "Quay lại";
            BackBtn.TextColor = Color.White;
            BackBtn.UseVisualStyleBackColor = true;
            BackBtn.Click += BackBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14F);
            label2.Location = new Point(12, 77);
            label2.Name = "label2";
            label2.Size = new Size(163, 27);
            label2.TabIndex = 11;
            label2.Text = "Tên người dùng";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtUsername.Location = new Point(192, 69);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(300, 35);
            txtUsername.TabIndex = 12;
            txtUsername.TextChanged += CheckEnableReset;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 14F);
            label3.Location = new Point(12, 124);
            label3.Name = "label3";
            label3.Size = new Size(83, 27);
            label3.TabIndex = 13;
            label3.Text = "Họ tên:";
            // 
            // txtFullName
            // 
            txtFullName.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtFullName.Location = new Point(192, 119);
            txtFullName.Multiline = true;
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(300, 35);
            txtFullName.TabIndex = 14;
            txtFullName.TextChanged += CheckEnableReset;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 14F);
            label4.Location = new Point(12, 171);
            label4.Name = "label4";
            label4.Size = new Size(126, 27);
            label4.TabIndex = 15;
            label4.Text = "Phân quyền";
            // 
            // cbUserRole
            // 
            cbUserRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cbUserRole.FormattingEnabled = true;
            cbUserRole.Location = new Point(192, 169);
            cbUserRole.Margin = new Padding(2);
            cbUserRole.Name = "cbUserRole";
            cbUserRole.Size = new Size(300, 28);
            cbUserRole.TabIndex = 22;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtPhoneNumber.Location = new Point(192, 212);
            txtPhoneNumber.Multiline = true;
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(300, 35);
            txtPhoneNumber.TabIndex = 30;
            txtPhoneNumber.TextChanged += CheckEnableReset;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 14F);
            label8.Location = new Point(12, 218);
            label8.Name = "label8";
            label8.Size = new Size(137, 27);
            label8.TabIndex = 29;
            label8.Text = "Số điện thoại";
            // 
            // UserCreatePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(501, 329);
            Controls.Add(txtPhoneNumber);
            Controls.Add(label8);
            Controls.Add(cbUserRole);
            Controls.Add(BackBtn);
            Controls.Add(ResetBtn);
            Controls.Add(SaveBtn);
            Controls.Add(label4);
            Controls.Add(txtFullName);
            Controls.Add(label3);
            Controls.Add(txtUsername);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UserCreatePage";
            Text = "Quản lý trạm bơm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private CustomButton ResetBtn;
        private CustomButton SaveBtn;
        private CustomButton BackBtn;
        private Label label2;
        private TextBox txtUsername;
        private Label label3;
        private TextBox txtFullName;
        private Label label4;
        private ComboBox cbUserRole;
        private TextBox txtPhoneNumber;
        private Label label8;
    }
}