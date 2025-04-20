namespace WinFormsApp31_03
{
    partial class UserUpdatePage
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
            txtPhoneNumber = new TextBox();
            label8 = new Label();
            cbUserRole = new ComboBox();
            label4 = new Label();
            txtFullName = new TextBox();
            label3 = new Label();
            txtUsername = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.Location = new Point(488, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(393, 41);
            label1.TabIndex = 0;
            label1.Text = "CẬP NHẬT MÁY BƠM";
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
            // txtPhoneNumber
            // 
            txtPhoneNumber.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtPhoneNumber.Location = new Point(549, 287);
            txtPhoneNumber.Margin = new Padding(4);
            txtPhoneNumber.Multiline = true;
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(346, 40);
            txtPhoneNumber.TabIndex = 38;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 14F);
            label8.Location = new Point(334, 284);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(163, 33);
            label8.TabIndex = 37;
            label8.Text = "Số điện thoại";
            // 
            // cbUserRole
            // 
            cbUserRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cbUserRole.FormattingEnabled = true;
            cbUserRole.Location = new Point(549, 225);
            cbUserRole.Name = "cbUserRole";
            cbUserRole.Size = new Size(346, 33);
            cbUserRole.TabIndex = 36;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 14F);
            label4.Location = new Point(334, 219);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(145, 33);
            label4.TabIndex = 35;
            label4.Text = "Phân quyền";
            // 
            // txtFullName
            // 
            txtFullName.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtFullName.Location = new Point(549, 162);
            txtFullName.Margin = new Padding(4);
            txtFullName.Multiline = true;
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(346, 30);
            txtFullName.TabIndex = 34;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 14F);
            label3.Location = new Point(334, 159);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(97, 33);
            label3.TabIndex = 33;
            label3.Text = "Họ tên:";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtUsername.Location = new Point(549, 105);
            txtUsername.Margin = new Padding(4);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(346, 32);
            txtUsername.TabIndex = 32;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14F);
            label2.Location = new Point(334, 101);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(191, 33);
            label2.TabIndex = 31;
            label2.Text = "Tên người dùng";
            // 
            // UserUpdatePage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1689, 705);
            Controls.Add(txtPhoneNumber);
            Controls.Add(label8);
            Controls.Add(cbUserRole);
            Controls.Add(label4);
            Controls.Add(txtFullName);
            Controls.Add(label3);
            Controls.Add(txtUsername);
            Controls.Add(label2);
            Controls.Add(BackBtn);
            Controls.Add(ResetBtn);
            Controls.Add(SaveBtn);
            Controls.Add(label1);
            Margin = new Padding(4);
            Name = "UserUpdatePage";
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
        private TextBox txtPhoneNumber;
        private Label label8;
        private ComboBox cbUserRole;
        private Label label4;
        private TextBox txtFullName;
        private Label label3;
        private TextBox txtUsername;
        private Label label2;
    }
}