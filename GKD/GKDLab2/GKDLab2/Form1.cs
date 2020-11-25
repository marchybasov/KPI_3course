using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Threading;
using System.IO;

namespace GKDLab2
{
    public partial class Form1 : Form
    {
        string newFilePath, keywordFilePath, cipheredFilePath, partnerCipheredFilePath, partnerKeywordPath, uncipheredFilePath;
        DateTime timeStamp = DateTime.Now;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse);

        public Form1()
        {
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            pnlNav.Height = btnCreateNewFile.Height;
            pnlNav.Top = btnCreateNewFile.Top;
            pnlNav.Left = btnCreateNewFile.Left;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCreateNewFile_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnCreateNewFile.Height;
            pnlNav.Top = btnCreateNewFile.Top;
            pnlNav.Left = btnCreateNewFile.Left;
            btnCreateNewFile.BackColor = Color.FromArgb(46, 51, 73);
            newFilePath = UserDialogHandler.GetFileName("Archybasov", "Create a text file");
            if (newFilePath != String.Empty && newFilePath != null)
            {
                TxtFileHandler.CreateAndOpenNewTxtFile(newFilePath);
                
                txtLog.AppendText($"{GetTimeStamp()} - New file \"{Path.GetFileName(newFilePath)}\" with an original text was created\n");
                txtLog.AppendText(Environment.NewLine);
            }
            else
            {
                MessageBox.Show("Please define a new file name");
            }


        }

       

        private string GetTimeStamp() => timeStamp.ToString("MM/dd/yyyy hh:mm:ss");

        private void btnCreateKeyWord_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnCreateKeyWord.Height;
            pnlNav.Top = btnCreateKeyWord.Top;
            pnlNav.Left = btnCreateKeyWord.Left;
            btnCreateKeyWord.BackColor = Color.FromArgb(46, 51, 73);
            keywordFilePath = UserDialogHandler.GetFileName("Archybasov", "Create a keyword file");
            if (keywordFilePath != String.Empty && keywordFilePath != null)
            {
                TxtFileHandler.CreateAndOpenNewTxtFile(keywordFilePath);
                txtLog.AppendText($"{GetTimeStamp()} -New file \"{Path.GetFileName(keywordFilePath)}\" with a keyword was created");
                txtLog.AppendText(Environment.NewLine);
            }
            else
            {
                MessageBox.Show("Please define a new file name");

            }

        }

        private void btnEncryptFile_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnEncryptFile.Height;
            pnlNav.Top = btnEncryptFile.Top;
            pnlNav.Left = btnEncryptFile.Left;
            btnEncryptFile.BackColor = Color.FromArgb(46, 51, 73);
            if (File.Exists(newFilePath) && File.Exists(keywordFilePath))
            {
                cipheredFilePath = UserDialogHandler.GetFileName("Archybasov", "Save an encripted file");
                string content = TxtFileHandler.ReadContentFromFile(newFilePath);
                string keyWord = TxtFileHandler.ReadContentFromFile(keywordFilePath);

                string cipheredString = new Cipher().CipherString(content, keyWord);
                txtLog.AppendText($"{GetTimeStamp()} -File \"{Path.GetFileName(cipheredFilePath)}\" was encrypted");
                txtLog.AppendText(Environment.NewLine);
                TxtFileHandler.CreateAndWriteContent(cipheredFilePath, cipheredString);


            }
            else
            {
                MessageBox.Show("Cannot locate files.Please create file to be encrypted and keyword file first.");
                // throw new Exception("Cannot locate files. Please create file to be encrypted and keyword file first.");
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnBrowse.Height;
            pnlNav.Top = btnBrowse.Top;
            pnlNav.Left = btnBrowse.Left;
            btnBrowse.BackColor = Color.FromArgb(46, 51, 73);
            partnerCipheredFilePath = UserDialogHandler.BrowseToFile("untitled", "Find ciphered file.");
            txtLog.AppendText( $"{GetTimeStamp()} - File \"{Path.GetFileName(partnerCipheredFilePath)}\" was found");
            txtLog.AppendText(Environment.NewLine);

        }

        private void btnDecryptFile_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnDecryptFile.Height;
            pnlNav.Top = btnDecryptFile.Top;
            pnlNav.Left = btnDecryptFile.Left;
            btnDecryptFile.BackColor = Color.FromArgb(46, 51, 73);


            if (File.Exists(partnerCipheredFilePath) && File.Exists(partnerKeywordPath))
            {
                uncipheredFilePath = UserDialogHandler.GetFileName("Archybasov", "Save a decripted file");
                string content = TxtFileHandler.ReadContentFromFile(partnerCipheredFilePath);
                string keywordVal = TxtFileHandler.ReadContentFromFile(partnerKeywordPath);
                string uncipheredString = new Cipher().UncipherString(content, keywordVal);
                TxtFileHandler.CreateAndWriteContent(uncipheredFilePath, uncipheredString);
                txtLog.AppendText($"{GetTimeStamp()} - File \"{Path.GetFileName(partnerCipheredFilePath)}\" was decrypted");
                txtLog.AppendText(Environment.NewLine);

            }
            else
            {
                MessageBox.Show("Cannot locate files.Please create file to be encrypted and keyword file first.");
               
            }

        }

        private void btnLogFile_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnLogFile.Height;
            pnlNav.Top = btnLogFile.Top;
            pnlNav.Left = btnLogFile.Left;
            btnLogFile.BackColor = Color.FromArgb(46, 51, 73);
            if (File.Exists(@".\log.txt"))
            {
                Process.Start(@".\log.txt");
            }
            else
            {
                MessageBox.Show("Log file doesn't exist");
            }

        }

        private void btnCreateNewFile_Leave(object sender, EventArgs e)
        {
            btnCreateNewFile.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnCreateKeyWord_Leave(object sender, EventArgs e)
        {
            btnCreateKeyWord.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnEncryptFile_Leave(object sender, EventArgs e)
        {
            btnEncryptFile.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnFindKey_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnFindKey.Height;
            pnlNav.Top = btnFindKey.Top;
            pnlNav.Left = btnFindKey.Left;
            btnFindKey.BackColor = Color.FromArgb(46, 51, 73);
            partnerKeywordPath = UserDialogHandler.BrowseToFile("untitled", "Find keyword file.");
            txtLog.AppendText($"{GetTimeStamp()} - File \"{Path.GetFileName(partnerCipheredFilePath)}\" with keyword was found");
            txtLog.AppendText(Environment.NewLine);
        }

        private void btnFindKey_Leave(object sender, EventArgs e)
        {
            btnFindKey.BackColor = Color.FromArgb(24, 30, 54);

        }

        private void btnBrowse_Leave(object sender, EventArgs e)
        {
            btnBrowse.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnDecryptFile_Leave(object sender, EventArgs e)
        {
            btnDecryptFile.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string logContent = txtLog.Text;
            TxtFileHandler.LogEvents(logContent);
            this.Close();
        }

        private void btnLogFile_Leave(object sender, EventArgs e)
        {
            btnLogFile.BackColor = Color.FromArgb(24, 30, 54);
        }
    }
}
