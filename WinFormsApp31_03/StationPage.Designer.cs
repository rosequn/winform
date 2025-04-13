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
            label1 = new Label();
            dgStation = new DataGridView();
            LoadBtn = new Button();
            ResetBtn = new Button();
            SaveBtn = new Button();
            txtDescription = new TextBox();
            label4 = new Label();
            txtLocation = new TextBox();
            label3 = new Label();
            txtName = new TextBox();
            label2 = new Label();
            DeleteBtn = new Button();
            CancelBtn = new Button();
            StationId = new DataGridViewTextBoxColumn();
            StationName = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            Location = new DataGridViewTextBoxColumn();
            StatusName = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgStation).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.Location = new Point(209, 50);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(447, 41);
            label1.TabIndex = 0;
            label1.Text = "DANH SÁCH TRẠM BƠM";
            label1.Click += label1_Click;
            // 
            // dgStation
            // 
            dgStation.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgStation.Columns.AddRange(new DataGridViewColumn[] { StationId, StationName, Description, Location, StatusName });
            dgStation.Location = new Point(33, 134);
            dgStation.Name = "dgStation";
            dgStation.ReadOnly = true;
            dgStation.RowHeadersWidth = 62;
            dgStation.Size = new Size(826, 349);
            dgStation.TabIndex = 1;
            dgStation.DoubleClick += dgStation_DoubleClick;
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
            // ResetBtn
            // 
            ResetBtn.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 163);
            ResetBtn.Location = new Point(1387, 218);
            ResetBtn.Margin = new Padding(4);
            ResetBtn.Name = "ResetBtn";
            ResetBtn.Size = new Size(150, 50);
            ResetBtn.TabIndex = 19;
            ResetBtn.Text = "Đặt lại";
            ResetBtn.UseVisualStyleBackColor = true;
            ResetBtn.Click += ResetBtn_Click;
            // 
            // SaveBtn
            // 
            SaveBtn.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 163);
            SaveBtn.Location = new Point(1387, 142);
            SaveBtn.Margin = new Padding(4);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(150, 50);
            SaveBtn.TabIndex = 17;
            SaveBtn.Text = "Lưu";
            SaveBtn.UseVisualStyleBackColor = true;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // txtDescription
            // 
            txtDescription.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtDescription.Location = new Point(986, 255);
            txtDescription.Margin = new Padding(4);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(346, 151);
            txtDescription.TabIndex = 16;
            txtDescription.TextChanged += CheckEnableReset;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 14F);
            label4.Location = new Point(886, 260);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(96, 33);
            label4.TabIndex = 15;
            label4.Text = "Mô tả :";
            // 
            // txtLocation
            // 
            txtLocation.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtLocation.Location = new Point(986, 200);
            txtLocation.Margin = new Padding(4);
            txtLocation.Multiline = true;
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new Size(346, 30);
            txtLocation.TabIndex = 14;
            txtLocation.TextChanged += CheckEnableReset;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 14F);
            label3.Location = new Point(886, 199);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(90, 33);
            label3.TabIndex = 13;
            label3.Text = "Vị trí :";
            // 
            // txtName
            // 
            txtName.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtName.Location = new Point(986, 143);
            txtName.Margin = new Padding(4);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.Size = new Size(346, 32);
            txtName.TabIndex = 12;
            txtName.TextChanged += CheckEnableReset;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14F);
            label2.Location = new Point(886, 142);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(72, 33);
            label2.TabIndex = 11;
            label2.Text = "Tên :";
            // 
            // DeleteBtn
            // 
            DeleteBtn.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 163);
            DeleteBtn.Location = new Point(1387, 303);
            DeleteBtn.Margin = new Padding(4);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(150, 50);
            DeleteBtn.TabIndex = 20;
            DeleteBtn.Text = "Xóa";
            DeleteBtn.UseVisualStyleBackColor = true;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // CancelBtn
            // 
            CancelBtn.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 163);
            CancelBtn.Location = new Point(1387, 383);
            CancelBtn.Margin = new Padding(4);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new Size(150, 50);
            CancelBtn.TabIndex = 21;
            CancelBtn.Text = "Hủy";
            CancelBtn.UseVisualStyleBackColor = true;
            CancelBtn.Click += CancelBtn_Click;
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
            StationName.DataPropertyName = "StationName";
            StationName.HeaderText = "Tên";
            StationName.MinimumWidth = 8;
            StationName.Name = "StationName";
            StationName.ReadOnly = true;
            StationName.Width = 150;
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
            Location.MinimumWidth = 8;
            Location.Name = "Location";
            Location.ReadOnly = true;
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
            // StationPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1689, 705);
            Controls.Add(CancelBtn);
            Controls.Add(DeleteBtn);
            Controls.Add(ResetBtn);
            Controls.Add(SaveBtn);
            Controls.Add(txtDescription);
            Controls.Add(label4);
            Controls.Add(txtLocation);
            Controls.Add(label3);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(LoadBtn);
            Controls.Add(dgStation);
            Controls.Add(label1);
            Margin = new Padding(4);
            Name = "StationPage";
            Text = "Quản lý trạm bơm";
            ((System.ComponentModel.ISupportInitialize)dgStation).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgStation;
        private Button LoadBtn;
        private Button ResetBtn;
        private Button SaveBtn;
        private TextBox txtDescription;
        private Label label4;
        private TextBox txtLocation;
        private Label label3;
        private TextBox txtName;
        private Label label2;
        private Button DeleteBtn;
        private Button CancelBtn;
        private DataGridViewTextBoxColumn StationId;
        private DataGridViewTextBoxColumn StationName;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn Location;
        private DataGridViewTextBoxColumn StatusName;
    }
}