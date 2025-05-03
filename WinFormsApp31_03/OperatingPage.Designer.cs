using WinFormsApp31_03.Models;

namespace WinFormsApp31_03
{
    partial class OperatingPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OperatingPage));
            dgOperating = new DataGridView();
            DataID = new DataGridViewTextBoxColumn();
            PumpName = new DataGridViewTextBoxColumn();
            RecordTime = new DataGridViewTextBoxColumn();
            FlowRate = new DataGridViewTextBoxColumn();
            Pressure = new DataGridViewTextBoxColumn();
            PowerConsumption = new DataGridViewTextBoxColumn();
            Temperature = new DataGridViewTextBoxColumn();
            RunningHours = new DataGridViewTextBoxColumn();
            Efficiency = new DataGridViewTextBoxColumn();
            LoadBtn = new CustomButton();
            UpdateBtn = new CustomButton();
            CreateBtn = new CustomButton();
            DeleteBtn = new CustomButton();
            label1 = new Label();
            label2 = new Label();
            cbStation = new ComboBox();
            panel1 = new Panel();
            txtSearch = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgOperating).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgOperating
            // 
            dgOperating.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgOperating.Columns.AddRange(new DataGridViewColumn[] { DataID, PumpName, RecordTime, FlowRate, Pressure, PowerConsumption, Temperature, RunningHours, Efficiency });
            dgOperating.Location = new Point(26, 91);
            dgOperating.Margin = new Padding(2);
            dgOperating.Name = "dgOperating";
            dgOperating.ReadOnly = true;
            dgOperating.RowHeadersWidth = 62;
            dgOperating.Size = new Size(1398, 237);
            dgOperating.TabIndex = 1;
            dgOperating.DoubleClick += dgOperating_DoubleClick;
            // 
            // DataID
            // 
            DataID.DataPropertyName = "DataID";
            DataID.HeaderText = "Mã";
            DataID.MinimumWidth = 8;
            DataID.Name = "DataID";
            DataID.ReadOnly = true;
            DataID.Width = 150;
            // 
            // PumpName
            // 
            PumpName.DataPropertyName = "PumpName";
            PumpName.HeaderText = "Máy bơm";
            PumpName.MinimumWidth = 8;
            PumpName.Name = "PumpName";
            PumpName.ReadOnly = true;
            PumpName.Width = 150;
            // 
            // RecordTime
            // 
            RecordTime.DataPropertyName = "RecordTime";
            RecordTime.HeaderText = "Thời gian ghi";
            RecordTime.MinimumWidth = 8;
            RecordTime.Name = "RecordTime";
            RecordTime.ReadOnly = true;
            RecordTime.Width = 150;
            // 
            // FlowRate
            // 
            FlowRate.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            FlowRate.DataPropertyName = "FlowRate";
            FlowRate.HeaderText = "Lưu lượng";
            FlowRate.MinimumWidth = 150;
            FlowRate.Name = "FlowRate";
            FlowRate.ReadOnly = true;
            // 
            // Pressure
            // 
            Pressure.DataPropertyName = "Pressure";
            Pressure.HeaderText = "Áp suất";
            Pressure.MinimumWidth = 8;
            Pressure.Name = "Pressure";
            Pressure.ReadOnly = true;
            Pressure.Width = 150;
            // 
            // PowerConsumption
            // 
            PowerConsumption.DataPropertyName = "PowerConsumption";
            PowerConsumption.HeaderText = "Công suất thiêu thụ";
            PowerConsumption.MinimumWidth = 8;
            PowerConsumption.Name = "PowerConsumption";
            PowerConsumption.ReadOnly = true;
            PowerConsumption.Width = 150;
            // 
            // Temperature
            // 
            Temperature.DataPropertyName = "Temperature";
            Temperature.HeaderText = "Nhiệt độ";
            Temperature.MinimumWidth = 8;
            Temperature.Name = "Temperature";
            Temperature.ReadOnly = true;
            Temperature.Width = 150;
            // 
            // RunningHours
            // 
            RunningHours.DataPropertyName = "RunningHours";
            RunningHours.HeaderText = "Số giờ hoạt động";
            RunningHours.MinimumWidth = 8;
            RunningHours.Name = "RunningHours";
            RunningHours.ReadOnly = true;
            RunningHours.Width = 150;
            // 
            // Efficiency
            // 
            Efficiency.DataPropertyName = "Efficiency";
            Efficiency.HeaderText = "Hiệu suất";
            Efficiency.MinimumWidth = 8;
            Efficiency.Name = "Efficiency";
            Efficiency.ReadOnly = true;
            Efficiency.Width = 150;
            // 
            // LoadBtn
            // 
            LoadBtn.BackColor = Color.MediumSlateBlue;
            LoadBtn.BackgroundColor = Color.MediumSlateBlue;
            LoadBtn.BorderColor = Color.PaleVioletRed;
            LoadBtn.BorderRadius = 20;
            LoadBtn.BorderSize = 0;
            LoadBtn.FlatStyle = FlatStyle.Flat;
            LoadBtn.ForeColor = Color.White;
            LoadBtn.Location = new Point(124, 360);
            LoadBtn.Margin = new Padding(2);
            LoadBtn.Name = "LoadBtn";
            LoadBtn.Size = new Size(158, 54);
            LoadBtn.TabIndex = 2;
            LoadBtn.Text = "Load Data";
            LoadBtn.TextColor = Color.White;
            LoadBtn.UseVisualStyleBackColor = true;
            LoadBtn.Click += LoadBtn_Click;
            // 
            // UpdateBtn
            // 
            UpdateBtn.BackColor = Color.MediumSlateBlue;
            UpdateBtn.BackgroundColor = Color.MediumSlateBlue;
            UpdateBtn.BorderColor = Color.PaleVioletRed;
            UpdateBtn.BorderRadius = 20;
            UpdateBtn.BorderSize = 0;
            UpdateBtn.FlatStyle = FlatStyle.Flat;
            UpdateBtn.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 163);
            UpdateBtn.ForeColor = Color.White;
            UpdateBtn.Location = new Point(572, 359);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(158, 54);
            UpdateBtn.TabIndex = 19;
            UpdateBtn.Text = "Sửa";
            UpdateBtn.TextColor = Color.White;
            UpdateBtn.UseVisualStyleBackColor = true;
            UpdateBtn.Click += UpdateBtn_Click;
            // 
            // CreateBtn
            // 
            CreateBtn.BackColor = Color.MediumSlateBlue;
            CreateBtn.BackgroundColor = Color.MediumSlateBlue;
            CreateBtn.BorderColor = Color.PaleVioletRed;
            CreateBtn.BorderRadius = 20;
            CreateBtn.BorderSize = 0;
            CreateBtn.FlatStyle = FlatStyle.Flat;
            CreateBtn.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 163);
            CreateBtn.ForeColor = Color.White;
            CreateBtn.Location = new Point(348, 359);
            CreateBtn.Name = "CreateBtn";
            CreateBtn.Size = new Size(158, 54);
            CreateBtn.TabIndex = 17;
            CreateBtn.Text = "+ Thêm";
            CreateBtn.TextColor = Color.White;
            CreateBtn.UseVisualStyleBackColor = true;
            CreateBtn.Click += CreateBtn_Click;
            // 
            // DeleteBtn
            // 
            DeleteBtn.BackColor = Color.MediumSlateBlue;
            DeleteBtn.BackgroundColor = Color.MediumSlateBlue;
            DeleteBtn.BorderColor = Color.PaleVioletRed;
            DeleteBtn.BorderRadius = 20;
            DeleteBtn.BorderSize = 0;
            DeleteBtn.FlatStyle = FlatStyle.Flat;
            DeleteBtn.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 163);
            DeleteBtn.ForeColor = Color.White;
            DeleteBtn.Location = new Point(796, 359);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(158, 54);
            DeleteBtn.TabIndex = 20;
            DeleteBtn.Text = "Xóa";
            DeleteBtn.TextColor = Color.White;
            DeleteBtn.UseVisualStyleBackColor = true;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.Location = new Point(530, 8);
            label1.Name = "label1";
            label1.Size = new Size(364, 35);
            label1.TabIndex = 0;
            label1.Text = "DANH SÁCH VẬN HÀNH";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 16.2F);
            label2.Location = new Point(26, 43);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(142, 33);
            label2.TabIndex = 25;
            label2.Text = "Trạm bơm :";
            // 
            // cbStation
            // 
            cbStation.DropDownStyle = ComboBoxStyle.DropDownList;
            cbStation.FormattingEnabled = true;
            cbStation.Location = new Point(185, 48);
            cbStation.Margin = new Padding(2);
            cbStation.Name = "cbStation";
            cbStation.Size = new Size(193, 25);
            cbStation.TabIndex = 24;
            cbStation.SelectedIndexChanged += CbStation_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(txtSearch);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(1065, 36);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(272, 31);
            panel1.TabIndex = 28;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = SystemColors.ActiveCaption;
            txtSearch.BorderStyle = BorderStyle.None;
            txtSearch.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(2, 6);
            txtSearch.Margin = new Padding(2);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(235, 23);
            txtSearch.TabIndex = 24;
            txtSearch.TextChanged += Search;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(239, 2);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 27);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            // 
            // OperatingPage
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1435, 441);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(cbStation);
            Controls.Add(DeleteBtn);
            Controls.Add(UpdateBtn);
            Controls.Add(CreateBtn);
            Controls.Add(LoadBtn);
            Controls.Add(dgOperating);
            Controls.Add(label1);
            Font = new Font("Microsoft Sans Serif", 8.25F);
            Name = "OperatingPage";
            Text = "Quản lý vận hành";
            ((System.ComponentModel.ISupportInitialize)dgOperating).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgOperating;
        private CustomButton LoadBtn;
        private CustomButton UpdateBtn;
        private CustomButton CreateBtn;
        private CustomButton DeleteBtn;
        private CustomButton BackBtn;
        private Label label1;
        private Label label2;
        private ComboBox cbStation;
        private DataGridViewTextBoxColumn DataID;
        private DataGridViewTextBoxColumn PumpName;
        private DataGridViewTextBoxColumn RecordTime;
        private DataGridViewTextBoxColumn FlowRate;
        private DataGridViewTextBoxColumn Pressure;
        private DataGridViewTextBoxColumn PowerConsumption;
        private DataGridViewTextBoxColumn Temperature;
        private DataGridViewTextBoxColumn RunningHours;
        private DataGridViewTextBoxColumn Efficiency;
        private Panel panel1;
        private TextBox txtSearch;
        private PictureBox pictureBox1;
    }
}