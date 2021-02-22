using System;
using Microsoft.Win32;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Auto_Tweaking_Utility
{
    public partial class MessageNumberLimitDialog : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public MessageNumberLimitDialog()
        {
            InitializeComponent();
        }

        public string DeviceID { get; set; }
        public int SelectedDevice { get; set; }
        public string MessageNumberLimit { get; set; }

        private void MessageNumberLimitDialog_Load(object sender, EventArgs e)
        {
            int MsgNumberLimitInt = 0;
            Int32.TryParse(MessageNumberLimit, out MsgNumberLimitInt);
            MsgNumberLimit.Value = MsgNumberLimitInt;
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
            if (MsgNumberLimit.Value == 0)
            {
                if (DevicePath.GetValue("MessageNumberLimit") != null) { DevicePath.DeleteValue("MessageNumberLimit"); }
            }
            else
            {
                DevicePath.SetValue("MessageNumberLimit", MsgNumberLimit.Value.ToString(), RegistryValueKind.DWord);
            }
            this.Close();
            if (MessageNumberLimit == MsgNumberLimit.Value.ToString())
            {
            }
            else
            {
                MessageBox.Show("Message number limit for this device was succesfully changed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show("Your changes will not take effect until your computer/the device is restarted.", "Restart", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            InterruptMSITweaksForm InterruptMSITweaksForm = (InterruptMSITweaksForm)Application.OpenForms["InterruptMSITweaksForm"];
            InterruptMSITweaksForm.UpdateValues();
            InterruptMSITweaksForm.ListBoxDevices.SelectedIndex = SelectedDevice;
        }

        private void MsgNumberLimit_Validated(object sender, EventArgs e)
        {
            if (MsgNumberLimit.Text == "")
            {
                MsgNumberLimit.Value = 0;
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