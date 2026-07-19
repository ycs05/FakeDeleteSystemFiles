namespace FakeDeleteSystemFiles
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Title = new Label();
            button1 = new Button();
            progressBar1 = new ProgressBar();
            Tip1 = new Label();
            SuspendLayout();
            // 
            // Title
            // 
            Title.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Title.AutoSize = true;
            Title.Font = new Font("Microsoft YaHei UI", 36F);
            Title.Location = new Point(225, 36);
            Title.Name = "Title";
            Title.Size = new Size(363, 62);
            Title.TabIndex = 0;
            Title.Text = "系统文件清除器";
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft YaHei UI", 24F);
            button1.Location = new Point(271, 173);
            button1.Name = "button1";
            button1.Size = new Size(259, 70);
            button1.TabIndex = 1;
            button1.Text = "一键毁灭系统";
            button1.UseVisualStyleBackColor = true;
            button1.Click += OnBoomSystemPressed;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(212, 279);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(402, 49);
            progressBar1.TabIndex = 2;
            progressBar1.Visible = false;
            // 
            // Tip1
            // 
            Tip1.AutoSize = true;
            Tip1.Location = new Point(212, 331);
            Tip1.Name = "Tip1";
            Tip1.Size = new Size(100, 17);
            Tip1.TabIndex = 3;
            Tip1.Text = "正在毁灭系统……";
            Tip1.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(796, 446);
            ControlBox = false;
            Controls.Add(Tip1);
            Controls.Add(progressBar1);
            Controls.Add(button1);
            Controls.Add(Title);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "系统文件清除器 By Bilibili@ycs05_";
            FormClosing += StopClose;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Title;
        private Button button1;
        private ProgressBar progressBar1;
        private Label Tip1;
    }
}
