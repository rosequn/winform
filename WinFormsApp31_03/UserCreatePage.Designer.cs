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
            ResetBtn = new Button();
            SaveBtn = new Button();
            BackBtn = new Button();
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
            label1.Location = new Point(392, 33);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(321, 41);
            label1.TabIndex = 0;
            label1.Text = "THÊM MÁY BƠM";
            // 
            // ResetBtn
            // 
            ResetBtn.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 163);
            ResetBtn.Location = new Point(1118, 167);
            ResetBtn.Margin = new Padding(4);
            ResetBtn.Name = "ResetBtn";
            ResetBtn.Size = new Size(150, 50);
            ResetBtn.TabIndex = 19;
            ResetBtn.Text = "Đặt lại";
            ResetBtn.UseVisualStyleBackColor = true;
            ResetBtn.Click += ResetBtn_Click;
            // 
            // SaveBtn
            // 
            SaveBtn.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 163);
            SaveBtn.Location = new Point(1118, 93);
            SaveBtn.Margin = new Padding(4);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(150, 50);
            SaveBtn.TabIndex = 17;
            SaveBtn.Text = "Lưu";
            SaveBtn.UseVisualStyleBackColor = true;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // BackBtn
            // 
            BackBtn.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 163);
            BackBtn.Location = new Point(1118, 256);
            BackBtn.Margin = new Padding(4);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(150, 50);
            BackBtn.TabIndex = 21;
            BackBtn.Text = "Quay lại";
            BackBtn.UseVisualStyleBackColor = true;
            BackBtn.Click += BackBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14F);
            label2.Location = new Point(79, 98);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(191, 33);
            label2.TabIndex = 11;
            label2.Text = "Tên người dùng";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtUsername.Location = new Point(294, 102);
            txtUsername.Margin = new Padding(4);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(346, 32);
            txtUsername.TabIndex = 12;
            txtUsername.TextChanged += CheckEnableReset;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 14F);
            label3.Location = new Point(79, 156);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(97, 33);
            label3.TabIndex = 13;
            label3.Text = "Họ tên:";
            // 
            // txtFullName
            // 
            txtFullName.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtFullName.Location = new Point(294, 159);
            txtFullName.Margin = new Padding(4);
            txtFullName.Multiline = true;
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(346, 30);
            txtFullName.TabIndex = 14;
            txtFullName.TextChanged += CheckEnableReset;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 14F);
            label4.Location = new Point(79, 216);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(145, 33);
            label4.TabIndex = 15;
            label4.Text = "Phân quyền";
            // 
            // cbUserRole
            // 
            cbUserRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cbUserRole.FormattingEnabled = true;
            cbUserRole.Location = new Point(294, 222);
            cbUserRole.Name = "cbUserRole";
            cbUserRole.Size = new Size(346, 33);
            cbUserRole.TabIndex = 22;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtPhoneNumber.Location = new Point(294, 284);
            txtPhoneNumber.Margin = new Padding(4);
            txtPhoneNumber.Multiline = true;
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(346, 40);
            txtPhoneNumber.TabIndex = 30;
            txtPhoneNumber.TextChanged += CheckEnableReset;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 14F);
            label8.Location = new Point(79, 281);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(163, 33);
            label8.TabIndex = 29;
            label8.Text = "Số điện thoại";
            // 
            // UserCreatePage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1689, 705);
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
            Margin = new Padding(4);
            Name = "UserCreatePage";
            Text = "Quản lý trạm bơm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button LoadBtn;
        private Button ResetBtn;
        private Button SaveBtn;
        private Button BackBtn;
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