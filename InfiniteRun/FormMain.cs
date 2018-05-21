using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace InfiniteRun
{
    public partial class frmMain : Form
    {
        Process np = new Process();
        bool RunningFlag;
        private void btnRestart_Click(object sender, EventArgs e)
        {
            if (np != null)
            {
                if (!np.HasExited) np.Kill();
                np = null;
            }
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            if (tbCmd.Text == "") return;
            if (np != null) return;          
            Thread t = new Thread(new ThreadStart(Exec));
            t.Start();
        }
        private void btnStop_Click(object sender, EventArgs e)
        {
            RunningFlag = false;
            ni.Icon = this.Icon;
            ni.Text = "InfiniteRun";
            if (np != null)
            {
                if (!np.HasExited) np.Kill();
                np = null;
            }
        }
        private void Exec()
        {
            try
            {
                Process p = new Process();
                p.StartInfo.FileName = tbCmd.Text.Substring(0, tbCmd.Text.IndexOf(".exe") + 4);
                p.StartInfo.Arguments = tbCmd.Text.Substring(tbCmd.Text.IndexOf(".exe") + 4, tbCmd.Text.Length - p.StartInfo.FileName.Length);
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.RedirectStandardInput = true;
                p.StartInfo.RedirectStandardOutput = true;
                p.StartInfo.RedirectStandardError = true;
                p.StartInfo.CreateNoWindow = true;
                p.OutputDataReceived += new DataReceivedEventHandler(OutputReceived);
                ni.Icon = System.Drawing.Icon.ExtractAssociatedIcon(p.StartInfo.FileName);
                ni.Text = "InfiniteRun - " + System.IO.Path.GetFileName(p.StartInfo.FileName);
                RunningFlag = true;
                np = p;
                p.Start();
                p.BeginOutputReadLine();
                p.WaitForExit();
                p.Close();
                np = null;
                this.BeginInvoke(new Action(() => { this.tbOutput.AppendText(System.Environment.NewLine + "Process Termainated." + System.Environment.NewLine + System.Environment.NewLine); }));
                if (RunningFlag == true)
                {
                    btnStart_Click(this, null);
                }
                else
                {
                    this.BeginInvoke(new Action(() => { this.tbOutput.AppendText("Process Stopped." + System.Environment.NewLine + System.Environment.NewLine); }));
                }
            }
            catch (Exception)
            { }
        }
        private void frmMain_Activated(object sender, EventArgs e)
        {
            if (RunningFlag == false) tbCmd.Focus();
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            ni.Icon = this.Icon;
            np = null;
        }
        public frmMain()
        {
            InitializeComponent();
        }
        private void frmMain_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.ShowInTaskbar = false;
                this.Hide();
                ni.Visible = true;
            }
        }
        private void ni_DoubleClick(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Show();
                this.ShowInTaskbar = true;
                this.WindowState = FormWindowState.Normal;
                //this.Activate();
                ni.Visible = false;
            }
        }
        private void OutputReceived(object sender, DataReceivedEventArgs e)
        {
            if (!String.IsNullOrEmpty(e.Data))
            {
                this.BeginInvoke(new Action(() => { this.tbOutput.AppendText(e.Data + System.Environment.NewLine); }));
            }
        }
        private void StopAndExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (np != null) btnStop_Click(this, null);
            Application.Exit();
        }
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (np != null) btnStop_Click(this, null);
        }
    }
}
