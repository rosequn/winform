namespace WinFormsApp31_03
{
    partial class Form8
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
            progressBar1 = new ProgressBar();
            label1 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(52, 92);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(717, 309);
            progressBar1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(288, 9);
            label1.Name = "label1";
            label1.Size = new Size(216, 45);
            label1.TabIndex = 1;
            label1.Text = "Lưu Lượng";
            // 
            // button1
            // 
            button1.Location = new Point(543, 428);
            button1.Name = "button1";
            button1.Size = new Size(169, 51);
            button1.TabIndex = 2;
            button1.Text = "Quay Lại";
            button1.UseVisualStyleBackColor = true;
            button1.Click += BackBtn_Click;
            // 
            // button2
            // 
            button2.Location = new Point(75, 428);
            button2.Name = "button2";
            button2.Size = new Size(169, 51);
            button2.TabIndex = 3;
            button2.Text = "Lưu";
            button2.UseVisualStyleBackColor = true;
            // 
            // Form8
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 508);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(progressBar1);
            Name = "Form8";
            Text = "Form8";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar progressBar1;
        private Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button button1;
        private Button button2;
    }
}