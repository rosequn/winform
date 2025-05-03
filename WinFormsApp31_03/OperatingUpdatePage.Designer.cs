namespace WinFormsApp31_03
{
    partial class OperatingUpdatePage
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
            txtFlowRate = new TextBox();
            label3 = new Label();
            txtPressure = new TextBox();
            cbPump = new ComboBox();
            label5 = new Label();
            txtTemperature = new TextBox();
            label11 = new Label();
            txtConsumption = new TextBox();
            label7 = new Label();
            label9 = new Label();
            dpRecord = new DateTimePicker();
            txtRunningHours = new TextBox();
            label4 = new Label();
            txtEfficiency = new TextBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.Location = new Point(314, 26);
            label1.Name = "label1";
            label1.Size = new Size(411, 35);
            label1.TabIndex = 0;
            label1.Text = "THÊM DỮ LIỆU VẬN HÀNH";
            // 
            // ResetBtn
            // 
            ResetBtn.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 163);
            ResetBtn.Location = new Point(409, 293);
            ResetBtn.Name = "ResetBtn";
            ResetBtn.Size = new Size(120, 40);
            ResetBtn.TabIndex = 19;
            ResetBtn.Text = "Đặt lại";
            ResetBtn.UseVisualStyleBackColor = true;
            ResetBtn.Click += ResetBtn_Click;
            // 
            // SaveBtn
            // 
            SaveBtn.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 163);
            SaveBtn.Location = new Point(222, 293);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(120, 40);
            SaveBtn.TabIndex = 17;
            SaveBtn.Text = "Lưu";
            SaveBtn.UseVisualStyleBackColor = true;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // BackBtn
            // 
            BackBtn.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 163);
            BackBtn.Location = new Point(596, 293);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(120, 40);
            BackBtn.TabIndex = 21;
            BackBtn.Text = "Quay lại";
            BackBtn.UseVisualStyleBackColor = true;
            BackBtn.Click += BackBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14F);
            label2.Location = new Point(0, 81);
            label2.Name = "label2";
            label2.Size = new Size(113, 27);
            label2.TabIndex = 11;
            label2.Text = "Lưu lượng";
            // 
            // txtFlowRate
            // 
            txtFlowRate.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtFlowRate.Location = new Point(119, 78);
            txtFlowRate.Multiline = true;
            txtFlowRate.Name = "txtFlowRate";
            txtFlowRate.Size = new Size(300, 35);
            txtFlowRate.TabIndex = 12;
            txtFlowRate.TextChanged += CheckEnableReset;
            txtFlowRate.KeyPress += CheckTextBox.Number_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 14F);
            label3.Location = new Point(0, 130);
            label3.Name = "label3";
            label3.Size = new Size(86, 27);
            label3.TabIndex = 13;
            label3.Text = "Áp suất";
            // 
            // txtPressure
            // 
            txtPressure.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtPressure.Location = new Point(119, 127);
            txtPressure.Multiline = true;
            txtPressure.Name = "txtPressure";
            txtPressure.Size = new Size(300, 35);
            txtPressure.TabIndex = 14;
            txtPressure.TextChanged += CheckEnableReset;
            txtPressure.KeyPress += CheckTextBox.Number_KeyPress;
            // 
            // cbPump
            // 
            cbPump.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPump.FormattingEnabled = true;
            cbPump.Location = new Point(661, 180);
            cbPump.Margin = new Padding(2, 2, 2, 2);
            cbPump.Name = "cbPump";
            cbPump.Size = new Size(300, 28);
            cbPump.TabIndex = 28;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 14F);
            label5.Location = new Point(450, 177);
            label5.Name = "label5";
            label5.Size = new Size(105, 27);
            label5.TabIndex = 27;
            label5.Text = "Máy bơm";
            // 
            // txtTemperature
            // 
            txtTemperature.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtTemperature.Location = new Point(661, 129);
            txtTemperature.Multiline = true;
            txtTemperature.Name = "txtTemperature";
            txtTemperature.Size = new Size(300, 35);
            txtTemperature.TabIndex = 26;
            txtTemperature.TextChanged += CheckEnableReset;
            txtTemperature.KeyPress += CheckTextBox.Number_KeyPress;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Times New Roman", 14F);
            label11.Location = new Point(450, 129);
            label11.Name = "label11";
            label11.Size = new Size(95, 27);
            label11.TabIndex = 25;
            label11.Text = "Nhiệt độ";
            // 
            // txtConsumption
            // 
            txtConsumption.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtConsumption.Location = new Point(661, 78);
            txtConsumption.Multiline = true;
            txtConsumption.Name = "txtConsumption";
            txtConsumption.Size = new Size(300, 35);
            txtConsumption.TabIndex = 24;
            txtConsumption.TextChanged += CheckEnableReset;
            txtConsumption.KeyPress += CheckTextBox.Number_KeyPress;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 14F);
            label7.Location = new Point(450, 81);
            label7.Name = "label7";
            label7.Size = new Size(187, 27);
            label7.TabIndex = 23;
            label7.Text = "Công suất tiêu thụ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 14F);
            label9.Location = new Point(450, 225);
            label9.Name = "label9";
            label9.Size = new Size(138, 27);
            label9.TabIndex = 31;
            label9.Text = "Thời gian ghi";
            // 
            // dpRecord
            // 
            dpRecord.CustomFormat = "dddd, dd 'tháng' MM 'năm' yyyy";
            dpRecord.Location = new Point(661, 224);
            dpRecord.Margin = new Padding(2, 2, 2, 2);
            dpRecord.Name = "dpRecord";
            dpRecord.Size = new Size(300, 27);
            dpRecord.TabIndex = 32;
            // 
            // txtRunningHours
            // 
            txtRunningHours.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtRunningHours.Location = new Point(119, 176);
            txtRunningHours.Multiline = true;
            txtRunningHours.Name = "txtRunningHours";
            txtRunningHours.Size = new Size(300, 35);
            txtRunningHours.TabIndex = 34;
            txtRunningHours.KeyPress += CheckTextBox.Number_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 14F);
            label4.Location = new Point(0, 179);
            label4.Name = "label4";
            label4.Size = new Size(112, 27);
            label4.TabIndex = 33;
            label4.Text = "Số giờ HD";
            // 
            // txtEfficiency
            // 
            txtEfficiency.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtEfficiency.Location = new Point(119, 225);
            txtEfficiency.Multiline = true;
            txtEfficiency.Name = "txtEfficiency";
            txtEfficiency.Size = new Size(300, 35);
            txtEfficiency.TabIndex = 36;
            txtEfficiency.KeyPress += CheckTextBox.Number_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 14F);
            label6.Location = new Point(0, 228);
            label6.Name = "label6";
            label6.Size = new Size(103, 27);
            label6.TabIndex = 35;
            label6.Text = "Hiệu suất";
            // 
            // OperatingUpdatePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(980, 358);
            Controls.Add(txtEfficiency);
            Controls.Add(label6);
            Controls.Add(txtRunningHours);
            Controls.Add(label4);
            Controls.Add(dpRecord);
            Controls.Add(label9);
            Controls.Add(cbPump);
            Controls.Add(label5);
            Controls.Add(txtTemperature);
            Controls.Add(label11);
            Controls.Add(txtConsumption);
            Controls.Add(label7);
            Controls.Add(BackBtn);
            Controls.Add(ResetBtn);
            Controls.Add(SaveBtn);
            Controls.Add(txtPressure);
            Controls.Add(label3);
            Controls.Add(txtFlowRate);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "OperatingUpdatePage";
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
        private TextBox txtFlowRate;
        private Label label3;
        private TextBox txtPressure;
        private ComboBox cbPump;
        private Label label5;
        private TextBox txtTemperature;
        private Label label11;
        private TextBox txtConsumption;
        private Label label7;
        private Label label9;
        private DateTimePicker dpRecord;
        private TextBox txtRunningHours;
        private Label label4;
        private TextBox txtEfficiency;
        private Label label6;
    }
}