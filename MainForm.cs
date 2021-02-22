using System;
using System.IO;
using System.Net;
using System.Linq;
using Microsoft.Win32;
using System.Diagnostics;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Security.AccessControl;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;

namespace Auto_Tweaking_Utility
{
    public partial class MainForm : Form
    {
        NetworkTweaksDialog NetworkTweaksDialog = new NetworkTweaksDialog();
        SchedulingTweaksForm SchedulingTweaksForm = new SchedulingTweaksForm();
        ServicesTweaksForm ServicesTweaksForm = new ServicesTweaksForm();
        InterruptMSITweaksForm InterruptTweaksForm = new InterruptMSITweaksForm();
        InstallProgramsForm InstallProgramsForm = new InstallProgramsForm();
        InstallRuntimesForm InstallRuntimesForm = new InstallRuntimesForm();

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        public RegistryKey nvlddmkm;
        public RegistryKey classkey;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public RegistryKey GameConfigStore;
        public RegistryKey GameBar;
        public RegistryKey children;
        public RegistryKey parents;

        public MainForm()
        {
            InitializeComponent();
        }

        RegistryKey Services = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services");

        private void Titlebar_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Titlebar_Close_Click(object sender, EventArgs e)
        {
            KillApp();
        }

        private void Titlebar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void ButtonNetworktweaks_Click(object sender, EventArgs e)
        {
            string AdapterName = "";
            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {
                AdapterName = nic.Description;

                if (AdapterName.Contains("Intel"))
                {
                    NetworkTweaksDialog.ShowDialog(this);
                    break;
                }
                else if (AdapterName.Contains("Realtek"))
                {
                    NetworkTweaksDialog.ShowDialog(this);
                    break;
                }
                else
                {
                    MessageBox.Show("Unsupported network interface card found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }
            }
        }

        private void ButtonSchedulingTweaks_Click(object sender, EventArgs e)
        {
            SchedulingTweaksForm.ShowDialog(this);
        }

        private void ButtonServicesTweaks_Click(object sender, EventArgs e)
        {
            ServicesTweaksForm.ShowDialog(this);
        }

        private void ButtonDisableDrivers_Click(object sender, EventArgs e)
        {
            bool UACEnabled = true;
            RegistryKey Settings = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\Auto Tweaking Utility", true);

            if (MessageBox.Show("Are you using a Microsoft account?", "Microsoft account", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                RegistryKey System = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\System", true);

                if (System.GetValue("EnableLUA").ToString() == "1")
                {
                    if (MessageBox.Show("You seem to have UAC enabled. You must disable UAC to continue. Do you want to disable UAC now?", "User Account Control", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        System.SetValue("EnableLUA", "0", RegistryValueKind.DWord);
                        UACEnabled = false;
                    }
                    else
                    {
                        MessageBox.Show("You can't disable drivers if you have UAC enabled.", "User Account Control", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        UACEnabled = true;
                    }
                }
                else if (System.GetValue("EnableLUA").ToString() == "0")
                {
                    UACEnabled = false;
                }

                if (UACEnabled == false)
                {
                    try
                    {
                        RegistryKey Key = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Control\Class\{4D36E96C-E325-11CE-BFC1-08002BE10318}", RegistryKeyPermissionCheck.ReadWriteSubTree);
                        Key.SetValue("UpperFilters", new string[] { "" }, RegistryValueKind.MultiString);
                    }
                    catch
                    {
                        MessageBox.Show("'HKLM\\SYSTEM\\CurrentControlSet\\Control\\Class\\{4D36E96C-E325-11CE-BFC1-08002BE10318}' doesn't exist, skipping..", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    try
                    {
                        RegistryKey Key = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Control\Class\{4D36E967-E325-11CE-BFC1-08002BE10318}", RegistryKeyPermissionCheck.ReadWriteSubTree);
                        Key.SetValue("LowerFilters", new string[] { "" }, RegistryValueKind.MultiString);
                    }
                    catch
                    {
                        MessageBox.Show("'HKLM\\SYSTEM\\CurrentControlSet\\Control\\Class\\{4D36E967-E325-11CE-BFC1-08002BE10318}' doesn't exist, skipping..", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    try
                    {
                        RegistryKey Key = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Control\Class\{6BDD1FC6-810F-11D0-BEC7-08002BE2092F}", RegistryKeyPermissionCheck.ReadWriteSubTree);
                        Key.SetValue("UpperFilters", new string[] { "" }, RegistryValueKind.MultiString);
                    }
                    catch
                    {
                        MessageBox.Show("'HKLM\\SYSTEM\\CurrentControlSet\\Control\\Class\\{6BDD1FC6-810F-11D0-BEC7-08002BE2092F}' doesn't exist, skipping..", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    try
                    {
                        RegistryKey Key = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Control\Class\{71A27CDD-812A-11D0-BEC7-08002BE2092F}", RegistryKeyPermissionCheck.ReadWriteSubTree);
                        Key.SetValue("LowerFilters", new string[] { "" }, RegistryValueKind.MultiString);
                    }
                    catch
                    {
                        MessageBox.Show("'HKLM\\SYSTEM\\CurrentControlSet\\Control\\Class\\{71A27CDD-812A-11D0-BEC7-08002BE2092F}' doesn't exist, skipping..", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    if (Services.GetSubKeyNames().Contains("Audiosrv"))
                    {
                        RegistryKey Audiosrv = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\Audiosrv", RegistryKeyPermissionCheck.ReadWriteSubTree);
                        Audiosrv.SetValue("DependOnService", new string[] { "" }, RegistryValueKind.MultiString);
                    }

                    if (Services.GetSubKeyNames().Contains("Dhcp"))
                    {
                        RegistryKey Dhcp = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\Dhcp", RegistryKeyPermissionCheck.ReadWriteSubTree);
                        Dhcp.SetValue("DependOnService", new string[] { "" }, RegistryValueKind.MultiString);
                    }

                    if (Services.GetSubKeyNames().Contains("hidserv"))
                    {
                        RegistryKey hidserv = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\hidserv", RegistryKeyPermissionCheck.ReadWriteSubTree);
                        hidserv.SetValue("DependOnService", new string[] { "" }, RegistryValueKind.MultiString);
                    }

                    if (Settings.GetValue("DriversDisabled") != null)
                    {
                        if (Settings.GetValue("DriversDisabled").ToString() == "1")
                        {
                            if (MessageBox.Show("Drivers are already disabled. Do you want to enable them?", "Drivers", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                RevertDrivers();
                                Settings.SetValue("DriversDisabled", "0", RegistryValueKind.String);
                            }
                        }
                        else if (Settings.GetValue("DriversDisabled").ToString() == "0")
                        {
                            DisableDrivers();
                            Settings.SetValue("DriversDisabled", "1", RegistryValueKind.String);
                            MessageBox.Show("Succesfully disabled drivers.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            MessageBox.Show("Your changes will not take effect until your computer is restarted.", "Restart", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        DisableDrivers();
                        Settings.SetValue("DriversDisabled", "1", RegistryValueKind.String);
                        MessageBox.Show("Succesfully disabled drivers.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MessageBox.Show("Your changes will not take effect until your computer is restarted.", "Restart", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please switch to an offline account instead to prevent bricking of the OS.", "Offline account", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DisableDrivers()
        {
            if (Services.GetSubKeyNames().Contains("Beep"))
            {
                RegistryKey Beep = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\Beep", RegistryKeyPermissionCheck.ReadWriteSubTree);
                Beep.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("cdfs"))
            {
                RegistryKey cdfs = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\cdfs", RegistryKeyPermissionCheck.ReadWriteSubTree);
                cdfs.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("fvevol"))
            {
                RegistryKey fvevol = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\fvevol", RegistryKeyPermissionCheck.ReadWriteSubTree);
                fvevol.SetValue("ErrorControl", "0", RegistryValueKind.DWord);
                fvevol.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("lltdio"))
            {
                RegistryKey lltdio = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\lltdio", RegistryKeyPermissionCheck.ReadWriteSubTree);
                lltdio.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("luafv"))
            {
                RegistryKey luafv = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\luafv", RegistryKeyPermissionCheck.ReadWriteSubTree);
                luafv.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("mpsdrv"))
            {
                RegistryKey mpsdrv = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\mpsdrv", RegistryKeyPermissionCheck.ReadWriteSubTree);
                mpsdrv.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("MsLldp"))
            {
                RegistryKey MsLldp = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\MsLldp", RegistryKeyPermissionCheck.ReadWriteSubTree);
                MsLldp.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("Ndu"))
            {
                RegistryKey Ndu = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\Ndu", RegistryKeyPermissionCheck.ReadWriteSubTree);
                Ndu.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("NetBIOS"))
            {
                RegistryKey NetBIOS = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\NetBIOS", RegistryKeyPermissionCheck.ReadWriteSubTree);
                NetBIOS.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("NetBT"))
            {
                RegistryKey NetBT = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\NetBT", RegistryKeyPermissionCheck.ReadWriteSubTree);
                NetBT.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("rdyboost"))
            {
                RegistryKey rdyboost = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\rdyboost", RegistryKeyPermissionCheck.ReadWriteSubTree);
                rdyboost.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("rspndr"))
            {
                RegistryKey rspndr = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\rspndr", RegistryKeyPermissionCheck.ReadWriteSubTree);
                rspndr.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("secdrv"))
            {
                RegistryKey secdrv = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\secdrv", RegistryKeyPermissionCheck.ReadWriteSubTree);
                secdrv.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("tcpipreg"))
            {
                RegistryKey tcpipreg = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\tcpipreg", RegistryKeyPermissionCheck.ReadWriteSubTree);
                tcpipreg.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("udfs"))
            {
                RegistryKey udfs = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\udfs", RegistryKeyPermissionCheck.ReadWriteSubTree);
                udfs.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("WmiAcpi"))
            {
                RegistryKey WmiAcpi = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\WmiAcpi", RegistryKeyPermissionCheck.ReadWriteSubTree);
                WmiAcpi.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("Wof"))
            {
                RegistryKey Wof = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\Wof", RegistryKeyPermissionCheck.ReadWriteSubTree);
                Wof.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("ws2ifsl"))
            {
                RegistryKey ws2ifsl = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\ws2ifsl", RegistryKeyPermissionCheck.ReadWriteSubTree);
                ws2ifsl.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (MessageBox.Show("Are you using Wi-Fi?", "Wi-Fi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (Services.GetSubKeyNames().Contains("NativeWifiP"))
                {
                    RegistryKey NativeWifiP = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\NativeWifiP", RegistryKeyPermissionCheck.ReadWriteSubTree);
                    NativeWifiP.SetValue("Start", "3", RegistryValueKind.DWord);
                }

                if (Services.GetSubKeyNames().Contains("Ndisuio"))
                {
                    RegistryKey Ndisuio = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\Ndisuio", RegistryKeyPermissionCheck.ReadWriteSubTree);
                    Ndisuio.SetValue("Start", "3", RegistryValueKind.DWord);
                }
            }

            if (MessageBox.Show("Are you using a laptop?", "Laptop", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (Services.GetSubKeyNames().Contains("msisadrv"))
                {
                    RegistryKey msisadrv = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\msisadrv", RegistryKeyPermissionCheck.ReadWriteSubTree);
                    msisadrv.SetValue("Start", "0", RegistryValueKind.DWord);
                }
            }
        }

        private void RevertDrivers()
        {
            if (Services.GetSubKeyNames().Contains("Beep"))
            {
                RegistryKey Beep = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\Beep", RegistryKeyPermissionCheck.ReadWriteSubTree);
                Beep.SetValue("Start", "1", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("cdfs"))
            {
                RegistryKey cdfs = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\cdfs", RegistryKeyPermissionCheck.ReadWriteSubTree);
                cdfs.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("fvevol"))
            {
                RegistryKey fvevol = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\fvevol", RegistryKeyPermissionCheck.ReadWriteSubTree);
                fvevol.SetValue("ErrorControl", "0", RegistryValueKind.DWord);
                fvevol.SetValue("Start", "0", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("lltdio"))
            {
                RegistryKey lltdio = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\lltdio", RegistryKeyPermissionCheck.ReadWriteSubTree);
                lltdio.SetValue("Start", "2", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("luafv"))
            {
                RegistryKey luafv = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\luafv", RegistryKeyPermissionCheck.ReadWriteSubTree);
                luafv.SetValue("Start", "2", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("mpsdrv"))
            {
                RegistryKey mpsdrv = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\mpsdrv", RegistryKeyPermissionCheck.ReadWriteSubTree);
                mpsdrv.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("MsLldp"))
            {
                RegistryKey MsLldp = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\MsLldp", RegistryKeyPermissionCheck.ReadWriteSubTree);
                MsLldp.SetValue("Start", "2", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("Ndu"))
            {
                RegistryKey Ndu = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\Ndu", RegistryKeyPermissionCheck.ReadWriteSubTree);
                Ndu.SetValue("Start", "2", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("NetBIOS"))
            {
                RegistryKey NetBIOS = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\NetBIOS", RegistryKeyPermissionCheck.ReadWriteSubTree);
                NetBIOS.SetValue("Start", "1", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("NetBT"))
            {
                RegistryKey NetBT = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\NetBT", RegistryKeyPermissionCheck.ReadWriteSubTree);
                NetBT.SetValue("Start", "1", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("rdyboost"))
            {
                RegistryKey rdyboost = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\rdyboost", RegistryKeyPermissionCheck.ReadWriteSubTree);
                rdyboost.SetValue("Start", "0", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("rspndr"))
            {
                RegistryKey rspndr = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\rspndr", RegistryKeyPermissionCheck.ReadWriteSubTree);
                rspndr.SetValue("Start", "2", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("secdrv"))
            {
                RegistryKey secdrv = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\secdrv", RegistryKeyPermissionCheck.ReadWriteSubTree);
                secdrv.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("tcpipreg"))
            {
                RegistryKey tcpipreg = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\tcpipreg", RegistryKeyPermissionCheck.ReadWriteSubTree);
                tcpipreg.SetValue("Start", "2", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("udfs"))
            {
                RegistryKey udfs = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\udfs", RegistryKeyPermissionCheck.ReadWriteSubTree);
                udfs.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("WmiAcpi"))
            {
                RegistryKey WmiAcpi = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\WmiAcpi", RegistryKeyPermissionCheck.ReadWriteSubTree);
                WmiAcpi.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("Wof"))
            {
                RegistryKey Wof = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\Wof", RegistryKeyPermissionCheck.ReadWriteSubTree);
                Wof.SetValue("Start", "0", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("ws2ifsl"))
            {
                RegistryKey ws2ifsl = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\ws2ifsl", RegistryKeyPermissionCheck.ReadWriteSubTree);
                ws2ifsl.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("NativeWifiP"))
            {
                RegistryKey NativeWifiP = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\NativeWifiP", RegistryKeyPermissionCheck.ReadWriteSubTree);
                NativeWifiP.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("Ndisuio"))
            {
                RegistryKey Ndisuio = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\Ndisuio", RegistryKeyPermissionCheck.ReadWriteSubTree);
                Ndisuio.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("msisadrv"))
            {
                RegistryKey msisadrv = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\msisadrv", RegistryKeyPermissionCheck.ReadWriteSubTree);
                msisadrv.SetValue("Start", "0", RegistryValueKind.DWord);
            }
        }

        private void ButtonInterruptMSITweaks_Click(object sender, EventArgs e)
        {
            InterruptTweaksForm.ShowDialog(this);
        }

        private void ButtonInstallPrograms_Click(object sender, EventArgs e)
        {
            InstallProgramsForm.ShowDialog(this);
        }

        private void ButtonInstallRuntimes_Click(object sender, EventArgs e)
        {
            InstallRuntimesForm.ShowDialog(this);
        }

        private void ButtonDisableFTH_Click(object sender, EventArgs e)
        {
            try
            {
                RegistryKey FTH = Registry.LocalMachine.CreateSubKey(@"SOFTWARE\Microsoft\FTH", true);
                if (FTH.GetValue("Enabled") != null)
                {
                    if (FTH.GetValue("Enabled").ToString() == "0")
                    {
                        if (MessageBox.Show("Fault Tolerant Heap (FTH) is already disabled. Do you want to revert the setting?", "Fault Tolerant Heap", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            FTH.SetValue("Enabled", "1", RegistryValueKind.DWord);
                        }
                    }
                    else if (FTH.GetValue("Enabled").ToString() == "1")
                    {
                        FTH.SetValue("Enabled", "0", RegistryValueKind.DWord);
                        MessageBox.Show("Succesfully disabled Fault Tolerant Heap (FTH).", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    FTH.SetValue("Enabled", "0", RegistryValueKind.DWord);
                    MessageBox.Show("Succesfully disabled Fault Tolerant Heap (FTH).", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ButtonApplyKernelTweaks_Click(object sender, EventArgs e)
        {
            try
            {
                RegistryKey Kernel = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Control\Session Manager\kernel", RegistryKeyPermissionCheck.ReadWriteSubTree);
                if (Kernel.GetValue("DisableExceptionChainValidation") != null)
                {
                    if (Kernel.GetValue("DisableExceptionChainValidation").ToString() == "1")
                    {
                        if (MessageBox.Show("Kernel tweaks are already applied. Do you want to revert the settings?", "Kernel tweaks", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            Kernel.DeleteValue("DisableExceptionChainValidation");
                            Kernel.DeleteValue("DpcWatchdogProfileOffset");
                            Kernel.DeleteValue("DpcWatchdogPeriod");
                            Kernel.DeleteValue("KernelSEHOPEnabled");
                            Kernel.DeleteValue("SerializeTimerExpiration");
                            Kernel.DeleteValue("InterruptSteeringDisabled");
                        }
                    }
                    else if (Kernel.GetValue("DisableExceptionChainValidation").ToString() == "0")
                    {
                        Kernel.SetValue("DisableExceptionChainValidation", "1", RegistryValueKind.DWord);
                        Kernel.SetValue("DpcWatchdogProfileOffset", "0", RegistryValueKind.DWord);
                        Kernel.SetValue("DpcWatchdogPeriod", "0", RegistryValueKind.DWord);
                        Kernel.SetValue("KernelSEHOPEnabled", "0", RegistryValueKind.DWord);
                        Kernel.SetValue("SerializeTimerExpiration", "0", RegistryValueKind.DWord);
                        Kernel.SetValue("InterruptSteeringDisabled", "1", RegistryValueKind.DWord);
                        MessageBox.Show("Succesfully applied kernel tweaks.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    Kernel.SetValue("DisableExceptionChainValidation", "1", RegistryValueKind.DWord);
                    Kernel.SetValue("DpcWatchdogProfileOffset", "0", RegistryValueKind.DWord);
                    Kernel.SetValue("DpcWatchdogPeriod", "0", RegistryValueKind.DWord);
                    Kernel.SetValue("KernelSEHOPEnabled", "0", RegistryValueKind.DWord);
                    Kernel.SetValue("SerializeTimerExpiration", "0", RegistryValueKind.DWord);
                    Kernel.SetValue("InterruptSteeringDisabled", "1", RegistryValueKind.DWord);
                    MessageBox.Show("Succesfully applied kernel tweaks.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ButtonEnableClassicAltTab_Click(object sender, EventArgs e)
        {
            try
            {
                RegistryKey Explorer = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer", true);
                if (Explorer.GetValue("AltTabSettings") != null)
                {
                    if (Explorer.GetValue("AltTabSettings").ToString() == "1")
                    {
                        if (MessageBox.Show("Classic alt-tab is already enabled. Do you want to revert the setting?", "Classic alt-tab", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            Explorer.DeleteValue("AltTabSettings");
                        }
                    }
                }
                else
                {
                    Explorer.SetValue("AltTabSettings", "1", RegistryValueKind.DWord);
                    MessageBox.Show("Succesfully enabled classic alt-tab.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ButtonDebloatWindows10_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("This will strip/break OneDrive and 99% of UWP apps (even Store, Edge, Photos, Spotify, Groove etc.), remove system files, restore Windows Photo Viewer and the old battery/network/volume flyouts and remove the quick access and network icons from file explorer. Make sure you have an alternative for the Windows bloat before continuing. Are you sure you want to continue?", "Continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Process takeown1 = new Process();
                takeown1.StartInfo.FileName = "cmd.exe";
                takeown1.StartInfo.Arguments = "/C TAKEOWN /F " + "\"" + Path.GetPathRoot(Environment.SystemDirectory) + @"Windows\SystemApps" + "\" " + "/A & ICACLS " + "\"" + Path.GetPathRoot(Environment.SystemDirectory) + @"Windows\SystemApps" + "\" " + "/GRANT Administrators:(F)";
                takeown1.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                takeown1.StartInfo.CreateNoWindow = true;
                takeown1.Start();
                takeown1.WaitForExit();

                Process takeown2 = new Process();
                takeown2.StartInfo.FileName = "cmd.exe";
                takeown2.StartInfo.Arguments = "/C TAKEOWN /F " + "\"" + Path.GetPathRoot(Environment.SystemDirectory) + @"ProgramData\Packages" + "\" " + "/A & ICACLS " + "\"" + Path.GetPathRoot(Environment.SystemDirectory) + @"ProgramData\Packages" + "\" " + "/GRANT Administrators:(F)";
                takeown2.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                takeown2.StartInfo.CreateNoWindow = true;
                takeown2.Start();
                takeown2.WaitForExit();

                Process takeown3 = new Process();
                takeown3.StartInfo.FileName = "cmd.exe";
                takeown3.StartInfo.Arguments = "/C TAKEOWN /F " + "\"" + Environment.GetEnvironmentVariable("LocalAppData") + @"\Packages" + "\" " + "/A & ICACLS " + "\"" + Environment.GetEnvironmentVariable("LocalAppData") + @"\Packages" + "\" " + "/GRANT Administrators:(F)";
                takeown3.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                takeown3.StartInfo.CreateNoWindow = true;
                takeown3.Start();
                takeown3.WaitForExit();

                Process takeown4 = new Process();
                takeown4.StartInfo.FileName = "cmd.exe";
                takeown4.StartInfo.Arguments = "/C TAKEOWN /F " + "\"" + Path.GetPathRoot(Environment.SystemDirectory) + @"Program Files\WindowsApps" + "\" " + "/A & ICACLS " + "\"" + Path.GetPathRoot(Environment.SystemDirectory) + @"Program Files\WindowsApps" + "\" " + "/GRANT Administrators:(F)";
                takeown4.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                takeown4.StartInfo.CreateNoWindow = true;
                takeown4.Start();
                takeown4.WaitForExit();

                Process takeown5 = new Process();
                takeown5.StartInfo.FileName = "cmd.exe";
                takeown5.StartInfo.Arguments = "/C TAKEOWN /F " + "\"" + Path.GetPathRoot(Environment.SystemDirectory) + @"Program Files (x86)\Microsoft" + "\" " + "/A & ICACLS " + "\"" + Path.GetPathRoot(Environment.SystemDirectory) + @"Program Files (x86)\Microsoft" + "\" " + "/GRANT Administrators:(F)";
                takeown5.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                takeown5.StartInfo.CreateNoWindow = true;
                takeown5.Start();
                takeown5.WaitForExit();

                Process takeown6 = new Process();
                takeown6.StartInfo.FileName = "cmd.exe";
                takeown6.StartInfo.Arguments = "/C TAKEOWN /F " + "\"" + Environment.GetEnvironmentVariable("LocalAppData") + @"\Microsoft\WindowsApps" + "\" " + "/A & ICACLS " + "\"" + Environment.GetEnvironmentVariable("LocalAppData") + @"\Microsoft\WindowsApps" + "\" " + "/GRANT Administrators:(F)";
                takeown6.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                takeown6.StartInfo.CreateNoWindow = true;
                takeown6.Start();
                takeown6.WaitForExit();

                Process takeown7 = new Process();
                takeown7.StartInfo.FileName = "cmd.exe";
                takeown7.StartInfo.Arguments = "/C TAKEOWN /F " + "\"" + Path.GetPathRoot(Environment.SystemDirectory) + @"Windows" + "\" " + "/A & ICACLS " + "\"" + Path.GetPathRoot(Environment.SystemDirectory) + @"Windows" + "\" " + "/GRANT Administrators:(F)";
                takeown7.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                takeown7.StartInfo.CreateNoWindow = true;
                takeown7.Start();
                takeown7.WaitForExit();

                Process takeown8 = new Process();
                takeown8.StartInfo.FileName = "cmd.exe";
                takeown8.StartInfo.Arguments = "/C TAKEOWN /F " + "\"" + Path.GetPathRoot(Environment.SystemDirectory) + @"Windows\System32" + "\" " + "/A & ICACLS " + "\"" + Path.GetPathRoot(Environment.SystemDirectory) + @"Windows\System32" + "\" " + "/GRANT Administrators:(F)";
                takeown8.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                takeown8.StartInfo.CreateNoWindow = true;
                takeown8.Start();
                takeown8.WaitForExit();

                Process takeown9 = new Process();
                takeown9.StartInfo.FileName = "cmd.exe";
                takeown9.StartInfo.Arguments = "/C TAKEOWN /F " + "\"" + Path.GetPathRoot(Environment.SystemDirectory) + @"Windows\SysWOW64" + "\" " + "/A & ICACLS " + "\"" + Path.GetPathRoot(Environment.SystemDirectory) + @"Windows\SysWOW64" + "\" " + "/GRANT Administrators:(F)";
                takeown9.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                takeown9.StartInfo.CreateNoWindow = true;
                takeown9.Start();
                takeown9.WaitForExit();

                DebloatTimer_Tick(sender, e);
                DebloatTimer.Enabled = true;

                try
                {
                    Process uninstallonedrive = new Process();
                    uninstallonedrive.StartInfo.FileName = @"C:\Windows\SysWOW64\OneDriveSetup.exe";
                    uninstallonedrive.StartInfo.Arguments = "/uninstall";
                    uninstallonedrive.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    uninstallonedrive.StartInfo.CreateNoWindow = true;
                    uninstallonedrive.Start();
                    uninstallonedrive.WaitForExit();
                }
                catch
                {
                }

                Process helppane = new Process();
                helppane.StartInfo.FileName = "cmd.exe";
                helppane.StartInfo.Arguments = @"/C DEL /Q " + "\"" + Path.GetPathRoot(Environment.SystemDirectory) + @"Windows\helpPane.exe" + "\"";
                helppane.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                helppane.StartInfo.CreateNoWindow = true;
                helppane.Start();
                helppane.WaitForExit();

                Process backgroundtaskhost1 = new Process();
                backgroundtaskhost1.StartInfo.FileName = "cmd.exe";
                backgroundtaskhost1.StartInfo.Arguments = @"/C DEL /Q " + "\"" + Path.GetPathRoot(Environment.SystemDirectory) + @"Windows\System32\backgroundtaskhost.exe" + "\"";
                backgroundtaskhost1.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                backgroundtaskhost1.StartInfo.CreateNoWindow = true;
                backgroundtaskhost1.Start();
                backgroundtaskhost1.WaitForExit();

                Process EaseOfAccessDialog1 = new Process();
                EaseOfAccessDialog1.StartInfo.FileName = "cmd.exe";
                EaseOfAccessDialog1.StartInfo.Arguments = @"/C DEL /Q " + "\"" + Path.GetPathRoot(Environment.SystemDirectory) + @"Windows\System32\EaseOfAccessDialog.exe" + "\"";
                EaseOfAccessDialog1.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                EaseOfAccessDialog1.StartInfo.CreateNoWindow = true;
                EaseOfAccessDialog1.Start();
                EaseOfAccessDialog1.WaitForExit();

                Process RuntimeBroker = new Process();
                RuntimeBroker.StartInfo.FileName = "cmd.exe";
                RuntimeBroker.StartInfo.Arguments = @"/C DEL /Q " + "\"" + Path.GetPathRoot(Environment.SystemDirectory) + @"Windows\System32\RuntimeBroker.exe" + "\"";
                RuntimeBroker.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                RuntimeBroker.StartInfo.CreateNoWindow = true;
                RuntimeBroker.Start();
                RuntimeBroker.WaitForExit();

                Process WSClient1 = new Process();
                WSClient1.StartInfo.FileName = "cmd.exe";
                WSClient1.StartInfo.Arguments = @"/C DEL /Q " + "\"" + Path.GetPathRoot(Environment.SystemDirectory) + @"Windows\System32\WSClient.dll" + "\"";
                WSClient1.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                WSClient1.StartInfo.CreateNoWindow = true;
                WSClient1.Start();
                WSClient1.WaitForExit();

                Process WSCollect = new Process();
                WSCollect.StartInfo.FileName = "cmd.exe";
                WSCollect.StartInfo.Arguments = @"/C DEL /Q " + "\"" + Path.GetPathRoot(Environment.SystemDirectory) + @"Windows\System32\WSCollect.exe" + "\"";
                WSCollect.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                WSCollect.StartInfo.CreateNoWindow = true;
                WSCollect.Start();
                WSCollect.WaitForExit();

                Process gamebarpresencewriter1 = new Process();
                gamebarpresencewriter1.StartInfo.FileName = "cmd.exe";
                gamebarpresencewriter1.StartInfo.Arguments = @"/C DEL /Q " + "\"" + Path.GetPathRoot(Environment.SystemDirectory) + @"Windows\System32\gamebarpresencewriter.exe" + "\"";
                gamebarpresencewriter1.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                gamebarpresencewriter1.StartInfo.CreateNoWindow = true;
                gamebarpresencewriter1.Start();
                gamebarpresencewriter1.WaitForExit();

                Process gamepanel1 = new Process();
                gamepanel1.StartInfo.FileName = "cmd.exe";
                gamepanel1.StartInfo.Arguments = @"/C DEL /Q " + "\"" + Path.GetPathRoot(Environment.SystemDirectory) + @"Windows\System32\gamepanel.exe" + "\"";
                gamepanel1.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                gamepanel1.StartInfo.CreateNoWindow = true;
                gamepanel1.Start();
                gamepanel1.WaitForExit();

                Process magnify1 = new Process();
                magnify1.StartInfo.FileName = "cmd.exe";
                magnify1.StartInfo.Arguments = @"/C DEL /Q " + "\"" + Path.GetPathRoot(Environment.SystemDirectory) + @"Windows\System32\magnify.exe" + "\"";
                magnify1.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                magnify1.StartInfo.CreateNoWindow = true;
                magnify1.Start();
                magnify1.WaitForExit();

                Process mblctr = new Process();
                mblctr.StartInfo.FileName = "cmd.exe";
                mblctr.StartInfo.Arguments = @"/C DEL /Q " + "\"" + Path.GetPathRoot(Environment.SystemDirectory) + @"Windows\System32\mblctr.exe" + "\"";
                mblctr.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                mblctr.StartInfo.CreateNoWindow = true;
                mblctr.Start();
                mblctr.WaitForExit();

                Process sdiagnhost = new Process();
                sdiagnhost.StartInfo.FileName = "cmd.exe";
                sdiagnhost.StartInfo.Arguments = @"/C DEL /Q " + "\"" + Path.GetPathRoot(Environment.SystemDirectory) + @"Windows\System32\sdiagnhost.exe" + "\"";
                sdiagnhost.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                sdiagnhost.StartInfo.CreateNoWindow = true;
                sdiagnhost.Start();
                sdiagnhost.WaitForExit();

                Process mobsync1 = new Process();
                mobsync1.StartInfo.FileName = "cmd.exe";
                mobsync1.StartInfo.Arguments = @"/C DEL /Q " + "\"" + Path.GetPathRoot(Environment.SystemDirectory) + @"Windows\System32\mobsync.exe" + "\"";
                mobsync1.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                mobsync1.StartInfo.CreateNoWindow = true;
                mobsync1.Start();
                mobsync1.WaitForExit();

                Process msdt = new Process();
                msdt.StartInfo.FileName = "cmd.exe";
                msdt.StartInfo.Arguments = @"/C DEL /Q " + "\"" + Path.GetPathRoot(Environment.SystemDirectory) + @"Windows\System32\msdt.exe" + "\"";
                msdt.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                msdt.StartInfo.CreateNoWindow = true;
                msdt.Start();
                msdt.WaitForExit();

                Process narrator = new Process();
                narrator.StartInfo.FileName = "cmd.exe";
                narrator.StartInfo.Arguments = @"/C DEL /Q " + "\"" + Path.GetPathRoot(Environment.SystemDirectory) + @"Windows\System32\narrator.exe" + "\"";
                narrator.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                narrator.StartInfo.CreateNoWindow = true;
                narrator.Start();
                narrator.WaitForExit();

                Process osk = new Process();
                osk.StartInfo.FileName = "cmd.exe";
                osk.StartInfo.Arguments = @"/C DEL /Q " + "\"" + Path.GetPathRoot(Environment.SystemDirectory) + @"Windows\System32\osk.exe" + "\"";
                osk.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                osk.StartInfo.CreateNoWindow = true;
                osk.Start();
                osk.WaitForExit();

                Process smartscreen = new Process();
                smartscreen.StartInfo.FileName = "cmd.exe";
                smartscreen.StartInfo.Arguments = @"/C DEL /Q " + "\"" + Path.GetPathRoot(Environment.SystemDirectory) + @"Windows\System32\smartscreen.exe" + "\"";
                smartscreen.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                smartscreen.StartInfo.CreateNoWindow = true;
                smartscreen.Start();
                smartscreen.WaitForExit();

                Process backgroundtaskhost2 = new Process();
                backgroundtaskhost2.StartInfo.FileName = "cmd.exe";
                backgroundtaskhost2.StartInfo.Arguments = @"/C DEL /Q " + "\"" + Path.GetPathRoot(Environment.SystemDirectory) + @"Windows\SysWOW64\backgroundtaskhost.exe" + "\"";
                backgroundtaskhost2.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                backgroundtaskhost2.StartInfo.CreateNoWindow = true;
                backgroundtaskhost2.Start();
                backgroundtaskhost2.WaitForExit();

                Process EaseOfAccessDialog2 = new Process();
                EaseOfAccessDialog2.StartInfo.FileName = "cmd.exe";
                EaseOfAccessDialog2.StartInfo.Arguments = @"/C DEL /Q " + "\"" + Path.GetPathRoot(Environment.SystemDirectory) + @"Windows\SysWOW64\EaseOfAccessDialog.exe" + "\"";
                EaseOfAccessDialog2.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                EaseOfAccessDialog2.StartInfo.CreateNoWindow = true;
                EaseOfAccessDialog2.Start();
                EaseOfAccessDialog2.WaitForExit();

                Process WSClient2 = new Process();
                WSClient2.StartInfo.FileName = "cmd.exe";
                WSClient2.StartInfo.Arguments = @"/C DEL /Q " + "\"" + Path.GetPathRoot(Environment.SystemDirectory) + @"Windows\SysWOW64\WSClient.dll" + "\"";
                WSClient2.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                WSClient2.StartInfo.CreateNoWindow = true;
                WSClient2.Start();
                WSClient2.WaitForExit();

                Process gamebarpresencewriter2 = new Process();
                gamebarpresencewriter2.StartInfo.FileName = "cmd.exe";
                gamebarpresencewriter2.StartInfo.Arguments = @"/C DEL /Q " + "\"" + Path.GetPathRoot(Environment.SystemDirectory) + @"Windows\SysWOW64\gamebarpresencewriter.exe" + "\"";
                gamebarpresencewriter2.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                gamebarpresencewriter2.StartInfo.CreateNoWindow = true;
                gamebarpresencewriter2.Start();
                gamebarpresencewriter2.WaitForExit();

                Process gamepanel2 = new Process();
                gamepanel2.StartInfo.FileName = "cmd.exe";
                gamepanel2.StartInfo.Arguments = @"/C DEL /Q " + "\"" + Path.GetPathRoot(Environment.SystemDirectory) + @"Windows\SysWOW64\gamepanel.exe" + "\"";
                gamepanel2.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                gamepanel2.StartInfo.CreateNoWindow = true;
                gamepanel2.Start();
                gamepanel2.WaitForExit();

                Process magnify2 = new Process();
                magnify2.StartInfo.FileName = "cmd.exe";
                magnify2.StartInfo.Arguments = @"/C DEL /Q " + "\"" + Path.GetPathRoot(Environment.SystemDirectory) + @"Windows\SysWOW64\magnify.exe" + "\"";
                magnify2.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                magnify2.StartInfo.CreateNoWindow = true;
                magnify2.Start();
                magnify2.WaitForExit();

                Process mobsync2 = new Process();
                mobsync2.StartInfo.FileName = "cmd.exe";
                mobsync2.StartInfo.Arguments = @"/C DEL /Q " + "\"" + Path.GetPathRoot(Environment.SystemDirectory) + @"Windows\SysWOW64\mobsync.exe" + "\"";
                mobsync2.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                mobsync2.StartInfo.CreateNoWindow = true;
                mobsync2.Start();
                mobsync2.WaitForExit();

                Process flashPlayerCPLApp = new Process();
                flashPlayerCPLApp.StartInfo.FileName = "cmd.exe";
                flashPlayerCPLApp.StartInfo.Arguments = @"/C DEL /Q " + "\"" + Path.GetPathRoot(Environment.SystemDirectory) + @"Windows\SysWOW64\flashPlayerCPLApp.cpl" + "\"";
                flashPlayerCPLApp.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                flashPlayerCPLApp.StartInfo.CreateNoWindow = true;
                flashPlayerCPLApp.Start();
                flashPlayerCPLApp.WaitForExit();

                Process flashPlayerApp = new Process();
                flashPlayerApp.StartInfo.FileName = "cmd.exe";
                flashPlayerApp.StartInfo.Arguments = @"/C DEL /Q " + "\"" + Path.GetPathRoot(Environment.SystemDirectory) + @"Windows\SysWOW64\flashPlayerApp.exe" + "\"";
                flashPlayerApp.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                flashPlayerApp.StartInfo.CreateNoWindow = true;
                flashPlayerApp.Start();
                flashPlayerApp.WaitForExit();

                Process SystemApps = new Process();
                SystemApps.StartInfo.FileName = "cmd.exe";
                SystemApps.StartInfo.Arguments = @"/C RD /S /Q " + "\"" + Path.GetPathRoot(Environment.SystemDirectory) + @"Windows\SystemApps" + "\"";
                SystemApps.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                SystemApps.StartInfo.CreateNoWindow = true;
                SystemApps.Start();
                SystemApps.WaitForExit();

                Process Packages1 = new Process();
                Packages1.StartInfo.FileName = "cmd.exe";
                Packages1.StartInfo.Arguments = @"/C RD /S /Q " + "\"" + Path.GetPathRoot(Environment.SystemDirectory) + @"ProgramData\Packages" + "\"";
                Packages1.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                Packages1.StartInfo.CreateNoWindow = true;
                Packages1.Start();
                Packages1.WaitForExit();

                Process Packages2 = new Process();
                Packages2.StartInfo.FileName = "cmd.exe";
                Packages2.StartInfo.Arguments = @"/C RD /S /Q " + "\"" + Environment.GetEnvironmentVariable("LocalAppData") + @"\Packages" + "\"";
                Packages2.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                Packages2.StartInfo.CreateNoWindow = true;
                Packages2.Start();
                Packages2.WaitForExit();

                Process WindowsApps1 = new Process();
                WindowsApps1.StartInfo.FileName = "cmd.exe";
                WindowsApps1.StartInfo.Arguments = @"/C RD /S /Q " + "\"" + Path.GetPathRoot(Environment.SystemDirectory) + @"Program Files\WindowsApps" + "\"";
                WindowsApps1.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                WindowsApps1.StartInfo.CreateNoWindow = true;
                WindowsApps1.Start();
                WindowsApps1.WaitForExit();

                Process Microsoft = new Process();
                Microsoft.StartInfo.FileName = "cmd.exe";
                Microsoft.StartInfo.Arguments = @"/C RD /S /Q " + "\"" + Path.GetPathRoot(Environment.SystemDirectory) + @"Program Files (x86)\Microsoft" + "\"";
                Microsoft.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                Microsoft.StartInfo.CreateNoWindow = true;
                Microsoft.Start();
                Microsoft.WaitForExit();

                Process WindowsApps2 = new Process();
                WindowsApps2.StartInfo.FileName = "cmd.exe";
                WindowsApps2.StartInfo.Arguments = @"/C RD /S /Q " + "\"" + Environment.GetEnvironmentVariable("LocalAppData") + @"\Microsoft\WindowsApps" + "\"";
                WindowsApps2.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                WindowsApps2.StartInfo.CreateNoWindow = true;
                WindowsApps2.Start();
                WindowsApps2.WaitForExit();

                DebloatTimer.Enabled = false;
                DebloatTimer_Tick(sender, e);

                RegistryKey MTCUVC = Registry.LocalMachine.CreateSubKey(@"Software\Microsoft\Windows NT\CurrentVersion\MTCUVC", RegistryKeyPermissionCheck.ReadWriteSubTree);
                RegistryKey ImmersiveShell = Registry.LocalMachine.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\ImmersiveShell", RegistryKeyPermissionCheck.ReadWriteSubTree);
                RegistryKey FileAssociations = Registry.LocalMachine.CreateSubKey(@"Software\Microsoft\Windows Photo Viewer\Capabilities\FileAssociations", RegistryKeyPermissionCheck.ReadWriteSubTree);

                Process networkreg = new Process();
                networkreg.StartInfo.FileName = "NSudoLG.exe";
                networkreg.StartInfo.Arguments = "-U:T Reg add " + "\"" + @"HKLM\SOFTWARE\Microsoft\Windows\CurrentVersion\Control Panel\Settings\Network" + "\" " + "/v " + "\"" + "ReplaceVan" + "\" " + "/t " + "REG_DWORD /d " + "\"" + "2" + "\" /f";
                networkreg.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                networkreg.StartInfo.CreateNoWindow = true;
                networkreg.Start();
                networkreg.WaitForExit();

                Process quickaccess1 = new Process();
                quickaccess1.StartInfo.FileName = "NSudoLG.exe";
                quickaccess1.StartInfo.Arguments = "-U:T Reg add " + "\"" + @"HKEY_CLASSES_ROOT\CLSID\{679f85cb-0220-4080-b29b-5540cc05aab6}\ShellFolder" + "\" " + "/v " + "\"" + "Attributes" + "\" " + "/t " + "REG_DWORD /d " + "\"" + "2690646016" + "\" /f";
                quickaccess1.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                quickaccess1.StartInfo.CreateNoWindow = true;
                quickaccess1.Start();
                quickaccess1.WaitForExit();

                Process quickaccess2 = new Process();
                quickaccess2.StartInfo.FileName = "NSudoLG.exe";
                quickaccess2.StartInfo.Arguments = "-U:T Reg add " + "\"" + @"HKEY_CLASSES_ROOT\Wow6432Node\CLSID\{679f85cb-0220-4080-b29b-5540cc05aab6}\ShellFolder" + "\" " + "/v " + "\"" + "Attributes" + "\" " + "/t " + "REG_DWORD /d " + "\"" + "2690646016" + "\" /f";
                quickaccess2.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                quickaccess2.StartInfo.CreateNoWindow = true;
                quickaccess2.Start();
                quickaccess2.WaitForExit();

                Process network1 = new Process();
                network1.StartInfo.FileName = "NSudoLG.exe";
                network1.StartInfo.Arguments = "-U:T Reg add " + "\"" + @"HKEY_CLASSES_ROOT\CLSID\{F02C1A0D-BE21-4350-88B0-7367FC96EF3C}\ShellFolder" + "\" " + "/v " + "\"" + "Attributes" + "\" " + "/t " + "REG_DWORD /d " + "\"" + "2962489444" + "\" /f";
                network1.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                network1.StartInfo.CreateNoWindow = true;
                network1.Start();
                network1.WaitForExit();

                Process network2 = new Process();
                network2.StartInfo.FileName = "NSudoLG.exe";
                network2.StartInfo.Arguments = "-U:T Reg add " + "\"" + @"HKEY_CLASSES_ROOT\Wow6432Node\CLSID\{F02C1A0D-BE21-4350-88B0-7367FC96EF3C}}\ShellFolder" + "\" " + "/v " + "\"" + "Attributes" + "\" " + "/t " + "REG_DWORD /d " + "\"" + "2962489444" + "\" /f";
                network2.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                network2.StartInfo.CreateNoWindow = true;
                network2.Start();
                network2.WaitForExit();

                MTCUVC.SetValue("EnableMtcUvc", "0", RegistryValueKind.DWord);
                ImmersiveShell.SetValue("UseWin32BatteryFlyout", "1", RegistryValueKind.DWord);
                FileAssociations.SetValue(".bmp", "PhotoViewer.FileAssoc.Tiff", RegistryValueKind.String);
                FileAssociations.SetValue(".dib", "PhotoViewer.FileAssoc.Tiff", RegistryValueKind.String);
                FileAssociations.SetValue(".gif", "PhotoViewer.FileAssoc.Tiff", RegistryValueKind.String);
                FileAssociations.SetValue(".jpe", "PhotoViewer.FileAssoc.Tiff", RegistryValueKind.String);
                FileAssociations.SetValue(".jpg", "PhotoViewer.FileAssoc.Tiff", RegistryValueKind.String);
                FileAssociations.SetValue(".jxr", "PhotoViewer.FileAssoc.Tiff", RegistryValueKind.String);
                FileAssociations.SetValue(".png", "PhotoViewer.FileAssoc.Tiff", RegistryValueKind.String);
                FileAssociations.SetValue(".tif", "PhotoViewer.FileAssoc.Tiff", RegistryValueKind.String);
                FileAssociations.SetValue(".jpeg", "PhotoViewer.FileAssoc.Tiff", RegistryValueKind.String);
                FileAssociations.SetValue(".jfif", "PhotoViewer.FileAssoc.Tiff", RegistryValueKind.String);
                FileAssociations.SetValue(".tiff", "PhotoViewer.FileAssoc.Tiff", RegistryValueKind.String);

                MessageBox.Show("Succesfully debloated Windows", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ButtonApplyMemoryTweaks_Click(object sender, EventArgs e)
        {
            try
            {
                RegistryKey Memory = Registry.LocalMachine.CreateSubKey(@"SYSTEM\CurrentControlSet\Control\Session Manager\Memory Management", RegistryKeyPermissionCheck.ReadWriteSubTree);
                RegistryKey PrefetchParameters = Registry.LocalMachine.CreateSubKey(@"SYSTEM\ControlSet001\Control\Session Manager\Memory Management\PrefetchParameters", RegistryKeyPermissionCheck.ReadWriteSubTree);
                if (Memory.GetValue("EnableCfg") != null)
                {
                    if (Memory.GetValue("EnableCfg").ToString() == "0")
                    {
                        if (MessageBox.Show("Memory tweaks are already applied. Do you want to revert the settings?", "Memory tweaks", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            Memory.DeleteValue("EnableCfg");
                            Memory.DeleteValue("FeatureSettings");
                            Memory.DeleteValue("FeatureSettingsOverride");
                            Memory.DeleteValue("FeatureSettingsOverrideMask");
                            Memory.DeleteValue("MoveImages");
                            PrefetchParameters.DeleteValue("EnablePrefetcher");
                            PrefetchParameters.DeleteValue("EnableSuperfetch");
                        }
                    }
                    else if (Memory.GetValue("EnableCfg").ToString() == "1")
                    {
                        Memory.SetValue("EnableCfg", "0", RegistryValueKind.DWord);
                        Memory.SetValue("FeatureSettings", "1", RegistryValueKind.DWord);
                        Memory.SetValue("FeatureSettingsOverride", "3", RegistryValueKind.DWord);
                        Memory.SetValue("FeatureSettingsOverrideMask", "3", RegistryValueKind.DWord);
                        Memory.SetValue("MoveImages", "0", RegistryValueKind.DWord);
                        PrefetchParameters.SetValue("EnablePrefetcher", "0", RegistryValueKind.DWord);
                        PrefetchParameters.SetValue("EnableSuperfetch", "0", RegistryValueKind.DWord);
                        MessageBox.Show("Succesfully applied memory tweaks.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    Memory.SetValue("EnableCfg", "0", RegistryValueKind.DWord);
                    Memory.SetValue("FeatureSettings", "1", RegistryValueKind.DWord);
                    Memory.SetValue("FeatureSettingsOverride", "3", RegistryValueKind.DWord);
                    Memory.SetValue("FeatureSettingsOverrideMask", "3", RegistryValueKind.DWord);
                    Memory.SetValue("MoveImages", "0", RegistryValueKind.DWord);
                    PrefetchParameters.SetValue("EnablePrefetcher", "0", RegistryValueKind.DWord);
                    PrefetchParameters.SetValue("EnableSuperfetch", "0", RegistryValueKind.DWord);
                    MessageBox.Show("Succesfully applied memory tweaks.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ButtonApplyStorageTweaks_Click(object sender, EventArgs e)
        {
            RegistryKey Device = Registry.LocalMachine.CreateSubKey(@"SYSTEM\CurrentControlSet\services\stornvme\Parameters\Device", RegistryKeyPermissionCheck.ReadWriteSubTree);

            try
            {
                RegistryKey services = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\services", RegistryKeyPermissionCheck.ReadWriteSubTree);

                foreach (string x in services.GetSubKeyNames())
                {
                    RegistryKey Subkeys = services.OpenSubKey(x);

                    if (Subkeys.GetSubKeyNames().Contains("Parameters"))
                    {
                        RegistryKey parameters = Subkeys.OpenSubKey("Parameters", RegistryRights.ReadKey);

                        if (parameters.GetValueNames().Contains("IoLatencyCap"))
                        {
                            RegistryKey Parameters = Subkeys.OpenSubKey("Parameters", RegistryKeyPermissionCheck.ReadWriteSubTree, RegistryRights.FullControl);
                            Parameters.SetValue("IoLatencyCap", 0);
                            MessageBox.Show("Succesfully set IoLatencyCap to 0 at " + parameters.ToString(), "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            try
            {
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

                                if (DeviceParameters.GetSubKeyNames().Contains("StorPort"))
                                {
                                    RegistryKey StorPort = DeviceParameters.OpenSubKey("StorPort", RegistryKeyPermissionCheck.ReadWriteSubTree);
                                    StorPort.SetValue("EnableIdlePowerManagement", "0", RegistryValueKind.DWord);
                                    MessageBox.Show("Succesfully set EnableIdlePowerManagement to 0 at " + StorPort.ToString(), "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            Device.SetValue("ContiguousMemoryFromAnyNode", "1", RegistryValueKind.DWord);
            Device.SetValue("LogSize", "0", RegistryValueKind.DWord);
            Device.SetValue("IdlePowerMode", "0", RegistryValueKind.DWord);
            Device.SetValue("DiagnosticFlags", "0", RegistryValueKind.DWord);

            MessageBox.Show("Succesfully applied storage tweaks!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ButtonImportATUPowerPlan_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("This will remove all your power plans and apply the Auto Tweaking Utility power plan.", "Power plan", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                try
                {
                    Process restoredefaultschemes = new Process();
                    restoredefaultschemes.StartInfo.FileName = "powercfg.exe";
                    restoredefaultschemes.StartInfo.Arguments = "-restoredefaultschemes";
                    restoredefaultschemes.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    restoredefaultschemes.StartInfo.CreateNoWindow = true;
                    restoredefaultschemes.Start();
                    restoredefaultschemes.WaitForExit();

                    Process duplicatescheme = new Process();
                    duplicatescheme.StartInfo.FileName = "powercfg.exe";
                    duplicatescheme.StartInfo.Arguments = "-duplicatescheme 8c5e7fda-e8bf-4a96-9a85-a6e23a8c635c 00000000-0000-0000-0000-000000000000";
                    duplicatescheme.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    duplicatescheme.StartInfo.CreateNoWindow = true;
                    duplicatescheme.Start();
                    duplicatescheme.WaitForExit();

                    Process setactive = new Process();
                    setactive.StartInfo.FileName = "powercfg.exe";
                    setactive.StartInfo.Arguments = "-setactive 00000000-0000-0000-0000-000000000000";
                    setactive.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    setactive.StartInfo.CreateNoWindow = true;
                    setactive.Start();
                    setactive.WaitForExit();

                    Process delete1 = new Process();
                    delete1.StartInfo.FileName = "powercfg.exe";
                    delete1.StartInfo.Arguments = "-delete 8c5e7fda-e8bf-4a96-9a85-a6e23a8c635c";
                    delete1.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    delete1.StartInfo.CreateNoWindow = true;
                    delete1.Start();
                    delete1.WaitForExit();

                    Process delete2 = new Process();
                    delete2.StartInfo.FileName = "powercfg.exe";
                    delete2.StartInfo.Arguments = "-delete 381b4222-f694-41f0-9685-ff5bb260df2e";
                    delete2.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    delete2.StartInfo.CreateNoWindow = true;
                    delete2.Start();
                    delete2.WaitForExit();

                    Process delete3 = new Process();
                    delete3.StartInfo.FileName = "powercfg.exe";
                    delete3.StartInfo.Arguments = "-delete a1841308-3541-4fab-bc81-f71556f20b4a";
                    delete3.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    delete3.StartInfo.CreateNoWindow = true;
                    delete3.Start();
                    delete3.WaitForExit();

                    Process changename = new Process();
                    changename.StartInfo.FileName = "powercfg.exe";
                    changename.StartInfo.Arguments = "-changename 00000000-0000-0000-0000-000000000000 " + "\"" + "Auto Tweaking Utility Power Plan" + "\"" + " " + "\"" + "Provides optimised performance and latency." + "\"";
                    changename.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    changename.StartInfo.CreateNoWindow = true;
                    changename.Start();
                    changename.WaitForExit();

                    Process disablehibernate = new Process();
                    disablehibernate.StartInfo.FileName = "powercfg.exe";
                    disablehibernate.StartInfo.Arguments = "-hibernate off";
                    disablehibernate.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    disablehibernate.StartInfo.CreateNoWindow = true;
                    disablehibernate.Start();
                    disablehibernate.WaitForExit();

                    Process turnharddiskoffafter = new Process();
                    turnharddiskoffafter.StartInfo.FileName = "powercfg.exe";
                    turnharddiskoffafter.StartInfo.Arguments = "-setacvalueindex scheme_current 0012ee47-9041-4b5d-9b77-535fba8b1442 6738e2c4-e8a5-4a42-b16a-e040e769756e 0";
                    turnharddiskoffafter.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    turnharddiskoffafter.StartInfo.CreateNoWindow = true;
                    turnharddiskoffafter.Start();
                    turnharddiskoffafter.WaitForExit();

                    Process nvmeidletimeout = new Process();
                    nvmeidletimeout.StartInfo.FileName = "powercfg.exe";
                    nvmeidletimeout.StartInfo.Arguments = "-setacvalueindex scheme_current 0012ee47-9041-4b5d-9b77-535fba8b1442 d639518a-e56d-4345-8af2-b9f32fb26109 0";
                    nvmeidletimeout.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    nvmeidletimeout.StartInfo.CreateNoWindow = true;
                    nvmeidletimeout.Start();
                    nvmeidletimeout.WaitForExit();

                    Process lockinterruptrouting = new Process();
                    lockinterruptrouting.StartInfo.FileName = "powercfg.exe";
                    lockinterruptrouting.StartInfo.Arguments = "-setacvalueindex scheme_current 48672f38-7a9a-4bb2-8bf8-3d85be19de4e 2bfc24f9-5ea2-4801-8213-3dbae01aa39d 4";
                    lockinterruptrouting.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    lockinterruptrouting.StartInfo.CreateNoWindow = true;
                    lockinterruptrouting.Start();
                    lockinterruptrouting.WaitForExit();

                    Process disablewaketimers = new Process();
                    disablewaketimers.StartInfo.FileName = "powercfg.exe";
                    disablewaketimers.StartInfo.Arguments = "-setacvalueindex scheme_current 238c9fa8-0aad-41ed-83f4-97be242c8f20 bd3b718a-0680-4d9d-8ab2-e1d2b4ac806d 0";
                    disablewaketimers.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    disablewaketimers.StartInfo.CreateNoWindow = true;
                    disablewaketimers.Start();
                    disablewaketimers.WaitForExit();

                    Process maxhubselectivesuspendtimeout = new Process();
                    maxhubselectivesuspendtimeout.StartInfo.FileName = "powercfg.exe";
                    maxhubselectivesuspendtimeout.StartInfo.Arguments = "-setacvalueindex scheme_current 2a737441-1930-4402-8d77-b2bebba308a3 0853a681-27c8-4100-a2fd-82013e970683 186a0";
                    maxhubselectivesuspendtimeout.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    maxhubselectivesuspendtimeout.StartInfo.CreateNoWindow = true;
                    maxhubselectivesuspendtimeout.Start();
                    maxhubselectivesuspendtimeout.WaitForExit();

                    Process disableusbselectivesuspend = new Process();
                    disableusbselectivesuspend.StartInfo.FileName = "powercfg.exe";
                    disableusbselectivesuspend.StartInfo.Arguments = "-setacvalueindex scheme_current 2a737441-1930-4402-8d77-b2bebba308a3 48e6b7a6-50f5-4782-a5d4-53bb8f07e226 0";
                    disableusbselectivesuspend.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    disableusbselectivesuspend.StartInfo.CreateNoWindow = true;
                    disableusbselectivesuspend.Start();
                    disableusbselectivesuspend.WaitForExit();

                    Process disableusb3linkpowermanagement = new Process();
                    disableusb3linkpowermanagement.StartInfo.FileName = "powercfg.exe";
                    disableusb3linkpowermanagement.StartInfo.Arguments = "-setacvalueindex scheme_current 2a737441-1930-4402-8d77-b2bebba308a3 d4e98f31-5ffe-4ce1-be31-1b38b384c009 0";
                    disableusb3linkpowermanagement.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    disableusb3linkpowermanagement.StartInfo.CreateNoWindow = true;
                    disableusb3linkpowermanagement.Start();
                    disableusb3linkpowermanagement.WaitForExit();

                    if (MessageBox.Show("Do you want to disable idle? Disabling idle will decrease latency, although it may increase the temperatures. Disable idle at your own risk, and only if you have HT/SMT disabled in BIOS and adequate CPU temperatures!", "Disable idle?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Process disableidle = new Process();
                        disableidle.StartInfo.FileName = "powercfg.exe";
                        disableidle.StartInfo.Arguments = "-setacvalueindex scheme_current 54533251-82be-4824-96c1-47b60b740d00 5d76a2ca-e8c0-402f-a133-2158492d58ad 1";
                        disableidle.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                        disableidle.StartInfo.CreateNoWindow = true;
                        disableidle.Start();
                        disableidle.WaitForExit();
                    }

                    MessageBox.Show("Succesfully imported Auto Tweaking Utility power plan with the GUID 00000000-0000-0000-0000-000000000000.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void ButtonApplyBCDEditSettings_Click(object sender, EventArgs e)
        {
            try
            {
                Process bcdedit = new Process();
                bcdedit.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                bcdedit.StartInfo.UseShellExecute = false;
                bcdedit.StartInfo.RedirectStandardOutput = true;
                bcdedit.StartInfo.FileName = "bcdedit.exe";
                bcdedit.StartInfo.Arguments = "/enum {current}";
                bcdedit.Start();
                bcdedit.WaitForExit();

                if (bcdedit.StandardOutput.ReadToEnd().Contains("hypervisorlaunchtype    Off"))
                {
                    if (MessageBox.Show("BCDEdit settings are already applied. Do you want to revert the settings?", "BCDEdit settings", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Process nx = new Process();
                        nx.StartInfo.FileName = "bcdedit.exe";
                        nx.StartInfo.Arguments = "/deletevalue nx";
                        nx.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                        nx.StartInfo.CreateNoWindow = true;
                        nx.Start();
                        nx.WaitForExit();

                        Process useplatformtick = new Process();
                        useplatformtick.StartInfo.FileName = "bcdedit.exe";
                        useplatformtick.StartInfo.Arguments = "/deletevalue useplatformtick";
                        useplatformtick.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                        useplatformtick.StartInfo.CreateNoWindow = true;
                        useplatformtick.Start();
                        useplatformtick.WaitForExit();

                        Process useplatformclock = new Process();
                        useplatformclock.StartInfo.FileName = "bcdedit.exe";
                        useplatformclock.StartInfo.Arguments = "/deletevalue useplatformclock";
                        useplatformclock.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                        useplatformclock.StartInfo.CreateNoWindow = true;
                        useplatformclock.Start();
                        useplatformclock.WaitForExit();

                        Process x2apicpolicy = new Process();
                        x2apicpolicy.StartInfo.FileName = "bcdedit.exe";
                        x2apicpolicy.StartInfo.Arguments = "/deletevalue x2apicpolicy";
                        x2apicpolicy.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                        x2apicpolicy.StartInfo.CreateNoWindow = true;
                        x2apicpolicy.Start();
                        x2apicpolicy.WaitForExit();

                        Process disabledynamictick = new Process();
                        disabledynamictick.StartInfo.FileName = "bcdedit.exe";
                        disabledynamictick.StartInfo.Arguments = "/deletevalue disabledynamictick";
                        disabledynamictick.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                        disabledynamictick.StartInfo.CreateNoWindow = true;
                        disabledynamictick.Start();
                        disabledynamictick.WaitForExit();

                        Process hypervisorlaunchtype = new Process();
                        hypervisorlaunchtype.StartInfo.FileName = "bcdedit.exe";
                        hypervisorlaunchtype.StartInfo.Arguments = "/deletevalue hypervisorlaunchtype";
                        hypervisorlaunchtype.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                        hypervisorlaunchtype.StartInfo.CreateNoWindow = true;
                        hypervisorlaunchtype.Start();
                        hypervisorlaunchtype.WaitForExit();

                        Process tpmbootentropy = new Process();
                        tpmbootentropy.StartInfo.FileName = "bcdedit.exe";
                        tpmbootentropy.StartInfo.Arguments = "/deletevalue tpmbootentropy";
                        tpmbootentropy.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                        tpmbootentropy.StartInfo.CreateNoWindow = true;
                        tpmbootentropy.Start();
                        tpmbootentropy.WaitForExit();

                        Process quietboot = new Process();
                        quietboot.StartInfo.FileName = "bcdedit.exe";
                        quietboot.StartInfo.Arguments = "/deletevalue quietboot";
                        quietboot.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                        quietboot.StartInfo.CreateNoWindow = true;
                        quietboot.Start();
                        quietboot.WaitForExit();

                        Process bootux = new Process();
                        bootux.StartInfo.FileName = "bcdedit.exe";
                        bootux.StartInfo.Arguments = "/deletevalue bootux";
                        bootux.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                        bootux.StartInfo.CreateNoWindow = true;
                        bootux.Start();
                        bootux.WaitForExit();
                    }
                }
                else
                {
                    Process nx = new Process();
                    nx.StartInfo.FileName = "bcdedit.exe";
                    nx.StartInfo.Arguments = "/set nx optin";
                    nx.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    nx.StartInfo.CreateNoWindow = true;
                    nx.Start();
                    nx.WaitForExit();

                    Process useplatformtick = new Process();
                    useplatformtick.StartInfo.FileName = "bcdedit.exe";
                    useplatformtick.StartInfo.Arguments = "/set useplatformtick yes";
                    useplatformtick.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    useplatformtick.StartInfo.CreateNoWindow = true;
                    useplatformtick.Start();
                    useplatformtick.WaitForExit();

                    Process useplatformclock = new Process();
                    useplatformclock.StartInfo.FileName = "bcdedit.exe";
                    useplatformclock.StartInfo.Arguments = "/set useplatformclock no";
                    useplatformclock.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    useplatformclock.StartInfo.CreateNoWindow = true;
                    useplatformclock.Start();
                    useplatformclock.WaitForExit();

                    Process x2apicpolicy = new Process();
                    x2apicpolicy.StartInfo.FileName = "bcdedit.exe";
                    x2apicpolicy.StartInfo.Arguments = "/set x2apicpolicy disable";
                    x2apicpolicy.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    x2apicpolicy.StartInfo.CreateNoWindow = true;
                    x2apicpolicy.Start();
                    x2apicpolicy.WaitForExit();

                    Process disabledynamictick = new Process();
                    disabledynamictick.StartInfo.FileName = "bcdedit.exe";
                    disabledynamictick.StartInfo.Arguments = "/set disabledynamictick yes";
                    disabledynamictick.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    disabledynamictick.StartInfo.CreateNoWindow = true;
                    disabledynamictick.Start();
                    disabledynamictick.WaitForExit();

                    Process hypervisorlaunchtype = new Process();
                    hypervisorlaunchtype.StartInfo.FileName = "bcdedit.exe";
                    hypervisorlaunchtype.StartInfo.Arguments = "/set hypervisorlaunchtype off";
                    hypervisorlaunchtype.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    hypervisorlaunchtype.StartInfo.CreateNoWindow = true;
                    hypervisorlaunchtype.Start();
                    hypervisorlaunchtype.WaitForExit();

                    Process tpmbootentropy = new Process();
                    tpmbootentropy.StartInfo.FileName = "bcdedit.exe";
                    tpmbootentropy.StartInfo.Arguments = "/set tpmbootentropy ForceDisable";
                    tpmbootentropy.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    tpmbootentropy.StartInfo.CreateNoWindow = true;
                    tpmbootentropy.Start();
                    tpmbootentropy.WaitForExit();

                    Process quietboot = new Process();
                    quietboot.StartInfo.FileName = "bcdedit.exe";
                    quietboot.StartInfo.Arguments = "/set quietboot Yes";
                    quietboot.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    quietboot.StartInfo.CreateNoWindow = true;
                    quietboot.Start();
                    quietboot.WaitForExit();

                    Process bootux = new Process();
                    bootux.StartInfo.FileName = "bcdedit.exe";
                    bootux.StartInfo.Arguments = "/set bootux disabled";
                    bootux.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    bootux.StartInfo.CreateNoWindow = true;
                    bootux.Start();
                    bootux.WaitForExit();

                    MessageBox.Show("Succesfully applied BCDEdit settings.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ButtonDisableDefender_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("This will disable Windows Defender, Security Center and Firewall. Are you sure you want to continue?", "Security features", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    RegistryKey Settings = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\Auto Tweaking Utility", true);

                    if (Settings.GetValue("SecurityFeaturesDisabled") != null)
                    {
                        if (Settings.GetValue("SecurityFeaturesDisabled").ToString() == "1")
                        {
                            if (MessageBox.Show("Security features are already disabled. Do you want to revert the settings?", "Security features", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                RevertSecurityFeatures();
                                Settings.SetValue("SecurityFeaturesDisabled", "0", RegistryValueKind.String);
                            }
                        }
                        else if (Settings.GetValue("SecurityFeaturesDisabled").ToString() == "0")
                        {
                            DisableSecurityFeatures();
                            Settings.SetValue("SecurityFeaturesDisabled", "1", RegistryValueKind.String);
                            MessageBox.Show("Succesfully disabled Windows Defender, Security Center and Firewall.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        DisableSecurityFeatures();
                        Settings.SetValue("SecurityFeaturesDisabled", "1", RegistryValueKind.String);
                        MessageBox.Show("Succesfully disabled Windows Defender, Security Center and Firewall.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void DisableSecurityFeatures()
        {
            Process wdboot = new Process();
            wdboot.StartInfo.FileName = "NSudoLG.exe";
            wdboot.StartInfo.Arguments = "-U:T sc config wdboot start=disabled";
            wdboot.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            wdboot.StartInfo.CreateNoWindow = true;
            wdboot.Start();
            wdboot.WaitForExit();

            Process wdfilter = new Process();
            wdfilter.StartInfo.FileName = "NSudoLG.exe";
            wdfilter.StartInfo.Arguments = "-U:T sc config wdfilter start=disabled";
            wdfilter.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            wdfilter.StartInfo.CreateNoWindow = true;
            wdfilter.Start();
            wdfilter.WaitForExit();

            Process wdnisdrv = new Process();
            wdnisdrv.StartInfo.FileName = "NSudoLG.exe";
            wdnisdrv.StartInfo.Arguments = "-U:T sc config wdnisdrv start=disabled";
            wdnisdrv.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            wdnisdrv.StartInfo.CreateNoWindow = true;
            wdnisdrv.Start();
            wdnisdrv.WaitForExit();

            Process wdnissvc = new Process();
            wdnissvc.StartInfo.FileName = "NSudoLG.exe";
            wdnissvc.StartInfo.Arguments = "-U:T sc config wdnissvc start=disabled";
            wdnissvc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            wdnissvc.StartInfo.CreateNoWindow = true;
            wdnissvc.Start();
            wdnissvc.WaitForExit();

            Process windefend = new Process();
            windefend.StartInfo.FileName = "NSudoLG.exe";
            windefend.StartInfo.Arguments = "-U:T sc config windefend start=disabled";
            windefend.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            windefend.StartInfo.CreateNoWindow = true;
            windefend.Start();
            windefend.WaitForExit();

            Process wscsvc = new Process();
            wscsvc.StartInfo.FileName = "NSudoLG.exe";
            wscsvc.StartInfo.Arguments = "-U:T sc config wscsvc start=disabled";
            wscsvc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            wscsvc.StartInfo.CreateNoWindow = true;
            wscsvc.Start();
            wscsvc.WaitForExit();

            Process sense = new Process();
            sense.StartInfo.FileName = "NSudoLG.exe";
            sense.StartInfo.Arguments = "-U:T sc config sense start=disabled";
            sense.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            sense.StartInfo.CreateNoWindow = true;
            sense.Start();
            sense.WaitForExit();

            Process securityhealthservice = new Process();
            securityhealthservice.StartInfo.FileName = "NSudoLG.exe";
            securityhealthservice.StartInfo.Arguments = "-U:T sc config securityhealthservice start=disabled";
            securityhealthservice.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            securityhealthservice.StartInfo.CreateNoWindow = true;
            securityhealthservice.Start();
            securityhealthservice.WaitForExit();

            Process mssecflt = new Process();
            mssecflt.StartInfo.FileName = "NSudoLG.exe";
            mssecflt.StartInfo.Arguments = "-U:T sc config mssecflt start=disabled";
            mssecflt.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            mssecflt.StartInfo.CreateNoWindow = true;
            mssecflt.Start();
            mssecflt.WaitForExit();
        }

        private void RevertSecurityFeatures()
        {
            Process wdboot = new Process();
            wdboot.StartInfo.FileName = "NSudoLG.exe";
            wdboot.StartInfo.Arguments = "-U:T sc config wdboot start=boot";
            wdboot.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            wdboot.StartInfo.CreateNoWindow = true;
            wdboot.Start();
            wdboot.WaitForExit();

            Process wdfilter = new Process();
            wdfilter.StartInfo.FileName = "NSudoLG.exe";
            wdfilter.StartInfo.Arguments = "-U:T sc config wdfilter start=boot";
            wdfilter.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            wdfilter.StartInfo.CreateNoWindow = true;
            wdfilter.Start();
            wdfilter.WaitForExit();

            Process wdnisdrv = new Process();
            wdnisdrv.StartInfo.FileName = "NSudoLG.exe";
            wdnisdrv.StartInfo.Arguments = "-U:T sc config wdnisdrv start=demand";
            wdnisdrv.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            wdnisdrv.StartInfo.CreateNoWindow = true;
            wdnisdrv.Start();
            wdnisdrv.WaitForExit();

            Process wdnissvc = new Process();
            wdnissvc.StartInfo.FileName = "NSudoLG.exe";
            wdnissvc.StartInfo.Arguments = "-U:T sc config wdnissvc start=demand";
            wdnissvc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            wdnissvc.StartInfo.CreateNoWindow = true;
            wdnissvc.Start();
            wdnissvc.WaitForExit();

            Process windefend = new Process();
            windefend.StartInfo.FileName = "NSudoLG.exe";
            windefend.StartInfo.Arguments = "-U:T sc config windefend start=auto";
            windefend.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            windefend.StartInfo.CreateNoWindow = true;
            windefend.Start();
            windefend.WaitForExit();

            Process wscsvc = new Process();
            wscsvc.StartInfo.FileName = "NSudoLG.exe";
            wscsvc.StartInfo.Arguments = "-U:T sc config wscsvc start=auto";
            wscsvc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            wscsvc.StartInfo.CreateNoWindow = true;
            wscsvc.Start();
            wscsvc.WaitForExit();

            Process sense = new Process();
            sense.StartInfo.FileName = "NSudoLG.exe";
            sense.StartInfo.Arguments = "-U:T sc config sense start=demand";
            sense.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            sense.StartInfo.CreateNoWindow = true;
            sense.Start();
            sense.WaitForExit();

            Process securityhealthservice = new Process();
            securityhealthservice.StartInfo.FileName = "NSudoLG.exe";
            securityhealthservice.StartInfo.Arguments = "-U:T sc config securityhealthservice start=demand";
            securityhealthservice.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            securityhealthservice.StartInfo.CreateNoWindow = true;
            securityhealthservice.Start();
            securityhealthservice.WaitForExit();

            Process mssecflt = new Process();
            mssecflt.StartInfo.FileName = "NSudoLG.exe";
            mssecflt.StartInfo.Arguments = "-U:T sc config mssecflt start=boot";
            mssecflt.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            mssecflt.StartInfo.CreateNoWindow = true;
            mssecflt.Start();
            mssecflt.WaitForExit();
        }

        private void ButtonDisablePowerThrottling_Click(object sender, EventArgs e)
        {
            try
            {
                RegistryKey PowerThrottling = Registry.LocalMachine.CreateSubKey(@"SYSTEM\CurrentControlSet\Control\Power\PowerThrottling", RegistryKeyPermissionCheck.ReadWriteSubTree);

                if (PowerThrottling.GetValue("PowerThrottlingOff") != null)
                {
                    if (PowerThrottling.GetValue("PowerThrottlingOff").ToString() == "1")
                    {
                        if (MessageBox.Show("Power throttling is already disabled. Do you want to revert the setting?", "Power saving", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            PowerThrottling.SetValue("PowerThrottlingOff", "0", RegistryValueKind.DWord);
                        }
                    }
                    else if (PowerThrottling.GetValue("PowerThrottlingOff").ToString() == "0")
                    {
                        PowerThrottling.SetValue("PowerThrottlingOff", "1", RegistryValueKind.DWord);
                        MessageBox.Show("Succesfully disabled power throttling.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    PowerThrottling.SetValue("PowerThrottlingOff", "0", RegistryValueKind.DWord);
                    MessageBox.Show("Succesfully disabled power throttling.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ButtonDisableFSO_Click(object sender, EventArgs e)
        {
            try
            {
                GameConfigStore = Registry.CurrentUser.CreateSubKey(@"SYSTEM\GameConfigStore", RegistryKeyPermissionCheck.ReadWriteSubTree);
                GameBar = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\Microsoft\GameBar", RegistryKeyPermissionCheck.ReadWriteSubTree);
                children = Registry.CurrentUser.OpenSubKey(@"SYSTEM\GameConfigStore\Children");
                parents = Registry.CurrentUser.OpenSubKey(@"SYSTEM\GameConfigStore\Parents");

                if (GameConfigStore.GetValue("GameDVR_Enabled") != null)
                {
                    if (GameConfigStore.GetValue("GameDVR_Enabled").ToString() == "0")
                    {
                        if (MessageBox.Show("Fullscreen optimizations and gamebar are already disabled. Do you want to revert the settings?", "Fullscreen optimizations and gamebar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            RevertFullscreenOptimizationsAndGameBar();
                        }
                    }
                    else if (GameConfigStore.GetValue("GameDVR_Enabled").ToString() == "1")
                    {
                        DisableFullscreenOptimizationsAndGameBar();
                        MessageBox.Show("Succesfully disabled fullscreen optimizations and gamebar.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    DisableFullscreenOptimizationsAndGameBar();
                    MessageBox.Show("Succesfully disabled fullscreen optimizations and gamebar.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void DisableFullscreenOptimizationsAndGameBar()
        {
            GameConfigStore.SetValue("GameDVR_Enabled", "0", RegistryValueKind.DWord);
            GameConfigStore.SetValue("GameDVR_FSEBehavior", "2", RegistryValueKind.DWord);
            GameConfigStore.SetValue("GameDVR_HonorUserFSEBehaviorMode", "1", RegistryValueKind.DWord);
            GameConfigStore.SetValue("GameDVR_FSEBehaviorMode", "2", RegistryValueKind.DWord);
            GameConfigStore.SetValue("GameDVR_DXGIHonorFSEWindowsCompatible", "1", RegistryValueKind.DWord);

            if (children != null)
            {
                Registry.CurrentUser.DeleteSubKeyTree(@"SYSTEM\GameConfigStore\Children");
            }

            if (parents != null)
            {
                Registry.CurrentUser.DeleteSubKeyTree(@"SYSTEM\GameConfigStore\Parents");
            }

            GameBar.SetValue("AllowAutoGameMode", "0", RegistryValueKind.DWord);
            GameBar.SetValue("AutoGameModeEnabled", "0", RegistryValueKind.DWord);
        }

        private void RevertFullscreenOptimizationsAndGameBar()
        {
            GameConfigStore.SetValue("GameDVR_Enabled", "1", RegistryValueKind.DWord);
            GameConfigStore.SetValue("GameDVR_FSEBehavior", "2", RegistryValueKind.DWord);
            GameConfigStore.SetValue("GameDVR_HonorUserFSEBehaviorMode", "0", RegistryValueKind.DWord);
            GameConfigStore.SetValue("GameDVR_FSEBehaviorMode", "2", RegistryValueKind.DWord);
            GameConfigStore.SetValue("GameDVR_DXGIHonorFSEWindowsCompatible", "0", RegistryValueKind.DWord);
            GameBar.SetValue("AllowAutoGameMode", "1", RegistryValueKind.DWord);
            GameBar.SetValue("AutoGameModeEnabled", "1", RegistryValueKind.DWord);
        }

        private void ButtonApplyVisualFxTweaks_Click(object sender, EventArgs e)
        {
            try
            {
                RegistryKey Desktop = Registry.CurrentUser.CreateSubKey(@"Control Panel\Desktop", true);
                RegistryKey Settings = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\Auto Tweaking Utility", true);
                RegistryKey WindowMetrics = Registry.CurrentUser.CreateSubKey(@"Control Panel\Desktop\WindowMetrics", true);
                RegistryKey VisualEffects = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\VisualEffects", true);

                if (Settings.GetValue("VisualEffectTweaksApplied") != null)
                {
                    if (Settings.GetValue("VisualEffectTweaksApplied").ToString() == "1")
                    {
                        if (MessageBox.Show("Visual effect tweaks are already applied. Do you want to revert them?", "Visual effect tweaks", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            Desktop.SetValue("DragFullWindows", "1", RegistryValueKind.String);
                            Desktop.SetValue("FontSmoothing", "2", RegistryValueKind.String);
                            Desktop.SetValue("MenuShowDelay", "200", RegistryValueKind.String);
                            Desktop.SetValue("UserPreferencesMask", new byte[] { 0x9E, 0x3E, 0x05, 0x80, 0x12, 0x00, 0x00, 0x00 }, RegistryValueKind.Binary);
                            WindowMetrics.SetValue("MinAnimate", "1", RegistryValueKind.String);
                            VisualEffects.SetValue("VisualFXSetting", "0", RegistryValueKind.DWord);
                            Settings.SetValue("VisualEffectTweaksApplied", "0", RegistryValueKind.String);
                        }
                    }
                    else if (Settings.GetValue("VisualEffectTweaksApplied").ToString() == "0")
                    {
                        Desktop.SetValue("DragFullWindows", "0", RegistryValueKind.String);
                        Desktop.SetValue("FontSmoothing", "0", RegistryValueKind.String);
                        Desktop.SetValue("MenuShowDelay", "0", RegistryValueKind.String);
                        Desktop.SetValue("UserPreferencesMask", new byte[] { 0x90, 0x12, 0x03, 0x80, 0x10, 0x00, 0x00, 0x00 }, RegistryValueKind.Binary);
                        WindowMetrics.SetValue("MinAnimate", "0", RegistryValueKind.String);
                        VisualEffects.SetValue("VisualFXSetting", "2", RegistryValueKind.DWord);
                        Settings.SetValue("VisualEffectTweaksApplied", "1", RegistryValueKind.String);
                        MessageBox.Show("Successfully applied visual effect tweaks", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MessageBox.Show("Your changes will not take effect until your computer is restarted.", "Restart", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    Desktop.SetValue("DragFullWindows", "0", RegistryValueKind.String);
                    Desktop.SetValue("FontSmoothing", "0", RegistryValueKind.String);
                    Desktop.SetValue("MenuShowDelay", "0", RegistryValueKind.String);
                    Desktop.SetValue("UserPreferencesMask", new byte[] { 0x90, 0x12, 0x03, 0x80, 0x10, 0x00, 0x00, 0x00 }, RegistryValueKind.Binary);
                    WindowMetrics.SetValue("MinAnimate", "0", RegistryValueKind.String);
                    VisualEffects.SetValue("VisualFXSetting", "2", RegistryValueKind.DWord);
                    Settings.SetValue("VisualEffectTweaksApplied", "1", RegistryValueKind.String);
                    MessageBox.Show("Successfully applied visual effect tweaks", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show("Your changes will not take effect until your computer is restarted.", "Restart", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ButtonDeleteMicrocode_Click(object sender, EventArgs e)
        {
            try
            {
                if (!File.Exists(Path.GetPathRoot(Environment.SystemDirectory) + @"Windows\System32\mcupdate_AuthenticAMD.dll"))
                {
                    MessageBox.Show("Microcode not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Process takeown1 = new Process();
                    takeown1.StartInfo.FileName = "cmd.exe";
                    takeown1.StartInfo.Arguments = "/C TAKEOWN /F " + Path.GetPathRoot(Environment.SystemDirectory) + @"Windows\System32\mcupdate_AuthenticAMD.dll /A & ICACLS " + Path.GetPathRoot(Environment.SystemDirectory) + @"Windows\System32\mcupdate_AuthenticAMD.dll /GRANT Administrators:(F)";
                    takeown1.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    takeown1.StartInfo.CreateNoWindow = true;
                    takeown1.Start();
                    takeown1.WaitForExit();

                    Process takeown2 = new Process();
                    takeown2.StartInfo.FileName = "cmd.exe";
                    takeown2.StartInfo.Arguments = "/C TAKEOWN /F " + Path.GetPathRoot(Environment.SystemDirectory) + @"Windows\System32\mcupdate_GenuineIntel.dll /A & ICACLS " + Path.GetPathRoot(Environment.SystemDirectory) + @"Windows\System32\mcupdate_GenuineIntel.dll /GRANT Administrators:(F)";
                    takeown2.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    takeown2.StartInfo.CreateNoWindow = true;
                    takeown2.Start();
                    takeown2.WaitForExit();

                    Process deletemc1 = new Process();
                    deletemc1.StartInfo.FileName = "cmd.exe";
                    deletemc1.StartInfo.Arguments = @"/C DEL /Q " + Path.GetPathRoot(Environment.SystemDirectory) + @"Windows\System32\mcupdate_AuthenticAMD.dll";
                    deletemc1.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    deletemc1.StartInfo.CreateNoWindow = true;
                    deletemc1.Start();
                    deletemc1.WaitForExit();

                    Process deletemc2 = new Process();
                    deletemc2.StartInfo.FileName = "cmd.exe";
                    deletemc2.StartInfo.Arguments = @"/C DEL /Q " + Path.GetPathRoot(Environment.SystemDirectory) + @"Windows\System32\mcupdate_GenuineIntel.dll";
                    deletemc2.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    deletemc2.StartInfo.CreateNoWindow = true;
                    deletemc2.Start();
                    deletemc2.WaitForExit();

                    MessageBox.Show("Successfully deleted microcode.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void DebloatTimer_Tick(object sender, EventArgs e)
        {
            List<string> x = new List<string>(new string[] {
            "OneDrive",
            "TextInputHost",
            "SkypeApp",
            "SkypeBackgroundHost",
            "Spotify",
            "msedge",
            "PeopleApp",
            "smartscreen",
            "HelpPane",
            "backgroundTaskHost",
            "EaseOfAccessDialog",
            "RuntimeBroker",
            "WSCollect",
            "GameBarPresenceWriter",
            "GamePanel",
            "Magnify",
            "mblctr",
            "sdiagnhost",
            "mobsync",
            "msdt",
            "Narrator",
            "osk",
            "flashPlayerApp"});

            foreach (Process p in Process.GetProcesses())
            {
                if (x.Contains(p.ProcessName.ToUpper()))
                {
                    p.Kill();
                }
            }
        }

        void KillApp()
        {
            this.Close();
            Application.Exit();
        }
    }
}