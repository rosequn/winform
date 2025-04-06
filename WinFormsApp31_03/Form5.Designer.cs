namespace WinFormsApp31_03
{
    partial class Form5
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
            textBox1 = new TextBox();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            textBoxDescription = new TextBox();
            label4 = new Label();
            textBoxLocation = new TextBox();
            label3 = new Label();
            textBoxName = new TextBox();
            label2 = new Label();
            button2 = new Button();
            label5 = new Label();
            textBoxID = new TextBox();
            label6 = new Label();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.Location = new Point(26, 22);
            label1.Name = "label1";
            label1.Size = new Size(432, 35);
            label1.TabIndex = 0;
            label1.Text = "SỬA THÔNG TIN TRẠM BƠM";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(26, 100);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(810, 49);
            textBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 163);
            button1.Location = new Point(842, 100);
            button1.Name = "button1";
            button1.Size = new Size(152, 49);
            button1.TabIndex = 2;
            button1.Text = "Tìm kiếm";
            button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(26, 151);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(810, 127);
            dataGridView1.TabIndex = 3;
            // 
            // textBoxDescription
            // 
            textBoxDescription.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 163);
            textBoxDescription.Location = new Point(392, 502);
            textBoxDescription.Multiline = true;
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(444, 43);
            textBoxDescription.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label4.Location = new Point(105, 511);
            label4.Name = "label4";
            label4.Size = new Size(269, 34);
            label4.TabIndex = 11;
            label4.Text = "Mô tả thông tin trạm:";
            // 
            // textBoxLocation
            // 
            textBoxLocation.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 163);
            textBoxLocation.Location = new Point(392, 435);
            textBoxLocation.Multiline = true;
            textBoxLocation.Name = "textBoxLocation";
            textBoxLocation.Size = new Size(444, 43);
            textBoxLocation.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label3.Location = new Point(164, 444);
            label3.Name = "label3";
            label3.Size = new Size(210, 34);
            label3.TabIndex = 9;
            label3.Text = "Vị trí trạm bơm:";
            // 
            // textBoxName
            // 
            textBoxName.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 163);
            textBoxName.Location = new Point(392, 367);
            textBoxName.Multiline = true;
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(444, 43);
            textBoxName.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label2.Location = new Point(184, 376);
            label2.Name = "label2";
            label2.Size = new Size(202, 34);
            label2.TabIndex = 7;
            label2.Text = "Tên trạm bơm: ";
            // 
            // button2
            // 
            button2.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 163);
            button2.Location = new Point(699, 565);
            button2.Name = "button2";
            button2.Size = new Size(137, 49);
            button2.TabIndex = 13;
            button2.Text = "Cập nhật";
            button2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label5.Location = new Point(26, 80);
            label5.Name = "label5";
            label5.Size = new Size(278, 17);
            label5.TabIndex = 15;
            label5.Text = "Nhập địa chỉ TÊN trạm bơm cần sử thông tin.\r\n";
            // 
            // textBoxID
            // 
            textBoxID.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 163);
            textBoxID.Location = new Point(392, 301);
            textBoxID.Multiline = true;
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new Size(444, 43);
            textBoxID.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label6.Location = new Point(320, 310);
            label6.Name = "label6";
            label6.Size = new Size(54, 34);
            label6.TabIndex = 16;
            label6.Text = "ID:";
            // 
            // button3
            // 
            button3.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 163);
            button3.Location = new Point(26, 565);
            button3.Name = "button3";
            button3.Size = new Size(137, 49);
            button3.TabIndex = 18;
            button3.Text = "Quay lại";
            button3.UseVisualStyleBackColor = true;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1006, 644);
            Controls.Add(button3);
            Controls.Add(textBoxID);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(button2);
            Controls.Add(textBoxDescription);
            Controls.Add(label4);
            Controls.Add(textBoxLocation);
            Controls.Add(label3);
            Controls.Add(textBoxName);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form5";
            Text = "Form5";
            Load += Form5_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private DataGridView dataGridView1;
        private TextBox textBoxDescription;
        private Label label4;
        private TextBox textBoxLocation;
        private Label label3;
        private TextBox textBoxName;
        private Label label2;
        private Button button2;
        private Label label5;
        private TextBox textBoxID;
        private Label label6;
        private Button button3;
    }
}