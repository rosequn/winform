namespace WinFormsApp31_03
{
    partial class PumpPage
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
            dgPump = new DataGridView();
            LoadBtn = new Button();
            UpdateBtn = new Button();
            CreateBtn = new Button();
            DeleteBtn = new Button();
            BackBtn = new Button();
            cbStation = new ComboBox();
            label2 = new Label();
            PumpID = new DataGridViewTextBoxColumn();
            PumpName = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            PumpTypeName = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            Capacity = new DataGridViewTextBoxColumn();
            Manufacturer = new DataGridViewTextBoxColumn();
            SerialNumber = new DataGridViewTextBoxColumn();
            WarrantyExpireDate = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgPump).BeginInit();
            SuspendLayout();
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
            // dgPump
            // 
            dgPump.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgPump.Columns.AddRange(new DataGridViewColumn[] { PumpID, PumpName, Description, PumpTypeName, Status, Capacity, Manufacturer, SerialNumber, WarrantyExpireDate });
            dgPump.Location = new Point(62, 132);
            dgPump.Name = "dgPump";
            dgPump.ReadOnly = true;
            dgPump.RowHeadersWidth = 62;
            dgPump.Size = new Size(1399, 349);
            dgPump.TabIndex = 1;
            dgPump.DoubleClick += dgPump_DoubleClick;
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
            // cbStation
            // 
            cbStation.DropDownStyle = ComboBoxStyle.DropDownList;
            cbStation.FormattingEnabled = true;
            cbStation.Location = new Point(33, 40);
            cbStation.Name = "cbStation";
            cbStation.Size = new Size(240, 33);
            cbStation.TabIndex = 22;
            cbStation.SelectedIndexChanged += CbStation_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 9);
            label2.Name = "label2";
            label2.Size = new Size(102, 25);
            label2.TabIndex = 23;
            label2.Text = "Trạm bơm :";
            // 
            // PumpID
            // 
            PumpID.DataPropertyName = "PumpID";
            PumpID.HeaderText = "Mã";
            PumpID.MinimumWidth = 8;
            PumpID.Name = "PumpID";
            PumpID.ReadOnly = true;
            PumpID.Width = 150;
            // 
            // PumpName
            // 
            PumpName.DataPropertyName = "PumpName";
            PumpName.HeaderText = "Tên";
            PumpName.MinimumWidth = 8;
            PumpName.Name = "PumpName";
            PumpName.ReadOnly = true;
            PumpName.Width = 150;
            // 
            // Description
            // 
            Description.DataPropertyName = "Description";
            Description.HeaderText = "Mô tả";
            Description.MinimumWidth = 8;
            Description.Name = "Description";
            Description.ReadOnly = true;
            Description.Width = 150;
            // 
            // PumpTypeName
            // 
            PumpTypeName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            PumpTypeName.DataPropertyName = "PumpTypeName";
            PumpTypeName.HeaderText = "Loại Bơm";
            PumpTypeName.MinimumWidth = 150;
            PumpTypeName.Name = "PumpTypeName";
            PumpTypeName.ReadOnly = true;
            // 
            // Status
            // 
            Status.DataPropertyName = "StatusName";
            Status.HeaderText = "Trạng thái";
            Status.MinimumWidth = 8;
            Status.Name = "Status";
            Status.ReadOnly = true;
            Status.Width = 150;
            // 
            // Capacity
            // 
            Capacity.DataPropertyName = "Capacity";
            Capacity.HeaderText = "Công suất";
            Capacity.MinimumWidth = 8;
            Capacity.Name = "Capacity";
            Capacity.ReadOnly = true;
            Capacity.Width = 150;
            // 
            // Manufacturer
            // 
            Manufacturer.DataPropertyName = "Manufacturer";
            Manufacturer.HeaderText = "NSX";
            Manufacturer.MinimumWidth = 8;
            Manufacturer.Name = "Manufacturer";
            Manufacturer.ReadOnly = true;
            Manufacturer.Width = 150;
            // 
            // SerialNumber
            // 
            SerialNumber.DataPropertyName = "SerialNumber";
            SerialNumber.HeaderText = "Số Seri";
            SerialNumber.MinimumWidth = 8;
            SerialNumber.Name = "SerialNumber";
            SerialNumber.ReadOnly = true;
            SerialNumber.Width = 150;
            // 
            // WarrantyExpireDate
            // 
            WarrantyExpireDate.DataPropertyName = "WarrantyExpireDate";
            WarrantyExpireDate.HeaderText = "Hạn bảo hành";
            WarrantyExpireDate.MinimumWidth = 8;
            WarrantyExpireDate.Name = "WarrantyExpireDate";
            WarrantyExpireDate.ReadOnly = true;
            WarrantyExpireDate.Width = 150;
            // 
            // PumpPage
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
            Controls.Add(dgPump);
            Controls.Add(label1);
            Margin = new Padding(4);
            Name = "PumpPage";
            Text = "Quản lý trạm bơm";
            ((System.ComponentModel.ISupportInitialize)dgPump).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgPump;
        private Button LoadBtn;
        private Button UpdateBtn;
        private Button CreateBtn;
        private Button DeleteBtn;
        private Button BackBtn;
        private ComboBox cbStation;
        private Label label2;
        private DataGridViewTextBoxColumn PumpID;
        private DataGridViewTextBoxColumn PumpName;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn PumpTypeName;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn Capacity;
        private DataGridViewTextBoxColumn Manufacturer;
        private DataGridViewTextBoxColumn SerialNumber;
        private DataGridViewTextBoxColumn WarrantyExpireDate;
    }
}