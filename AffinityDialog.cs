using System;
using System.Data;
using System.Linq;
using Microsoft.Win32;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Auto_Tweaking_Utility
{
    public partial class AffinityDialog : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public AffinityDialog()
        {
            InitializeComponent();
        }

        private CheckBox[] CheckBoxes;
        public string DeviceID { get; set; }
        public int SelectedDevice { get; set; }
        public string BinaryAffinity { get; set; }

        private void AffinityDialog_Load(object sender, EventArgs e)
        {
            CheckBoxes = new CheckBox[] {
                CPU0, CPU1, CPU2, CPU3, CPU4, CPU5, CPU6, CPU7,
                CPU8, CPU9, CPU10, CPU11, CPU12, CPU13, CPU14, CPU15,
                CPU16, CPU17, CPU18, CPU19, CPU20, CPU21, CPU22, CPU23,
                CPU24, CPU25, CPU26, CPU27, CPU28, CPU29, CPU30, CPU31,
                CPU32, CPU33, CPU34, CPU35, CPU36, CPU37, CPU38, CPU39,
                CPU40, CPU41, CPU42, CPU43, CPU44, CPU45, CPU46, CPU47,
                CPU48, CPU49, CPU50, CPU51, CPU52, CPU53, CPU54, CPU55,
                CPU56, CPU57, CPU58, CPU59, CPU60, CPU61, CPU62, CPU63 };

            for (int i = 0; i < BinaryAffinity.Length; i++)
            {
                CheckBoxes[i].Enabled = true;
                CheckBoxes[i].Checked = BinaryAffinity[BinaryAffinity.Length - i - 1] == '1';
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
            List<string> checkedItems = (from Control x in Controls where x is CheckBox && ((CheckBox)x).Checked select x.Text).ToList();
            RegistryKey DevicePath = Registry.LocalMachine.CreateSubKey("SYSTEM\\CurrentControlSet\\Enum\\" + DeviceID + "\\Device Parameters\\Interrupt Management\\Affinity Policy", true);
            string affinityMask = "";
            try
            {
                ulong affinitymask = string.Join(",", checkedItems).Replace("CPU", "").Replace(" ", " ").Split(',').Select(int.Parse).Aggregate(0UL, (mask, id) => mask | (1UL << id));
                if (affinitymask.ToString().Length == 1) { affinityMask = "0" + affinitymask; } else { affinityMask = affinitymask.ToString(); }
                DevicePath.SetValue("AssignmentSetOverride", new byte[] { Convert.ToByte(affinityMask) }, RegistryValueKind.Binary);
                DevicePath.SetValue("DevicePolicy", "4", RegistryValueKind.DWord);
                this.Close();
                MessageBox.Show("The interrupt policy for this device was succesfully changed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show("Your changes will not take effect until your computer/the device is restarted.", "Restart", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                InterruptMSITweaksForm InterruptMSITweaksForm = (InterruptMSITweaksForm)Application.OpenForms["InterruptMSITweaksForm"];
                InterruptMSITweaksForm.UpdateValues();
                InterruptMSITweaksForm.ListBoxDevices.SelectedIndex = SelectedDevice;
            }
            catch
            {
                MessageBox.Show("The affinity mask must contain atleast one processor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonSelectNone_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < BinaryAffinity.Length; i++)
            {
                CheckBoxes[i].Checked = false;
            }
        }

        private void ButtonSelectAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < BinaryAffinity.Length; i++)
            {
                CheckBoxes[i].Checked = true;
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
