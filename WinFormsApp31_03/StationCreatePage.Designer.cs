namespace WinFormsApp31_03
{
    partial class StationCreatePage
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
            txtDescription = new TextBox();
            label4 = new Label();
            txtLocation = new TextBox();
            label3 = new Label();
            txtName = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.Location = new Point(117, 9);
            label1.Name = "label1";
            label1.Size = new Size(284, 35);
            label1.TabIndex = 0;
            label1.Text = "THÊM TRẠM BƠM";
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
            // txtDescription
            // 
            txtDescription.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtDescription.Location = new Point(97, 134);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(300, 122);
            txtDescription.TabIndex = 27;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 14F);
            label4.Location = new Point(17, 138);
            label4.Name = "label4";
            label4.Size = new Size(81, 27);
            label4.TabIndex = 26;
            label4.Text = "Mô tả :";
            // 
            // txtLocation
            // 
            txtLocation.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtLocation.Location = new Point(97, 90);
            txtLocation.Multiline = true;
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new Size(300, 35);
            txtLocation.TabIndex = 25;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 14F);
            label3.Location = new Point(17, 89);
            label3.Name = "label3";
            label3.Size = new Size(73, 27);
            label3.TabIndex = 24;
            label3.Text = "Vị trí :";
            // 
            // txtName
            // 
            txtName.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtName.Location = new Point(97, 44);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.Size = new Size(300, 35);
            txtName.TabIndex = 23;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14F);
            label2.Location = new Point(17, 44);
            label2.Name = "label2";
            label2.Size = new Size(61, 27);
            label2.TabIndex = 22;
            label2.Text = "Tên :";
            // 
            // StationCreatePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(501, 329);
            Controls.Add(txtDescription);
            Controls.Add(label4);
            Controls.Add(txtLocation);
            Controls.Add(label3);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(BackBtn);
            Controls.Add(ResetBtn);
            Controls.Add(SaveBtn);
            Controls.Add(label1);
            Name = "StationCreatePage";
            Text = "Quản lý trạm bơm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private CustomButton ResetBtn;
        private CustomButton SaveBtn;
        private CustomButton BackBtn;
        private TextBox txtDescription;
        private Label label4;
        private TextBox txtLocation;
        private Label label3;
        private TextBox txtName;
        private Label label2;
    }
}