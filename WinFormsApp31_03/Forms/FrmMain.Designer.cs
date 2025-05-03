namespace WinFormsApp31_03.Forms
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            panelLogo = new Panel();
            pictureBox1 = new PictureBox();
            lblUsername = new Label();
            panelMenu = new Panel();
            btnUser = new Button();
            btnHistory = new Button();
            btnAlert = new Button();
            btnOperating = new Button();
            btnPump = new Button();
            btnStation = new Button();
            panelTitleBar = new Panel();
            lblTitle = new Label();
            lbl3 = new Label();
            btnCloseChildForm = new Button();
            lbl2 = new Label();
            logo = new PictureBox();
            lbl1 = new Label();
            panelDesktop = new Panel();
            LogoutBtn = new Button();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelMenu.SuspendLayout();
            panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            SuspendLayout();
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.Navy;
            panelLogo.Controls.Add(LogoutBtn);
            panelLogo.Controls.Add(pictureBox1);
            panelLogo.Controls.Add(lblUsername);
            panelLogo.Controls.Add(panelMenu);
            panelLogo.Dock = DockStyle.Left;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(200, 664);
            panelLogo.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.user_icon;
            pictureBox1.Location = new Point(3, 599);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(45, 46);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsername.ForeColor = SystemColors.Control;
            lblUsername.Location = new Point(55, 599);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(95, 23);
            lblUsername.TabIndex = 3;
            lblUsername.Text = "userName";
            // 
            // panelMenu
            // 
            panelMenu.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelMenu.Controls.Add(btnUser);
            panelMenu.Controls.Add(btnHistory);
            panelMenu.Controls.Add(btnAlert);
            panelMenu.Controls.Add(btnOperating);
            panelMenu.Controls.Add(btnPump);
            panelMenu.Controls.Add(btnStation);
            panelMenu.Location = new Point(0, 99);
            panelMenu.Margin = new Padding(5);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(200, 414);
            panelMenu.TabIndex = 2;
            // 
            // btnUser
            // 
            btnUser.BackColor = Color.SteelBlue;
            btnUser.Dock = DockStyle.Top;
            btnUser.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 128);
            btnUser.FlatAppearance.CheckedBackColor = Color.White;
            btnUser.FlatAppearance.MouseDownBackColor = Color.Yellow;
            btnUser.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 192);
            btnUser.FlatStyle = FlatStyle.Flat;
            btnUser.Font = new Font("Microsoft Sans Serif", 10.2F);
            btnUser.ForeColor = Color.AliceBlue;
            btnUser.Location = new Point(0, 345);
            btnUser.Name = "btnUser";
            btnUser.Size = new Size(200, 69);
            btnUser.TabIndex = 5;
            btnUser.Text = "Người dùng";
            btnUser.UseVisualStyleBackColor = false;
            btnUser.Click += UserBtn_Click;
            // 
            // btnHistory
            // 
            btnHistory.BackColor = Color.SteelBlue;
            btnHistory.Dock = DockStyle.Top;
            btnHistory.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 128);
            btnHistory.FlatAppearance.CheckedBackColor = Color.White;
            btnHistory.FlatAppearance.MouseDownBackColor = Color.Yellow;
            btnHistory.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 192);
            btnHistory.FlatStyle = FlatStyle.Flat;
            btnHistory.Font = new Font("Microsoft Sans Serif", 10.2F);
            btnHistory.ForeColor = Color.AliceBlue;
            btnHistory.Location = new Point(0, 276);
            btnHistory.Name = "btnHistory";
            btnHistory.Size = new Size(200, 69);
            btnHistory.TabIndex = 4;
            btnHistory.Text = "Lịch sử bảo trì";
            btnHistory.UseVisualStyleBackColor = false;
            btnHistory.Click += MaintainBtn_Click;
            // 
            // btnAlert
            // 
            btnAlert.BackColor = Color.SteelBlue;
            btnAlert.Dock = DockStyle.Top;
            btnAlert.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 128);
            btnAlert.FlatAppearance.CheckedBackColor = Color.White;
            btnAlert.FlatAppearance.MouseDownBackColor = Color.Yellow;
            btnAlert.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 192);
            btnAlert.FlatStyle = FlatStyle.Flat;
            btnAlert.Font = new Font("Microsoft Sans Serif", 10.2F);
            btnAlert.ForeColor = Color.AliceBlue;
            btnAlert.Location = new Point(0, 207);
            btnAlert.Name = "btnAlert";
            btnAlert.Size = new Size(200, 69);
            btnAlert.TabIndex = 3;
            btnAlert.Text = "Cảnh báo";
            btnAlert.UseVisualStyleBackColor = false;
            btnAlert.Click += AlertBtn_Click;
            // 
            // btnOperating
            // 
            btnOperating.BackColor = Color.SteelBlue;
            btnOperating.Dock = DockStyle.Top;
            btnOperating.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 128);
            btnOperating.FlatAppearance.CheckedBackColor = Color.White;
            btnOperating.FlatAppearance.MouseDownBackColor = Color.Yellow;
            btnOperating.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 192);
            btnOperating.FlatStyle = FlatStyle.Flat;
            btnOperating.Font = new Font("Microsoft Sans Serif", 10.2F);
            btnOperating.ForeColor = Color.AliceBlue;
            btnOperating.Location = new Point(0, 138);
            btnOperating.Name = "btnOperating";
            btnOperating.Size = new Size(200, 69);
            btnOperating.TabIndex = 2;
            btnOperating.Text = "Vận hành";
            btnOperating.UseVisualStyleBackColor = false;
            // 
            // btnPump
            // 
            btnPump.BackColor = Color.SteelBlue;
            btnPump.Dock = DockStyle.Top;
            btnPump.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 128);
            btnPump.FlatAppearance.CheckedBackColor = Color.White;
            btnPump.FlatAppearance.MouseDownBackColor = Color.Yellow;
            btnPump.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 192);
            btnPump.FlatStyle = FlatStyle.Flat;
            btnPump.Font = new Font("Microsoft Sans Serif", 10.2F);
            btnPump.ForeColor = Color.AliceBlue;
            btnPump.Location = new Point(0, 69);
            btnPump.Name = "btnPump";
            btnPump.Size = new Size(200, 69);
            btnPump.TabIndex = 1;
            btnPump.Text = "Máy Bơm";
            btnPump.UseVisualStyleBackColor = false;
            btnPump.Click += PumpBtn_Click;
            // 
            // btnStation
            // 
            btnStation.BackColor = Color.SteelBlue;
            btnStation.Dock = DockStyle.Top;
            btnStation.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 128);
            btnStation.FlatAppearance.CheckedBackColor = Color.White;
            btnStation.FlatAppearance.MouseDownBackColor = Color.Yellow;
            btnStation.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 192);
            btnStation.FlatStyle = FlatStyle.Flat;
            btnStation.Font = new Font("Microsoft Sans Serif", 10.2F);
            btnStation.ForeColor = Color.AliceBlue;
            btnStation.ImageAlign = ContentAlignment.MiddleLeft;
            btnStation.Location = new Point(0, 0);
            btnStation.Name = "btnStation";
            btnStation.Size = new Size(200, 69);
            btnStation.TabIndex = 0;
            btnStation.Text = "Trạm bơm";
            btnStation.UseVisualStyleBackColor = false;
            btnStation.Click += StationBtn_Click;
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.Navy;
            panelTitleBar.Controls.Add(lblTitle);
            panelTitleBar.Controls.Add(lbl3);
            panelTitleBar.Controls.Add(btnCloseChildForm);
            panelTitleBar.Controls.Add(lbl2);
            panelTitleBar.Controls.Add(logo);
            panelTitleBar.Controls.Add(lbl1);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(200, 0);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(1313, 100);
            panelTitleBar.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Times New Roman", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Transparent;
            lblTitle.Location = new Point(546, 24);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(172, 53);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "HOME";
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.BackColor = Color.Navy;
            lbl3.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lbl3.ForeColor = Color.White;
            lbl3.Location = new Point(762, 37);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(291, 25);
            lbl3.TabIndex = 21;
            lbl3.Text = "BỘ MÔN ĐIỆN - ĐIỆN TỬ";
            // 
            // btnCloseChildForm
            // 
            btnCloseChildForm.BackgroundImageLayout = ImageLayout.None;
            btnCloseChildForm.Dock = DockStyle.Left;
            btnCloseChildForm.FlatAppearance.BorderSize = 0;
            btnCloseChildForm.FlatStyle = FlatStyle.Flat;
            btnCloseChildForm.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCloseChildForm.Image = (Image)resources.GetObject("btnCloseChildForm.Image");
            btnCloseChildForm.Location = new Point(0, 0);
            btnCloseChildForm.Name = "btnCloseChildForm";
            btnCloseChildForm.Size = new Size(70, 100);
            btnCloseChildForm.TabIndex = 1;
            btnCloseChildForm.UseVisualStyleBackColor = false;
            btnCloseChildForm.Click += btnCloseChildForm_Click;
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.BackColor = Color.Navy;
            lbl2.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lbl2.ForeColor = Color.Gold;
            lbl2.Location = new Point(167, 45);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(331, 17);
            lbl2.TabIndex = 20;
            lbl2.Text = "PHÂN HIỆU TẠI THÀNH PHỐ HỒ CHÍ MINH";
            // 
            // logo
            // 
            logo.BackColor = Color.Navy;
            logo.Image = (Image)resources.GetObject("logo.Image");
            logo.Location = new Point(82, 10);
            logo.Name = "logo";
            logo.Size = new Size(95, 67);
            logo.SizeMode = PictureBoxSizeMode.StretchImage;
            logo.TabIndex = 18;
            logo.TabStop = false;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.BackColor = Color.Navy;
            lbl1.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lbl1.ForeColor = SystemColors.HighlightText;
            lbl1.Location = new Point(172, 24);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(317, 17);
            lbl1.TabIndex = 19;
            lbl1.Text = "TRƯỜNG ĐẠI HỌC GIAO THÔNG VẬN TẢI";
            // 
            // panelDesktop
            // 
            panelDesktop.Dock = DockStyle.Fill;
            panelDesktop.Location = new Point(200, 100);
            panelDesktop.Name = "panelDesktop";
            panelDesktop.Size = new Size(1313, 564);
            panelDesktop.TabIndex = 2;
            // 
            // LogoutBtn
            // 
            LogoutBtn.FlatStyle = FlatStyle.Flat;
            LogoutBtn.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LogoutBtn.ForeColor = SystemColors.ButtonHighlight;
            LogoutBtn.Location = new Point(53, 627);
            LogoutBtn.Name = "LogoutBtn";
            LogoutBtn.Size = new Size(121, 36);
            LogoutBtn.TabIndex = 5;
            LogoutBtn.Text = "Đăng xuất";
            LogoutBtn.UseVisualStyleBackColor = true;
            LogoutBtn.Click += LogoutBtn_Click;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1513, 664);
            Controls.Add(panelDesktop);
            Controls.Add(panelTitleBar);
            Controls.Add(panelLogo);
            Name = "FrmMain";
            Text = "FrmMain";
            panelLogo.ResumeLayout(false);
            panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelMenu.ResumeLayout(false);
            panelTitleBar.ResumeLayout(false);
            panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            ResumeLayout(false);
        }

        private void BtnUser_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Panel panelLogo;
        private Panel panelTitleBar;
        private Panel panelMenu;
        private Button btnStation;
        private Button btnUser;
        private Button btnHistory;
        private Button btnAlert;
        private Button btnOperating;
        private Button btnPump;
        private Panel panelDesktop;
        private Button btnCloseChildForm;
        private Label lblUsername;
        private PictureBox pictureBox1;
        private Label lbl3;
        private Label lbl2;
        private Label lbl1;
        private PictureBox logo;
        private Label lblTitle;
        private Button LogoutBtn;
    }
}