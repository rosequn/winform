namespace WinFormsApp31_03
{
    partial class PumpCreatePage
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
            txtName = new TextBox();
            label3 = new Label();
            txtCapacity = new TextBox();
            label4 = new Label();
            cbPumpType = new ComboBox();
            cbStation = new ComboBox();
            label5 = new Label();
            txtSerialNumber = new TextBox();
            label11 = new Label();
            txtManufracture = new TextBox();
            label7 = new Label();
            txtDescription = new TextBox();
            label8 = new Label();
            label9 = new Label();
            dpGuarantee = new DateTimePicker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.Location = new Point(337, 9);
            label1.Name = "label1";
            label1.Size = new Size(265, 35);
            label1.TabIndex = 0;
            label1.Text = "THÊM MÁY BƠM";
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
            ResetBtn.Location = new Point(337, 352);
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
            SaveBtn.Location = new Point(513, 352);
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
            BackBtn.Location = new Point(161, 352);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(158, 63);
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
            label2.Location = new Point(12, 82);
            label2.Name = "label2";
            label2.Size = new Size(61, 27);
            label2.TabIndex = 11;
            label2.Text = "Tên :";
            // 
            // txtName
            // 
            txtName.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtName.Location = new Point(125, 74);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.Size = new Size(300, 35);
            txtName.TabIndex = 12;
            txtName.TextChanged += CheckEnableReset;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 14F);
            label3.Location = new Point(12, 129);
            label3.Name = "label3";
            label3.Size = new Size(114, 27);
            label3.TabIndex = 13;
            label3.Text = "Công suất:";
            // 
            // txtCapacity
            // 
            txtCapacity.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtCapacity.Location = new Point(125, 120);
            txtCapacity.Multiline = true;
            txtCapacity.Name = "txtCapacity";
            txtCapacity.Size = new Size(300, 35);
            txtCapacity.TabIndex = 14;
            txtCapacity.TextChanged += CheckEnableReset;
            txtCapacity.KeyPress += CheckTextBox.Number_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 14F);
            label4.Location = new Point(12, 176);
            label4.Name = "label4";
            label4.Size = new Size(68, 27);
            label4.TabIndex = 15;
            label4.Text = "Loại: ";
            // 
            // cbPumpType
            // 
            cbPumpType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPumpType.FormattingEnabled = true;
            cbPumpType.Location = new Point(125, 170);
            cbPumpType.Margin = new Padding(2);
            cbPumpType.Name = "cbPumpType";
            cbPumpType.Size = new Size(300, 28);
            cbPumpType.TabIndex = 22;
            // 
            // cbStation
            // 
            cbStation.DropDownStyle = ComboBoxStyle.DropDownList;
            cbStation.FormattingEnabled = true;
            cbStation.Location = new Point(594, 172);
            cbStation.Margin = new Padding(2);
            cbStation.Name = "cbStation";
            cbStation.Size = new Size(300, 28);
            cbStation.TabIndex = 28;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 14F);
            label5.Location = new Point(443, 173);
            label5.Name = "label5";
            label5.Size = new Size(117, 27);
            label5.TabIndex = 27;
            label5.Text = "Trạm bơm:";
            // 
            // txtSerialNumber
            // 
            txtSerialNumber.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtSerialNumber.Location = new Point(594, 120);
            txtSerialNumber.Multiline = true;
            txtSerialNumber.Name = "txtSerialNumber";
            txtSerialNumber.Size = new Size(300, 35);
            txtSerialNumber.TabIndex = 26;
            txtSerialNumber.TextChanged += CheckEnableReset;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Times New Roman", 14F);
            label11.Location = new Point(443, 123);
            label11.Name = "label11";
            label11.Size = new Size(82, 27);
            label11.TabIndex = 25;
            label11.Text = "Số seri:";
            // 
            // txtManufracture
            // 
            txtManufracture.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtManufracture.Location = new Point(594, 70);
            txtManufracture.Multiline = true;
            txtManufracture.Name = "txtManufracture";
            txtManufracture.Size = new Size(300, 35);
            txtManufracture.TabIndex = 24;
            txtManufracture.TextChanged += CheckEnableReset;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 14F);
            label7.Location = new Point(443, 73);
            label7.Name = "label7";
            label7.Size = new Size(145, 27);
            label7.TabIndex = 23;
            label7.Text = "Nhà sản xuất;";
            // 
            // txtDescription
            // 
            txtDescription.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtDescription.Location = new Point(125, 220);
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
            label8.Location = new Point(12, 223);
            label8.Name = "label8";
            label8.Size = new Size(69, 27);
            label8.TabIndex = 29;
            label8.Text = "Mô tả";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 14F);
            label9.Location = new Point(443, 223);
            label9.Name = "label9";
            label9.Size = new Size(104, 27);
            label9.TabIndex = 31;
            label9.Text = "Bảo hành";
            // 
            // dpGuarantee
            // 
            dpGuarantee.CustomFormat = "dddd, dd 'tháng' MM 'năm' yyyy";
            dpGuarantee.Location = new Point(594, 222);
            dpGuarantee.Margin = new Padding(2);
            dpGuarantee.Name = "dpGuarantee";
            dpGuarantee.Size = new Size(300, 27);
            dpGuarantee.TabIndex = 32;
            // 
            // PumpCreatePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(908, 421);
            Controls.Add(dpGuarantee);
            Controls.Add(label9);
            Controls.Add(txtDescription);
            Controls.Add(label8);
            Controls.Add(cbStation);
            Controls.Add(label5);
            Controls.Add(txtSerialNumber);
            Controls.Add(label11);
            Controls.Add(txtManufracture);
            Controls.Add(label7);
            Controls.Add(cbPumpType);
            Controls.Add(BackBtn);
            Controls.Add(ResetBtn);
            Controls.Add(SaveBtn);
            Controls.Add(label4);
            Controls.Add(txtCapacity);
            Controls.Add(label3);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "PumpCreatePage";
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
        private TextBox txtName;
        private Label label3;
        private TextBox txtCapacity;
        private Label label4;
        private ComboBox cbPumpType;
        private ComboBox cbStation;
        private Label label5;
        private TextBox txtSerialNumber;
        private Label label11;
        private TextBox txtManufracture;
        private Label label7;
        private TextBox txtDescription;
        private Label label8;
        private Label label9;
        private DateTimePicker dpGuarantee;
    }
}