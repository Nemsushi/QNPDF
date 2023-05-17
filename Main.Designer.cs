namespace QNPDF
{
    partial class Main
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
            this.darkMenuStrip1 = new DarkUI.Controls.DarkMenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tạoRSAKeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darkGroupBox1 = new DarkUI.Controls.DarkGroupBox();
            this.SelectPrivateKeyButton = new DarkUI.Controls.DarkButton();
            this.SelectPdfButton = new DarkUI.Controls.DarkButton();
            this.pemPathTextBox = new DarkUI.Controls.DarkTextBox();
            this.pdfPathTextBox = new DarkUI.Controls.DarkTextBox();
            this.darkTitle2 = new DarkUI.Controls.DarkTitle();
            this.darkTitle1 = new DarkUI.Controls.DarkTitle();
            this.EncryptButton = new DarkUI.Controls.DarkButton();
            this.DecryptButton = new DarkUI.Controls.DarkButton();
            this.darkMenuStrip1.SuspendLayout();
            this.darkGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // darkMenuStrip1
            // 
            this.darkMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.darkMenuStrip1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem});
            this.darkMenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.darkMenuStrip1.Name = "darkMenuStrip1";
            this.darkMenuStrip1.Padding = new System.Windows.Forms.Padding(3, 2, 0, 2);
            this.darkMenuStrip1.Size = new System.Drawing.Size(560, 24);
            this.darkMenuStrip1.TabIndex = 0;
            this.darkMenuStrip1.Text = "darkMenuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tạoRSAKeyToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.hệThốngToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // tạoRSAKeyToolStripMenuItem
            // 
            this.tạoRSAKeyToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.tạoRSAKeyToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.tạoRSAKeyToolStripMenuItem.Name = "tạoRSAKeyToolStripMenuItem";
            this.tạoRSAKeyToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.tạoRSAKeyToolStripMenuItem.Text = "Tạo RSA key";
            this.tạoRSAKeyToolStripMenuItem.Click += new System.EventHandler(this.tạoRSAKeyToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.thoátToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.thoátToolStripMenuItem.Text = "Thoát";
            // 
            // darkGroupBox1
            // 
            this.darkGroupBox1.BorderColor = System.Drawing.Color.White;
            this.darkGroupBox1.Controls.Add(this.SelectPrivateKeyButton);
            this.darkGroupBox1.Controls.Add(this.SelectPdfButton);
            this.darkGroupBox1.Controls.Add(this.pemPathTextBox);
            this.darkGroupBox1.Controls.Add(this.pdfPathTextBox);
            this.darkGroupBox1.Controls.Add(this.darkTitle2);
            this.darkGroupBox1.Controls.Add(this.darkTitle1);
            this.darkGroupBox1.Location = new System.Drawing.Point(12, 27);
            this.darkGroupBox1.Name = "darkGroupBox1";
            this.darkGroupBox1.Size = new System.Drawing.Size(528, 77);
            this.darkGroupBox1.TabIndex = 1;
            this.darkGroupBox1.TabStop = false;
            this.darkGroupBox1.Text = "Thiết lập";
            // 
            // SelectPrivateKeyButton
            // 
            this.SelectPrivateKeyButton.Location = new System.Drawing.Point(440, 42);
            this.SelectPrivateKeyButton.Name = "SelectPrivateKeyButton";
            this.SelectPrivateKeyButton.Padding = new System.Windows.Forms.Padding(5);
            this.SelectPrivateKeyButton.Size = new System.Drawing.Size(75, 23);
            this.SelectPrivateKeyButton.TabIndex = 5;
            this.SelectPrivateKeyButton.Text = "Chọn";
            this.SelectPrivateKeyButton.Click += new System.EventHandler(this.SelectPrivateKeyButton_Click);
            // 
            // SelectPdfButton
            // 
            this.SelectPdfButton.Location = new System.Drawing.Point(440, 15);
            this.SelectPdfButton.Name = "SelectPdfButton";
            this.SelectPdfButton.Padding = new System.Windows.Forms.Padding(5);
            this.SelectPdfButton.Size = new System.Drawing.Size(75, 23);
            this.SelectPdfButton.TabIndex = 4;
            this.SelectPdfButton.Text = "Chọn";
            this.SelectPdfButton.Click += new System.EventHandler(this.SelectPdfButton_Click);
            // 
            // pemPathTextBox
            // 
            this.pemPathTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.pemPathTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pemPathTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.pemPathTextBox.Location = new System.Drawing.Point(44, 44);
            this.pemPathTextBox.Name = "pemPathTextBox";
            this.pemPathTextBox.Size = new System.Drawing.Size(389, 20);
            this.pemPathTextBox.TabIndex = 3;
            // 
            // pdfPathTextBox
            // 
            this.pdfPathTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.pdfPathTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pdfPathTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.pdfPathTextBox.Location = new System.Drawing.Point(44, 18);
            this.pdfPathTextBox.Name = "pdfPathTextBox";
            this.pdfPathTextBox.Size = new System.Drawing.Size(389, 20);
            this.pdfPathTextBox.TabIndex = 2;
            // 
            // darkTitle2
            // 
            this.darkTitle2.AutoSize = true;
            this.darkTitle2.Location = new System.Drawing.Point(7, 47);
            this.darkTitle2.Name = "darkTitle2";
            this.darkTitle2.Size = new System.Drawing.Size(34, 13);
            this.darkTitle2.TabIndex = 1;
            this.darkTitle2.Text = ".Pem:";
            // 
            // darkTitle1
            // 
            this.darkTitle1.AutoSize = true;
            this.darkTitle1.Location = new System.Drawing.Point(7, 20);
            this.darkTitle1.Name = "darkTitle1";
            this.darkTitle1.Size = new System.Drawing.Size(31, 13);
            this.darkTitle1.TabIndex = 0;
            this.darkTitle1.Text = "PDF:";
            // 
            // EncryptButton
            // 
            this.EncryptButton.Location = new System.Drawing.Point(107, 110);
            this.EncryptButton.Name = "EncryptButton";
            this.EncryptButton.Padding = new System.Windows.Forms.Padding(5);
            this.EncryptButton.Size = new System.Drawing.Size(433, 23);
            this.EncryptButton.TabIndex = 2;
            this.EncryptButton.Text = "Mã Hoá";
            this.EncryptButton.Click += new System.EventHandler(this.EncryptButton_Click);
            // 
            // DecryptButton
            // 
            this.DecryptButton.Location = new System.Drawing.Point(13, 110);
            this.DecryptButton.Name = "DecryptButton";
            this.DecryptButton.Padding = new System.Windows.Forms.Padding(5);
            this.DecryptButton.Size = new System.Drawing.Size(88, 23);
            this.DecryptButton.TabIndex = 3;
            this.DecryptButton.Text = "Giải Mã";
            this.DecryptButton.Click += new System.EventHandler(this.DecryptButton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 150);
            this.Controls.Add(this.DecryptButton);
            this.Controls.Add(this.EncryptButton);
            this.Controls.Add(this.darkGroupBox1);
            this.Controls.Add(this.darkMenuStrip1);
            this.MainMenuStrip = this.darkMenuStrip1;
            this.Name = "Main";
            this.Text = "Main";
            this.darkMenuStrip1.ResumeLayout(false);
            this.darkMenuStrip1.PerformLayout();
            this.darkGroupBox1.ResumeLayout(false);
            this.darkGroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DarkUI.Controls.DarkMenuStrip darkMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tạoRSAKeyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private DarkUI.Controls.DarkGroupBox darkGroupBox1;
        private DarkUI.Controls.DarkButton SelectPrivateKeyButton;
        private DarkUI.Controls.DarkButton SelectPdfButton;
        private DarkUI.Controls.DarkTextBox pemPathTextBox;
        private DarkUI.Controls.DarkTextBox pdfPathTextBox;
        private DarkUI.Controls.DarkTitle darkTitle2;
        private DarkUI.Controls.DarkTitle darkTitle1;
        private DarkUI.Controls.DarkButton EncryptButton;
        private DarkUI.Controls.DarkButton DecryptButton;
    }
}