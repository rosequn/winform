using WinFormsApp31_03.Models;

namespace WinFormsApp31_03
{
    partial class MaintainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MaintainPage));
            dgMaintain = new DataGridView();
            MaintenanceID = new DataGridViewTextBoxColumn();
            PumpName = new DataGridViewTextBoxColumn();
            TypeName = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            StatusName = new DataGridViewTextBoxColumn();
            StartDate = new DataGridViewTextBoxColumn();
            EndDate = new DataGridViewTextBoxColumn();
            PerformedName = new DataGridViewTextBoxColumn();
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
            CompletedBtn = new CustomButton();
            ((System.ComponentModel.ISupportInitialize)dgMaintain).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgMaintain
            // 
            dgMaintain.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgMaintain.Columns.AddRange(new DataGridViewColumn[] { MaintenanceID, PumpName, TypeName, Description, StatusName, StartDate, EndDate, PerformedName });
            dgMaintain.Location = new Point(26, 115);
            dgMaintain.Margin = new Padding(2);
            dgMaintain.Name = "dgMaintain";
            dgMaintain.ReadOnly = true;
            dgMaintain.RowHeadersWidth = 62;
            dgMaintain.Size = new Size(1256, 279);
            dgMaintain.TabIndex = 1;
            dgMaintain.DoubleClick += dgPump_DoubleClick;
            // 
            // MaintenanceID
            // 
            MaintenanceID.DataPropertyName = "MaintenanceId";
            MaintenanceID.Frozen = true;
            MaintenanceID.HeaderText = "Mã";
            MaintenanceID.MinimumWidth = 8;
            MaintenanceID.Name = "MaintenanceID";
            MaintenanceID.ReadOnly = true;
            MaintenanceID.Width = 150;
            // 
            // PumpName
            // 
            PumpName.DataPropertyName = "PumpName";
            PumpName.Frozen = true;
            PumpName.HeaderText = "Máy bơm";
            PumpName.MinimumWidth = 8;
            PumpName.Name = "PumpName";
            PumpName.ReadOnly = true;
            PumpName.Width = 150;
            // 
            // TypeName
            // 
            TypeName.DataPropertyName = "TypeName";
            TypeName.Frozen = true;
            TypeName.HeaderText = "Loại";
            TypeName.MinimumWidth = 8;
            TypeName.Name = "TypeName";
            TypeName.ReadOnly = true;
            TypeName.Width = 150;
            // 
            // Description
            // 
            Description.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Description.DataPropertyName = "Description";
            Description.Frozen = true;
            Description.HeaderText = "Nội dung";
            Description.MinimumWidth = 150;
            Description.Name = "Description";
            Description.ReadOnly = true;
            Description.Width = 150;
            // 
            // StatusName
            // 
            StatusName.DataPropertyName = "StatusName";
            StatusName.Frozen = true;
            StatusName.HeaderText = "Trạng thái";
            StatusName.MinimumWidth = 8;
            StatusName.Name = "StatusName";
            StatusName.ReadOnly = true;
            StatusName.Width = 150;
            // 
            // StartDate
            // 
            StartDate.DataPropertyName = "StartDate";
            StartDate.HeaderText = "Ngày bắt đầu";
            StartDate.MinimumWidth = 8;
            StartDate.Name = "StartDate";
            StartDate.ReadOnly = true;
            StartDate.Width = 150;
            // 
            // EndDate
            // 
            EndDate.DataPropertyName = "EndDate";
            EndDate.HeaderText = "Ngày kết thúc";
            EndDate.MinimumWidth = 8;
            EndDate.Name = "EndDate";
            EndDate.ReadOnly = true;
            EndDate.Width = 150;
            // 
            // PerformedName
            // 
            PerformedName.DataPropertyName = "PerformedName";
            PerformedName.HeaderText = "Người xử lý";
            PerformedName.MinimumWidth = 8;
            PerformedName.Name = "PerformedName";
            PerformedName.ReadOnly = true;
            PerformedName.Width = 150;
            // 
            // LoadBtn
            // 
            LoadBtn.BackColor = Color.MediumSlateBlue;
            LoadBtn.BackgroundColor = Color.MediumSlateBlue;
            LoadBtn.BorderColor = Color.PaleVioletRed;
            LoadBtn.BorderRadius = 20;
            LoadBtn.BorderSize = 0;
            LoadBtn.FlatStyle = FlatStyle.Flat;
            LoadBtn.Font = new Font("Times New Roman", 13.2000008F);
            LoadBtn.ForeColor = Color.White;
            LoadBtn.Location = new Point(53, 429);
            LoadBtn.Margin = new Padding(2);
            LoadBtn.Name = "LoadBtn";
            LoadBtn.Size = new Size(158, 63);
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
            UpdateBtn.Location = new Point(692, 429);
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
            CreateBtn.BorderRadius = 20;
            CreateBtn.BorderSize = 0;
            CreateBtn.FlatStyle = FlatStyle.Flat;
            CreateBtn.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 163);
            CreateBtn.ForeColor = Color.White;
            CreateBtn.Location = new Point(266, 429);
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
            DeleteBtn.BorderRadius = 20;
            DeleteBtn.BorderSize = 0;
            DeleteBtn.FlatStyle = FlatStyle.Flat;
            DeleteBtn.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 163);
            DeleteBtn.ForeColor = Color.White;
            DeleteBtn.Location = new Point(479, 429);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(158, 63);
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
            label1.Location = new Point(529, 20);
            label1.Name = "label1";
            label1.Size = new Size(275, 35);
            label1.TabIndex = 0;
            label1.Text = "LỊCH SỬ BẢO TRÌ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 16.2F);
            label2.Location = new Point(26, 57);
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
            cbStation.Location = new Point(172, 58);
            cbStation.Margin = new Padding(2);
            cbStation.Name = "cbStation";
            cbStation.Size = new Size(193, 28);
            cbStation.TabIndex = 24;
            cbStation.SelectedIndexChanged += CbStation_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(txtSearch);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(1010, 49);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(272, 37);
            panel1.TabIndex = 28;
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
            // CompletedBtn
            // 
            CompletedBtn.BackColor = Color.MediumSlateBlue;
            CompletedBtn.BackgroundColor = Color.MediumSlateBlue;
            CompletedBtn.BorderColor = Color.PaleVioletRed;
            CompletedBtn.BorderRadius = 20;
            CompletedBtn.BorderSize = 0;
            CompletedBtn.FlatStyle = FlatStyle.Flat;
            CompletedBtn.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 163);
            CompletedBtn.ForeColor = Color.White;
            CompletedBtn.Location = new Point(891, 429);
            CompletedBtn.Name = "CompletedBtn";
            CompletedBtn.Size = new Size(158, 63);
            CompletedBtn.TabIndex = 29;
            CompletedBtn.Text = "Đã bảo trì";
            CompletedBtn.TextColor = Color.White;
            CompletedBtn.UseVisualStyleBackColor = true;
            CompletedBtn.Click += CompletedBtn_Click;
            // 
            // MaintainPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1293, 564);
            Controls.Add(CompletedBtn);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(cbStation);
            Controls.Add(DeleteBtn);
            Controls.Add(UpdateBtn);
            Controls.Add(CreateBtn);
            Controls.Add(LoadBtn);
            Controls.Add(dgMaintain);
            Controls.Add(label1);
            Name = "MaintainPage";
            Text = "Quản lý thông báo";
            ((System.ComponentModel.ISupportInitialize)dgMaintain).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgMaintain;
        private CustomButton LoadBtn;
        private CustomButton UpdateBtn;
        private CustomButton CreateBtn;
        private CustomButton DeleteBtn;
        private Label label1;
        private Label label2;
        private ComboBox cbStation;
        private Panel panel1;
        private TextBox txtSearch;
        private PictureBox pictureBox1;
        private DataGridViewTextBoxColumn MaintenanceID;
        private DataGridViewTextBoxColumn PumpName;
        private DataGridViewTextBoxColumn TypeName;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn StatusName;
        private DataGridViewTextBoxColumn StartDate;
        private DataGridViewTextBoxColumn EndDate;
        private DataGridViewTextBoxColumn PerformedName;
        private CustomButton CompletedBtn;
    }
}