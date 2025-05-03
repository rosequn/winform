namespace WinFormsApp31_03
{
    partial class MaintainUpdatePage
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
            label4 = new Label();
            cbMaintainType = new ComboBox();
            cbPump = new ComboBox();
            label5 = new Label();
            txtDescription = new TextBox();
            label8 = new Label();
            dpEnd = new DateTimePicker();
            label2 = new Label();
            dpStart = new DateTimePicker();
            label9 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.Location = new Point(113, 9);
            label1.Name = "label1";
            label1.Size = new Size(388, 35);
            label1.TabIndex = 0;
            label1.Text = "SỬA THÔNG TIN BẢO TRÌ";
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
            ResetBtn.Location = new Point(196, 466);
            ResetBtn.Name = "ResetBtn";
            ResetBtn.Size = new Size(158, 63);
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
            SaveBtn.Location = new Point(7, 466);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(158, 63);
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
            BackBtn.Location = new Point(385, 466);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(158, 63);
            BackBtn.TabIndex = 21;
            BackBtn.Text = "Quay lại";
            BackBtn.TextColor = Color.White;
            BackBtn.UseVisualStyleBackColor = true;
            BackBtn.Click += BackBtn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 14F);
            label4.Location = new Point(7, 76);
            label4.Name = "label4";
            label4.Size = new Size(68, 27);
            label4.TabIndex = 15;
            label4.Text = "Loại: ";
            // 
            // cbMaintainType
            // 
            cbMaintainType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMaintainType.FormattingEnabled = true;
            cbMaintainType.Location = new Point(200, 75);
            cbMaintainType.Margin = new Padding(2);
            cbMaintainType.Name = "cbMaintainType";
            cbMaintainType.Size = new Size(300, 28);
            cbMaintainType.TabIndex = 22;
            // 
            // cbPump
            // 
            cbPump.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPump.FormattingEnabled = true;
            cbPump.Location = new Point(200, 281);
            cbPump.Margin = new Padding(2);
            cbPump.Name = "cbPump";
            cbPump.Size = new Size(300, 28);
            cbPump.TabIndex = 28;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 14F);
            label5.Location = new Point(7, 281);
            label5.Name = "label5";
            label5.Size = new Size(105, 27);
            label5.TabIndex = 27;
            label5.Text = "Máy bơm";
            // 
            // txtDescription
            // 
            txtDescription.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtDescription.Location = new Point(200, 137);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(300, 110);
            txtDescription.TabIndex = 30;
            txtDescription.TextChanged += CheckEnableReset;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 14F);
            label8.Location = new Point(7, 137);
            label8.Name = "label8";
            label8.Size = new Size(100, 27);
            label8.TabIndex = 29;
            label8.Text = "Nội dung";
            // 
            // dpEnd
            // 
            dpEnd.CustomFormat = "dddd, dd 'tháng' MM 'năm' yyyy";
            dpEnd.Location = new Point(200, 404);
            dpEnd.Margin = new Padding(2);
            dpEnd.Name = "dpEnd";
            dpEnd.Size = new Size(300, 27);
            dpEnd.TabIndex = 40;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14F);
            label2.Location = new Point(7, 405);
            label2.Name = "label2";
            label2.Size = new Size(147, 27);
            label2.TabIndex = 39;
            label2.Text = "Ngày kết thúc";
            // 
            // dpStart
            // 
            dpStart.CustomFormat = "dddd, dd 'tháng' MM 'năm' yyyy";
            dpStart.Location = new Point(200, 343);
            dpStart.Margin = new Padding(2);
            dpStart.Name = "dpStart";
            dpStart.Size = new Size(300, 27);
            dpStart.TabIndex = 38;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 14F);
            label9.Location = new Point(7, 344);
            label9.Name = "label9";
            label9.Size = new Size(140, 27);
            label9.TabIndex = 37;
            label9.Text = "Ngày bắt đầu";
            // 
            // MaintainUpdatePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(575, 538);
            Controls.Add(dpEnd);
            Controls.Add(label2);
            Controls.Add(dpStart);
            Controls.Add(label9);
            Controls.Add(txtDescription);
            Controls.Add(label8);
            Controls.Add(cbPump);
            Controls.Add(label5);
            Controls.Add(cbMaintainType);
            Controls.Add(BackBtn);
            Controls.Add(ResetBtn);
            Controls.Add(SaveBtn);
            Controls.Add(label4);
            Controls.Add(label1);
            Name = "MaintainUpdatePage";
            Text = "Quản lý trạm bơm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private CustomButton ResetBtn;
        private CustomButton SaveBtn;
        private CustomButton BackBtn;
        private Label label4;
        private ComboBox cbMaintainType;
        private ComboBox cbPump;
        private Label label5;
        private TextBox txtDescription;
        private Label label8;
        private DateTimePicker dpEnd;
        private Label label2;
        private DateTimePicker dpStart;
        private Label label9;
    }
}