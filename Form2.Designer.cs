namespace FakeDeleteSystemFiles
{
    partial class Form2
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
            pictureBox1 = new PictureBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 48F, FontStyle.Bold);
            label1.Location = new Point(29, 19);
            label1.Name = "label1";
            label1.Size = new Size(80, 86);
            label1.TabIndex = 0;
            label1.Text = ":(";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei UI", 24F);
            label2.Location = new Point(91, 33);
            label2.Name = "label2";
            label2.Size = new Size(722, 82);
            label2.TabIndex = 1;
            label2.Text = "您的电脑遇到问题，需要重新启动。\r\n我们将会收集一些错误信息，然后为您重新启动。";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.qrcode_support_microsoft_com;
            pictureBox1.Location = new Point(60, 275);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(96, 96);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(177, 286);
            label3.Name = "label3";
            label3.Size = new Size(403, 17);
            label3.TabIndex = 3;
            label3.Text = "有关此问题的详细信息，请访问：https://www.windows.com/stopcode/";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Cursor = Cursors.AppStarting;
            ForeColor = SystemColors.HighlightText;
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form2";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "FakeBSoD";
            TopMost = true;
            FormClosed += Closed;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label3;
    }
}