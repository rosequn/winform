namespace WinFormsApp31_03
{
    partial class Form13
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
            progressBar1 = new ProgressBar();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DodgerBlue;
            label1.Location = new Point(203, 9);
            label1.Name = "label1";
            label1.Size = new Size(418, 51);
            label1.TabIndex = 0;
            label1.Text = "Danh Sách Cảnh Báo";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(84, 75);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(620, 294);
            progressBar1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(570, 375);
            button1.Name = "button1";
            button1.Size = new Size(160, 63);
            button1.TabIndex = 2;
            button1.Text = "Quay Lại ";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(109, 375);
            button2.Name = "button2";
            button2.Size = new Size(151, 63);
            button2.TabIndex = 3;
            button2.Text = "Sửa";
            button2.UseVisualStyleBackColor = true;
            // 
            // Form13
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(progressBar1);
            Controls.Add(label1);
            Name = "Form13";
            Text = "Form 13";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ProgressBar progressBar1;
        private Button button1;
        private Button button2;
    }
}