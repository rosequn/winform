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
            dgAlert = new DataGridView();
            AlertID = new DataGridViewTextBoxColumn();
            PumpName = new DataGridViewTextBoxColumn();
            AlertName = new DataGridViewTextBoxColumn();
            AlertMessage = new DataGridViewTextBoxColumn();
            StatusName = new DataGridViewTextBoxColumn();
            CreatedOn = new DataGridViewTextBoxColumn();
            ResolvedBy = new DataGridViewTextBoxColumn();
            ModifiedOn = new DataGridViewTextBoxColumn();
            LoadBtn = new Button();
            UpdateBtn = new Button();
            CreateBtn = new Button();
            DeleteBtn = new Button();
            BackBtn = new Button();
            label1 = new Label();
            label2 = new Label();
            cbStation = new ComboBox();
            IgnoredBtn = new Button();
            ResolvedBtn = new Button();
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
            dgAlert.Location = new Point(33, 144);
            dgAlert.Name = "dgAlert";
            dgAlert.ReadOnly = true;
            dgAlert.RowHeadersWidth = 62;
            dgAlert.Size = new Size(1224, 349);
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
            LoadBtn.Location = new Point(48, 509);
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
            UpdateBtn.Location = new Point(339, 592);
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
            CreateBtn.Location = new Point(167, 592);
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
            DeleteBtn.Location = new Point(526, 592);
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
            BackBtn.Location = new Point(167, 509);
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
            label1.Location = new Point(227, 76);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(463, 41);
            label1.TabIndex = 0;
            label1.Text = "DANH SÁCH THÔNG BÁO";
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
            // IgnoredBtn
            // 
            IgnoredBtn.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 163);
            IgnoredBtn.Location = new Point(526, 509);
            IgnoredBtn.Margin = new Padding(4);
            IgnoredBtn.Name = "IgnoredBtn";
            IgnoredBtn.Size = new Size(150, 50);
            IgnoredBtn.TabIndex = 27;
            IgnoredBtn.Text = "Bỏ qua";
            IgnoredBtn.UseVisualStyleBackColor = true;
            IgnoredBtn.Click += IgnoredBtn_Click;
            // 
            // ResolvedBtn
            // 
            ResolvedBtn.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 163);
            ResolvedBtn.Location = new Point(339, 509);
            ResolvedBtn.Margin = new Padding(4);
            ResolvedBtn.Name = "ResolvedBtn";
            ResolvedBtn.Size = new Size(150, 50);
            ResolvedBtn.TabIndex = 26;
            ResolvedBtn.Text = "Đã xử lý";
            ResolvedBtn.UseVisualStyleBackColor = true;
            ResolvedBtn.Click += ResolvedBtn_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(txtSearch);
            panel1.Location = new Point(751, 40);
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
            pictureBox1.Location = new Point(1057, 40);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(76, 63);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 28;
            pictureBox1.TabStop = false;
            // 
            // AlertPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1334, 705);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(IgnoredBtn);
            Controls.Add(ResolvedBtn);
            Controls.Add(label2);
            Controls.Add(cbStation);
            Controls.Add(BackBtn);
            Controls.Add(DeleteBtn);
            Controls.Add(UpdateBtn);
            Controls.Add(CreateBtn);
            Controls.Add(LoadBtn);
            Controls.Add(dgAlert);
            Controls.Add(label1);
            Margin = new Padding(4);
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
        private Button LoadBtn;
        private Button UpdateBtn;
        private Button CreateBtn;
        private Button DeleteBtn;
        private Button BackBtn;
        private Label label1;
        private Label label2;
        private ComboBox cbStation;
        private Button IgnoredBtn;
        private Button ResolvedBtn;
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