using System;
using Microsoft.Win32;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Auto_Tweaking_Utility
{
    public partial class SchedulingTweaksForm : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public SchedulingTweaksForm()
        {
            InitializeComponent();
        }

        RegistryKey PriorityControl = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Control\PriorityControl", true);
        RegistryKey SystemProfile = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion\Multimedia\SystemProfile", true);

        private void SchedulingTweaksForm_Shown(object sender, EventArgs e)
        {
            ComboBoxWin32PrioritySeparation.Text = PriorityControl.GetValue("Win32PrioritySeparation").ToString();
            ComboBoxNetworkThrottlingIndex.Text = SystemProfile.GetValue("NetworkThrottlingIndex").ToString();
            ComboBoxSystemResponsiveness.Text = SystemProfile.GetValue("SystemResponsiveness").ToString();
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

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            try
            {
                PriorityControl.SetValue("Win32PrioritySeparation", ComboBoxWin32PrioritySeparation.Text, RegistryValueKind.DWord);
                SystemProfile.SetValue("NetworkThrottlingIndex", ComboBoxNetworkThrottlingIndex.Text, RegistryValueKind.DWord);
                SystemProfile.SetValue("SystemResponsiveness", ComboBoxSystemResponsiveness.Text, RegistryValueKind.DWord);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonLoadRecommendedSettings_Click(object sender, EventArgs e)
        {
            ComboBoxWin32PrioritySeparation.Text = "40";
            ComboBoxNetworkThrottlingIndex.Text = "10";
            ComboBoxSystemResponsiveness.Text = "10";
        }

        private void ButtonRevertSettings_Click(object sender, EventArgs e)
        {
            ComboBoxWin32PrioritySeparation.Text = "2";
            ComboBoxNetworkThrottlingIndex.Text = "10";
            ComboBoxSystemResponsiveness.Text = "20";
        }

        private void Win32PrioritySeparation_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void NetworkThrottlingIndex_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void SystemResponsiveness_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
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
