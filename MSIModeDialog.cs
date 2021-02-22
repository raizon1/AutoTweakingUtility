using System;
using Microsoft.Win32;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Auto_Tweaking_Utility
{
    public partial class MSIModeDialog : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public MSIModeDialog()
        {
            InitializeComponent();
        }

        public string DeviceID { get; set; }
        public int SelectedDevice { get; set; }
        public string MSISupported { get; set; }

        private void MSIModeDialog_Load(object sender, EventArgs e)
        {
            if (MSISupported == "0")
            {
                Disabled.Checked = true;
            }
            else if (MSISupported == "1")
            {
                Enabled.Checked = true;
            }
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

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            RegistryKey DevicePath = Registry.LocalMachine.CreateSubKey("SYSTEM\\CurrentControlSet\\Enum\\" + DeviceID + "\\Device Parameters\\Interrupt Management\\MessageSignaledInterruptProperties", true);
            if (Enabled.Checked == true)
            {
                DevicePath.SetValue("MSISupported", "1", RegistryValueKind.DWord);
                this.Close();
                if (MSISupported == "1")
                {
                }
                else
                {
                    MessageBox.Show("MSI mode was succesfully enabled for this device.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show("Your changes will not take effect until your computer/the device is restarted.", "Restart", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                InterruptMSITweaksForm InterruptMSITweaksForm = (InterruptMSITweaksForm)Application.OpenForms["InterruptMSITweaksForm"];
                InterruptMSITweaksForm.UpdateValues();
                InterruptMSITweaksForm.ListBoxDevices.SelectedIndex = SelectedDevice;
            }
            if (Disabled.Checked == true)
            {
                DevicePath.SetValue("MSISupported", "0", RegistryValueKind.DWord);
                this.Close();
                if (MSISupported == "0")
                {
                }
                else
                {
                    MessageBox.Show("MSI mode was succesfully disabled for this device.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show("Your changes will not take effect until your computer/the device is restarted.", "Restart", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                InterruptMSITweaksForm InterruptMSITweaksForm = (InterruptMSITweaksForm)Application.OpenForms["InterruptMSITweaksForm"];
                InterruptMSITweaksForm.UpdateValues();
                InterruptMSITweaksForm.ListBoxDevices.SelectedIndex = SelectedDevice;
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
