using WinFormsApp31_03.Models;

namespace WinFormsApp31_03
{
    partial class StationPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StationPage));
            label1 = new Label();
            dgStation = new DataGridView();
            StationId = new DataGridViewTextBoxColumn();
            StationName = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            Location = new DataGridViewTextBoxColumn();
            StatusName = new DataGridViewTextBoxColumn();
            LoadBtn = new CustomButton();
            UpdateBtn = new CustomButton();
            CreateBtn = new CustomButton();
            DeleteBtn = new CustomButton();
            panel1 = new Panel();
            txtSearch = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgStation).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.Location = new Point(26, 55);
            label1.Name = "label1";
            label1.Size = new Size(373, 35);
            label1.TabIndex = 0;
            label1.Text = "DANH SÁCH TRẠM BƠM";
            // 
            // dgStation
            // 
            dgStation.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgStation.Columns.AddRange(new DataGridViewColumn[] { StationId, StationName, Description, Location, StatusName });
            dgStation.Location = new Point(26, 107);
            dgStation.Margin = new Padding(2);
            dgStation.Name = "dgStation";
            dgStation.ReadOnly = true;
            dgStation.RowHeadersWidth = 62;
            dgStation.Size = new Size(816, 279);
            dgStation.TabIndex = 1;
            dgStation.DoubleClick += dgStation_DoubleClick;
            // 
            // StationId
            // 
            StationId.DataPropertyName = "StationId";
            StationId.HeaderText = "Mã";
            StationId.MinimumWidth = 8;
            StationId.Name = "StationId";
            StationId.ReadOnly = true;
            StationId.Width = 150;
            // 
            // StationName
            // 
            StationName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            StationName.DataPropertyName = "StationName";
            StationName.HeaderText = "Tên";
            StationName.MinimumWidth = 8;
            StationName.Name = "StationName";
            StationName.ReadOnly = true;
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
            // Location
            // 
            Location.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Location.DataPropertyName = "Location";
            Location.HeaderText = "Vị trí";
            Location.MinimumWidth = 100;
            Location.Name = "Location";
            Location.ReadOnly = true;
            // 
            // StatusName
            // 
            StatusName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            StatusName.DataPropertyName = "StatusName";
            StatusName.HeaderText = "Trạng thái";
            StatusName.MinimumWidth = 8;
            StatusName.Name = "StatusName";
            StatusName.ReadOnly = true;
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
            LoadBtn.Location = new Point(85, 406);
            LoadBtn.Margin = new Padding(2);
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
            UpdateBtn.BorderRadius = 20;
            UpdateBtn.BorderSize = 0;
            UpdateBtn.FlatStyle = FlatStyle.Flat;
            UpdateBtn.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 163);
            UpdateBtn.ForeColor = Color.White;
            UpdateBtn.Location = new Point(441, 406);
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
            CreateBtn.Location = new Point(263, 406);
            CreateBtn.Name = "CreateBtn";
            CreateBtn.Size = new Size(158, 63);
            CreateBtn.TabIndex = 17;
            CreateBtn.Text = "Thêm";
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
            DeleteBtn.Location = new Point(619, 406);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(158, 63);
            DeleteBtn.TabIndex = 20;
            DeleteBtn.Text = "Xóa";
            DeleteBtn.TextColor = Color.White;
            DeleteBtn.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(txtSearch);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(569, 53);
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
            // StationPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(852, 496);
            Controls.Add(panel1);
            Controls.Add(DeleteBtn);
            Controls.Add(UpdateBtn);
            Controls.Add(CreateBtn);
            Controls.Add(LoadBtn);
            Controls.Add(dgStation);
            Controls.Add(label1);
            Name = "StationPage";
            Text = "Quản lý trạm bơm";
            ((System.ComponentModel.ISupportInitialize)dgStation).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgStation;
        private CustomButton LoadBtn;
        private CustomButton UpdateBtn;
        private CustomButton CreateBtn;
        private CustomButton DeleteBtn;
        private DataGridViewTextBoxColumn StationId;
        private DataGridViewTextBoxColumn StationName;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn Location;
        private DataGridViewTextBoxColumn StatusName;
        private Panel panel1;
        private TextBox txtSearch;
        private PictureBox pictureBox1;
    }
}