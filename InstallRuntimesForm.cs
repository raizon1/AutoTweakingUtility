using System;
using System.IO;
using System.Net;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO.Compression;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace Auto_Tweaking_Utility
{
    public partial class InstallRuntimesForm : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        WebClient a = new WebClient();

        public InstallRuntimesForm()
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

        private void ButtonInstallCppRuntimes_Click(object sender, EventArgs e)
        {
            try
            {
                if (!File.Exists(Path.GetTempPath() + "VisualCppRedist_AIO_x86_x64.exe"))
                {
                    a.DownloadFile("https://github.com/abbodi1406/vcredist/releases/download/v0.39.0/VisualCppRedist_AIO_x86_x64_39.zip", "" + Path.GetTempPath() + "" + "VisualCppRedist_AIO_x86_x64_39.zip");
                    ZipFile.ExtractToDirectory("" + Path.GetTempPath() + "" + "VisualCppRedist_AIO_x86_x64_39.zip", "" + Path.GetTempPath() + "");
                }

                Process.Start(Path.GetTempPath() + "VisualCppRedist_AIO_x86_x64.exe", "/aiA");
                MessageBox.Show("The installation will continue in the background. Feel free to close Auto Tweaking Utility during the installation if you wish to do so.", "Installing..", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonInstallDirectXRuntime_Click(object sender, EventArgs e)
        {
            try
            {
                if (!File.Exists(Path.GetTempPath() + "dxwebsetup.exe"))
                {
                    a.DownloadFile("https://download.microsoft.com/download/1/7/1/1718CCC4-6315-4D8E-9543-8E28A4E18C4C/dxwebsetup.exe", "" + Path.GetTempPath() + "" + "dxwebsetup.exe");
                }

                Process.Start(Path.GetTempPath() + "dxwebsetup.exe", "/Q");
                MessageBox.Show("The installation will continue in the background. Feel free to close Auto Tweaking Utility during the installation if you wish to do so.", "Installing..", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }   
        }

        private void ButtonInstallDotNET48Runtime_Click(object sender, EventArgs e)
        {
            try
            {
                if (!File.Exists(Path.GetTempPath() + "ndp48-web.exe"))
                {
                    a.DownloadFile("https://download.visualstudio.microsoft.com/download/pr/014120d7-d689-4305-befd-3cb711108212/1f81f3962f75eff5d83a60abd3a3ec7b/ndp48-web.exe", "" + Path.GetTempPath() + "" + "ndp48-web.exe");
                    a.DownloadFile("https://download.microsoft.com/download/2/4/8/248D8A62-FCCD-475C-85E7-6ED59520FC0F/MicrosoftRootCertificateAuthority2011.cer", "" + Path.GetTempPath() + "" + "MicrosoftRootCertificateAuthority2011.cer");

                    X509Store store = new X509Store(StoreName.Root, StoreLocation.LocalMachine);
                    store.Open(OpenFlags.ReadWrite);
                    store.Add(new X509Certificate2(X509Certificate2.CreateFromCertFile(Path.GetTempPath() + "MicrosoftRootCertificateAuthority2011.cer")));
                    store.Close();
                }

                Process.Start(Path.GetTempPath() + "ndp48-web.exe", "/q /norestart");
                MessageBox.Show("The installation will continue in the background. Feel free to close Auto Tweaking Utility during the installation if you wish to do so.", "Installing..", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonInstallVulkanRuntime_Click(object sender, EventArgs e)
        {
            try
            {
                if (!File.Exists(Path.GetTempPath() + "vulkan-runtime.exe"))
                {
                    a.DownloadFile("https://sdk.lunarg.com/sdk/download/latest/windows/vulkan-runtime.exe?u=", "" + Path.GetTempPath() + "" + "vulkan-runtime.exe");
                }

                Process.Start(Path.GetTempPath() + "vulkan-runtime.exe", "/S");
                MessageBox.Show("The installation will continue in the background. Feel free to close Auto Tweaking Utility during the installation if you wish to do so.", "Installing..", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
