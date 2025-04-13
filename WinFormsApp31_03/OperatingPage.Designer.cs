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
            dgOperating = new DataGridView();
            LoadBtn = new Button();
            UpdateBtn = new Button();
            CreateBtn = new Button();
            DeleteBtn = new Button();
            BackBtn = new Button();
            label1 = new Label();
            label2 = new Label();
            cbStation = new ComboBox();
            DataID = new DataGridViewTextBoxColumn();
            PumpID = new DataGridViewTextBoxColumn();
            RecordTime = new DataGridViewTextBoxColumn();
            FlowRate = new DataGridViewTextBoxColumn();
            Pressure = new DataGridViewTextBoxColumn();
            PowerConsumption = new DataGridViewTextBoxColumn();
            Temperature = new DataGridViewTextBoxColumn();
            RunningHours = new DataGridViewTextBoxColumn();
            Efficiency = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgOperating).BeginInit();
            SuspendLayout();
            // 
            // dgOperating
            // 
            dgOperating.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgOperating.Columns.AddRange(new DataGridViewColumn[] { DataID, PumpID, RecordTime, FlowRate, Pressure, PowerConsumption, Temperature, RunningHours, Efficiency });
            dgOperating.Location = new Point(33, 134);
            dgOperating.Name = "dgOperating";
            dgOperating.ReadOnly = true;
            dgOperating.RowHeadersWidth = 62;
            dgOperating.Size = new Size(1399, 349);
            dgOperating.TabIndex = 1;
            dgOperating.DoubleClick += dgPump_DoubleClick;
            // 
            // LoadBtn
            // 
            LoadBtn.Location = new Point(351, 509);
            LoadBtn.Name = "LoadBtn";
            LoadBtn.Size = new Size(112, 34);
            LoadBtn.TabIndex = 2;
            LoadBtn.Text = "Load Data";
            LoadBtn.UseVisualStyleBackColor = true;
            LoadBtn.Click += LoadBtn_Click;
            // 
            // UpdateBtn
            // 
            UpdateBtn.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 163);
            UpdateBtn.Location = new Point(889, 75);
            UpdateBtn.Margin = new Padding(4);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(150, 50);
            UpdateBtn.TabIndex = 19;
            UpdateBtn.Text = "Sửa";
            UpdateBtn.UseVisualStyleBackColor = true;
            UpdateBtn.Click += UpdateBtn_Click;
            // 
            // CreateBtn
            // 
            CreateBtn.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 163);
            CreateBtn.Location = new Point(709, 75);
            CreateBtn.Margin = new Padding(4);
            CreateBtn.Name = "CreateBtn";
            CreateBtn.Size = new Size(150, 50);
            CreateBtn.TabIndex = 17;
            CreateBtn.Text = "+ Thêm";
            CreateBtn.UseVisualStyleBackColor = true;
            CreateBtn.Click += CreateBtn_Click;
            // 
            // DeleteBtn
            // 
            DeleteBtn.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 163);
            DeleteBtn.Location = new Point(1085, 75);
            DeleteBtn.Margin = new Padding(4);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(150, 50);
            DeleteBtn.TabIndex = 20;
            DeleteBtn.Text = "Xóa";
            DeleteBtn.UseVisualStyleBackColor = true;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // BackBtn
            // 
            BackBtn.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 163);
            BackBtn.Location = new Point(991, 521);
            BackBtn.Margin = new Padding(4);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(150, 50);
            BackBtn.TabIndex = 21;
            BackBtn.Text = "Quay lại";
            BackBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.Location = new Point(210, 76);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(424, 41);
            label1.TabIndex = 0;
            label1.Text = "DANH SÁCH MÁY BƠM";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 9);
            label2.Name = "label2";
            label2.Size = new Size(102, 25);
            label2.TabIndex = 25;
            label2.Text = "Trạm bơm :";
            // 
            // cbStation
            // 
            cbStation.DropDownStyle = ComboBoxStyle.DropDownList;
            cbStation.FormattingEnabled = true;
            cbStation.Location = new Point(33, 40);
            cbStation.Name = "cbStation";
            cbStation.Size = new Size(240, 33);
            cbStation.TabIndex = 24;
            cbStation.SelectedIndexChanged += CbStation_SelectedIndexChanged;
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
            // PumpID
            // 
            PumpID.DataPropertyName = "PumpID";
            PumpID.HeaderText = "Máy bơm";
            PumpID.MinimumWidth = 8;
            PumpID.Name = "PumpID";
            PumpID.ReadOnly = true;
            PumpID.Width = 150;
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
            // OperatingPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1492, 705);
            Controls.Add(label2);
            Controls.Add(cbStation);
            Controls.Add(BackBtn);
            Controls.Add(DeleteBtn);
            Controls.Add(UpdateBtn);
            Controls.Add(CreateBtn);
            Controls.Add(LoadBtn);
            Controls.Add(dgOperating);
            Controls.Add(label1);
            Margin = new Padding(4);
            Name = "OperatingPage";
            Text = "Quản lý trạm bơm";
            ((System.ComponentModel.ISupportInitialize)dgOperating).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgOperating;
        private Button LoadBtn;
        private Button UpdateBtn;
        private Button CreateBtn;
        private Button DeleteBtn;
        private Button BackBtn;
        private Label label1;
        private Label label2;
        private ComboBox cbStation;
        private DataGridViewTextBoxColumn DataID;
        private DataGridViewTextBoxColumn PumpID;
        private DataGridViewTextBoxColumn RecordTime;
        private DataGridViewTextBoxColumn FlowRate;
        private DataGridViewTextBoxColumn Pressure;
        private DataGridViewTextBoxColumn PowerConsumption;
        private DataGridViewTextBoxColumn Temperature;
        private DataGridViewTextBoxColumn RunningHours;
        private DataGridViewTextBoxColumn Efficiency;
    }
}