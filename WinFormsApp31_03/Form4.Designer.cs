namespace WinFormsApp31_03
{
    partial class Form4
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
            label2 = new Label();
            txtName = new TextBox();
            txtLocation = new TextBox();
            label3 = new Label();
            txtDescription = new TextBox();
            label4 = new Label();
            SaveBtn = new Button();
            BackBtn = new Button();
            ResetBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.Location = new Point(454, 11);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(344, 41);
            label1.TabIndex = 0;
            label1.Text = "THÊM TRẠM BƠM";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label2.Location = new Point(24, 92);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(89, 41);
            label2.TabIndex = 1;
            label2.Text = "Tên :";
            // 
            // txtName
            // 
            txtName.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtName.Location = new Point(269, 80);
            txtName.Margin = new Padding(4);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.Size = new Size(529, 53);
            txtName.TabIndex = 2;
            // 
            // txtLocation
            // 
            txtLocation.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtLocation.Location = new Point(269, 171);
            txtLocation.Margin = new Padding(4);
            txtLocation.Multiline = true;
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new Size(529, 53);
            txtLocation.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label3.Location = new Point(24, 183);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(112, 41);
            label3.TabIndex = 3;
            label3.Text = "Vị trí :";
            // 
            // txtDescription
            // 
            txtDescription.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtDescription.Location = new Point(269, 255);
            txtDescription.Margin = new Padding(4);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(529, 193);
            txtDescription.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label4.Location = new Point(24, 267);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(121, 41);
            label4.TabIndex = 5;
            label4.Text = "Mô tả :";
            // 
            // SaveBtn
            // 
            SaveBtn.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 163);
            SaveBtn.Location = new Point(454, 588);
            SaveBtn.Margin = new Padding(4);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(171, 54);
            SaveBtn.TabIndex = 7;
            SaveBtn.Text = "Lưu";
            SaveBtn.UseVisualStyleBackColor = true;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // BackBtn
            // 
            BackBtn.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 163);
            BackBtn.Location = new Point(191, 588);
            BackBtn.Margin = new Padding(4);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(171, 54);
            BackBtn.TabIndex = 8;
            BackBtn.Text = "Quay Lại";
            BackBtn.UseVisualStyleBackColor = true;
            // 
            // ResetBtn
            // 
            ResetBtn.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 163);
            ResetBtn.Location = new Point(711, 588);
            ResetBtn.Margin = new Padding(4);
            ResetBtn.Name = "ResetBtn";
            ResetBtn.Size = new Size(171, 54);
            ResetBtn.TabIndex = 9;
            ResetBtn.Text = "Đặt lại";
            ResetBtn.UseVisualStyleBackColor = true;
            ResetBtn.Click += ResetBtn_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1258, 655);
            Controls.Add(ResetBtn);
            Controls.Add(BackBtn);
            Controls.Add(SaveBtn);
            Controls.Add(txtDescription);
            Controls.Add(label4);
            Controls.Add(txtLocation);
            Controls.Add(label3);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(4);
            Name = "Form4";
            Text = "Form4";
            Load += Form4_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtName;
        private TextBox txtLocation;
        private Label label3;
        private TextBox txtDescription;
        private Label label4;
        private Button SaveBtn;
        private Button BackBtn;
        private Button ResetBtn;
    }
}