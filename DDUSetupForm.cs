using System;
using System.IO;
using System.Net;
using Microsoft.Win32;
using System.Windows.Forms;
using System.IO.Compression;
using System.Runtime.InteropServices;

namespace Auto_Tweaking_Utility
{
    public partial class DDUSetupForm : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public DDUSetupForm()
        {
            InitializeComponent();
        }

        private void DDUSetupForm_Load(object sender, EventArgs e)
        {
            CheckBoxDisableDriverSearching.Checked = false;
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
            if (!File.Exists(InstallPath.Text + @"\DDU v18.0.3.5\Display Driver Uninstaller.exe"))
            {
                try
                {
                    WebClient a = new WebClient();
                    Directory.CreateDirectory(InstallPath.Text);
                    a.DownloadFile("https://ftp.nluug.nl/pub/games/PC/guru3d/ddu/[Guru3D.com]-DDU.zip", "" + Path.GetTempPath() + "" + "[Guru3D.com]-DDU.zip");
                    ZipFile.ExtractToDirectory("" + Path.GetTempPath() + "" + "[Guru3D.com]-DDU.zip", "" + InstallPath.Text + "");

                    if (CheckBoxDisableDriverSearching.Checked == true)
                    {
                        RegistryKey DriverSearching = Registry.LocalMachine.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\DriverSearching", true);
                        DriverSearching.SetValue("SearchOrderConfig", "0", RegistryValueKind.DWord);
                    }

                    MessageBox.Show("Succesfully installed Display Driver Uninstaller", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("Display Driver Uninstaller is already installed in the specified location!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
