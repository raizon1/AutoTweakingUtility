using System;
using Microsoft.Win32;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Auto_Tweaking_Utility
{
    public partial class DevicePolicyDialog : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        AffinityDialog AffinityDialog = new AffinityDialog();

        public DevicePolicyDialog()
        {
            InitializeComponent();
        }

        public string DeviceID { get; set; }
        public int SelectedDevice { get; set; }
        public string DevicePolicy { get; set; }

        private void DevicePolicyDialog_Load(object sender, EventArgs e)
        {
            if (DevicePolicy == "0")
            {
                IrqPolicyMachineDefault.Checked = true;
            }
            else if (DevicePolicy == "1")
            {
                IrqPolicyAllCloseProcessors.Checked = true;
            }
            else if (DevicePolicy == "2")
            {
                IrqPolicyOneCloseProcessor.Checked = true;
            }
            else if (DevicePolicy == "3")
            {
                IrqPolicyAllProcessorsInMachine.Checked = true;
            }
            else if (DevicePolicy == "4")
            {
                IrqPolicySpecifiedProcessors.Checked = true;
            }
            else if (DevicePolicy == "5")
            {
                IrqPolicySpreadMessageAcrossAllProcessors.Checked = true;
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
            if (IrqPolicyMachineDefault.Checked == true)
            {
                DevicePath.SetValue("DevicePolicy", "0", RegistryValueKind.DWord);
                if (DevicePath.GetValue("AssignmentSetOverride") != null) { DevicePath.DeleteValue("AssignmentSetOverride"); }
                this.Close();
                if (DevicePolicy == "0")
                {
                }
                else
                {
                    MessageBox.Show("The device policy for this device was succesfully changed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show("Your changes will not take effect until your computer/the device is restarted.", "Restart", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                InterruptMSITweaksForm InterruptMSITweaksForm = (InterruptMSITweaksForm)Application.OpenForms["InterruptMSITweaksForm"];
                InterruptMSITweaksForm.UpdateValues();
                InterruptMSITweaksForm.ListBoxDevices.SelectedIndex = SelectedDevice;
            }
            if (IrqPolicyAllCloseProcessors.Checked == true)
            {
                DevicePath.SetValue("DevicePolicy", "1", RegistryValueKind.DWord);
                if (DevicePath.GetValue("AssignmentSetOverride") != null) { DevicePath.DeleteValue("AssignmentSetOverride"); }
                this.Close();
                if (DevicePolicy == "1")
                {
                }
                else
                {
                    MessageBox.Show("The device policy for this device was succesfully changed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show("Your changes will not take effect until your computer/the device is restarted.", "Restart", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                InterruptMSITweaksForm InterruptMSITweaksForm = (InterruptMSITweaksForm)Application.OpenForms["InterruptMSITweaksForm"];
                InterruptMSITweaksForm.UpdateValues();
                InterruptMSITweaksForm.ListBoxDevices.SelectedIndex = SelectedDevice;
            }
            if (IrqPolicyOneCloseProcessor.Checked == true)
            {
                DevicePath.SetValue("DevicePolicy", "2", RegistryValueKind.DWord);
                if (DevicePath.GetValue("AssignmentSetOverride") != null) { DevicePath.DeleteValue("AssignmentSetOverride"); }
                this.Close();
                if (DevicePolicy == "2")
                {
                }
                else
                {
                    MessageBox.Show("The device policy for this device was succesfully changed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show("Your changes will not take effect until your computer/the device is restarted.", "Restart", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                InterruptMSITweaksForm InterruptMSITweaksForm = (InterruptMSITweaksForm)Application.OpenForms["InterruptMSITweaksForm"];
                InterruptMSITweaksForm.UpdateValues();
                InterruptMSITweaksForm.ListBoxDevices.SelectedIndex = SelectedDevice;
            }
            if (IrqPolicyAllProcessorsInMachine.Checked == true)
            {
                DevicePath.SetValue("DevicePolicy", "3", RegistryValueKind.DWord);
                if (DevicePath.GetValue("AssignmentSetOverride") != null) { DevicePath.DeleteValue("AssignmentSetOverride"); }
                this.Close();
                if (DevicePolicy == "3")
                {
                }
                else
                {
                    MessageBox.Show("The device policy for this device was succesfully changed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show("Your changes will not take effect until your computer/the device is restarted.", "Restart", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                InterruptMSITweaksForm InterruptMSITweaksForm = (InterruptMSITweaksForm)Application.OpenForms["InterruptMSITweaksForm"];
                InterruptMSITweaksForm.UpdateValues();
                InterruptMSITweaksForm.ListBoxDevices.SelectedIndex = SelectedDevice;
            }
            if (IrqPolicySpecifiedProcessors.Checked == true)
            {
                if (DevicePath.GetValue("DevicePolicy").ToString() == "4")
                {
                    this.Close();
                    InterruptMSITweaksForm InterruptMSITweaksForm = (InterruptMSITweaksForm)Application.OpenForms["InterruptMSITweaksForm"];
                    InterruptMSITweaksForm.UpdateValues();
                    InterruptMSITweaksForm.ListBoxDevices.SelectedIndex = SelectedDevice;
                }
                else
                {
                    this.Close();
                    InterruptMSITweaksForm InterruptMSITweaksForm = (InterruptMSITweaksForm)Application.OpenForms["InterruptMSITweaksForm"];
                    InterruptMSITweaksForm.ButtonSetMask_Click(sender, e);
                    InterruptMSITweaksForm.ListBoxDevices.SelectedIndex = SelectedDevice;
                }
            }
            if (IrqPolicySpreadMessageAcrossAllProcessors.Checked == true)
            {
                DevicePath.SetValue("DevicePolicy", "5", RegistryValueKind.DWord);
                if (DevicePath.GetValue("AssignmentSetOverride") != null) { DevicePath.DeleteValue("AssignmentSetOverride"); }
                this.Close();
                if (DevicePolicy == "5")
                {
                }
                else
                {
                    MessageBox.Show("The device policy for this device was succesfully changed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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