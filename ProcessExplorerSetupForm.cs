using System;
using System.IO;
using System.Net;
using Microsoft.Win32;
using System.Windows.Forms;
using System.IO.Compression;
using System.Runtime.InteropServices;

namespace Auto_Tweaking_Utility
{
    public partial class ProcessExplorerSetupForm : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public ProcessExplorerSetupForm()
        {
            InitializeComponent();
        }

        private void InstallProcessExplorerForm_Shown(object sender, EventArgs e)
        {
            CheckBoxReplaceTaskManagerWithProcessExplorer.Checked = false;
        }

        private void Titlebar_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Titlebar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void ButtonBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                InstallPath.Text = fbd.SelectedPath;
            }
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonInstall_Click(object sender, EventArgs e)
        {
            if (!File.Exists(InstallPath.Text + @"\procexp64.exe"))
            {
                try
                {
                    WebClient a = new WebClient();
                    Directory.CreateDirectory(InstallPath.Text);
                    a.DownloadFile("https://download.sysinternals.com/files/ProcessExplorer.zip", "" + Path.GetTempPath() + "" + "ProcessExplorer.zip");
                    ZipFile.ExtractToDirectory("" + Path.GetTempPath() + "" + "ProcessExplorer.zip", "" + InstallPath.Text + "");
                    RegistryKey ProcessExplorer = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\Sysinternals\Process Explorer", true);
                    ProcessExplorer.SetValue("HighlightServices", "0", RegistryValueKind.DWord);
                    ProcessExplorer.SetValue("HighlightOwnProcesses", "0", RegistryValueKind.DWord);
                    ProcessExplorer.SetValue("HighlightRelocatedDlls", "0", RegistryValueKind.DWord);
                    ProcessExplorer.SetValue("HighlightJobs", "0", RegistryValueKind.DWord);
                    ProcessExplorer.SetValue("HighlightNewProc", "0", RegistryValueKind.DWord);
                    ProcessExplorer.SetValue("HighlightDelProc", "0", RegistryValueKind.DWord);
                    ProcessExplorer.SetValue("HighlightImmersive", "0", RegistryValueKind.DWord);
                    ProcessExplorer.SetValue("HighlightProtected", "0", RegistryValueKind.DWord);
                    ProcessExplorer.SetValue("HighlightPacked", "0", RegistryValueKind.DWord);
                    ProcessExplorer.SetValue("HighlightNetProcess", "0", RegistryValueKind.DWord);
                    ProcessExplorer.SetValue("HighlightSuspend", "0", RegistryValueKind.DWord);
                    ProcessExplorer.SetValue("HighlightDuration", "0", RegistryValueKind.DWord);
                    ProcessExplorer.SetValue("ShowProcessTree", "0", RegistryValueKind.DWord);
                    
                    if (CheckBoxReplaceTaskManagerWithProcessExplorer.Checked == true)
                    {
                        RegistryKey taskmgrImageFileExecutionOptions = Registry.LocalMachine.CreateSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion\Image File Execution Options\taskmgr.exe", true);
                        taskmgrImageFileExecutionOptions.SetValue("Debugger", InstallPath.Text + "\\procexp64.exe", RegistryValueKind.String);
                    }

                    MessageBox.Show("Succesfully installed Process Explorer", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Process Explorer is already installed in the specified location!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            KeyEventArgs a = new KeyEventArgs(keyData);
            if (a.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}