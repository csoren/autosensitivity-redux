namespace AutoSensitivity
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelTouchpadMouseStatus = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonMouseApply = new System.Windows.Forms.Button();
            this.buttonTouchpadApply = new System.Windows.Forms.Button();
            this.buttonMouseGetCurrent = new System.Windows.Forms.Button();
            this.mouseBar = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonTouchpadGetCurrent = new System.Windows.Forms.Button();
            this.touchpadBar = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.linkLabelProgram = new System.Windows.Forms.LinkLabel();
            this.linkLabelDonate = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonMinimize = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.runAtStartupCB = new System.Windows.Forms.CheckBox();
            this.startMinimizedCB = new System.Windows.Forms.CheckBox();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mouseBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.touchpadBar)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTouchpadMouseStatus
            // 
            this.labelTouchpadMouseStatus.AutoSize = true;
            this.labelTouchpadMouseStatus.Location = new System.Drawing.Point(13, 356);
            this.labelTouchpadMouseStatus.Name = "labelTouchpadMouseStatus";
            this.labelTouchpadMouseStatus.Size = new System.Drawing.Size(80, 13);
            this.labelTouchpadMouseStatus.TabIndex = 0;
            this.labelTouchpadMouseStatus.Text = "Touchpad Only";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonMouseApply);
            this.groupBox1.Controls.Add(this.buttonTouchpadApply);
            this.groupBox1.Controls.Add(this.buttonMouseGetCurrent);
            this.groupBox1.Controls.Add(this.mouseBar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.buttonTouchpadGetCurrent);
            this.groupBox1.Controls.Add(this.touchpadBar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(6, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(364, 149);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sensitivities";
            // 
            // buttonMouseApply
            // 
            this.buttonMouseApply.Location = new System.Drawing.Point(281, 103);
            this.buttonMouseApply.Name = "buttonMouseApply";
            this.buttonMouseApply.Size = new System.Drawing.Size(75, 23);
            this.buttonMouseApply.TabIndex = 7;
            this.buttonMouseApply.Text = "Apply";
            this.buttonMouseApply.UseVisualStyleBackColor = true;
            this.buttonMouseApply.Click += new System.EventHandler(this.ButtonMouseApply);
            // 
            // buttonTouchpadApply
            // 
            this.buttonTouchpadApply.Location = new System.Drawing.Point(281, 37);
            this.buttonTouchpadApply.Name = "buttonTouchpadApply";
            this.buttonTouchpadApply.Size = new System.Drawing.Size(75, 23);
            this.buttonTouchpadApply.TabIndex = 6;
            this.buttonTouchpadApply.Text = "Apply";
            this.buttonTouchpadApply.UseVisualStyleBackColor = true;
            this.buttonTouchpadApply.Click += new System.EventHandler(this.ButtonTouchpadApply);
            // 
            // buttonMouseGetCurrent
            // 
            this.buttonMouseGetCurrent.Location = new System.Drawing.Point(199, 103);
            this.buttonMouseGetCurrent.Name = "buttonMouseGetCurrent";
            this.buttonMouseGetCurrent.Size = new System.Drawing.Size(75, 23);
            this.buttonMouseGetCurrent.TabIndex = 5;
            this.buttonMouseGetCurrent.Text = "Get Current";
            this.buttonMouseGetCurrent.UseVisualStyleBackColor = true;
            this.buttonMouseGetCurrent.Click += new System.EventHandler(this.ButtonMouseGetCurrent);
            // 
            // mouseBar
            // 
            this.mouseBar.Location = new System.Drawing.Point(13, 103);
            this.mouseBar.Maximum = 20;
            this.mouseBar.Name = "mouseBar";
            this.mouseBar.Size = new System.Drawing.Size(180, 45);
            this.mouseBar.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mouse";
            // 
            // buttonTouchpadGetCurrent
            // 
            this.buttonTouchpadGetCurrent.Location = new System.Drawing.Point(199, 37);
            this.buttonTouchpadGetCurrent.Name = "buttonTouchpadGetCurrent";
            this.buttonTouchpadGetCurrent.Size = new System.Drawing.Size(75, 23);
            this.buttonTouchpadGetCurrent.TabIndex = 2;
            this.buttonTouchpadGetCurrent.Text = "Get Current";
            this.buttonTouchpadGetCurrent.UseVisualStyleBackColor = true;
            this.buttonTouchpadGetCurrent.Click += new System.EventHandler(this.ButtonTouchpadGetCurrent);
            // 
            // touchpadBar
            // 
            this.touchpadBar.Location = new System.Drawing.Point(10, 37);
            this.touchpadBar.Maximum = 20;
            this.touchpadBar.Name = "touchpadBar";
            this.touchpadBar.Size = new System.Drawing.Size(183, 45);
            this.touchpadBar.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Touchpad";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.linkLabelProgram);
            this.groupBox2.Controls.Add(this.linkLabelDonate);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(6, 209);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(364, 130);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "About";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(10, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(342, 35);
            this.label5.TabIndex = 3;
            this.label5.Text = "If you like this utility, please consider donating to the original author";
            // 
            // linkLabelProgram
            // 
            this.linkLabelProgram.AutoSize = true;
            this.linkLabelProgram.Location = new System.Drawing.Point(10, 53);
            this.linkLabelProgram.Name = "linkLabelProgram";
            this.linkLabelProgram.Size = new System.Drawing.Size(232, 13);
            this.linkLabelProgram.TabIndex = 2;
            this.linkLabelProgram.TabStop = true;
            this.linkLabelProgram.Text = "https://github.com/csoren/autosensitivity-redux";
            this.linkLabelProgram.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel2LinkClicked);
            // 
            // linkLabelDonate
            // 
            this.linkLabelDonate.AutoSize = true;
            this.linkLabelDonate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.linkLabelDonate.Location = new System.Drawing.Point(10, 107);
            this.linkLabelDonate.Name = "linkLabelDonate";
            this.linkLabelDonate.Size = new System.Drawing.Size(48, 13);
            this.linkLabelDonate.TabIndex = 1;
            this.linkLabelDonate.TabStop = true;
            this.linkLabelDonate.Text = "Donate";
            this.linkLabelDonate.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 26);
            this.label4.TabIndex = 0;
            this.label4.Text = "2011 - Igor Kulman\r\n2012 - Carsten Elton Sørensen";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // buttonMinimize
            // 
            this.buttonMinimize.Location = new System.Drawing.Point(283, 346);
            this.buttonMinimize.Name = "buttonMinimize";
            this.buttonMinimize.Size = new System.Drawing.Size(75, 23);
            this.buttonMinimize.TabIndex = 3;
            this.buttonMinimize.Text = "Minimize";
            this.buttonMinimize.UseVisualStyleBackColor = true;
            this.buttonMinimize.Click += new System.EventHandler(this.Button5Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "AutoSensitivity";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIcon1MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.toolStripMenuItem5,
            this.toolStripMenuItem4,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(114, 126);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItemClick);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(113, 22);
            this.toolStripMenuItem5.Text = "Refresh";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(110, 6);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(113, 22);
            this.toolStripMenuItem2.Text = "Update";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.ToolStripMenuItem2Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(113, 22);
            this.toolStripMenuItem3.Text = "Donate";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.ToolStripMenuItem3Click1);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(110, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItemClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.runAtStartupCB);
            this.groupBox3.Controls.Add(this.startMinimizedCB);
            this.groupBox3.Location = new System.Drawing.Point(6, 152);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(364, 51);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Settings";
            // 
            // runAtStartupCB
            // 
            this.runAtStartupCB.AutoSize = true;
            this.runAtStartupCB.Location = new System.Drawing.Point(199, 19);
            this.runAtStartupCB.Name = "runAtStartupCB";
            this.runAtStartupCB.Size = new System.Drawing.Size(93, 17);
            this.runAtStartupCB.TabIndex = 1;
            this.runAtStartupCB.Text = "Run at startup";
            this.runAtStartupCB.UseVisualStyleBackColor = true;
            this.runAtStartupCB.Click += new System.EventHandler(this.RunAtStartupCbClick);
            // 
            // startMinimizedCB
            // 
            this.startMinimizedCB.AutoSize = true;
            this.startMinimizedCB.Location = new System.Drawing.Point(10, 20);
            this.startMinimizedCB.Name = "startMinimizedCB";
            this.startMinimizedCB.Size = new System.Drawing.Size(96, 17);
            this.startMinimizedCB.TabIndex = 0;
            this.startMinimizedCB.Text = "Start minimized";
            this.startMinimizedCB.UseVisualStyleBackColor = true;
            this.startMinimizedCB.CheckedChanged += new System.EventHandler(this.StartMinimizedCbCheckedChanged);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(205, 345);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(75, 23);
            this.buttonRefresh.TabIndex = 5;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.RefreshClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 377);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.buttonMinimize);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelTouchpadMouseStatus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "AutoSensitivity";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mouseBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.touchpadBar)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTouchpadMouseStatus;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonMouseGetCurrent;
        private System.Windows.Forms.TrackBar mouseBar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonTouchpadGetCurrent;
        private System.Windows.Forms.TrackBar touchpadBar;
        private System.Windows.Forms.Button buttonMouseApply;
        private System.Windows.Forms.Button buttonTouchpadApply;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.LinkLabel linkLabelProgram;
        private System.Windows.Forms.LinkLabel linkLabelDonate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonMinimize;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox runAtStartupCB;
        private System.Windows.Forms.CheckBox startMinimizedCB;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
    }
}

