using System.Windows.Forms;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PumpPage));
            label1 = new Label();
            dgPump = new DataGridView();
            PumpID = new DataGridViewTextBoxColumn();
            PumpName = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            PumpTypeName = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            Capacity = new DataGridViewTextBoxColumn();
            Manufacturer = new DataGridViewTextBoxColumn();
            SerialNumber = new DataGridViewTextBoxColumn();
            WarrantyExpireDate = new DataGridViewTextBoxColumn();
            LoadBtn = new CustomButton();
            UpdateBtn = new CustomButton();
            CreateBtn = new CustomButton();
            DeleteBtn = new CustomButton();
            cbStation = new ComboBox();
            label2 = new Label();
            txtSearch = new TextBox();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            ExportBtn = new CustomButton();
            ((System.ComponentModel.ISupportInitialize)dgPump).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.Location = new Point(541, 9);
            label1.Name = "label1";
            label1.Size = new Size(354, 35);
            label1.TabIndex = 0;
            label1.Text = "DANH SÁCH MÁY BƠM";
            // 
            // dgPump
            // 
            dgPump.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgPump.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgPump.Columns.AddRange(new DataGridViewColumn[] { PumpID, PumpName, Description, PumpTypeName, Status, Capacity, Manufacturer, SerialNumber, WarrantyExpireDate });
            dgPump.GridColor = SystemColors.ActiveBorder;
            dgPump.Location = new Point(50, 106);
            dgPump.Margin = new Padding(2);
            dgPump.Name = "dgPump";
            dgPump.ReadOnly = true;
            dgPump.RowHeadersWidth = 62;
            dgPump.RowTemplate.Height = 30;
            dgPump.Size = new Size(1265, 350);
            dgPump.TabIndex = 1;
            dgPump.DoubleClick += dgPump_DoubleClick;
            // 
            // PumpID
            // 
            PumpID.DataPropertyName = "PumpID";
            PumpID.HeaderText = "Mã";
            PumpID.MinimumWidth = 8;
            PumpID.Name = "PumpID";
            PumpID.ReadOnly = true;
            // 
            // PumpName
            // 
            PumpName.DataPropertyName = "PumpName";
            PumpName.HeaderText = "Tên";
            PumpName.MinimumWidth = 8;
            PumpName.Name = "PumpName";
            PumpName.ReadOnly = true;
            // 
            // Description
            // 
            Description.DataPropertyName = "Description";
            Description.HeaderText = "Mô tả";
            Description.MinimumWidth = 8;
            Description.Name = "Description";
            Description.ReadOnly = true;
            // 
            // PumpTypeName
            // 
            PumpTypeName.DataPropertyName = "PumpTypeName";
            PumpTypeName.HeaderText = "Loại Bơm";
            PumpTypeName.MinimumWidth = 8;
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
            // 
            // Capacity
            // 
            Capacity.DataPropertyName = "Capacity";
            Capacity.HeaderText = "Công suất";
            Capacity.MinimumWidth = 8;
            Capacity.Name = "Capacity";
            Capacity.ReadOnly = true;
            // 
            // Manufacturer
            // 
            Manufacturer.DataPropertyName = "Manufacturer";
            Manufacturer.HeaderText = "NSX";
            Manufacturer.MinimumWidth = 8;
            Manufacturer.Name = "Manufacturer";
            Manufacturer.ReadOnly = true;
            // 
            // SerialNumber
            // 
            SerialNumber.DataPropertyName = "SerialNumber";
            SerialNumber.HeaderText = "Số Seri";
            SerialNumber.MinimumWidth = 8;
            SerialNumber.Name = "SerialNumber";
            SerialNumber.ReadOnly = true;
            // 
            // WarrantyExpireDate
            // 
            WarrantyExpireDate.DataPropertyName = "WarrantyExpireDate";
            WarrantyExpireDate.HeaderText = "Hạn bảo hành";
            WarrantyExpireDate.MinimumWidth = 8;
            WarrantyExpireDate.Name = "WarrantyExpireDate";
            WarrantyExpireDate.ReadOnly = true;
            // 
            // LoadBtn
            // 
            LoadBtn.BackColor = Color.MediumSlateBlue;
            LoadBtn.BackgroundColor = Color.MediumSlateBlue;
            LoadBtn.BorderColor = Color.PaleVioletRed;
            LoadBtn.BorderRadius = 25;
            LoadBtn.BorderSize = 0;
            LoadBtn.FlatStyle = FlatStyle.Flat;
            LoadBtn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            LoadBtn.ForeColor = Color.White;
            LoadBtn.Location = new Point(153, 473);
            LoadBtn.Name = "LoadBtn";
            LoadBtn.Size = new Size(158, 63);
            LoadBtn.TabIndex = 2;
            LoadBtn.Text = "Làm mới";
            LoadBtn.TextColor = Color.White;
            LoadBtn.UseVisualStyleBackColor = true;
            LoadBtn.Click += LoadBtn_Click;
            // 
            // UpdateBtn
            // 
            UpdateBtn.BackColor = Color.MediumSlateBlue;
            UpdateBtn.BackgroundColor = Color.MediumSlateBlue;
            UpdateBtn.BorderColor = Color.PaleVioletRed;
            UpdateBtn.BorderRadius = 25;
            UpdateBtn.BorderSize = 0;
            UpdateBtn.FlatStyle = FlatStyle.Flat;
            UpdateBtn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            UpdateBtn.ForeColor = Color.White;
            UpdateBtn.Location = new Point(563, 473);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(158, 63);
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
            CreateBtn.BorderRadius = 25;
            CreateBtn.BorderSize = 0;
            CreateBtn.FlatStyle = FlatStyle.Flat;
            CreateBtn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            CreateBtn.ForeColor = Color.White;
            CreateBtn.Location = new Point(358, 473);
            CreateBtn.Name = "CreateBtn";
            CreateBtn.Size = new Size(158, 63);
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
            DeleteBtn.BorderRadius = 25;
            DeleteBtn.BorderSize = 0;
            DeleteBtn.FlatStyle = FlatStyle.Flat;
            DeleteBtn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            DeleteBtn.ForeColor = Color.White;
            DeleteBtn.Location = new Point(768, 473);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(158, 63);
            DeleteBtn.TabIndex = 20;
            DeleteBtn.Text = "Xóa";
            DeleteBtn.TextColor = Color.White;
            DeleteBtn.UseVisualStyleBackColor = true;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // cbStation
            // 
            cbStation.DropDownStyle = ComboBoxStyle.DropDownList;
            cbStation.FormattingEnabled = true;
            cbStation.Location = new Point(196, 50);
            cbStation.Margin = new Padding(2);
            cbStation.Name = "cbStation";
            cbStation.Size = new Size(193, 28);
            cbStation.TabIndex = 24;
            cbStation.SelectedIndexChanged += CbStation_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(50, 45);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(142, 33);
            label2.TabIndex = 23;
            label2.Text = "Trạm bơm :";
            // 
            // txtSearch
            // 
            txtSearch.BackColor = SystemColors.ActiveCaption;
            txtSearch.BorderStyle = BorderStyle.None;
            txtSearch.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(2, 7);
            txtSearch.Margin = new Padding(2);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(235, 23);
            txtSearch.TabIndex = 24;
            txtSearch.TextChanged += Search;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(txtSearch);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(948, 39);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(272, 37);
            panel1.TabIndex = 27;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(239, 2);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            // 
            // ExportBtn
            // 
            ExportBtn.BackColor = Color.MediumSlateBlue;
            ExportBtn.BackgroundColor = Color.MediumSlateBlue;
            ExportBtn.BorderColor = Color.PaleVioletRed;
            ExportBtn.BorderRadius = 25;
            ExportBtn.BorderSize = 0;
            ExportBtn.FlatStyle = FlatStyle.Flat;
            ExportBtn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            ExportBtn.ForeColor = Color.White;
            ExportBtn.Location = new Point(976, 473);
            ExportBtn.Name = "ExportBtn";
            ExportBtn.Size = new Size(158, 63);
            ExportBtn.TabIndex = 28;
            ExportBtn.Text = "Xuất Excel";
            ExportBtn.TextColor = Color.White;
            ExportBtn.UseVisualStyleBackColor = true;
            ExportBtn.Click += ExportBtn_Click;
            // 
            // PumpPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1322, 564);
            Controls.Add(ExportBtn);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(cbStation);
            Controls.Add(DeleteBtn);
            Controls.Add(UpdateBtn);
            Controls.Add(CreateBtn);
            Controls.Add(LoadBtn);
            Controls.Add(dgPump);
            Controls.Add(label1);
            Name = "PumpPage";
            Text = "Quản lý máy bơm";
            ((System.ComponentModel.ISupportInitialize)dgPump).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgPump;
        private CustomButton LoadBtn;
        private CustomButton UpdateBtn;
        private CustomButton CreateBtn;
        private CustomButton DeleteBtn;
        private CustomButton BackBtn;
        private ComboBox cbStation;
        private Label label2;
        private TextBox txtSearch;
        private Panel panel1;
        private PictureBox pictureBox1;
        private DataGridViewTextBoxColumn PumpID;
        private DataGridViewTextBoxColumn PumpName;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn PumpTypeName;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn Capacity;
        private DataGridViewTextBoxColumn Manufacturer;
        private DataGridViewTextBoxColumn SerialNumber;
        private DataGridViewTextBoxColumn WarrantyExpireDate;
        private CustomButton ExportBtn;
    }
}