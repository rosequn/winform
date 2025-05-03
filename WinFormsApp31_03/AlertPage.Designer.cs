using WinFormsApp31_03.Models;

namespace WinFormsApp31_03
{
    partial class AlertPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlertPage));
            dgAlert = new DataGridView();
            AlertID = new DataGridViewTextBoxColumn();
            PumpName = new DataGridViewTextBoxColumn();
            AlertName = new DataGridViewTextBoxColumn();
            AlertMessage = new DataGridViewTextBoxColumn();
            StatusName = new DataGridViewTextBoxColumn();
            CreatedOn = new DataGridViewTextBoxColumn();
            ResolvedBy = new DataGridViewTextBoxColumn();
            ModifiedOn = new DataGridViewTextBoxColumn();
            LoadBtn = new CustomButton();
            UpdateBtn = new CustomButton();
            CreateBtn = new CustomButton();
            DeleteBtn = new CustomButton();
            label1 = new Label();
            label2 = new Label();
            cbStation = new ComboBox();
            IgnoredBtn = new CustomButton();
            ResolvedBtn = new CustomButton();
            panel1 = new Panel();
            txtSearch = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgAlert).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgAlert
            // 
            dgAlert.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgAlert.Columns.AddRange(new DataGridViewColumn[] { AlertID, PumpName, AlertName, AlertMessage, StatusName, CreatedOn, ResolvedBy, ModifiedOn });
            dgAlert.Location = new Point(26, 115);
            dgAlert.Margin = new Padding(2);
            dgAlert.Name = "dgAlert";
            dgAlert.ReadOnly = true;
            dgAlert.RowHeadersWidth = 62;
            dgAlert.Size = new Size(1256, 279);
            dgAlert.TabIndex = 1;
            dgAlert.DoubleClick += dgPump_DoubleClick;
            // 
            // AlertID
            // 
            AlertID.DataPropertyName = "AlertID";
            AlertID.HeaderText = "Mã";
            AlertID.MinimumWidth = 8;
            AlertID.Name = "AlertID";
            AlertID.ReadOnly = true;
            AlertID.Width = 150;
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
            // AlertName
            // 
            AlertName.DataPropertyName = "AlertName";
            AlertName.HeaderText = "Loại thông báo";
            AlertName.MinimumWidth = 8;
            AlertName.Name = "AlertName";
            AlertName.ReadOnly = true;
            AlertName.Width = 150;
            // 
            // AlertMessage
            // 
            AlertMessage.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            AlertMessage.DataPropertyName = "AlertMessage";
            AlertMessage.HeaderText = "Nội dung";
            AlertMessage.MinimumWidth = 150;
            AlertMessage.Name = "AlertMessage";
            AlertMessage.ReadOnly = true;
            // 
            // StatusName
            // 
            StatusName.DataPropertyName = "StatusName";
            StatusName.HeaderText = "Trạng thái";
            StatusName.MinimumWidth = 8;
            StatusName.Name = "StatusName";
            StatusName.ReadOnly = true;
            StatusName.Width = 150;
            // 
            // CreatedOn
            // 
            CreatedOn.DataPropertyName = "CreatedOn";
            CreatedOn.HeaderText = "Ngày tạo";
            CreatedOn.MinimumWidth = 8;
            CreatedOn.Name = "CreatedOn";
            CreatedOn.ReadOnly = true;
            CreatedOn.Width = 150;
            // 
            // ResolvedBy
            // 
            ResolvedBy.DataPropertyName = "ResolvedBy";
            ResolvedBy.HeaderText = "Người xử lý";
            ResolvedBy.MinimumWidth = 8;
            ResolvedBy.Name = "ResolvedBy";
            ResolvedBy.ReadOnly = true;
            ResolvedBy.Width = 150;
            // 
            // ModifiedOn
            // 
            ModifiedOn.DataPropertyName = "ModifiedOn";
            ModifiedOn.HeaderText = "Ngày xử lý";
            ModifiedOn.MinimumWidth = 8;
            ModifiedOn.Name = "ModifiedOn";
            ModifiedOn.ReadOnly = true;
            ModifiedOn.Width = 150;
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
            UpdateBtn.Location = new Point(1063, 429);
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
            CreateBtn.Location = new Point(659, 429);
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
            DeleteBtn.Location = new Point(861, 429);
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
            label1.Location = new Point(465, 23);
            label1.Name = "label1";
            label1.Size = new Size(387, 35);
            label1.TabIndex = 0;
            label1.Text = "DANH SÁCH THÔNG BÁO";
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
            // IgnoredBtn
            // 
            IgnoredBtn.BackColor = Color.MediumSlateBlue;
            IgnoredBtn.BackgroundColor = Color.MediumSlateBlue;
            IgnoredBtn.BorderColor = Color.PaleVioletRed;
            IgnoredBtn.BorderRadius = 20;
            IgnoredBtn.BorderSize = 0;
            IgnoredBtn.FlatStyle = FlatStyle.Flat;
            IgnoredBtn.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 163);
            IgnoredBtn.ForeColor = Color.White;
            IgnoredBtn.Location = new Point(457, 429);
            IgnoredBtn.Name = "IgnoredBtn";
            IgnoredBtn.Size = new Size(158, 63);
            IgnoredBtn.TabIndex = 27;
            IgnoredBtn.Text = "Bỏ qua";
            IgnoredBtn.TextColor = Color.White;
            IgnoredBtn.UseVisualStyleBackColor = true;
            IgnoredBtn.Click += IgnoredBtn_Click;
            // 
            // ResolvedBtn
            // 
            ResolvedBtn.BackColor = Color.MediumSlateBlue;
            ResolvedBtn.BackgroundColor = Color.MediumSlateBlue;
            ResolvedBtn.BorderColor = Color.PaleVioletRed;
            ResolvedBtn.BorderRadius = 20;
            ResolvedBtn.BorderSize = 0;
            ResolvedBtn.FlatStyle = FlatStyle.Flat;
            ResolvedBtn.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 163);
            ResolvedBtn.ForeColor = Color.White;
            ResolvedBtn.Location = new Point(255, 429);
            ResolvedBtn.Name = "ResolvedBtn";
            ResolvedBtn.Size = new Size(158, 63);
            ResolvedBtn.TabIndex = 26;
            ResolvedBtn.Text = "Đã xử lý";
            ResolvedBtn.TextColor = Color.White;
            ResolvedBtn.UseVisualStyleBackColor = true;
            ResolvedBtn.Click += ResolvedBtn_Click;
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
            // AlertPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1293, 564);
            Controls.Add(panel1);
            Controls.Add(IgnoredBtn);
            Controls.Add(ResolvedBtn);
            Controls.Add(label2);
            Controls.Add(cbStation);
            Controls.Add(DeleteBtn);
            Controls.Add(UpdateBtn);
            Controls.Add(CreateBtn);
            Controls.Add(LoadBtn);
            Controls.Add(dgAlert);
            Controls.Add(label1);
            Name = "AlertPage";
            Text = "Quản lý thông báo";
            ((System.ComponentModel.ISupportInitialize)dgAlert).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgAlert;
        private CustomButton LoadBtn;
        private CustomButton UpdateBtn;
        private CustomButton CreateBtn;
        private CustomButton DeleteBtn;
        private Label label1;
        private Label label2;
        private ComboBox cbStation;
        private CustomButton IgnoredBtn;
        private CustomButton ResolvedBtn;
        private DataGridViewTextBoxColumn AlertID;
        private DataGridViewTextBoxColumn PumpName;
        private DataGridViewTextBoxColumn AlertName;
        private DataGridViewTextBoxColumn AlertMessage;
        private DataGridViewTextBoxColumn StatusName;
        private DataGridViewTextBoxColumn CreatedOn;
        private DataGridViewTextBoxColumn ResolvedBy;
        private DataGridViewTextBoxColumn ModifiedOn;
        private Panel panel1;
        private TextBox txtSearch;
        private PictureBox pictureBox1;
    }
}