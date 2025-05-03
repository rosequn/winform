using WinFormsApp31_03.Models;

namespace WinFormsApp31_03
{
    partial class UserPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserPage));
            label1 = new Label();
            dgUser = new DataGridView();
            UserID = new DataGridViewTextBoxColumn();
            Username = new DataGridViewTextBoxColumn();
            FullName = new DataGridViewTextBoxColumn();
            PhoneNumber = new DataGridViewTextBoxColumn();
            RoleName = new DataGridViewTextBoxColumn();
            LoadBtn = new CustomButton();
            UpdateBtn = new CustomButton();
            CreateBtn = new CustomButton();
            DeleteBtn = new CustomButton();
            panel1 = new Panel();
            txtSearch = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgUser).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.Location = new Point(50, 45);
            label1.Name = "label1";
            label1.Size = new Size(404, 35);
            label1.TabIndex = 0;
            label1.Text = "DANH SÁCH NGƯỜI DÙNG";
            // 
            // dgUser
            // 
            dgUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgUser.Columns.AddRange(new DataGridViewColumn[] { UserID, Username, FullName, PhoneNumber, RoleName });
            dgUser.Location = new Point(50, 106);
            dgUser.Margin = new Padding(2);
            dgUser.Name = "dgUser";
            dgUser.ReadOnly = true;
            dgUser.RowHeadersWidth = 62;
            dgUser.Size = new Size(782, 279);
            dgUser.TabIndex = 1;
            dgUser.DoubleClick += dgPump_DoubleClick;
            // 
            // UserID
            // 
            UserID.DataPropertyName = "UserID";
            UserID.HeaderText = "Mã";
            UserID.MinimumWidth = 8;
            UserID.Name = "UserID";
            UserID.ReadOnly = true;
            UserID.Width = 150;
            // 
            // Username
            // 
            Username.DataPropertyName = "Username";
            Username.HeaderText = "Tên người dùng";
            Username.MinimumWidth = 8;
            Username.Name = "Username";
            Username.ReadOnly = true;
            Username.Width = 150;
            // 
            // FullName
            // 
            FullName.DataPropertyName = "FullName";
            FullName.HeaderText = "Họ tên";
            FullName.MinimumWidth = 8;
            FullName.Name = "FullName";
            FullName.ReadOnly = true;
            FullName.Width = 150;
            // 
            // PhoneNumber
            // 
            PhoneNumber.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            PhoneNumber.DataPropertyName = "PhoneNumber";
            PhoneNumber.HeaderText = "SDT";
            PhoneNumber.MinimumWidth = 150;
            PhoneNumber.Name = "PhoneNumber";
            PhoneNumber.ReadOnly = true;
            // 
            // RoleName
            // 
            RoleName.DataPropertyName = "RoleName";
            RoleName.HeaderText = "Quyền";
            RoleName.MinimumWidth = 8;
            RoleName.Name = "RoleName";
            RoleName.ReadOnly = true;
            RoleName.Width = 150;
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
            LoadBtn.Location = new Point(50, 390);
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
            UpdateBtn.Location = new Point(434, 390);
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
            CreateBtn.Location = new Point(242, 390);
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
            DeleteBtn.Location = new Point(626, 390);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(158, 63);
            DeleteBtn.TabIndex = 20;
            DeleteBtn.Text = "Xóa";
            DeleteBtn.TextColor = Color.White;
            DeleteBtn.UseVisualStyleBackColor = true;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(txtSearch);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(560, 46);
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
            // UserPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(850, 465);
            Controls.Add(panel1);
            Controls.Add(DeleteBtn);
            Controls.Add(UpdateBtn);
            Controls.Add(CreateBtn);
            Controls.Add(LoadBtn);
            Controls.Add(dgUser);
            Controls.Add(label1);
            Name = "UserPage";
            Text = "Quản lý người dùng";
            ((System.ComponentModel.ISupportInitialize)dgUser).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgUser;
        private CustomButton LoadBtn;
        private CustomButton UpdateBtn;
        private CustomButton CreateBtn;
        private CustomButton DeleteBtn;
        private CustomButton BackBtn;
        private DataGridViewTextBoxColumn UserID;
        private DataGridViewTextBoxColumn Username;
        private DataGridViewTextBoxColumn FullName;
        private DataGridViewTextBoxColumn PhoneNumber;
        private DataGridViewTextBoxColumn RoleName;
        private Panel panel1;
        private TextBox txtSearch;
        private PictureBox pictureBox1;
    }
}