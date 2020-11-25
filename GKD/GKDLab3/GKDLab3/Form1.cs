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
using System.Collections;
using System.Collections.Generic;

namespace GKDLab3
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
            pnlNav.Height = btnSaveQuestions.Height;
            pnlNav.Top = btnSaveQuestions.Top;
            pnlNav.Left = btnSaveQuestions.Left;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }




        private string GetTimeStamp() => timeStamp.ToString("MM/dd/yyyy hh:mm:ss");

      


        private void btnBrowse_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnOpenAnswers.Height;
            pnlNav.Top = btnOpenAnswers.Top;
            pnlNav.Left = btnOpenAnswers.Left;
            btnOpenAnswers.BackColor = Color.FromArgb(46, 51, 73);
            partnerCipheredFilePath = UserDialogHandler.BrowseToFile("untitled", "Find ciphered file.");
            //txtLog.AppendText( $"{GetTimeStamp()} - File \"{Path.GetFileName(partnerCipheredFilePath)}\" was found");
            //txtLog.AppendText(Environment.NewLine);

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

        


        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_qst1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_answer2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSaveQuestions_Click(object sender, EventArgs e)
        {

            pnlNav.Height = btnSaveQuestions.Height;
            pnlNav.Top = btnSaveQuestions.Top;
            pnlNav.Left = btnSaveQuestions.Left;
            btnSaveQuestions.BackColor = Color.FromArgb(46, 51, 73);
            string qstListPath = UserDialogHandler.GetFileName("(Lab4) Archybasov","Save your questions list");
            string[] qstArr = new string[5];
            int i = 0;
            foreach  (Control control in  panel3.Controls)
            {
                foreach (TextBox txtBox in  control.Controls.OfType<TextBox>())
                {
                    if (txtBox.Name.Contains("qst"))
                    {
                        qstArr[i] = txtBox.Text;
                        i++;
                    }
                }              
              
            }

            TxtFileHandler.CreateAndWriteContent(qstListPath, String.Join("\n", qstArr.Reverse()));

        }

        private void btnSaveQuestions_Leave(object sender, EventArgs e)
        {
            btnSaveQuestions.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnOpenQuestions_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnOpenQuestions.Height;
            pnlNav.Top = btnOpenQuestions.Top;
            pnlNav.Left = btnOpenQuestions.Left;
            btnOpenQuestions.BackColor = Color.FromArgb(46, 51, 73);
            string[] questionsList = TxtFileHandler.ReadContentFromFile(UserDialogHandler.BrowseToFile("Questions", "Find questions list location")).Split('\n').Reverse().ToArray();
            
            int i = 0;
            foreach (Control control in panel3.Controls)
            {
                foreach (TextBox txtBox in control.Controls.OfType<TextBox>())
                {
                    if (txtBox.Name.Contains("qst"))
                    {
                        txtBox.Text= questionsList[i] ;
                        i++;
                    }
                }

            }

        }

        private void btnOpenQuestions_Leave(object sender, EventArgs e)
        {
            btnOpenQuestions.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnSaveAnswers_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnSaveAnswers.Height;
            pnlNav.Top = btnSaveAnswers.Top;
            pnlNav.Left = btnSaveAnswers.Left;
            btnSaveAnswers.BackColor = Color.FromArgb(46, 51, 73);

            string answersListPath = UserDialogHandler.GetFileName("(lab4) Archybasov", "Save your answers list");
            string[] answersArr = new string[5];
            int i = 0;
            foreach (Control control in panel3.Controls)
            {
                foreach (TextBox txtBox in control.Controls.OfType<TextBox>())
                {
                    if (txtBox.Name.Contains("answer"))
                    {
                        answersArr[i] = txtBox.Text;
                        i++;
                    }
                }

            }

            TxtFileHandler.CreateAndWriteContent(answersListPath, String.Join("\n", answersArr.Reverse()));

        }

        private void btnSaveAnswers_Leave(object sender, EventArgs e)
        {
            btnSaveAnswers.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnOpenAnswers_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnOpenAnswers.Height;
            pnlNav.Top = btnOpenAnswers.Top;
            pnlNav.Left = btnOpenAnswers.Left;
            btnOpenAnswers.BackColor = Color.FromArgb(46, 51, 73);

            string[] answersList = TxtFileHandler.ReadContentFromFile(UserDialogHandler.BrowseToFile("Answers", "Find answers list location")).Split('\n').Reverse().ToArray();

            int i = 0;
            foreach (Control control in panel3.Controls)
            {
                foreach (TextBox txtBox in control.Controls.OfType<TextBox>())
                {
                    if (txtBox.Name.Contains("qst"))
                    {
                        txtBox.Text = answersList[i];
                        i++;
                    }
                }

            }

        }

        private void btnOpenAnswers_Leave(object sender, EventArgs e)
        {
            btnOpenAnswers.BackColor = Color.FromArgb(24, 30, 54);

        }

     


        private void btnBrowse_Leave(object sender, EventArgs e)
        {
            btnOpenAnswers.BackColor = Color.FromArgb(24, 30, 54);
        }

     
        private void button2_Click(object sender, EventArgs e)
        {
            //string logContent = txtLog.Text;
            //TxtFileHandler.LogEvents(logContent);
            this.Close();
        }

        private void btnLogFile_Leave(object sender, EventArgs e)
        {
            btnLogFile.BackColor = Color.FromArgb(24, 30, 54);
        }
    }
}
