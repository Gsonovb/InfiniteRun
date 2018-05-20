namespace InfiniteRun
{
    partial class frmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnStart = new System.Windows.Forms.Button();
            this.lbCmd = new System.Windows.Forms.Label();
            this.tbCmd = new System.Windows.Forms.TextBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.tbOutput = new System.Windows.Forms.TextBox();
            this.ni = new System.Windows.Forms.NotifyIcon(this.components);
            this.ctMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.stopExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRestart = new System.Windows.Forms.Button();
            this.ctMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(802, 39);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(112, 34);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lbCmd
            // 
            this.lbCmd.AutoSize = true;
            this.lbCmd.Location = new System.Drawing.Point(36, 46);
            this.lbCmd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCmd.Name = "lbCmd";
            this.lbCmd.Size = new System.Drawing.Size(80, 18);
            this.lbCmd.TabIndex = 1;
            this.lbCmd.Text = "Command:";
            // 
            // tbCmd
            // 
            this.tbCmd.Location = new System.Drawing.Point(124, 42);
            this.tbCmd.Margin = new System.Windows.Forms.Padding(4);
            this.tbCmd.Name = "tbCmd";
            this.tbCmd.Size = new System.Drawing.Size(631, 28);
            this.tbCmd.TabIndex = 2;
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(802, 100);
            this.btnStop.Margin = new System.Windows.Forms.Padding(4);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(112, 34);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // tbOutput
            // 
            this.tbOutput.Location = new System.Drawing.Point(39, 168);
            this.tbOutput.Margin = new System.Windows.Forms.Padding(4);
            this.tbOutput.Multiline = true;
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.ReadOnly = true;
            this.tbOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbOutput.Size = new System.Drawing.Size(874, 470);
            this.tbOutput.TabIndex = 4;
            // 
            // ni
            // 
            this.ni.ContextMenuStrip = this.ctMenu;
            this.ni.Text = "InfiniteRun";
            this.ni.DoubleClick += new System.EventHandler(this.ni_DoubleClick);
            // 
            // ctMenu
            // 
            this.ctMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ctMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stopExitToolStripMenuItem});
            this.ctMenu.Name = "ctMenu";
            this.ctMenu.Size = new System.Drawing.Size(198, 32);
            // 
            // stopExitToolStripMenuItem
            // 
            this.stopExitToolStripMenuItem.Name = "stopExitToolStripMenuItem";
            this.stopExitToolStripMenuItem.Size = new System.Drawing.Size(197, 28);
            this.stopExitToolStripMenuItem.Text = "Stop And Exit";
            this.stopExitToolStripMenuItem.Click += new System.EventHandler(this.StopAndExitToolStripMenuItem_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.Location = new System.Drawing.Point(643, 100);
            this.btnRestart.Margin = new System.Windows.Forms.Padding(4);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(112, 34);
            this.btnRestart.TabIndex = 5;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // frmMain
            // 
            this.AcceptButton = this.btnStart;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 675);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.tbOutput);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.tbCmd);
            this.Controls.Add(this.lbCmd);
            this.Controls.Add(this.btnStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "InfiniteRun";
            this.Activated += new System.EventHandler(this.frmMain_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.SizeChanged += new System.EventHandler(this.frmMain_SizeChanged);
            this.ctMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lbCmd;
        private System.Windows.Forms.TextBox tbCmd;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.TextBox tbOutput;
        private System.Windows.Forms.NotifyIcon ni;
        private System.Windows.Forms.ContextMenuStrip ctMenu;
        private System.Windows.Forms.ToolStripMenuItem stopExitToolStripMenuItem;
        private System.Windows.Forms.Button btnRestart;
    }
}

