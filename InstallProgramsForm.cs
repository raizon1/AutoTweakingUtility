using System;
using System.IO;
using System.Net;
using System.Diagnostics;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Auto_Tweaking_Utility
{
    public partial class InstallProgramsForm : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        ProcessExplorerSetupForm ProcessExplorerSetupForm = new ProcessExplorerSetupForm();
        RipcordSetupForm RipcordSetupForm = new RipcordSetupForm();
        MemoryCleanerSetupForm MemoryCleanerSetupForm = new MemoryCleanerSetupForm();
        DDUSetupForm DDUSetupForm = new DDUSetupForm();

        public InstallProgramsForm()
        {
            InitializeComponent();
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

        private void ButtonInstallProcessExplorer_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This installer was made by the Auto Tweaking Utility team. Auto Tweaking Utility is not associated with Microsoft nor SysInternals. Process Explorer is owned, created and maintained by Windows Sysinternals.", "Disclaimer", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ProcessExplorerSetupForm.ShowDialog(this);
        }

        private void ButtonInstall7Zip_Click(object sender, EventArgs e)
        {
            WebClient a = new WebClient();

            if (!File.Exists(Path.GetTempPath() + "7z1900-x64.exe"))
            {
                a.DownloadFile("https://www.7-zip.org/a/7z1900-x64.exe", "" + Path.GetTempPath() + "" + "7z1900-x64.exe");
            }

            Process.Start(Path.GetTempPath() + "7z1900-x64.exe");
        }

        private void ButtonInstallMemoryCleaner_Click(object sender, EventArgs e)
        {
            MemoryCleanerSetupForm.ShowDialog(this);
        }

        private void ButtonInstallRipcord_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This installer was made by the Auto Tweaking Utility team. Auto Tweaking Utility is not associated with Cancel nor Ripcord. Ripcord is owned, created and maintained by Cancel.", "Disclaimer", MessageBoxButtons.OK, MessageBoxIcon.Information);
            RipcordSetupForm.ShowDialog(this);
        }

        private void ButtonInstallDDU_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This installer was made by the Auto Tweaking Utility team. Auto Tweaking Utility is not associated with Display Driver Uninstaller (DDU).", "Disclaimer", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DDUSetupForm.ShowDialog(this);
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
