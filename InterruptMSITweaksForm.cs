using System;
using System.Linq;
using Microsoft.Win32;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Auto_Tweaking_Utility
{
    public partial class InterruptMSITweaksForm : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        AffinityDialog AffinityDialog = new AffinityDialog();
        DevicePolicyDialog DevicePolicyDialog = new DevicePolicyDialog();
        MSIModeDialog MSIModeDialog = new MSIModeDialog();
        MessageNumberLimitDialog MessageNumberLimitDialog = new MessageNumberLimitDialog();
        InterruptPriorityDialog InterruptPriorityDialog = new InterruptPriorityDialog();

        public InterruptMSITweaksForm()
        {
            InitializeComponent();
        }

        private void AffinityPriorityTweaksForm_Load(object sender, EventArgs e)
        {
            UpdateValues();
        }

        private void InterruptTweaksForm_Shown(object sender, EventArgs e)
        {
            ListBoxDevices.SelectedIndex = 0;
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

        public void UpdateValues()
        {
            ListBoxDevices.Items.Clear();
            ListBoxDeviceIDs.Items.Clear();
            ListBoxMSISupported.Items.Clear();
            ListBoxDevicePolicies.Items.Clear();
            ListBoxDevicePriorities.Items.Clear();
            ListBoxMessageNumberLimits.Items.Clear();
            ListBoxBinaryAffinityMasks.Items.Clear();

            RegistryKey Enum = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Enum");

            foreach (string a in Enum.GetSubKeyNames())
            {
                RegistryKey Type = Enum.OpenSubKey(a);

                foreach (string b in Type.GetSubKeyNames())
                {
                    RegistryKey ID = Type.OpenSubKey(b);

                    foreach (string c in ID.GetSubKeyNames())
                    {
                        RegistryKey ID2 = ID.OpenSubKey(c);

                        if (ID2.GetSubKeyNames().Contains("Device Parameters"))
                        {
                            RegistryKey DeviceParameters = ID2.OpenSubKey("Device Parameters");

                            if (DeviceParameters.GetSubKeyNames().Contains("Interrupt Management"))
                            {
                                RegistryKey InterruptManagement = DeviceParameters.OpenSubKey("Interrupt Management");

                                if (InterruptManagement.GetSubKeyNames().Contains("Affinity Policy - Temporal"))
                                {
                                    RegistryKey AffinityPolicyTemp = InterruptManagement.OpenSubKey("Affinity Policy - Temporal");

                                    if (AffinityPolicyTemp.GetValueNames().Contains("TargetSet"))
                                    {
                                        int AssignmentSetOverride = 0;
                                        string DevicePolicy = "";
                                        string DevicePriority = "";
                                        string assignmentsetOverride = "";
                                        string MessageNumberLimit = "";
                                        string MSISupported = "";

                                        if (InterruptManagement.GetSubKeyNames().Contains("Affinity Policy"))
                                        {
                                            RegistryKey AffinityPolicy = InterruptManagement.OpenSubKey("Affinity Policy");
                                            if (AffinityPolicy.GetValue("DevicePolicy") != null) { DevicePolicy = Convert.ToString(AffinityPolicy.GetValue("DevicePolicy")); } else { DevicePolicy = "0"; }
                                            if (AffinityPolicy.GetValue("DevicePriority") != null) { DevicePriority = Convert.ToString(AffinityPolicy.GetValue("DevicePriority")); } else { DevicePriority = "0"; }
                                            if ((byte[])AffinityPolicy.GetValue("AssignmentSetOverride") != null) { assignmentsetOverride = String.Join(" ", (byte[])AffinityPolicy.GetValue("AssignmentSetOverride")); } else { assignmentsetOverride = ""; }
                                        }

                                        if (InterruptManagement.GetSubKeyNames().Contains("MessageSignaledInterruptProperties"))
                                        {
                                            RegistryKey MessageSignaledInterruptProperties = InterruptManagement.OpenSubKey("MessageSignaledInterruptProperties");
                                            if (MessageSignaledInterruptProperties.GetValue("MessageNumberLimit") != null) { MessageNumberLimit = Convert.ToString(MessageSignaledInterruptProperties.GetValue("MessageNumberLimit")); } else { MessageNumberLimit = "0"; }
                                            if (MessageSignaledInterruptProperties.GetValue("MSISupported") != null) { MSISupported = Convert.ToString(MessageSignaledInterruptProperties.GetValue("MSISupported")); } else { MSISupported = "0"; }
                                        }

                                        Int32.TryParse(assignmentsetOverride, out AssignmentSetOverride);
                                        string DeviceNames = Convert.ToString(ID2.GetValue("DeviceDesc"));
                                        string DeviceIDs = AffinityPolicyTemp.ToString().Replace("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Enum\\", "").Replace(" ", " ").Replace("\\Device Parameters\\Interrupt Management\\Affinity Policy - Temporal", "").Replace(" ", " ");
                                        string BinaryAffinityMask = new string('0', Environment.ProcessorCount - Convert.ToString(AssignmentSetOverride, 2).Length) + Convert.ToString(AssignmentSetOverride, 2);
                                        if (DeviceNames.Contains(";")) { DeviceNames = DeviceNames.Split(new char[] { ';' })[1]; }

                                        ListBoxDevices.Items.Add(DeviceNames);
                                        ListBoxDeviceIDs.Items.Add(DeviceIDs);
                                        ListBoxMSISupported.Items.Add(MSISupported);
                                        ListBoxDevicePolicies.Items.Add(DevicePolicy);
                                        ListBoxDevicePriorities.Items.Add(DevicePriority);
                                        ListBoxMessageNumberLimits.Items.Add(MessageNumberLimit);
                                        ListBoxBinaryAffinityMasks.Items.Add(BinaryAffinityMask);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonChangeInterruptPriority_Click(object sender, EventArgs e)
        {
            string DeviceID = ListBoxDeviceIDs.Items[ListBoxDevices.SelectedIndex].ToString();
            InterruptPriorityDialog.DeviceID = DeviceID;

            string DevicePriority = ListBoxDevicePriorities.Items[ListBoxDevices.SelectedIndex].ToString();
            InterruptPriorityDialog.DevicePriority = DevicePriority;

            int SelectedDevice = ListBoxDevices.SelectedIndex;
            InterruptPriorityDialog.SelectedDevice = SelectedDevice;

            InterruptPriorityDialog.ShowDialog(this);
        }

        private void ButtonChangeMessageNumberLimit_Click(object sender, EventArgs e)
        {
            string DeviceID = ListBoxDeviceIDs.Items[ListBoxDevices.SelectedIndex].ToString();
            MessageNumberLimitDialog.DeviceID = DeviceID;

            string MessageNumberLimit = ListBoxMessageNumberLimits.Items[ListBoxDevices.SelectedIndex].ToString();
            MessageNumberLimitDialog.MessageNumberLimit = MessageNumberLimit;

            int SelectedDevice = ListBoxDevices.SelectedIndex;
            MessageNumberLimitDialog.SelectedDevice = SelectedDevice;

            MessageNumberLimitDialog.ShowDialog(this);
        }

        private void ButtonEnableDisableMSIMode_Click(object sender, EventArgs e)
        {
            string DeviceID = ListBoxDeviceIDs.Items[ListBoxDevices.SelectedIndex].ToString();
            MSIModeDialog.DeviceID = DeviceID;

            string MSISupported = ListBoxMSISupported.Items[ListBoxDevices.SelectedIndex].ToString();
            MSIModeDialog.MSISupported = MSISupported;

            int SelectedDevice = ListBoxDevices.SelectedIndex;
            MSIModeDialog.SelectedDevice = SelectedDevice;

            MessageBox.Show("Be careful with MSI mode, due to the reason that some devices only support line-based interrupts, not message signal-based interrupts (which is what MSI stands for). If you enable MSI mode for a device that doesn't support it, the device will stop working which might result in bricking of the whole operating system at worst.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            MSIModeDialog.ShowDialog(this);
        }

        private void ButtonChangeDevicePolicy_Click(object sender, EventArgs e)
        {
            string DeviceID = ListBoxDeviceIDs.Items[ListBoxDevices.SelectedIndex].ToString();
            DevicePolicyDialog.DeviceID = DeviceID;

            string DevicePolicy = ListBoxDevicePolicies.Items[ListBoxDevices.SelectedIndex].ToString();
            DevicePolicyDialog.DevicePolicy = DevicePolicy;

            int SelectedDevice = ListBoxDevices.SelectedIndex;
            DevicePolicyDialog.SelectedDevice = SelectedDevice;

            DevicePolicyDialog.ShowDialog(this);
        }

        private void ButtonDeleteMask_Click(object sender, EventArgs e)
        {
            int SelectedDevice = ListBoxDevices.SelectedIndex;

            RegistryKey DevicePath = Registry.LocalMachine.CreateSubKey("SYSTEM\\CurrentControlSet\\Enum\\" + ListBoxDeviceIDs.Items[ListBoxDevices.SelectedIndex].ToString() + "\\Device Parameters\\Interrupt Management\\Affinity Policy", true);
            bool success = false;
            bool error = false;

            if (DevicePath.GetValue("AssignmentSetOverride") != null)
            {
                DevicePath.DeleteValue("AssignmentSetOverride");
                if (success == false) { MessageBox.Show("The interrupt policy for this device was succesfully deleted from the registry.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information); MessageBox.Show("Your changes will not take effect until your computer/the device is restarted.", "Restart", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                error = false;
                success = true;
            }
            else
            {
                error = true;
            }

            if (DevicePath.GetValue("DevicePolicy") != null)
            {
                DevicePath.DeleteValue("DevicePolicy");
                if (success == false) { MessageBox.Show("The interrupt policy for this device was succesfully deleted from the registry.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information); MessageBox.Show("Your changes will not take effect until your computer/the device is restarted.", "Restart", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                error = false;
                success = true;
            }
            else
            {
                if (success == true) { error = false; }
            }

            if (error == true) { MessageBox.Show("There was no interrupt policy registry value for this device.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            UpdateValues();
            ListBoxDevices.SelectedIndex = SelectedDevice;
        }

        public void ButtonSetMask_Click(object sender, EventArgs e)
        {
            string DeviceID = ListBoxDeviceIDs.Items[ListBoxDevices.SelectedIndex].ToString();
            AffinityDialog.DeviceID = DeviceID;

            string BinaryAffinity = ListBoxBinaryAffinityMasks.Items[ListBoxDevices.SelectedIndex].ToString();
            AffinityDialog.BinaryAffinity = BinaryAffinity;

            int SelectedDevice = ListBoxDevices.SelectedIndex;
            AffinityDialog.SelectedDevice = SelectedDevice;

            AffinityDialog.ShowDialog(this);
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