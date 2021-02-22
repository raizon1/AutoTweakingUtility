using System;
using System.IO;
using System.Net;
using System.Windows.Forms;
using System.IO.Compression;
using System.Runtime.InteropServices;

namespace Auto_Tweaking_Utility
{
    public partial class RipcordSetupForm : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public RipcordSetupForm()
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
            if (!File.Exists(InstallPath.Text + @"\Ripcord.exe"))
            {
                try
                {
                    WebClient a = new WebClient();
                    Directory.CreateDirectory(InstallPath.Text);
                    a.DownloadFile("https://cancel.fm/dl/Ripcord_Win_0.4.28.zip", "" + Path.GetTempPath() + "" + "Ripcord_Win_0.4.28.zip");
                    ZipFile.ExtractToDirectory("" + Path.GetTempPath() + "" + "Ripcord_Win_0.4.28.zip", "" + InstallPath.Text + "");

                    MessageBox.Show("Succesfully installed Ripcord", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("Ripcord is already installed in the specified location!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
