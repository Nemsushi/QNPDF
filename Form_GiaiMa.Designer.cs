namespace QNPDF
{
    partial class Form_GiaiMa
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
            this.DecryptButton = new DarkUI.Controls.DarkButton();
            this.SelectPdfButton = new DarkUI.Controls.DarkButton();
            this.pdfPathTextBox = new DarkUI.Controls.DarkTextBox();
            this.darkGroupBox1 = new DarkUI.Controls.DarkGroupBox();
            this.SelectPrivateKeyButton = new DarkUI.Controls.DarkButton();
            this.pemPathTextBox = new DarkUI.Controls.DarkTextBox();
            this.darkTitle2 = new DarkUI.Controls.DarkTitle();
            this.darkTitle1 = new DarkUI.Controls.DarkTitle();
            this.darkGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DecryptButton
            // 
            this.DecryptButton.Location = new System.Drawing.Point(12, 95);
            this.DecryptButton.Name = "DecryptButton";
            this.DecryptButton.Padding = new System.Windows.Forms.Padding(5);
            this.DecryptButton.Size = new System.Drawing.Size(528, 23);
            this.DecryptButton.TabIndex = 7;
            this.DecryptButton.Text = "Giải Mã";
            this.DecryptButton.Click += new System.EventHandler(this.DecryptButton_Click);
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
            // darkGroupBox1
            // 
            this.darkGroupBox1.BorderColor = System.Drawing.Color.White;
            this.darkGroupBox1.Controls.Add(this.SelectPrivateKeyButton);
            this.darkGroupBox1.Controls.Add(this.SelectPdfButton);
            this.darkGroupBox1.Controls.Add(this.pemPathTextBox);
            this.darkGroupBox1.Controls.Add(this.pdfPathTextBox);
            this.darkGroupBox1.Controls.Add(this.darkTitle2);
            this.darkGroupBox1.Controls.Add(this.darkTitle1);
            this.darkGroupBox1.Location = new System.Drawing.Point(12, 12);
            this.darkGroupBox1.Name = "darkGroupBox1";
            this.darkGroupBox1.Size = new System.Drawing.Size(528, 77);
            this.darkGroupBox1.TabIndex = 5;
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
            // Form_GiaiMa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 132);
            this.Controls.Add(this.DecryptButton);
            this.Controls.Add(this.darkGroupBox1);
            this.Name = "Form_GiaiMa";
            this.Text = "Form_GiaiMa";
            this.darkGroupBox1.ResumeLayout(false);
            this.darkGroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DarkUI.Controls.DarkButton DecryptButton;
        private DarkUI.Controls.DarkButton SelectPdfButton;
        private DarkUI.Controls.DarkTextBox pdfPathTextBox;
        private DarkUI.Controls.DarkGroupBox darkGroupBox1;
        private DarkUI.Controls.DarkButton SelectPrivateKeyButton;
        private DarkUI.Controls.DarkTextBox pemPathTextBox;
        private DarkUI.Controls.DarkTitle darkTitle2;
        private DarkUI.Controls.DarkTitle darkTitle1;
    }
}