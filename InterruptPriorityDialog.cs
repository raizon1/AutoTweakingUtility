using System;
using Microsoft.Win32;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Auto_Tweaking_Utility
{
    public partial class InterruptPriorityDialog : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public InterruptPriorityDialog()
        {
            InitializeComponent();
        }

        public string DeviceID { get; set; }
        public int SelectedDevice { get; set; }
        public string DevicePriority { get; set; }

        private void InterruptPriorityDialog_Load(object sender, EventArgs e)
        {
            if (DevicePriority == "0")
            {
                Undefined.Checked = true;
            }
            else if (DevicePriority == "1")
            {
                Low.Checked = true;
            }
            else if (DevicePriority == "2")
            {
                Normal.Checked = true;
            }
            else if (DevicePriority == "3")
            {
                High.Checked = true;
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
            RegistryKey DevicePath = Registry.LocalMachine.CreateSubKey("SYSTEM\\CurrentControlSet\\Enum\\" + DeviceID + "\\Device Parameters\\Interrupt Management\\Affinity Policy", true);
            if (Undefined.Checked == true)
            {
                if (DevicePath.GetValue("DevicePriority") != null) { DevicePath.DeleteValue("DevicePriority"); }
                this.Close();
                if (DevicePriority == "0")
                {
                }
                else
                {
                    MessageBox.Show("The interrupt priority for this device was succesfully changed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show("Your changes will not take effect until your computer/the device is restarted.", "Restart", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                InterruptMSITweaksForm InterruptMSITweaksForm = (InterruptMSITweaksForm)Application.OpenForms["InterruptMSITweaksForm"];
                InterruptMSITweaksForm.UpdateValues();
                InterruptMSITweaksForm.ListBoxDevices.SelectedIndex = SelectedDevice;
            }

            if (Low.Checked == true)
            {
                DevicePath.SetValue("DevicePriority", "1", RegistryValueKind.DWord);
                this.Close();
                if (DevicePriority == "1")
                {
                }
                else
                {
                    MessageBox.Show("The interrupt priority for this device was succesfully changed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show("Your changes will not take effect until your computer/the device is restarted.", "Restart", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                InterruptMSITweaksForm InterruptMSITweaksForm = (InterruptMSITweaksForm)Application.OpenForms["InterruptMSITweaksForm"];
                InterruptMSITweaksForm.UpdateValues();
                InterruptMSITweaksForm.ListBoxDevices.SelectedIndex = SelectedDevice;
            }

            if (Normal.Checked == true)
            {
                DevicePath.SetValue("DevicePriority", "2", RegistryValueKind.DWord);
                this.Close();
                if (DevicePriority == "2")
                {
                }
                else
                {
                    MessageBox.Show("The interrupt priority for this device was succesfully changed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show("Your changes will not take effect until your computer/the device is restarted.", "Restart", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                InterruptMSITweaksForm InterruptMSITweaksForm = (InterruptMSITweaksForm)Application.OpenForms["InterruptMSITweaksForm"];
                InterruptMSITweaksForm.UpdateValues();
                InterruptMSITweaksForm.ListBoxDevices.SelectedIndex = SelectedDevice;
            }

            if (High.Checked == true)
            {
                DevicePath.SetValue("DevicePriority", "3", RegistryValueKind.DWord);
                this.Close();
                if (DevicePriority == "3")
                {
                }
                else
                {
                    MessageBox.Show("The interrupt priority for this device was succesfully changed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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