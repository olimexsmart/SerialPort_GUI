namespace SerialPort_GUI
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ConnectB = new System.Windows.Forms.Button();
            this.COMpick = new System.Windows.Forms.ComboBox();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.inBox = new System.Windows.Forms.TextBox();
            this.SendB = new System.Windows.Forms.Button();
            this.baudRate = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.outBox = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.inputFileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.clearAllMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.copyAllMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.quitMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lineEndingMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.noLineEndingMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.newlineMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.carriageRMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.bothNLCRMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.autoscrollMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.infoMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMeMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.byReceivedText = new System.Windows.Forms.ToolStripStatusLabel();
            this.byReceivedN = new System.Windows.Forms.ToolStripStatusLabel();
            this.bySentText = new System.Windows.Forms.ToolStripStatusLabel();
            this.bySentN = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ConnectB
            // 
            this.ConnectB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ConnectB.Location = new System.Drawing.Point(329, 17);
            this.ConnectB.Name = "ConnectB";
            this.ConnectB.Size = new System.Drawing.Size(75, 23);
            this.ConnectB.TabIndex = 1;
            this.ConnectB.Text = "Connect";
            this.ConnectB.UseVisualStyleBackColor = true;
            this.ConnectB.Click += new System.EventHandler(this.ConnectB_Click);
            // 
            // COMpick
            // 
            this.COMpick.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.COMpick.FormattingEnabled = true;
            this.COMpick.Location = new System.Drawing.Point(46, 19);
            this.COMpick.Name = "COMpick";
            this.COMpick.Size = new System.Drawing.Size(121, 21);
            this.COMpick.TabIndex = 2;
            this.COMpick.DropDown += new System.EventHandler(this.comboBox1_DropDown);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "txt";
            this.saveFileDialog.FileName = "serial_dump";
            this.saveFileDialog.Filter = "TXT file|*.txt|Others|*.*";
            this.saveFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog_FileOk);
            // 
            // inBox
            // 
            this.inBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inBox.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inBox.Location = new System.Drawing.Point(6, 19);
            this.inBox.Name = "inBox";
            this.inBox.Size = new System.Drawing.Size(317, 22);
            this.inBox.TabIndex = 3;
            this.inBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inBox_KeyDown);
            // 
            // SendB
            // 
            this.SendB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SendB.Location = new System.Drawing.Point(329, 16);
            this.SendB.Name = "SendB";
            this.SendB.Size = new System.Drawing.Size(75, 23);
            this.SendB.TabIndex = 4;
            this.SendB.Text = "Send";
            this.SendB.UseVisualStyleBackColor = true;
            this.SendB.Click += new System.EventHandler(this.SendB_Click);
            // 
            // baudRate
            // 
            this.baudRate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.baudRate.FormattingEnabled = true;
            this.baudRate.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "28800",
            "38400",
            "57600",
            "76800",
            "115200"});
            this.baudRate.Location = new System.Drawing.Point(235, 19);
            this.baudRate.Name = "baudRate";
            this.baudRate.Size = new System.Drawing.Size(88, 21);
            this.baudRate.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.outBox);
            this.panel1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.panel1.Location = new System.Drawing.Point(6, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(398, 375);
            this.panel1.TabIndex = 7;
            // 
            // outBox
            // 
            this.outBox.AutoSize = true;
            this.outBox.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outBox.Location = new System.Drawing.Point(0, 0);
            this.outBox.Name = "outBox";
            this.outBox.Size = new System.Drawing.Size(0, 16);
            this.outBox.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.COMpick);
            this.groupBox1.Controls.Add(this.baudRate);
            this.groupBox1.Controls.Add(this.ConnectB);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(410, 427);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Output";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(173, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Baud rate:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "COM:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.inBox);
            this.groupBox2.Controls.Add(this.SendB);
            this.groupBox2.Location = new System.Drawing.Point(12, 460);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(410, 48);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Input";
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.aboutMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(434, 24);
            this.menuStrip.TabIndex = 10;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveFileMenu,
            this.inputFileMenu,
            this.toolStripSeparator2,
            this.clearAllMenu,
            this.copyAllMenu,
            this.toolStripSeparator1,
            this.quitMenu});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveFileMenu
            // 
            this.saveFileMenu.Name = "saveFileMenu";
            this.saveFileMenu.Size = new System.Drawing.Size(121, 22);
            this.saveFileMenu.Text = "Save file";
            this.saveFileMenu.Click += new System.EventHandler(this.saveFileMenu_Click);
            // 
            // inputFileMenu
            // 
            this.inputFileMenu.Name = "inputFileMenu";
            this.inputFileMenu.Size = new System.Drawing.Size(121, 22);
            this.inputFileMenu.Text = "Input file";
            this.inputFileMenu.Click += new System.EventHandler(this.inputFileMenu_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(118, 6);
            // 
            // clearAllMenu
            // 
            this.clearAllMenu.Name = "clearAllMenu";
            this.clearAllMenu.Size = new System.Drawing.Size(121, 22);
            this.clearAllMenu.Text = "Clear all";
            this.clearAllMenu.Click += new System.EventHandler(this.clearAllMenu_Click);
            // 
            // copyAllMenu
            // 
            this.copyAllMenu.Name = "copyAllMenu";
            this.copyAllMenu.Size = new System.Drawing.Size(121, 22);
            this.copyAllMenu.Text = "Copy all";
            this.copyAllMenu.Click += new System.EventHandler(this.copyAllMenu_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(118, 6);
            // 
            // quitMenu
            // 
            this.quitMenu.Name = "quitMenu";
            this.quitMenu.Size = new System.Drawing.Size(121, 22);
            this.quitMenu.Text = "Quit";
            this.quitMenu.Click += new System.EventHandler(this.quitMenu_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lineEndingMenu,
            this.autoscrollMenu});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // lineEndingMenu
            // 
            this.lineEndingMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.noLineEndingMenu,
            this.newlineMenu,
            this.carriageRMenu,
            this.bothNLCRMenu});
            this.lineEndingMenu.Name = "lineEndingMenu";
            this.lineEndingMenu.Size = new System.Drawing.Size(136, 22);
            this.lineEndingMenu.Text = "Line ending";
            // 
            // noLineEndingMenu
            // 
            this.noLineEndingMenu.Name = "noLineEndingMenu";
            this.noLineEndingMenu.Size = new System.Drawing.Size(158, 22);
            this.noLineEndingMenu.Text = "No line ending";
            // 
            // newlineMenu
            // 
            this.newlineMenu.Name = "newlineMenu";
            this.newlineMenu.Size = new System.Drawing.Size(158, 22);
            this.newlineMenu.Text = "Newline";
            // 
            // carriageRMenu
            // 
            this.carriageRMenu.Name = "carriageRMenu";
            this.carriageRMenu.Size = new System.Drawing.Size(158, 22);
            this.carriageRMenu.Text = "Carriage return";
            // 
            // bothNLCRMenu
            // 
            this.bothNLCRMenu.Name = "bothNLCRMenu";
            this.bothNLCRMenu.Size = new System.Drawing.Size(158, 22);
            this.bothNLCRMenu.Text = "Both NL and CR";
            // 
            // autoscrollMenu
            // 
            this.autoscrollMenu.Checked = true;
            this.autoscrollMenu.CheckOnClick = true;
            this.autoscrollMenu.CheckState = System.Windows.Forms.CheckState.Checked;
            this.autoscrollMenu.Name = "autoscrollMenu";
            this.autoscrollMenu.Size = new System.Drawing.Size(136, 22);
            this.autoscrollMenu.Text = "Autoscroll";
            // 
            // aboutMenu
            // 
            this.aboutMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoMenu,
            this.helpMeMenu});
            this.aboutMenu.Name = "aboutMenu";
            this.aboutMenu.Size = new System.Drawing.Size(52, 20);
            this.aboutMenu.Text = "About";
            // 
            // infoMenu
            // 
            this.infoMenu.Name = "infoMenu";
            this.infoMenu.Size = new System.Drawing.Size(119, 22);
            this.infoMenu.Text = "Info";
            // 
            // helpMeMenu
            // 
            this.helpMeMenu.Image = ((System.Drawing.Image)(resources.GetObject("helpMeMenu.Image")));
            this.helpMeMenu.Name = "helpMeMenu";
            this.helpMeMenu.Size = new System.Drawing.Size(119, 22);
            this.helpMeMenu.Text = "Help me";
            // 
            // timer
            // 
            this.timer.Interval = 50;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.byReceivedText,
            this.byReceivedN,
            this.bySentText,
            this.bySentN,
            this.toolStripStatusLabel1,
            this.toolStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 511);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(434, 24);
            this.statusStrip1.TabIndex = 11;
            // 
            // byReceivedText
            // 
            this.byReceivedText.Name = "byReceivedText";
            this.byReceivedText.Size = new System.Drawing.Size(60, 19);
            this.byReceivedText.Text = "Received: ";
            // 
            // byReceivedN
            // 
            this.byReceivedN.Name = "byReceivedN";
            this.byReceivedN.Size = new System.Drawing.Size(24, 19);
            this.byReceivedN.Text = "NC";
            // 
            // bySentText
            // 
            this.bySentText.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.bySentText.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.bySentText.Name = "bySentText";
            this.bySentText.Size = new System.Drawing.Size(40, 19);
            this.bySentText.Text = "Sent: ";
            // 
            // bySentN
            // 
            this.bySentN.Name = "bySentN";
            this.bySentN.Size = new System.Drawing.Size(24, 19);
            this.bySentN.Text = "NC";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(183, 19);
            this.toolStripStatusLabel1.Spring = true;
            this.toolStripStatusLabel1.Text = " ";
            // 
            // toolStatus
            // 
            this.toolStatus.Name = "toolStatus";
            this.toolStatus.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStatus.Size = new System.Drawing.Size(88, 19);
            this.toolStatus.Text = "Not Connected";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(434, 535);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(450, 550);
            this.Name = "MainForm";
            this.Text = "COMportBurst";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ConnectB;
        private System.Windows.Forms.ComboBox COMpick;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.TextBox inBox;
        private System.Windows.Forms.Button SendB;
        private System.Windows.Forms.ComboBox baudRate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label outBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveFileMenu;
        private System.Windows.Forms.ToolStripMenuItem inputFileMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem clearAllMenu;
        private System.Windows.Forms.ToolStripMenuItem copyAllMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem quitMenu;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lineEndingMenu;
        private System.Windows.Forms.ToolStripMenuItem noLineEndingMenu;
        private System.Windows.Forms.ToolStripMenuItem newlineMenu;
        private System.Windows.Forms.ToolStripMenuItem carriageRMenu;
        private System.Windows.Forms.ToolStripMenuItem bothNLCRMenu;
        private System.Windows.Forms.ToolStripMenuItem aboutMenu;
        private System.Windows.Forms.ToolStripMenuItem infoMenu;
        private System.Windows.Forms.ToolStripMenuItem helpMeMenu;
        private System.Windows.Forms.ToolStripMenuItem autoscrollMenu;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel byReceivedText;
        private System.Windows.Forms.ToolStripStatusLabel byReceivedN;
        private System.Windows.Forms.ToolStripStatusLabel bySentText;
        private System.Windows.Forms.ToolStripStatusLabel bySentN;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStatus;
    }
}

