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
            label1 = new Label();
            dgUser = new DataGridView();
            UserID = new DataGridViewTextBoxColumn();
            Username = new DataGridViewTextBoxColumn();
            FullName = new DataGridViewTextBoxColumn();
            PhoneNumber = new DataGridViewTextBoxColumn();
            RoleName = new DataGridViewTextBoxColumn();
            LoadBtn = new Button();
            UpdateBtn = new Button();
            CreateBtn = new Button();
            DeleteBtn = new Button();
            BackBtn = new Button();
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
            label1.Location = new Point(341, 69);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(424, 41);
            label1.TabIndex = 0;
            label1.Text = "DANH SÁCH MÁY BƠM";
            // 
            // dgUser
            // 
            dgUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgUser.Columns.AddRange(new DataGridViewColumn[] { UserID, Username, FullName, PhoneNumber, RoleName });
            dgUser.Location = new Point(62, 132);
            dgUser.Name = "dgUser";
            dgUser.ReadOnly = true;
            dgUser.RowHeadersWidth = 62;
            dgUser.Size = new Size(977, 349);
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
            UpdateBtn.Location = new Point(1085, 217);
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
            CreateBtn.Location = new Point(1085, 133);
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
            DeleteBtn.Location = new Point(1085, 298);
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
            BackBtn.Location = new Point(701, 509);
            BackBtn.Margin = new Padding(4);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(150, 50);
            BackBtn.TabIndex = 21;
            BackBtn.Text = "Quay lại";
            BackBtn.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(txtSearch);
            panel1.Location = new Point(795, 34);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 63);
            panel1.TabIndex = 29;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = SystemColors.ActiveCaption;
            txtSearch.BorderStyle = BorderStyle.None;
            txtSearch.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(3, 16);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(294, 28);
            txtSearch.TabIndex = 24;
            txtSearch.TextChanged += Search;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.E;
            pictureBox1.Location = new Point(1101, 34);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(76, 63);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 28;
            pictureBox1.TabStop = false;
            // 
            // UserPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1492, 705);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(BackBtn);
            Controls.Add(DeleteBtn);
            Controls.Add(UpdateBtn);
            Controls.Add(CreateBtn);
            Controls.Add(LoadBtn);
            Controls.Add(dgUser);
            Controls.Add(label1);
            Margin = new Padding(4);
            Name = "UserPage";
            Text = "Quản lý trạm bơm";
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
        private Button LoadBtn;
        private Button UpdateBtn;
        private Button CreateBtn;
        private Button DeleteBtn;
        private Button BackBtn;
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