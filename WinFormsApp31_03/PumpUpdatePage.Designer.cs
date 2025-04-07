namespace WinFormsApp31_03
{
    partial class PumpUpdatePage
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
            cbStatus = new ComboBox();
            label6 = new Label();
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14F);
            label2.Location = new Point(0, 93);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(72, 33);
            label2.TabIndex = 11;
            label2.Text = "Tên :";
            // 
            // txtName
            // 
            txtName.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtName.Location = new Point(132, 94);
            txtName.Margin = new Padding(4);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.Size = new Size(346, 32);
            txtName.TabIndex = 12;
            txtName.TextChanged += CheckEnableReset;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 14F);
            label3.Location = new Point(0, 151);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(135, 33);
            label3.TabIndex = 13;
            label3.Text = "Công suất:";
            // 
            // txtCapacity
            // 
            txtCapacity.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtCapacity.Location = new Point(132, 151);
            txtCapacity.Margin = new Padding(4);
            txtCapacity.Multiline = true;
            txtCapacity.Name = "txtCapacity";
            txtCapacity.Size = new Size(346, 30);
            txtCapacity.TabIndex = 14;
            txtCapacity.TextChanged += CheckEnableReset;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 14F);
            label4.Location = new Point(0, 211);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(80, 33);
            label4.TabIndex = 15;
            label4.Text = "Loại: ";
            // 
            // cbPumpType
            // 
            cbPumpType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPumpType.FormattingEnabled = true;
            cbPumpType.Location = new Point(132, 214);
            cbPumpType.Name = "cbPumpType";
            cbPumpType.Size = new Size(346, 33);
            cbPumpType.TabIndex = 22;
            // 
            // cbStation
            // 
            cbStation.DropDownStyle = ComboBoxStyle.DropDownList;
            cbStation.FormattingEnabled = true;
            cbStation.Location = new Point(696, 215);
            cbStation.Name = "cbStation";
            cbStation.Size = new Size(346, 33);
            cbStation.TabIndex = 28;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 14F);
            label5.Location = new Point(512, 215);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(135, 33);
            label5.TabIndex = 27;
            label5.Text = "Trạm bơm:";
            // 
            // txtSerialNumber
            // 
            txtSerialNumber.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtSerialNumber.Location = new Point(696, 152);
            txtSerialNumber.Margin = new Padding(4);
            txtSerialNumber.Multiline = true;
            txtSerialNumber.Name = "txtSerialNumber";
            txtSerialNumber.Size = new Size(346, 30);
            txtSerialNumber.TabIndex = 26;
            txtSerialNumber.TextChanged += CheckEnableReset;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Times New Roman", 14F);
            label11.Location = new Point(512, 151);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(100, 33);
            label11.TabIndex = 25;
            label11.Text = "Số seri:";
            // 
            // txtManufracture
            // 
            txtManufracture.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtManufracture.Location = new Point(696, 95);
            txtManufracture.Margin = new Padding(4);
            txtManufracture.Multiline = true;
            txtManufracture.Name = "txtManufracture";
            txtManufracture.Size = new Size(346, 32);
            txtManufracture.TabIndex = 24;
            txtManufracture.TextChanged += CheckEnableReset;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 14F);
            label7.Location = new Point(512, 94);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(168, 33);
            label7.TabIndex = 23;
            label7.Text = "Nhà sản xuất;";
            // 
            // txtDescription
            // 
            txtDescription.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtDescription.Location = new Point(132, 276);
            txtDescription.Margin = new Padding(4);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(346, 137);
            txtDescription.TabIndex = 30;
            txtDescription.TextChanged += CheckEnableReset;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 14F);
            label8.Location = new Point(0, 276);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(81, 33);
            label8.TabIndex = 29;
            label8.Text = "Mô tả";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 14F);
            label9.Location = new Point(512, 273);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(121, 33);
            label9.TabIndex = 31;
            label9.Text = "Bảo hành";
            // 
            // dpGuarantee
            // 
            dpGuarantee.CustomFormat = "dddd, dd 'tháng' MM 'năm' yyyy";
            dpGuarantee.Location = new Point(696, 278);
            dpGuarantee.Name = "dpGuarantee";
            dpGuarantee.Size = new Size(346, 31);
            dpGuarantee.TabIndex = 32;
            // 
            // cbStatus
            // 
            cbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cbStatus.FormattingEnabled = true;
            cbStatus.Location = new Point(696, 338);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(346, 33);
            cbStatus.TabIndex = 34;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 14F);
            label6.Location = new Point(512, 338);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(127, 33);
            label6.TabIndex = 33;
            label6.Text = "Trạng thái";
            // 
            // PumpUpdatePage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1689, 705);
            Controls.Add(cbStatus);
            Controls.Add(label6);
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
            Margin = new Padding(4);
            Name = "PumpUpdatePage";
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
        private ComboBox cbStatus;
        private Label label6;
    }
}