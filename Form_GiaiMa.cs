using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DarkUI.Forms;
using System.Windows.Forms;

namespace QNPDF
{
    public partial class Form_GiaiMa : DarkForm
    {
        private string pdfFilePath;
        private string pemFilePath;
        public Form_GiaiMa()
        {
            InitializeComponent();
        }

        private void SelectPdfButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "PDF Files (*.pdf)|*.pdf";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pdfFilePath = openFileDialog.FileName;
                pdfPathTextBox.Text = pdfFilePath;
            }
        }

        private void SelectPrivateKeyButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "PEM Files (*.pem)|*.pem";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pemFilePath = openFileDialog.FileName;
                pemPathTextBox.Text = pemFilePath;
            }
        }

        private void DecryptButton_Click(object sender, EventArgs e)
        {
            if (File.Exists(pdfFilePath) && File.Exists(pemFilePath))
            {
                // Goi Encryption.cs de ma hoa PDF
                Encryption.DecryptPDF(pdfFilePath, pemFilePath);
                MessageBox.Show("Giải mã PDF thành công!", "Giải mã", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn đủ .PDF and .PEM", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
