using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DarkUI.Forms;

namespace QNPDF
{
    public partial class Main : DarkForm
    {
        private string pdfFilePath;
        private string pemFilePath;
        public Main()
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

        private void tạoRSAKeyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PEM Files (*.pem)|*.pem";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Goi Encryption.cs de tao key .pem
                Encryption.GeneratePEMKey(saveFileDialog.FileName);
                MessageBox.Show("Tạo key .PEM thành công!", "Tạo key RSA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void EncryptButton_Click(object sender, EventArgs e)
        {
            if (File.Exists(pdfFilePath) && File.Exists(pemFilePath))
            {
                // Goi Encryption.cs de ma hoa PDF
                Encryption.EncryptPDF(pdfFilePath, pemFilePath);
                MessageBox.Show("Mã hoá PDF thành công!", "Mã hoá", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn đủ .PDF and .PEM", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DecryptButton_Click(object sender, EventArgs e)
        {
            Form_GiaiMa frmgm = new Form_GiaiMa();
            frmgm.ShowDialog();
        }
    }
}
