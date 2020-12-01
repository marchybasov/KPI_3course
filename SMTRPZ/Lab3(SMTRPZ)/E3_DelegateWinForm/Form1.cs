using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E3_DelegateWinForm
{
    public partial class Form1 : Form
    {
        string lifeTimeInfo;
        public Form1()
        {
            InitializeComponent();
            FormClosing += new FormClosingEventHandler(MainForm_FormClosing);
            Load += new EventHandler(MainForm_Load);
            FormClosed += new FormClosedEventHandler(MainForm_FormClosed);
            Activated += new EventHandler(MainForm_Activated);
            Deactivate += new EventHandler(MainForm_Deactivate);

        }

        private void MainForm_Deactivate(object sender, EventArgs e)
        {
            lifeTimeInfo += "Событие Deactivate\n";
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            lifeTimeInfo += "Событие Activated\n";
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            lifeTimeInfo += "Событие FormClosed\n";
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            lifeTimeInfo += "Событие Load\n";
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Вы действительно хотите закрыть приложение?", "Событие Closing", MessageBoxButtons.YesNo);

            if (dr == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                MessageBox.Show(lifeTimeInfo);
                e.Cancel = false;
            }
        }


    }
}
