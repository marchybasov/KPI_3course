namespace GKDLab2
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.btnLogFile = new System.Windows.Forms.Button();
            this.btnDecryptFile = new System.Windows.Forms.Button();
            this.btnFindKey = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnEncryptFile = new System.Windows.Forms.Button();
            this.btnCreateKeyWord = new System.Windows.Forms.Button();
            this.btnCreateNewFile = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtLog = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 54);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.pnlNav);
            this.panel1.Controls.Add(this.btnLogFile);
            this.panel1.Controls.Add(this.btnDecryptFile);
            this.panel1.Controls.Add(this.btnFindKey);
            this.panel1.Controls.Add(this.btnBrowse);
            this.panel1.Controls.Add(this.btnEncryptFile);
            this.panel1.Controls.Add(this.btnCreateKeyWord);
            this.panel1.Controls.Add(this.btnCreateNewFile);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(229, 534);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.pnlNav.Location = new System.Drawing.Point(0, 248);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(3, 100);
            this.pnlNav.TabIndex = 3;
            // 
            // btnLogFile
            // 
            this.btnLogFile.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogFile.FlatAppearance.BorderSize = 0;
            this.btnLogFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLogFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnLogFile.Image = global::GKDLab2.Properties.Resources.log_icon;
            this.btnLogFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogFile.Location = new System.Drawing.Point(0, 492);
            this.btnLogFile.Name = "btnLogFile";
            this.btnLogFile.Size = new System.Drawing.Size(229, 42);
            this.btnLogFile.TabIndex = 3;
            this.btnLogFile.Text = "View Log File";
            this.btnLogFile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogFile.UseVisualStyleBackColor = true;
            this.btnLogFile.Click += new System.EventHandler(this.btnLogFile_Click);
            this.btnLogFile.Leave += new System.EventHandler(this.btnLogFile_Leave);
            // 
            // btnDecryptFile
            // 
            this.btnDecryptFile.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDecryptFile.FlatAppearance.BorderSize = 0;
            this.btnDecryptFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDecryptFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDecryptFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnDecryptFile.Image = global::GKDLab2.Properties.Resources.unlock_icon;
            this.btnDecryptFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDecryptFile.Location = new System.Drawing.Point(0, 410);
            this.btnDecryptFile.Name = "btnDecryptFile";
            this.btnDecryptFile.Size = new System.Drawing.Size(229, 42);
            this.btnDecryptFile.TabIndex = 3;
            this.btnDecryptFile.Text = "Decrypt file";
            this.btnDecryptFile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDecryptFile.UseVisualStyleBackColor = true;
            this.btnDecryptFile.Click += new System.EventHandler(this.btnDecryptFile_Click);
            this.btnDecryptFile.Leave += new System.EventHandler(this.btnDecryptFile_Leave);
            // 
            // btnFindKey
            // 
            this.btnFindKey.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFindKey.FlatAppearance.BorderSize = 0;
            this.btnFindKey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFindKey.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnFindKey.Image = global::GKDLab2.Properties.Resources.Key_icon;
            this.btnFindKey.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFindKey.Location = new System.Drawing.Point(0, 368);
            this.btnFindKey.Name = "btnFindKey";
            this.btnFindKey.Size = new System.Drawing.Size(229, 42);
            this.btnFindKey.TabIndex = 3;
            this.btnFindKey.Text = "Get KeyWord";
            this.btnFindKey.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFindKey.UseVisualStyleBackColor = true;
            this.btnFindKey.Click += new System.EventHandler(this.btnFindKey_Click);
            this.btnFindKey.Leave += new System.EventHandler(this.btnFindKey_Leave);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBrowse.FlatAppearance.BorderSize = 0;
            this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBrowse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnBrowse.Image = global::GKDLab2.Properties.Resources.Preview_2_icon;
            this.btnBrowse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBrowse.Location = new System.Drawing.Point(0, 326);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(229, 42);
            this.btnBrowse.TabIndex = 3;
            this.btnBrowse.Text = "Browse to file";
            this.btnBrowse.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            this.btnBrowse.Leave += new System.EventHandler(this.btnBrowse_Leave);
            // 
            // btnEncryptFile
            // 
            this.btnEncryptFile.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEncryptFile.FlatAppearance.BorderSize = 0;
            this.btnEncryptFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEncryptFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEncryptFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnEncryptFile.Image = global::GKDLab2.Properties.Resources.lock_icon;
            this.btnEncryptFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEncryptFile.Location = new System.Drawing.Point(0, 284);
            this.btnEncryptFile.Name = "btnEncryptFile";
            this.btnEncryptFile.Size = new System.Drawing.Size(229, 42);
            this.btnEncryptFile.TabIndex = 3;
            this.btnEncryptFile.Text = "Encrypt File";
            this.btnEncryptFile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEncryptFile.UseVisualStyleBackColor = true;
            this.btnEncryptFile.Click += new System.EventHandler(this.btnEncryptFile_Click);
            this.btnEncryptFile.Leave += new System.EventHandler(this.btnEncryptFile_Leave);
            // 
            // btnCreateKeyWord
            // 
            this.btnCreateKeyWord.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCreateKeyWord.FlatAppearance.BorderSize = 0;
            this.btnCreateKeyWord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateKeyWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCreateKeyWord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnCreateKeyWord.Image = global::GKDLab2.Properties.Resources.PadLock_icon;
            this.btnCreateKeyWord.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateKeyWord.Location = new System.Drawing.Point(0, 242);
            this.btnCreateKeyWord.Name = "btnCreateKeyWord";
            this.btnCreateKeyWord.Size = new System.Drawing.Size(229, 42);
            this.btnCreateKeyWord.TabIndex = 3;
            this.btnCreateKeyWord.Text = "Create KeyWord File";
            this.btnCreateKeyWord.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCreateKeyWord.UseVisualStyleBackColor = true;
            this.btnCreateKeyWord.Click += new System.EventHandler(this.btnCreateKeyWord_Click);
            this.btnCreateKeyWord.Leave += new System.EventHandler(this.btnCreateKeyWord_Leave);
            // 
            // btnCreateNewFile
            // 
            this.btnCreateNewFile.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCreateNewFile.FlatAppearance.BorderSize = 0;
            this.btnCreateNewFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateNewFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCreateNewFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnCreateNewFile.Image = global::GKDLab2.Properties.Resources.New_file_icon;
            this.btnCreateNewFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateNewFile.Location = new System.Drawing.Point(0, 200);
            this.btnCreateNewFile.Name = "btnCreateNewFile";
            this.btnCreateNewFile.Size = new System.Drawing.Size(229, 42);
            this.btnCreateNewFile.TabIndex = 3;
            this.btnCreateNewFile.Text = "Create Text File";
            this.btnCreateNewFile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCreateNewFile.UseVisualStyleBackColor = true;
            this.btnCreateNewFile.Click += new System.EventHandler(this.btnCreateNewFile_Click);
            this.btnCreateNewFile.Leave += new System.EventHandler(this.btnCreateNewFile_Leave);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(229, 200);
            this.panel2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label2.Location = new System.Drawing.Point(39, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Арчибасов Максим";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label1.Location = new System.Drawing.Point(29, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Лабораторна робота 2";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pictureBox1.Image = global::GKDLab2.Properties.Resources.photo_2020_06_26_18_04_23;
            this.pictureBox1.Location = new System.Drawing.Point(64, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(725, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(36, 27);
            this.button2.TabIndex = 2;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label4.Location = new System.Drawing.Point(235, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 33);
            this.label4.TabIndex = 4;
            this.label4.Text = "Event Log";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtLog
            // 
            this.txtLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.txtLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLog.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.txtLog.Location = new System.Drawing.Point(229, 95);
            this.txtLog.Margin = new System.Windows.Forms.Padding(10);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(544, 439);
            this.txtLog.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(773, 534);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCreateNewFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogFile;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnEncryptFile;
        private System.Windows.Forms.Button btnCreateKeyWord;
        private System.Windows.Forms.Button btnFindKey;
        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDecryptFile;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtLog;
    }
}

