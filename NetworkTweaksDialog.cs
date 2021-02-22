using System;
using Microsoft.Win32;
using System.Diagnostics;
using System.Net.Sockets;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Text.RegularExpressions;
using System.Runtime.InteropServices;

namespace Auto_Tweaking_Utility
{
    public partial class NetworkTweaksDialog : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public NetworkTweaksDialog()
        {
            InitializeComponent();
        }

        public ComboBox[] ComboBoxes;
        public NumericUpDown[] NumericUpDowns;
        public RegistryKey AdapterKey;
        public RegistryKey QoSKey;
        public Process autotuning;

        public RegistryKey NDIS;
        public RegistryKey AFD;
        public RegistryKey Key;

        private void NetworkTweaksForm_Load(object sender, EventArgs e)
        {
            ComboBoxes = new ComboBox[] {
                ComboBoxGigabitMasterSlaveMode,
                ComboBoxInterruptModeration,
                ComboBoxInterruptModerationRate,
                ComboBoxIPv4ChecksumOffload,
                ComboBoxJumboFrame, ComboBoxJumboPacket,
                ComboBoxLargeSendOffloadv2IPv4,
                ComboBoxLargeSendOffloadv2IPv6,
                ComboBoxMaximumNumberOfRSSQueues,
                ComboBoxPacketPriorityAndVLAN,
                ComboBoxPriorityAndVLAN,
                ComboBoxQoSTimerResolution,
                ComboBoxReceiveSideScaling,
                ComboBoxRSSBaseProcessorNumber,
                ComboBoxSpeedAndDuplex,
                ComboBoxTCPChecksumOffloadIPv4,
                ComboBoxTCPChecksumOffloadIPv6,
                ComboBoxTCPReceiveWindowAutotuning,
                ComboBoxUDPChecksumOffloadIPv4,
                ComboBoxUDPChecksumOffloadIPv6,
                ComboBoxWOLAndShutdownLinkSpeed};

            NumericUpDowns = new NumericUpDown[] {
                NumericUpDownReceiveBuffers, NumericUpDownTransmitBuffers };

            autotuning = new Process();
            autotuning.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            autotuning.StartInfo.UseShellExecute = false;
            autotuning.StartInfo.RedirectStandardOutput = true;
            autotuning.StartInfo.CreateNoWindow = true;
            autotuning.StartInfo.FileName = "netsh.exe";
            autotuning.StartInfo.Arguments = "interface tcp show global";
            autotuning.Start();
            autotuning.WaitForExit();

            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {
                ComboBoxAdapterName.Text = nic.Description;
                break;
            }

            foreach (NetworkInterface connection in NetworkInterface.GetAllNetworkInterfaces())
            {
                ComboBoxConnectionName.Text = connection.Name;
                break;
            }

            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {
                ComboBoxAdapterName.Items.Add(nic.Description);
                ComboBoxAdapterName.Items.Remove("Software Loopback Interface 1");
            }

            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {
                ComboBoxConnectionName.Items.Add(nic.Name);
                ComboBoxConnectionName.Items.Remove("Loopback Pseudo-Interface 1");
            }

            this.ComboBoxAdapterName.TextChanged += new System.EventHandler(this.ComboBoxAdapterName_TextChanged);

            RegistryKey Adapter = Registry.LocalMachine.CreateSubKey(@"SYSTEM\CurrentControlSet\Control\Class\{4d36e972-e325-11ce-bfc1-08002be10318}", true);
            QoSKey = Registry.LocalMachine.CreateSubKey(@"SOFTWARE\Policies\Microsoft\Windows\Psched", true);
            Regex rx = new Regex(@"\d{4}", RegexOptions.Compiled | RegexOptions.IgnoreCase);

            foreach (string x in Adapter.GetSubKeyNames())
            {
                if (!rx.IsMatch(x))
                {
                    continue;
                }

                RegistryKey Key = Adapter.CreateSubKey(x, true);

                if (Convert.ToString(Key.GetValue("DriverDesc")).ToUpper().Contains(ComboBoxAdapterName.Text.ToUpper()))
                {
                    AdapterKey = Adapter.OpenSubKey(x, true);
                }
            }

            ComboBoxAdapterName_TextChanged(sender, e);
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

        private void ComboBoxAdapterName_TextChanged(object sender, EventArgs e)
        {
            if (ComboBoxAdapterName.Text.Contains("Intel"))
            {
                // Gigabit Master Slave Mode
                if (Convert.ToString(AdapterKey.GetValue("MasterSlave")) == "0")
                {
                    ComboBoxGigabitMasterSlaveMode.Text = "Auto Detect";
                }
                else if (Convert.ToString(AdapterKey.GetValue("MasterSlave")) == "1")
                {
                    ComboBoxGigabitMasterSlaveMode.Text = "Force Master Mode";
                }
                else if (Convert.ToString(AdapterKey.GetValue("MasterSlave")) == "2")
                {
                    ComboBoxGigabitMasterSlaveMode.Text = "Force Slave Mode";
                }

                // Interrupt Moderation Rate
                if (Convert.ToString(AdapterKey.GetValue("ITR")) == "0")
                {
                    ComboBoxInterruptModerationRate.Text = "Off";
                }
                else if (Convert.ToString(AdapterKey.GetValue("ITR")) == "200")
                {
                    ComboBoxInterruptModerationRate.Text = "Minimal";
                }
                else if (Convert.ToString(AdapterKey.GetValue("ITR")) == "400")
                {
                    ComboBoxInterruptModerationRate.Text = "Low";
                }
                else if (Convert.ToString(AdapterKey.GetValue("ITR")) == "950")
                {
                    ComboBoxInterruptModerationRate.Text = "Medium";
                }
                else if (Convert.ToString(AdapterKey.GetValue("ITR")) == "2000")
                {
                    ComboBoxInterruptModerationRate.Text = "High";
                }
                else if (Convert.ToString(AdapterKey.GetValue("ITR")) == "3600")
                {
                    ComboBoxInterruptModerationRate.Text = "Extreme";
                }
                else if (Convert.ToString(AdapterKey.GetValue("ITR")) == "65535")
                {
                    ComboBoxInterruptModerationRate.Text = "Adaptive";
                }

                // Jumbo Packet
                if (Convert.ToString(AdapterKey.GetValue("*JumboPacket")) == "4088")
                {
                    ComboBoxJumboPacket.Text = "4088 Bytes";
                }
                else if (Convert.ToString(AdapterKey.GetValue("*JumboPacket")) == "9014")
                {
                    ComboBoxJumboPacket.Text = "9014 Bytes";
                }
                else if (Convert.ToString(AdapterKey.GetValue("*JumboPacket")) == "1514")
                {
                    ComboBoxJumboPacket.Text = "Disabled";
                }

                // Packet Priority & VLAN
                if (Convert.ToString(AdapterKey.GetValue("*PriorityVLANTag")) == "0")
                {
                    ComboBoxPacketPriorityAndVLAN.Text = "Packet Priority & VLAN Disabled";
                }
                else if (Convert.ToString(AdapterKey.GetValue("*PriorityVLANTag")) == "3")
                {
                    ComboBoxPacketPriorityAndVLAN.Text = "Packet Priority & VLAN Enabled";
                }
                else if (Convert.ToString(AdapterKey.GetValue("*PriorityVLANTag")) == "1")
                {
                    ComboBoxPacketPriorityAndVLAN.Text = "Packet Priority Enabled";
                }
                else if (Convert.ToString(AdapterKey.GetValue("*PriorityVLANTag")) == "2")
                {
                    ComboBoxPacketPriorityAndVLAN.Text = "VLAN Enabled";
                }
            }
            else if (ComboBoxAdapterName.Text.Contains("Realtek"))
            {
                // Jumbo Frame
                if (Convert.ToString(AdapterKey.GetValue("*JumboPacket")) == "4088")
                {
                    ComboBoxJumboFrame.Text = "4088 Bytes";
                }
                else if (Convert.ToString(AdapterKey.GetValue("*JumboPacket")) == "9014")
                {
                    ComboBoxJumboFrame.Text = "9014 Bytes";
                }
                else if (Convert.ToString(AdapterKey.GetValue("*JumboPacket")) == "1514")
                {
                    ComboBoxJumboFrame.Text = "Disabled";
                }

                // Priority & VLAN
                if (Convert.ToString(AdapterKey.GetValue("*PriorityVLANTag")) == "0")
                {
                    ComboBoxPriorityAndVLAN.Text = "Priority & VLAN Disabled";
                }
                else if (Convert.ToString(AdapterKey.GetValue("*PriorityVLANTag")) == "3")
                {
                    ComboBoxPriorityAndVLAN.Text = "Priority & VLAN Enabled";
                }
                else if (Convert.ToString(AdapterKey.GetValue("*PriorityVLANTag")) == "1")
                {
                    ComboBoxPriorityAndVLAN.Text = "Priority Enabled";
                }
                else if (Convert.ToString(AdapterKey.GetValue("*PriorityVLANTag")) == "2")
                {
                    ComboBoxPriorityAndVLAN.Text = "VLAN Enabled";
                }

                // WOL & Shutdown Link Speed
                if (Convert.ToString(AdapterKey.GetValue("WolShutdownLinkSpeed")) == "0")
                {
                    ComboBoxWOLAndShutdownLinkSpeed.Text = "10 Mbps First";
                }
                else if (Convert.ToString(AdapterKey.GetValue("WolShutdownLinkSpeed")) == "1")
                {
                    ComboBoxWOLAndShutdownLinkSpeed.Text = "100 Mbps First";
                }
                else if (Convert.ToString(AdapterKey.GetValue("WolShutdownLinkSpeed")) == "2")
                {
                    ComboBoxWOLAndShutdownLinkSpeed.Text = "Not Speed Down";
                }
            }

            // Interrupt Moderation
            if (Convert.ToString(AdapterKey.GetValue("*InterruptModeration")) == "0")
            {
                ComboBoxInterruptModeration.Text = "Disabled";
            }
            else if (Convert.ToString(AdapterKey.GetValue("*InterruptModeration")) == "1")
            {
                ComboBoxInterruptModeration.Text = "Enabled";
            }

            // IPv4 Checksum Offload
            if (Convert.ToString(AdapterKey.GetValue("*IPChecksumOffloadIPv4")) == "0")
            {
                ComboBoxIPv4ChecksumOffload.Text = "Disabled";
            }
            else if (Convert.ToString(AdapterKey.GetValue("*IPChecksumOffloadIPv4")) == "3")
            {
                ComboBoxIPv4ChecksumOffload.Text = "Rx & Tx Enabled";
            }
            else if (Convert.ToString(AdapterKey.GetValue("*IPChecksumOffloadIPv4")) == "2")
            {
                ComboBoxIPv4ChecksumOffload.Text = "Rx Enabled";
            }
            else if (Convert.ToString(AdapterKey.GetValue("*IPChecksumOffloadIPv4")) == "1")
            {
                ComboBoxIPv4ChecksumOffload.Text = "Tx Enabled";
            }

            // Large Send Offload v2 (IPv4)
            if (Convert.ToString(AdapterKey.GetValue("*LsoV2IPv4")) == "0")
            {
                ComboBoxLargeSendOffloadv2IPv4.Text = "Disabled";
            }
            else if (Convert.ToString(AdapterKey.GetValue("*LsoV2IPv4")) == "1")
            {
                ComboBoxLargeSendOffloadv2IPv4.Text = "Enabled";
            }

            // Large Send Offload v2 (IPv6)
            if (Convert.ToString(AdapterKey.GetValue("*LsoV2IPv6")) == "0")
            {
                ComboBoxLargeSendOffloadv2IPv6.Text = "Disabled";
            }
            else if (Convert.ToString(AdapterKey.GetValue("*LsoV2IPv6")) == "1")
            {
                ComboBoxLargeSendOffloadv2IPv6.Text = "Enabled";
            }

            // Maximum Number of RSS Queues 1
            if (AdapterKey.GetValue("*NumRssQueues") != null)
            {
                if (Convert.ToString(AdapterKey.GetValue("*NumRssQueues")) == "1")
                {
                    ComboBoxMaximumNumberOfRSSQueues.Text = "1 Queue";
                }
                else if (Convert.ToString(AdapterKey.GetValue("*NumRssQueues")) == "2")
                {
                    ComboBoxMaximumNumberOfRSSQueues.Text = "2 Queues";
                }
                else if (Convert.ToString(AdapterKey.GetValue("*NumRssQueues")) == "3")
                {
                    ComboBoxMaximumNumberOfRSSQueues.Text = "3 Queues";
                }
                else if (Convert.ToString(AdapterKey.GetValue("*NumRssQueues")) == "4")
                {
                    ComboBoxMaximumNumberOfRSSQueues.Text = "4 Queues";
                }
                else if (Convert.ToString(AdapterKey.GetValue("*NumRssQueues")) == "5")
                {
                    ComboBoxMaximumNumberOfRSSQueues.Text = "5 Queues";
                }
                else if (Convert.ToString(AdapterKey.GetValue("*NumRssQueues")) == "6")
                {
                    ComboBoxMaximumNumberOfRSSQueues.Text = "6 Queues";
                }
                else if (Convert.ToString(AdapterKey.GetValue("*NumRssQueues")) == "7")
                {
                    ComboBoxMaximumNumberOfRSSQueues.Text = "7 Queues";
                }
                else if (Convert.ToString(AdapterKey.GetValue("*NumRssQueues")) == "8")
                {
                    ComboBoxMaximumNumberOfRSSQueues.Text = "8 Queues";
                }
                else
                {
                    ComboBoxMaximumNumberOfRSSQueues.Text = "2 Queues";
                }
            }

            // Maximum Number of RSS Queues 2
            if (AdapterKey.GetValue("*MaxRssProcessors") != null)
            {
                if (Convert.ToString(AdapterKey.GetValue("*MaxRssProcessors")) == "1")
                {
                    ComboBoxMaximumNumberOfRSSQueues.Text = "1 Queue";
                }
                else if (Convert.ToString(AdapterKey.GetValue("*MaxRssProcessors")) == "2")
                {
                    ComboBoxMaximumNumberOfRSSQueues.Text = "2 Queues";
                }
                else if (Convert.ToString(AdapterKey.GetValue("*MaxRssProcessors")) == "3")
                {
                    ComboBoxMaximumNumberOfRSSQueues.Text = "3 Queues";
                }
                else if (Convert.ToString(AdapterKey.GetValue("*MaxRssProcessors")) == "4")
                {
                    ComboBoxMaximumNumberOfRSSQueues.Text = "4 Queues";
                }
                else if (Convert.ToString(AdapterKey.GetValue("*MaxRssProcessors")) == "5")
                {
                    ComboBoxMaximumNumberOfRSSQueues.Text = "5 Queues";
                }
                else if (Convert.ToString(AdapterKey.GetValue("*MaxRssProcessors")) == "6")
                {
                    ComboBoxMaximumNumberOfRSSQueues.Text = "6 Queues";
                }
                else if (Convert.ToString(AdapterKey.GetValue("*MaxRssProcessors")) == "7")
                {
                    ComboBoxMaximumNumberOfRSSQueues.Text = "7 Queues";
                }
                else if (Convert.ToString(AdapterKey.GetValue("*MaxRssProcessors")) == "8")
                {
                    ComboBoxMaximumNumberOfRSSQueues.Text = "8 Queues";
                }
                else
                {
                    ComboBoxMaximumNumberOfRSSQueues.Text = "2 Queues";
                }
            }
            else
            {
                if (ComboBoxAdapterName.Text.Contains("Intel"))
                {
                    ComboBoxMaximumNumberOfRSSQueues.Text = "2 Queues";
                }
                else if (ComboBoxAdapterName.Text.Contains("Realtek"))
                {
                    ComboBoxMaximumNumberOfRSSQueues.Text = "4 Queues";
                }
            }

            // QoS Timer Resolution
            if (Convert.ToString(QoSKey.GetValue("TimerResolution")) == "1")
            {
                ComboBoxQoSTimerResolution.Text = "1ms";
            }
            else if (Convert.ToString(QoSKey.GetValue("TimerResolution")) == "2")
            {
                ComboBoxQoSTimerResolution.Text = "2ms";
            }
            else if (Convert.ToString(QoSKey.GetValue("TimerResolution")) == "3")
            {
                ComboBoxQoSTimerResolution.Text = "3ms";
            }
            else if (Convert.ToString(QoSKey.GetValue("TimerResolution")) == "4")
            {
                ComboBoxQoSTimerResolution.Text = "4ms";
            }
            else if (Convert.ToString(QoSKey.GetValue("TimerResolution")) == "5")
            {
                ComboBoxQoSTimerResolution.Text = "5ms";
            }
            else if (Convert.ToString(QoSKey.GetValue("TimerResolution")) == "6")
            {
                ComboBoxQoSTimerResolution.Text = "6ms";
            }
            else if (Convert.ToString(QoSKey.GetValue("TimerResolution")) == "7")
            {
                ComboBoxQoSTimerResolution.Text = "7ms";
            }
            else if (Convert.ToString(QoSKey.GetValue("TimerResolution")) == "8")
            {
                ComboBoxQoSTimerResolution.Text = "8ms";
            }
            else if (Convert.ToString(QoSKey.GetValue("TimerResolution")) == "9")
            {
                ComboBoxQoSTimerResolution.Text = "9ms";
            }
            else if (Convert.ToString(QoSKey.GetValue("TimerResolution")) == "10")
            {
                ComboBoxQoSTimerResolution.Text = "10ms";
            }
            else if (Convert.ToString(QoSKey.GetValue("TimerResolution")) == "11")
            {
                ComboBoxQoSTimerResolution.Text = "11ms";
            }
            else if (Convert.ToString(QoSKey.GetValue("TimerResolution")) == "12")
            {
                ComboBoxQoSTimerResolution.Text = "12ms";
            }
            else if (Convert.ToString(QoSKey.GetValue("TimerResolution")) == "13")
            {
                ComboBoxQoSTimerResolution.Text = "13ms";
            }
            else if (Convert.ToString(QoSKey.GetValue("TimerResolution")) == "14")
            {
                ComboBoxQoSTimerResolution.Text = "14ms";
            }
            else if (Convert.ToString(QoSKey.GetValue("TimerResolution")) == "15")
            {
                ComboBoxQoSTimerResolution.Text = "15ms";
            }
            else if (Convert.ToString(QoSKey.GetValue("TimerResolution")) == "16")
            {
                ComboBoxQoSTimerResolution.Text = "16ms";
            }
            else if (Convert.ToString(QoSKey.GetValue("TimerResolution")) == "17")
            {
                ComboBoxQoSTimerResolution.Text = "17ms";
            }
            else if (Convert.ToString(QoSKey.GetValue("TimerResolution")) == "18")
            {
                ComboBoxQoSTimerResolution.Text = "18ms";
            }
            else if (Convert.ToString(QoSKey.GetValue("TimerResolution")) == "19")
            {
                ComboBoxQoSTimerResolution.Text = "19ms";
            }
            else if (Convert.ToString(QoSKey.GetValue("TimerResolution")) == "20")
            {
                ComboBoxQoSTimerResolution.Text = "20ms (default)";
            }
            else
            {
                ComboBoxQoSTimerResolution.Text = "20ms (default)";
            }

            // Receive Buffers
            {
                NumericUpDownReceiveBuffers.Text = AdapterKey.GetValue("*ReceiveBuffers").ToString();
            }

            // Receive Side Scaling
            if (Convert.ToString(AdapterKey.GetValue("*RSS")) == "0")
            {
                ComboBoxReceiveSideScaling.Text = "Disabled";
            }
            else if (Convert.ToString(AdapterKey.GetValue("*RSS")) == "1")
            {
                ComboBoxReceiveSideScaling.Text = "Enabled";
            }

            // RSS Base Processor Number
            if (AdapterKey.GetValue("*RssBaseProcNumber") != null)
            {
                if (Convert.ToString(AdapterKey.GetValue("*RssBaseProcNumber")) == "0")
                {
                    ComboBoxRSSBaseProcessorNumber.Text = "CPU 0";
                }
                else if (Convert.ToString(AdapterKey.GetValue("*RssBaseProcNumber")) == "1")
                {
                    ComboBoxRSSBaseProcessorNumber.Text = "CPU 1";
                }
                else if (Convert.ToString(AdapterKey.GetValue("*RssBaseProcNumber")) == "2")
                {
                    ComboBoxRSSBaseProcessorNumber.Text = "CPU 2";
                }
                else if (Convert.ToString(AdapterKey.GetValue("*RssBaseProcNumber")) == "3")
                {
                    ComboBoxRSSBaseProcessorNumber.Text = "CPU 3";
                }
                else if (Convert.ToString(AdapterKey.GetValue("*RssBaseProcNumber")) == "4")
                {
                    ComboBoxRSSBaseProcessorNumber.Text = "CPU 4";
                }
                else if (Convert.ToString(AdapterKey.GetValue("*RssBaseProcNumber")) == "5")
                {
                    ComboBoxRSSBaseProcessorNumber.Text = "CPU 5";
                }
                else if (Convert.ToString(AdapterKey.GetValue("*RssBaseProcNumber")) == "6")
                {
                    ComboBoxRSSBaseProcessorNumber.Text = "CPU 6";
                }
                else if (Convert.ToString(AdapterKey.GetValue("*RssBaseProcNumber")) == "7")
                {
                    ComboBoxRSSBaseProcessorNumber.Text = "CPU 7";
                }
                else
                {
                    ComboBoxRSSBaseProcessorNumber.Text = "CPU 0";
                }
            }
            else
            {
                ComboBoxRSSBaseProcessorNumber.Text = "CPU 0";
            }

            // Speed & Duplex
            if (Convert.ToString(AdapterKey.GetValue("*SpeedDuplex")) == "6")
            {
                ComboBoxSpeedAndDuplex.Text = "1.0 Gbps Full Duplex";
            }
            else if (Convert.ToString(AdapterKey.GetValue("*SpeedDuplex")) == "2")
            {
                ComboBoxSpeedAndDuplex.Text = "10 Mbps Full Duplex";
            }
            else if (Convert.ToString(AdapterKey.GetValue("*SpeedDuplex")) == "1")
            {
                ComboBoxSpeedAndDuplex.Text = "10 Mbps Half Duplex";
            }
            else if (Convert.ToString(AdapterKey.GetValue("*SpeedDuplex")) == "4")
            {
                ComboBoxSpeedAndDuplex.Text = "100 Mbps Full Duplex";
            }
            else if (Convert.ToString(AdapterKey.GetValue("*SpeedDuplex")) == "3")
            {
                ComboBoxSpeedAndDuplex.Text = "100 Mbps Half Duplex";
            }
            else if (Convert.ToString(AdapterKey.GetValue("*SpeedDuplex")) == "0")
            {
                ComboBoxSpeedAndDuplex.Text = "Auto Negotiation";
            }

            // TCP Checksum Offload (IPv4)
            if (Convert.ToString(AdapterKey.GetValue("*TCPChecksumOffloadIPv4")) == "0")
            {
                ComboBoxTCPChecksumOffloadIPv4.Text = "Disabled";
            }
            else if (Convert.ToString(AdapterKey.GetValue("*TCPChecksumOffloadIPv4")) == "3")
            {
                ComboBoxTCPChecksumOffloadIPv4.Text = "Rx & Tx Enabled";
            }
            else if (Convert.ToString(AdapterKey.GetValue("*TCPChecksumOffloadIPv4")) == "2")
            {
                ComboBoxTCPChecksumOffloadIPv4.Text = "Rx Enabled";
            }
            else if (Convert.ToString(AdapterKey.GetValue("*TCPChecksumOffloadIPv4")) == "1")
            {
                ComboBoxTCPChecksumOffloadIPv4.Text = "Tx Enabled";
            }

            // TCP Checksum Offload (IPv6)
            if (Convert.ToString(AdapterKey.GetValue("*TCPChecksumOffloadIPv6")) == "0")
            {
                ComboBoxTCPChecksumOffloadIPv6.Text = "Disabled";
            }
            else if (Convert.ToString(AdapterKey.GetValue("*TCPChecksumOffloadIPv6")) == "3")
            {
                ComboBoxTCPChecksumOffloadIPv6.Text = "Rx & Tx Enabled";
            }
            else if (Convert.ToString(AdapterKey.GetValue("*TCPChecksumOffloadIPv6")) == "2")
            {
                ComboBoxTCPChecksumOffloadIPv6.Text = "Rx Enabled";
            }
            else if (Convert.ToString(AdapterKey.GetValue("*TCPChecksumOffloadIPv6")) == "1")
            {
                ComboBoxTCPChecksumOffloadIPv6.Text = "Tx Enabled";
            }

            // TCP Receive Window Autotuning
            if (autotuning.StandardOutput.ReadToEnd().Contains("Receive Window Auto-Tuning Level    : disabled"))
            {
                ComboBoxTCPReceiveWindowAutotuning.Text = "Disabled";
            }
            else if (autotuning.StandardOutput.ReadToEnd().Contains("Receive Window Auto-Tuning Level    : normal"))
            {
                ComboBoxTCPReceiveWindowAutotuning.Text = "Normal";
            }
            else if (autotuning.StandardOutput.ReadToEnd().Contains("Receive Window Auto-Tuning Level    : restricted"))
            {
                ComboBoxTCPReceiveWindowAutotuning.Text = "Restricted";
            }
            else if (autotuning.StandardOutput.ReadToEnd().Contains("Receive Window Auto-Tuning Level    : experimental"))
            {
                ComboBoxTCPReceiveWindowAutotuning.Text = "Experimental";
            }

            // Transmit Buffers
            {
                NumericUpDownTransmitBuffers.Text = AdapterKey.GetValue("*TransmitBuffers").ToString();
            }

            // UDP Checksum Offload (IPv4)
            if (Convert.ToString(AdapterKey.GetValue("*UDPChecksumOffloadIPv4")) == "0")
            {
                ComboBoxUDPChecksumOffloadIPv4.Text = "Disabled";
            }
            else if (Convert.ToString(AdapterKey.GetValue("*UDPChecksumOffloadIPv4")) == "3")
            {
                ComboBoxUDPChecksumOffloadIPv4.Text = "Rx & Tx Enabled";
            }
            else if (Convert.ToString(AdapterKey.GetValue("*UDPChecksumOffloadIPv4")) == "2")
            {
                ComboBoxUDPChecksumOffloadIPv4.Text = "Rx Enabled";
            }
            else if (Convert.ToString(AdapterKey.GetValue("*UDPChecksumOffloadIPv4")) == "1")
            {
                ComboBoxUDPChecksumOffloadIPv4.Text = "Tx Enabled";
            }

            // UDP Checksum Offload (IPv6)
            if (Convert.ToString(AdapterKey.GetValue("*UDPChecksumOffloadIPv6")) == "0")
            {
                ComboBoxUDPChecksumOffloadIPv6.Text = "Disabled";
            }
            else if (Convert.ToString(AdapterKey.GetValue("*UDPChecksumOffloadIPv6")) == "3")
            {
                ComboBoxUDPChecksumOffloadIPv6.Text = "Rx & Tx Enabled";
            }
            else if (Convert.ToString(AdapterKey.GetValue("*UDPChecksumOffloadIPv6")) == "2")
            {
                ComboBoxUDPChecksumOffloadIPv6.Text = "Rx Enabled";
            }
            else if (Convert.ToString(AdapterKey.GetValue("*UDPChecksumOffloadIPv6")) == "1")
            {
                ComboBoxUDPChecksumOffloadIPv6.Text = "Tx Enabled";
            }

            if (ComboBoxAdapterName.Text.Contains("Intel"))
            {
                ListBoxSettings.Items.Clear();
                ListBoxSettings.Items.Add("Gigabit Master Slave Mode");
                ListBoxSettings.Items.Add("Interrupt Moderation Rate");
                ListBoxSettings.Items.Add("Jumbo Packet");
                ListBoxSettings.Items.Add("Packet Priority & VLAN");

            }
            else if (ComboBoxAdapterName.Text.Contains("Realtek"))
            {
                ListBoxSettings.Items.Clear();
                ListBoxSettings.Items.Add("Jumbo Frame");
                ListBoxSettings.Items.Add("Priority & VLAN");
                ListBoxSettings.Items.Add("WOL & Shutdown Link Speed");
            }

            ListBoxSettings.Items.Add("Interrupt Moderation");
            ListBoxSettings.Items.Add("IPv4 Checksum Offload");
            ListBoxSettings.Items.Add("Large Send Offload V2 (IPv4)");
            ListBoxSettings.Items.Add("Large Send Offload V2 (IPv6)");
            ListBoxSettings.Items.Add("Maximum Number of RSS Queues");
            ListBoxSettings.Items.Add("QoS Timer Resolution");
            ListBoxSettings.Items.Add("Receive Buffers");
            ListBoxSettings.Items.Add("Receive Side Scaling");
            ListBoxSettings.Items.Add("RSS Base Processor Number");
            ListBoxSettings.Items.Add("Speed & Duplex");
            ListBoxSettings.Items.Add("TCP Checksum Offload (IPv4)");
            ListBoxSettings.Items.Add("TCP Checksum Offload (IPv6)");
            ListBoxSettings.Items.Add("TCP Receive Window Autotuning");
            ListBoxSettings.Items.Add("Transmit Buffers");
            ListBoxSettings.Items.Add("UDP Checksum Offload (IPv4)");
            ListBoxSettings.Items.Add("UDP Checksum Offload (IPv6)");
            ListBoxSettings.SelectedIndex = 0;
        }

        private void ListBoxSettings_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToString(ListBoxSettings.SelectedItem) == "Gigabit Master Slave Mode")
            {
                foreach (var x in ComboBoxes) { x.Visible = false; }
                foreach (var x in NumericUpDowns) { x.Visible = false; }
                ComboBoxGigabitMasterSlaveMode.Visible = true;
                ComboBoxOutline.Visible = true;
            }
            else if (Convert.ToString(ListBoxSettings.SelectedItem) == "Interrupt Moderation")
            {
                foreach (var x in ComboBoxes) { x.Visible = false; }
                foreach (var x in NumericUpDowns) { x.Visible = false; }
                ComboBoxInterruptModeration.Visible = true;
                ComboBoxOutline.Visible = true;
            }
            else if (Convert.ToString(ListBoxSettings.SelectedItem) == "Interrupt Moderation Rate")
            {
                foreach (var x in ComboBoxes) { x.Visible = false; }
                foreach (var x in NumericUpDowns) { x.Visible = false; }
                ComboBoxInterruptModerationRate.Visible = true;
                ComboBoxOutline.Visible = true;
            }
            else if (Convert.ToString(ListBoxSettings.SelectedItem) == "IPv4 Checksum Offload")
            {
                foreach (var x in ComboBoxes) { x.Visible = false; }
                foreach (var x in NumericUpDowns) { x.Visible = false; }
                ComboBoxIPv4ChecksumOffload.Visible = true;
                ComboBoxOutline.Visible = true;
            }
            else if (Convert.ToString(ListBoxSettings.SelectedItem) == "Jumbo Frame")
            {
                foreach (var x in ComboBoxes) { x.Visible = false; }
                foreach (var x in NumericUpDowns) { x.Visible = false; }
                ComboBoxJumboFrame.Visible = true;
                ComboBoxOutline.Visible = true;
            }
            else if (Convert.ToString(ListBoxSettings.SelectedItem) == "Jumbo Packet")
            {
                foreach (var x in ComboBoxes) { x.Visible = false; }
                foreach (var x in NumericUpDowns) { x.Visible = false; }
                ComboBoxJumboFrame.Visible = true;
                ComboBoxOutline.Visible = true;
            }
            else if (Convert.ToString(ListBoxSettings.SelectedItem) == "Large Send Offload v2 (IPv4)")
            {
                foreach (var x in ComboBoxes) { x.Visible = false; }
                foreach (var x in NumericUpDowns) { x.Visible = false; }
                ComboBoxLargeSendOffloadv2IPv4.Visible = true;
                ComboBoxOutline.Visible = true;
            }
            else if (Convert.ToString(ListBoxSettings.SelectedItem) == "Large Send Offload v2 (IPv6)")
            {
                foreach (var x in ComboBoxes) { x.Visible = false; }
                foreach (var x in NumericUpDowns) { x.Visible = false; }
                ComboBoxLargeSendOffloadv2IPv6.Visible = true;
                ComboBoxOutline.Visible = true;
            }
            else if (Convert.ToString(ListBoxSettings.SelectedItem) == "Maximum Number of RSS Queues")
            {
                foreach (var x in ComboBoxes) { x.Visible = false; }
                foreach (var x in NumericUpDowns) { x.Visible = false; }
                ComboBoxMaximumNumberOfRSSQueues.Visible = true;
                ComboBoxOutline.Visible = true;
            }
            else if (Convert.ToString(ListBoxSettings.SelectedItem) == "Packet Priority & VLAN")
            {
                foreach (var x in ComboBoxes) { x.Visible = false; }
                foreach (var x in NumericUpDowns) { x.Visible = false; }
                ComboBoxPacketPriorityAndVLAN.Visible = true;
                ComboBoxOutline.Visible = true;
            }
            else if (Convert.ToString(ListBoxSettings.SelectedItem) == "Priority & VLAN")
            {
                foreach (var x in ComboBoxes) { x.Visible = false; }
                foreach (var x in NumericUpDowns) { x.Visible = false; }
                ComboBoxPriorityAndVLAN.Visible = true;
                ComboBoxOutline.Visible = true;
            }
            else if (Convert.ToString(ListBoxSettings.SelectedItem) == "QoS Timer Resolution")
            {
                foreach (var x in ComboBoxes) { x.Visible = false; }
                foreach (var x in NumericUpDowns) { x.Visible = false; }
                ComboBoxQoSTimerResolution.Visible = true;
                ComboBoxOutline.Visible = true;
            }
            else if (Convert.ToString(ListBoxSettings.SelectedItem) == "Receive Buffers")
            {
                foreach (var x in ComboBoxes) { x.Visible = false; }
                foreach (var x in NumericUpDowns) { x.Visible = false; }
                NumericUpDownReceiveBuffers.Visible = true;
                ComboBoxOutline.Visible = false;
            }
            else if (Convert.ToString(ListBoxSettings.SelectedItem) == "Receive Side Scaling")
            {
                foreach (var x in ComboBoxes) { x.Visible = false; }
                foreach (var x in NumericUpDowns) { x.Visible = false; }
                ComboBoxReceiveSideScaling.Visible = true;
                ComboBoxOutline.Visible = true;
            }
            else if (Convert.ToString(ListBoxSettings.SelectedItem) == "RSS Base Processor Number")
            {
                foreach (var x in ComboBoxes) { x.Visible = false; }
                foreach (var x in NumericUpDowns) { x.Visible = false; }
                ComboBoxRSSBaseProcessorNumber.Visible = true;
                ComboBoxOutline.Visible = true;
            }
            else if (Convert.ToString(ListBoxSettings.SelectedItem) == "Speed & Duplex")
            {
                foreach (var x in ComboBoxes) { x.Visible = false; }
                foreach (var x in NumericUpDowns) { x.Visible = false; }
                ComboBoxSpeedAndDuplex.Visible = true;
                ComboBoxOutline.Visible = true;
            }
            else if (Convert.ToString(ListBoxSettings.SelectedItem) == "TCP Checksum Offload (IPv4)")
            {
                foreach (var x in ComboBoxes) { x.Visible = false; }
                foreach (var x in NumericUpDowns) { x.Visible = false; }
                ComboBoxTCPChecksumOffloadIPv4.Visible = true;
                ComboBoxOutline.Visible = true;
            }
            else if (Convert.ToString(ListBoxSettings.SelectedItem) == "TCP Checksum Offload (IPv6)")
            {
                foreach (var x in ComboBoxes) { x.Visible = false; }
                foreach (var x in NumericUpDowns) { x.Visible = false; }
                ComboBoxTCPChecksumOffloadIPv6.Visible = true;
                ComboBoxOutline.Visible = true;
            }
            else if (Convert.ToString(ListBoxSettings.SelectedItem) == "TCP Receive Window Autotuning")
            {
                foreach (var x in ComboBoxes) { x.Visible = false; }
                foreach (var x in NumericUpDowns) { x.Visible = false; }
                ComboBoxTCPReceiveWindowAutotuning.Visible = true;
                ComboBoxOutline.Visible = true;
            }
            else if (Convert.ToString(ListBoxSettings.SelectedItem) == "Transmit Buffers")
            {
                foreach (var x in ComboBoxes) { x.Visible = false; }
                foreach (var x in NumericUpDowns) { x.Visible = false; }
                NumericUpDownTransmitBuffers.Visible = true;
                ComboBoxOutline.Visible = false;
            }
            else if (Convert.ToString(ListBoxSettings.SelectedItem) == "UDP Checksum Offload (IPv4)")
            {
                foreach (var x in ComboBoxes) { x.Visible = false; }
                foreach (var x in NumericUpDowns) { x.Visible = false; }
                ComboBoxUDPChecksumOffloadIPv4.Visible = true;
                ComboBoxOutline.Visible = true;
            }
            else if (Convert.ToString(ListBoxSettings.SelectedItem) == "UDP Checksum Offload (IPv6)")
            {
                foreach (var x in ComboBoxes) { x.Visible = false; }
                foreach (var x in NumericUpDowns) { x.Visible = false; }
                ComboBoxUDPChecksumOffloadIPv6.Visible = true;
                ComboBoxOutline.Visible = true;
            }
            else if (Convert.ToString(ListBoxSettings.SelectedItem) == "WOL & Shutdown Link Speed")
            {
                foreach (var x in ComboBoxes) { x.Visible = false; }
                foreach (var x in NumericUpDowns) { x.Visible = false; }
                ComboBoxWOLAndShutdownLinkSpeed.Visible = true;
                ComboBoxOutline.Visible = true;
            }
        }

        private void ButtonLoadRecommendedSettings_Click(object sender, EventArgs e)
        {
            ComboBoxGigabitMasterSlaveMode.Text = "Disabled";
            ComboBoxInterruptModeration.Text = "Enabled";
            ComboBoxInterruptModerationRate.Text = "Adaptive";
            ComboBoxIPv4ChecksumOffload.Text = "Rx & Tx Enabled";
            ComboBoxJumboFrame.Text = "Disabled";
            ComboBoxJumboPacket.Text = "Disabled";
            ComboBoxLargeSendOffloadv2IPv4.Text = "Disabled";
            ComboBoxLargeSendOffloadv2IPv6.Text = "Disabled";
            ComboBoxMaximumNumberOfRSSQueues.Text = "2 Queues";
            ComboBoxPacketPriorityAndVLAN.Text = "Packet Priority & VLAN Disabled";
            ComboBoxPriorityAndVLAN.Text = "Priority & VLAN Disabled";
            ComboBoxQoSTimerResolution.Text = "1ms";
            NumericUpDownReceiveBuffers.Text = "256";
            ComboBoxReceiveSideScaling.Text = "Enabled";
            ComboBoxRSSBaseProcessorNumber.Text = "CPU 1";
            ComboBoxSpeedAndDuplex.Text = "Auto Negotiation";
            ComboBoxTCPChecksumOffloadIPv4.Text = "Disabled";
            ComboBoxTCPChecksumOffloadIPv6.Text = "Disabled";
            ComboBoxTCPReceiveWindowAutotuning.Text = "Disabled";
            NumericUpDownTransmitBuffers.Text = "256";
            ComboBoxUDPChecksumOffloadIPv4.Text = "Rx & Tx Enabled";
            ComboBoxUDPChecksumOffloadIPv6.Text = "Rx & Tx Enabled";
            ComboBoxWOLAndShutdownLinkSpeed.Text = "Not Speed Down";
        }

        private void ButtonRevertSettings_Click(object sender, EventArgs e)
        {
            ComboBoxGigabitMasterSlaveMode.Text = "Enabled";
            ComboBoxInterruptModeration.Text = "Enabled";
            ComboBoxInterruptModerationRate.Text = "Adaptive";
            ComboBoxIPv4ChecksumOffload.Text = "Rx & Tx Enabled";
            ComboBoxJumboFrame.Text = "Disabled";
            ComboBoxJumboPacket.Text = "Disabled";
            ComboBoxLargeSendOffloadv2IPv4.Text = "Enabled";
            ComboBoxLargeSendOffloadv2IPv6.Text = "Enabled";
            ComboBoxPacketPriorityAndVLAN.Text = "Packet Priority & VLAN Enabled";
            ComboBoxPriorityAndVLAN.Text = "Priority & VLAN Enabled";
            ComboBoxQoSTimerResolution.Text = "20ms (default)";
            ComboBoxReceiveSideScaling.Text = "Enabled";
            ComboBoxRSSBaseProcessorNumber.Text = "CPU 0";
            ComboBoxSpeedAndDuplex.Text = "Auto Negotiation";
            ComboBoxTCPChecksumOffloadIPv4.Text = "Rx & Tx Enabled";
            ComboBoxTCPChecksumOffloadIPv6.Text = "Rx & Tx Enabled";
            ComboBoxTCPReceiveWindowAutotuning.Text = "Normal";
            ComboBoxUDPChecksumOffloadIPv4.Text = "Rx & Tx Enabled";
            ComboBoxUDPChecksumOffloadIPv6.Text = "Rx & Tx Enabled";
            ComboBoxWOLAndShutdownLinkSpeed.Text = "10 Mbps First";

            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (nic.Description.Contains("Intel(R) Ethernet"))
                {
                    ComboBoxMaximumNumberOfRSSQueues.Text = "2 Queues";
                    NumericUpDownReceiveBuffers.Text = "256";
                    NumericUpDownTransmitBuffers.Text = "512";
                    break;
                }
                else if (nic.Description.Contains("Realtek PCIe"))
                {
                    ComboBoxMaximumNumberOfRSSQueues.Text = "4 Queues";
                    NumericUpDownReceiveBuffers.Text = "512";
                    NumericUpDownTransmitBuffers.Text = "128";
                    break;
                }
            }
        }

        private void ButtonDisableAllPowerSaving_Click(object sender, EventArgs e)
        {
            if (ComboBoxAdapterName.Text == "")
            {
                MessageBox.Show("Please select a network adapter");
            }
            else
            {
                try
                {
                    if (ComboBoxAdapterName.Text.Contains("Intel"))
                    {
                        AdapterKey.SetValue("AdaptiveIFS", "0", RegistryValueKind.String);
                        AdapterKey.SetValue("EnablePME", "0", RegistryValueKind.String);
                        AdapterKey.SetValue("EEELinkAdvertisement", "0", RegistryValueKind.String);
                        AdapterKey.SetValue("LinkNegotiationProcess", "1", RegistryValueKind.String);
                        AdapterKey.SetValue("LogLinkStateEvent", "16", RegistryValueKind.String);
                        AdapterKey.SetValue("ReduceSpeedOnPowerDown", "0", RegistryValueKind.String);
                        AdapterKey.SetValue("SipsEnabled", "0", RegistryValueKind.String);
                        AdapterKey.SetValue("ULPMode", "0", RegistryValueKind.String);
                        AdapterKey.SetValue("WaitAutoNegComplete", "0", RegistryValueKind.String);
                        AdapterKey.SetValue("WakeOnLink", "0", RegistryValueKind.String);
                    }
                    else if (ComboBoxAdapterName.Text.Contains("Realtek"))
                    {
                        AdapterKey.SetValue("AdvancedEEE", "0", RegistryValueKind.String);
                        AdapterKey.SetValue("*EEE", "0", RegistryValueKind.String);
                        AdapterKey.SetValue("GigaLite", "0", RegistryValueKind.String);
                        AdapterKey.SetValue("EnableGreenEthernet", "0", RegistryValueKind.String);
                        AdapterKey.SetValue("PowerSavingMode", "0", RegistryValueKind.String);
                        AdapterKey.SetValue("S5WakeOnLan", "0", RegistryValueKind.String);
                    }

                    AdapterKey.SetValue("*FlowControl", "0", RegistryValueKind.String);
                    AdapterKey.SetValue("*PMNSOffload", "0", RegistryValueKind.String);
                    AdapterKey.SetValue("*PMARPOffload", "0", RegistryValueKind.String);
                    AdapterKey.SetValue("*WakeOnMagicPacket", "0", RegistryValueKind.String);
                    AdapterKey.SetValue("*WakeOnPattern", "0", RegistryValueKind.String);

                    DialogResult dr = MessageBox.Show("Succesfully disabled all power saving. To apply the changes you must restart your network adapter driver. Do you want to restart your network adapter driver now?", "Restart network adapter driver", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        Process restartadapter1 = new Process();
                        restartadapter1.StartInfo.FileName = "netsh.exe";
                        restartadapter1.StartInfo.Arguments = "interface set interface " + "\"" + ComboBoxConnectionName.Text + "\"" + " " + "admin=" + "\"" + "disabled" + "\"";
                        restartadapter1.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                        restartadapter1.StartInfo.CreateNoWindow = true;
                        restartadapter1.Start();
                        restartadapter1.WaitForExit();

                        System.Threading.Thread.Sleep(500);

                        Process restartadapter2 = new Process();
                        restartadapter2.StartInfo.FileName = "netsh.exe";
                        restartadapter2.StartInfo.Arguments = "interface set interface " + "\"" + ComboBoxConnectionName.Text + "\"" + " " + "admin=" + "\"" + "enabled" + "\"";
                        restartadapter2.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                        restartadapter2.StartInfo.CreateNoWindow = true;
                        restartadapter2.Start();
                        restartadapter2.WaitForExit();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void ButtonApplyExtraNetworkTweaks_Click(object sender, EventArgs e)
        {
            NDIS = Registry.LocalMachine.CreateSubKey(@"SYSTEM\ControlSet001\Services\NDIS\Parameters", true);
            AFD = Registry.LocalMachine.CreateSubKey(@"SYSTEM\CurrentControlSet\services\AFD\Parameters", true);
            RegistryKey Adapter = Registry.LocalMachine.CreateSubKey(@"SYSTEM\CurrentControlSet\Control\Class\{4d36e972-e325-11ce-bfc1-08002be10318}", true);
            Regex rx = new Regex(@"\d{4}", RegexOptions.Compiled | RegexOptions.IgnoreCase);

            try
            {
                foreach (string x in Adapter.GetSubKeyNames())
                {
                    if (!rx.IsMatch(x))
                    {
                        continue;
                    }

                    Key = Adapter.OpenSubKey(x, RegistryKeyPermissionCheck.ReadWriteSubTree);

                    if (Convert.ToString(Key.GetValue("DeviceInstanceID")).ToUpper().Contains(("PCI\\VEN_").ToUpper()))
                    {
                        if (Key.GetValue("TxAbsIntDelay") != null)
                        {
                            if (Key.GetValue("TxAbsIntDelay").ToString() == "1")
                            {
                                if (MessageBox.Show("Hitreg tweaks are already applied. Do you want to revert the settings?", "Hitreg tweaks", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                {
                                    RevertHitRegTweaks();
                                }
                            }
                            else
                            {
                                ApplyHitRegTweaks();
                                MessageBox.Show("Succesfully applied hitreg tweaks.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            ApplyHitRegTweaks();
                            MessageBox.Show("Succesfully applied hitreg tweaks.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        void ApplyHitRegTweaks()
        {
            if (Convert.ToString(Key.GetValue("DeviceInstanceID")).ToUpper().Contains(("PCI\\VEN_").ToUpper()))
            {
                Key.SetValue("*TxAbsIntDelay", "1", RegistryValueKind.String);
                Key.SetValue("TxAbsIntDelay", "1", RegistryValueKind.String);
                Key.SetValue("*RxAbsIntDelay", "1", RegistryValueKind.String);
                Key.SetValue("RxAbsIntDelay", "1", RegistryValueKind.String);
                Key.SetValue("*TxIntDelay", "1", RegistryValueKind.String);
                Key.SetValue("TxIntDelay", "1", RegistryValueKind.String);
                Key.SetValue("*RxIntDelay", "1", RegistryValueKind.String);
                Key.SetValue("RxIntDelay", "1", RegistryValueKind.String);
                Key.SetValue("*Enable9KJFTpt", "0", RegistryValueKind.String);
                Key.SetValue("Enable9KJFTpt", "0", RegistryValueKind.String);
                Key.SetValue("*AlternateSemaphoreDelay", "0", RegistryValueKind.String);
                Key.SetValue("AlternateSemaphoreDelay", "0", RegistryValueKind.String);
                Key.SetValue("*Node", "0", RegistryValueKind.String);
                Key.SetValue("Node", "0", RegistryValueKind.String);
                Key.SetValue("*PacketDirect", "1", RegistryValueKind.String);
                Key.SetValue("NicAutoPowerSaver", "0", RegistryValueKind.String);
                Key.SetValue("EnableDynamicPowerGating", "0", RegistryValueKind.String);
                Key.SetValue("AutoPowerSaveModeEnabled", "0", RegistryValueKind.String);
                Key.SetValue("EnableConnectedPowerGating", "0", RegistryValueKind.String);
                Key.SetValue("EnablePowerManagement", "0", RegistryValueKind.String);
                Key.SetValue("EnableSavePowerNow", "0", RegistryValueKind.String);
                Key.SetValue("*Sriov", "0", RegistryValueKind.String);
                Key.SetValue("DisableIntelRST", "1", RegistryValueKind.String);
                Key.SetValue("EnableDCA", "1", RegistryValueKind.String);
                Key.SetValue("SmartSpeed", "0", RegistryValueKind.String);
                Key.SetValue("StoreBadPackets", "0", RegistryValueKind.String);
                Key.SetValue("OBFFEnabled", "0", RegistryValueKind.String);
                Key.SetValue("EnableDRBT", "0", RegistryValueKind.String);
                Key.SetValue("EnableETW", "0", RegistryValueKind.String);
                Key.SetValue("DynamicLTR", "0", RegistryValueKind.String);
                Key.SetValue("DcaTxSettings", "1", RegistryValueKind.String);
                Key.SetValue("DcaRxSettings", "1", RegistryValueKind.String);
                Key.SetValue("VMQ", "0", RegistryValueKind.String);
                Key.SetValue("*VMQ", "0", RegistryValueKind.String);
                Key.SetValue("EnableTcpTimer", "0", RegistryValueKind.String);
                Key.SetValue("SwParsing", "0", RegistryValueKind.String);
                Key.SetValue("RssOnHostVPorts", "0", RegistryValueKind.String);
                Key.SetValue("FwTracerEnabled", "0", RegistryValueKind.DWord);
                AFD.SetValue("DisableRawSecurity", "1", RegistryValueKind.DWord);
                AFD.SetValue("DynamicSendBufferDisable", "0", RegistryValueKind.DWord);
                AFD.SetValue("IrpStackSize", "50", RegistryValueKind.DWord);
                AFD.SetValue("PriorityBoost", "0", RegistryValueKind.DWord);
                AFD.SetValue("DoNotHoldNicBuffers", "1", RegistryValueKind.DWord);
                NDIS.SetValue("EnableNicAutoPowerSaverInSleepStudy", "0", RegistryValueKind.DWord);
                NDIS.SetValue("ImplicitPowerRefManagement", "0", RegistryValueKind.DWord);
                NDIS.SetValue("DebugLoggingMode", "0", RegistryValueKind.DWord);
                NDIS.SetValue("TrackNblOwner", "0", RegistryValueKind.DWord);
                NDIS.SetValue("DisableNDISWatchDog", "1", RegistryValueKind.DWord);
                NDIS.SetValue("LogPages", "0", RegistryValueKind.DWord);
                NDIS.SetValue("ForceLogsInMiniDump", "0", RegistryValueKind.DWord);
                NDIS.SetValue("DisableWDIWatchdogForceBugcheck", "1", RegistryValueKind.DWord);
            }
        }

        void RevertHitRegTweaks()
        {
            if (Convert.ToString(Key.GetValue("DeviceInstanceID")).ToUpper().Contains(("PCI\\VEN_").ToUpper()))
            {
                Key.DeleteValue("*TxAbsIntDelay");
                Key.DeleteValue("TxAbsIntDelay");
                Key.DeleteValue("*RxAbsIntDelay");
                Key.DeleteValue("RxAbsIntDelay");
                Key.DeleteValue("*TxIntDelay");
                Key.DeleteValue("TxIntDelay");
                Key.DeleteValue("*RxIntDelay");
                Key.DeleteValue("RxIntDelay");
                Key.DeleteValue("*Enable9KJFTpt");
                Key.DeleteValue("Enable9KJFTpt");
                Key.DeleteValue("*AlternateSemaphoreDelay");
                Key.DeleteValue("AlternateSemaphoreDelay");
                Key.DeleteValue("*Node");
                Key.DeleteValue("Node");
                Key.DeleteValue("*PacketDirect");
                Key.DeleteValue("NicAutoPowerSaver");
                Key.DeleteValue("EnableDynamicPowerGating");
                Key.DeleteValue("AutoPowerSaveModeEnabled");
                Key.DeleteValue("EnableConnectedPowerGating");
                Key.DeleteValue("EnablePowerManagement");
                Key.DeleteValue("EnableSavePowerNow");
                Key.DeleteValue("*Sriov");
                Key.DeleteValue("DisableIntelRST");
                Key.DeleteValue("EnableDCA");
                Key.DeleteValue("SmartSpeed");
                Key.DeleteValue("StoreBadPackets");
                Key.DeleteValue("OBFFEnabled");
                Key.DeleteValue("EnableDRBT");
                Key.DeleteValue("EnableETW");
                Key.DeleteValue("DynamicLTR");
                Key.DeleteValue("DcaTxSettings");
                Key.DeleteValue("DcaRxSettings");
                Key.DeleteValue("VMQ");
                Key.DeleteValue("*VMQ");
                Key.DeleteValue("EnableTcpTimer");
                Key.DeleteValue("SwParsing");
                Key.DeleteValue("RssOnHostVPorts");
                Key.DeleteValue("FwTracerEnabled");
                AFD.DeleteValue("DisableRawSecurity");
                AFD.DeleteValue("DynamicSendBufferDisable");
                AFD.DeleteValue("IrpStackSize");
                AFD.DeleteValue("PriorityBoost");
                AFD.DeleteValue("DoNotHoldNicBuffers");
                NDIS.DeleteValue("EnableNicAutoPowerSaverInSleepStudy");
                NDIS.DeleteValue("ImplicitPowerRefManagement");
                NDIS.DeleteValue("DebugLoggingMode");
                NDIS.DeleteValue("TrackNblOwner");
                NDIS.DeleteValue("DisableNDISWatchDog");
                NDIS.DeleteValue("LogPages");
                NDIS.DeleteValue("ForceLogsInMiniDump");
                NDIS.DeleteValue("DisableWDIWatchdogForceBugcheck");
            }
        }

        private void CheckBoxIP_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxIP.Checked == true)
            {
                TextBoxIPAddress.Enabled = true;
            }
            else if (CheckBoxIP.Checked == false)
            {
                TextBoxIPAddress.Enabled = false;
            }
        }

        private void CheckBoxSubnetMask_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxSubnetMask.Checked == true)
            {
                TextBoxSubnetMaskAddress.Enabled = true;
            }
            else if (CheckBoxSubnetMask.Checked == false)
            {
                TextBoxSubnetMaskAddress.Enabled = false;
            }
        }

        private void CheckBoxDefaultGateway_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxDefaultGateway.Checked == true)
            {
                TextBoxDefaultGatewayAddress.Enabled = true;
            }
            else if (CheckBoxDefaultGateway.Checked == false)
            {
                TextBoxDefaultGatewayAddress.Enabled = false;
            }
        }

        private void CheckBoxDNS1_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxDNS1.Checked == true)
            {
                TextBoxDNS1Address.Enabled = true;
            }
            else if (CheckBoxDNS1.Checked == false)
            {
                TextBoxDNS1Address.Enabled = false;
            }
        }

        private void CheckBoxDNS2_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxDNS2.Checked == true)
            {
                TextBoxDNS2Address.Enabled = true;
            }
            else if (CheckBoxDNS2.Checked == false)
            {
                TextBoxDNS2Address.Enabled = false;
            }
        }

        private void ButtonLoadAllAddresses_Click(object sender, EventArgs e)
        {
            string AdapterName = "";
            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {
                AdapterName = nic.Description;

                IPInterfaceProperties ipInterface = nic.GetIPProperties();

                foreach (UnicastIPAddressInformation a in nic.GetIPProperties().UnicastAddresses)
                {
                    if (a.Address.AddressFamily == AddressFamily.InterNetwork)
                    {
                        TextBoxIPAddress.Text = a.Address.ToString();
                        TextBoxSubnetMaskAddress.Text = a.IPv4Mask.ToString();
                    }
                }

                foreach (GatewayIPAddressInformation a in nic.GetIPProperties().GatewayAddresses)
                {
                    if (a.Address.AddressFamily == AddressFamily.InterNetwork)
                    {
                        TextBoxDefaultGatewayAddress.Text = a.Address.ToString();
                    }
                }

                TextBoxDNS1Address.Text = "1.1.1.1";
                TextBoxDNS2Address.Text = "1.0.0.1";

                break;
            }
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            string CONNECTION = ComboBoxConnectionName.Text;
            string IP = TextBoxIPAddress.Text;
            string SubnetMask = TextBoxSubnetMaskAddress.Text;
            string DefaultGateway = TextBoxDefaultGatewayAddress.Text;
            string DNS1 = TextBoxDNS1Address.Text;
            string DNS2 = TextBoxDNS2Address.Text;

            if (ComboBoxAdapterName.Text == "")
            {
                MessageBox.Show("Please select a network adapter");
            }
            else
            {
                if (ComboBoxAdapterName.Text.Contains("Intel"))
                {
                    // Gigabit Master Slave Mode
                    if (ComboBoxGigabitMasterSlaveMode.Text == "Auto Detect")
                    {
                        AdapterKey.SetValue("MasterSlave", 0, RegistryValueKind.String);
                    }
                    else if (ComboBoxGigabitMasterSlaveMode.Text == "Force Master Mode")
                    {
                        AdapterKey.SetValue("MasterSlave", 1, RegistryValueKind.String);
                    }
                    else if (ComboBoxGigabitMasterSlaveMode.Text == "Force Slave Mode")
                    {
                        AdapterKey.SetValue("MasterSlave", 2, RegistryValueKind.String);
                    }

                    // Interrupt Moderation Rate
                    if (ComboBoxInterruptModerationRate.Text == "Off")
                    {
                        AdapterKey.SetValue("ITR", 0, RegistryValueKind.String);
                    }
                    else if (ComboBoxInterruptModerationRate.Text == "Minimal")
                    {
                        AdapterKey.SetValue("ITR", 200, RegistryValueKind.String);
                    }
                    else if (ComboBoxInterruptModerationRate.Text == "Low")
                    {
                        AdapterKey.SetValue("ITR", 400, RegistryValueKind.String);
                    }
                    else if (ComboBoxInterruptModerationRate.Text == "Medium")
                    {
                        AdapterKey.SetValue("ITR", 950, RegistryValueKind.String);
                    }
                    else if (ComboBoxInterruptModerationRate.Text == "High")
                    {
                        AdapterKey.SetValue("ITR", 2000, RegistryValueKind.String);
                    }
                    else if (ComboBoxInterruptModerationRate.Text == "Extreme")
                    {
                        AdapterKey.SetValue("ITR", 3600, RegistryValueKind.String);
                    }
                    else if (ComboBoxInterruptModeration.Text == "Adaptive")
                    {
                        AdapterKey.SetValue("ITR", 65535, RegistryValueKind.String);
                    }

                    // Jumbo Packet
                    if (ComboBoxJumboPacket.Text == "4088 Bytes")
                    {
                        AdapterKey.SetValue("*JumboPacket", 4088, RegistryValueKind.String);
                    }
                    else if (ComboBoxJumboPacket.Text == "9014 Bytes")
                    {
                        AdapterKey.SetValue("*JumboPacket", 9014, RegistryValueKind.String);
                    }
                    else if (ComboBoxJumboPacket.Text == "Disabled")
                    {
                        AdapterKey.SetValue("*JumboPacket", 1514, RegistryValueKind.String);
                    }

                    // Packet Priority & VLAN
                    if (ComboBoxPacketPriorityAndVLAN.Text == "Packet Priority & VLAN Disabled")
                    {
                        AdapterKey.SetValue("*PriorityVLANTag", 0, RegistryValueKind.String);
                    }
                    else if (ComboBoxPacketPriorityAndVLAN.Text == "Packet Priority & VLAN Enabled")
                    {
                        AdapterKey.SetValue("*PriorityVLANTag", 3, RegistryValueKind.String);
                    }
                    else if (ComboBoxPacketPriorityAndVLAN.Text == "Packet Priority Enabled")
                    {
                        AdapterKey.SetValue("*PriorityVLANTag", 3, RegistryValueKind.String);
                    }
                    else if (ComboBoxPacketPriorityAndVLAN.Text == "VLAN Enabled")
                    {
                        AdapterKey.SetValue("*PriorityVLANTag", 2, RegistryValueKind.String);
                    }
                }
                else if (ComboBoxAdapterName.Text.Contains("Realtek"))
                {
                    // Jumbo Frame
                    if (ComboBoxJumboFrame.Text == "4088 Bytes")
                    {
                        AdapterKey.SetValue("*JumboPacket", 4088, RegistryValueKind.String);
                    }
                    else if (ComboBoxJumboFrame.Text == "9014 Bytes")
                    {
                        AdapterKey.SetValue("*JumboPacket", 9014, RegistryValueKind.String);
                    }
                    else if (ComboBoxJumboFrame.Text == "Disabled")
                    {
                        AdapterKey.SetValue("*JumboPacket", 1514, RegistryValueKind.String);
                    }

                    // Priority & VLAN
                    if (ComboBoxPriorityAndVLAN.Text == "Priority & VLAN Disabled")
                    {
                        AdapterKey.SetValue("*PriorityVLANTag", 0, RegistryValueKind.String);
                    }
                    else if (ComboBoxPriorityAndVLAN.Text == "Priority & VLAN Enabled")
                    {
                        AdapterKey.SetValue("*PriorityVLANTag", 3, RegistryValueKind.String);
                    }
                    else if (ComboBoxPriorityAndVLAN.Text == "Priority Enabled")
                    {
                        AdapterKey.SetValue("*PriorityVLANTag", 1, RegistryValueKind.String);
                    }
                    else if (ComboBoxPriorityAndVLAN.Text == "VLAN Enabled")
                    {
                        AdapterKey.SetValue("*PriorityVLANTag", 2, RegistryValueKind.String);
                    }

                    // WOL & Shutdown Link Speed
                    if (ComboBoxWOLAndShutdownLinkSpeed.Text == "10 Mbps First")
                    {
                        AdapterKey.SetValue("WolShutdownLinkSpeed", 0, RegistryValueKind.String);
                    }
                    else if (ComboBoxWOLAndShutdownLinkSpeed.Text == "100 Mbps First")
                    {
                        AdapterKey.SetValue("WolShutdownLinkSpeed", 1, RegistryValueKind.String);
                    }
                    else if (ComboBoxWOLAndShutdownLinkSpeed.Text == "Not Speed Down")
                    {
                        AdapterKey.SetValue("WolShutdownLinkSpeed", 2, RegistryValueKind.String);
                    }
                }

                // Interrupt Moderation
                if (ComboBoxInterruptModeration.Text == "Disabled")
                {
                    AdapterKey.SetValue("*InterruptModeration", 0, RegistryValueKind.String);
                }
                else if (ComboBoxInterruptModeration.Text == "Enabled")
                {
                    AdapterKey.SetValue("*InterruptModeration", 1, RegistryValueKind.String);
                }

                // IPv4 Checksum Offload
                if (ComboBoxIPv4ChecksumOffload.Text == "Disabled")
                {
                    AdapterKey.SetValue("*IPChecksumOffloadIPv4", 0, RegistryValueKind.String);
                }
                else if (ComboBoxIPv4ChecksumOffload.Text == "Rx & Tx Enabled")
                {
                    AdapterKey.SetValue("*IPChecksumOffloadIPv4", 3, RegistryValueKind.String);
                }
                else if (ComboBoxIPv4ChecksumOffload.Text == "Rx Enabled")
                {
                    AdapterKey.SetValue("*IPChecksumOffloadIPv4", 2, RegistryValueKind.String);
                }
                else if (ComboBoxIPv4ChecksumOffload.Text == "Tx Enabled")
                {
                    AdapterKey.SetValue("*IPChecksumOffloadIPv4", 1, RegistryValueKind.String);
                }

                // Large Send Offload v2 (IPv4)
                if (ComboBoxLargeSendOffloadv2IPv4.Text == "Disabled")
                {
                    AdapterKey.SetValue("*LsoV2IPv4", 0, RegistryValueKind.String);
                }
                else if (ComboBoxLargeSendOffloadv2IPv4.Text == "Enabled")
                {
                    AdapterKey.SetValue("*LsoV2IPv4", 1, RegistryValueKind.String);
                }

                // Large Send Offload v2 (IPv6)
                if (ComboBoxLargeSendOffloadv2IPv6.Text == "Disabled")
                {
                    AdapterKey.SetValue("*LsoV2IPv6", 0, RegistryValueKind.String);
                }
                else if (ComboBoxLargeSendOffloadv2IPv6.Text == "Enabled")
                {
                    AdapterKey.SetValue("*LsoV2IPv6", 1, RegistryValueKind.String);
                }

                // Maximum Number of RSS Queues
                if (ComboBoxMaximumNumberOfRSSQueues.Text == "1 Queue")
                {
                    AdapterKey.SetValue("*MaxRssProcessors", 1, RegistryValueKind.String);
                    AdapterKey.SetValue("*NumRssQueues", 1, RegistryValueKind.String);
                }
                else if (ComboBoxMaximumNumberOfRSSQueues.Text == "2 Queues")
                {
                    AdapterKey.SetValue("*MaxRssProcessors", 2, RegistryValueKind.String);
                    AdapterKey.SetValue("*NumRssQueues", 2, RegistryValueKind.String);
                }
                else if (ComboBoxMaximumNumberOfRSSQueues.Text == "3 Queues")
                {
                    AdapterKey.SetValue("*MaxRssProcessors", 3, RegistryValueKind.String);
                    AdapterKey.SetValue("*NumRssQueues", 3, RegistryValueKind.String);
                }
                else if (ComboBoxMaximumNumberOfRSSQueues.Text == "4 Queues")
                {
                    AdapterKey.SetValue("*MaxRssProcessors", 4, RegistryValueKind.String);
                    AdapterKey.SetValue("*NumRssQueues", 4, RegistryValueKind.String);
                }
                else if (ComboBoxMaximumNumberOfRSSQueues.Text == "5 Queues")
                {
                    AdapterKey.SetValue("*MaxRssProcessors", 5, RegistryValueKind.String);
                    AdapterKey.SetValue("*NumRssQueues", 5, RegistryValueKind.String);
                }
                else if (ComboBoxMaximumNumberOfRSSQueues.Text == "6 Queues")
                {
                    AdapterKey.SetValue("*MaxRssProcessors", 6, RegistryValueKind.String);
                    AdapterKey.SetValue("*NumRssQueues", 6, RegistryValueKind.String);
                }
                else if (ComboBoxMaximumNumberOfRSSQueues.Text == "7 Queues")
                {
                    AdapterKey.SetValue("*MaxRssProcessors", 7, RegistryValueKind.String);
                    AdapterKey.SetValue("*NumRssQueues", 7, RegistryValueKind.String);
                }
                else if (ComboBoxMaximumNumberOfRSSQueues.Text == "8 Queues")
                {
                    AdapterKey.SetValue("*MaxRssProcessors", 8, RegistryValueKind.String);
                    AdapterKey.SetValue("*NumRssQueues", 8, RegistryValueKind.String);
                }

                // QoS Timer Resolution
                if (ComboBoxQoSTimerResolution.Text == "1ms")
                {
                    QoSKey.SetValue("TimerResolution", 1, RegistryValueKind.DWord);
                }
                else if (ComboBoxQoSTimerResolution.Text == "2ms")
                {
                    QoSKey.SetValue("TimerResolution", 2, RegistryValueKind.DWord);
                }
                else if (ComboBoxQoSTimerResolution.Text == "3ms")
                {
                    QoSKey.SetValue("TimerResolution", 3, RegistryValueKind.DWord);
                }
                else if (ComboBoxQoSTimerResolution.Text == "4ms")
                {
                    QoSKey.SetValue("TimerResolution", 4, RegistryValueKind.DWord);
                }
                else if (ComboBoxQoSTimerResolution.Text == "5ms")
                {
                    QoSKey.SetValue("TimerResolution", 5, RegistryValueKind.DWord);
                }
                else if (ComboBoxQoSTimerResolution.Text == "6ms")
                {
                    QoSKey.SetValue("TimerResolution", 6, RegistryValueKind.DWord);
                }
                else if (ComboBoxQoSTimerResolution.Text == "7ms")
                {
                    QoSKey.SetValue("TimerResolution", 7, RegistryValueKind.DWord);
                }
                else if (ComboBoxQoSTimerResolution.Text == "8ms")
                {
                    QoSKey.SetValue("TimerResolution", 8, RegistryValueKind.DWord);
                }
                else if (ComboBoxQoSTimerResolution.Text == "9ms")
                {
                    QoSKey.SetValue("TimerResolution", 9, RegistryValueKind.DWord);
                }
                else if (ComboBoxQoSTimerResolution.Text == "10ms")
                {
                    QoSKey.SetValue("TimerResolution", 10, RegistryValueKind.DWord);
                }
                else if (ComboBoxQoSTimerResolution.Text == "11ms")
                {
                    QoSKey.SetValue("TimerResolution", 11, RegistryValueKind.DWord);
                }
                else if (ComboBoxQoSTimerResolution.Text == "12ms")
                {
                    QoSKey.SetValue("TimerResolution", 12, RegistryValueKind.DWord);
                }
                else if (ComboBoxQoSTimerResolution.Text == "13ms")
                {
                    QoSKey.SetValue("TimerResolution", 13, RegistryValueKind.DWord);
                }
                else if (ComboBoxQoSTimerResolution.Text == "14ms")
                {
                    QoSKey.SetValue("TimerResolution", 14, RegistryValueKind.DWord);
                }
                else if (ComboBoxQoSTimerResolution.Text == "15ms")
                {
                    QoSKey.SetValue("TimerResolution", 15, RegistryValueKind.DWord);
                }
                else if (ComboBoxQoSTimerResolution.Text == "16ms")
                {
                    QoSKey.SetValue("TimerResolution", 16, RegistryValueKind.DWord);
                }
                else if (ComboBoxQoSTimerResolution.Text == "17ms")
                {
                    QoSKey.SetValue("TimerResolution", 17, RegistryValueKind.DWord);
                }
                else if (ComboBoxQoSTimerResolution.Text == "18ms")
                {
                    QoSKey.SetValue("TimerResolution", 18, RegistryValueKind.DWord);
                }
                else if (ComboBoxQoSTimerResolution.Text == "19ms")
                {
                    QoSKey.SetValue("TimerResolution", 19, RegistryValueKind.DWord);
                }
                else if (ComboBoxQoSTimerResolution.Text == "20ms (default)")
                {
                    QoSKey.SetValue("TimerResolution", 20, RegistryValueKind.DWord);
                }

                // Receive Buffers
                {
                    AdapterKey.SetValue("*ReceiveBuffers", Convert.ToString(NumericUpDownReceiveBuffers.Value), RegistryValueKind.String);
                }

                // Receive Side Scaling
                if (ComboBoxReceiveSideScaling.Text == "Disabled")
                {
                    AdapterKey.SetValue("*RSS", 0, RegistryValueKind.String);
                }
                else if (ComboBoxReceiveSideScaling.Text == "Enabled")
                {
                    AdapterKey.SetValue("*RSS", 1, RegistryValueKind.String);
                }

                // RSS Base Processor Number
                if (ComboBoxRSSBaseProcessorNumber.Text == "CPU 0")
                {
                    AdapterKey.SetValue("*RssBaseProcNumber", 0, RegistryValueKind.String);
                }
                else if (ComboBoxRSSBaseProcessorNumber.Text == "CPU 1")
                {
                    AdapterKey.SetValue("*RssBaseProcNumber", 1, RegistryValueKind.String);
                }
                else if (ComboBoxRSSBaseProcessorNumber.Text == "CPU 2")
                {
                    AdapterKey.SetValue("*RssBaseProcNumber", 2, RegistryValueKind.String);
                }
                else if (ComboBoxRSSBaseProcessorNumber.Text == "CPU 3")
                {
                    AdapterKey.SetValue("*RssBaseProcNumber", 3, RegistryValueKind.String);
                }
                else if (ComboBoxRSSBaseProcessorNumber.Text == "CPU 4")
                {
                    AdapterKey.SetValue("*RssBaseProcNumber", 4, RegistryValueKind.String);
                }
                else if (ComboBoxRSSBaseProcessorNumber.Text == "CPU 5")
                {
                    AdapterKey.SetValue("*RssBaseProcNumber", 5, RegistryValueKind.String);
                }
                else if (ComboBoxRSSBaseProcessorNumber.Text == "CPU 6")
                {
                    AdapterKey.SetValue("*RssBaseProcNumber", 6, RegistryValueKind.String);
                }
                else if (ComboBoxRSSBaseProcessorNumber.Text == "CPU 7")
                {
                    AdapterKey.SetValue("*RssBaseProcNumber", 7, RegistryValueKind.String);
                }

                // Speed & Duplex
                if (ComboBoxSpeedAndDuplex.Text == "1.0 Gbps Full Duplex")
                {
                    AdapterKey.SetValue("*SpeedDuplex", 6, RegistryValueKind.String);
                }
                else if (ComboBoxSpeedAndDuplex.Text == "10 Mbps Full Duplex")
                {
                    AdapterKey.SetValue("*SpeedDuplex", 2, RegistryValueKind.String);
                }
                else if (ComboBoxSpeedAndDuplex.Text == "10 Mbps Half Duplex")
                {
                    AdapterKey.SetValue("*SpeedDuplex", 1, RegistryValueKind.String);
                }
                else if (ComboBoxSpeedAndDuplex.Text == "100 Mbps Full Duplex")
                {
                    AdapterKey.SetValue("*SpeedDuplex", 4, RegistryValueKind.String);
                }
                else if (ComboBoxSpeedAndDuplex.Text == "100 Mbps Half Duplex")
                {
                    AdapterKey.SetValue("*SpeedDuplex", 3, RegistryValueKind.String);
                }
                else if (ComboBoxSpeedAndDuplex.Text == "Auto Negotiation")
                {
                    AdapterKey.SetValue("*SpeedDuplex", 0, RegistryValueKind.String);
                }

                // TCP Checksum Offload (IPv4)
                if (ComboBoxTCPChecksumOffloadIPv4.Text == "Disabled")
                {
                    AdapterKey.SetValue("*TCPChecksumOffloadIPv4", 0, RegistryValueKind.String);
                }
                else if (ComboBoxTCPChecksumOffloadIPv4.Text == "Rx & Tx Enabled")
                {
                    AdapterKey.SetValue("*TCPChecksumOffloadIPv4", 3, RegistryValueKind.String);
                }
                else if (ComboBoxTCPChecksumOffloadIPv4.Text == "Rx Enabled")
                {
                    AdapterKey.SetValue("*TCPChecksumOffloadIPv4", 2, RegistryValueKind.String);
                }
                else if (ComboBoxTCPChecksumOffloadIPv4.Text == "Tx Enabled")
                {
                    AdapterKey.SetValue("*TCPChecksumOffloadIPv4", 1, RegistryValueKind.String);
                }

                // TCP Checksum Offload (IPv6)
                if (ComboBoxTCPChecksumOffloadIPv6.Text == "Disabled")
                {
                    AdapterKey.SetValue("*TCPChecksumOffloadIPv6", 0, RegistryValueKind.String);
                }
                else if (ComboBoxTCPChecksumOffloadIPv6.Text == "Rx & Tx Enabled")
                {
                    AdapterKey.SetValue("*TCPChecksumOffloadIPv6", 3, RegistryValueKind.String);
                }
                else if (ComboBoxTCPChecksumOffloadIPv6.Text == "Rx Enabled")
                {
                    AdapterKey.SetValue("*TCPChecksumOffloadIPv6", 2, RegistryValueKind.String);
                }
                else if (ComboBoxTCPChecksumOffloadIPv6.Text == "Tx Enabled")
                {
                    AdapterKey.SetValue("*TCPChecksumOffloadIPv6", 1, RegistryValueKind.String);
                }

                // TCP Receive Window Autotuning
                if (ComboBoxTCPReceiveWindowAutotuning.Text == "Disabled")
                {
                    Process autotuningdisabled = new Process();
                    autotuningdisabled.StartInfo.FileName = "netsh.exe";
                    autotuningdisabled.StartInfo.Arguments = "interface tcp set global autotuning=disabled";
                    autotuningdisabled.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    autotuningdisabled.StartInfo.CreateNoWindow = true;
                    autotuningdisabled.Start();
                    autotuningdisabled.WaitForExit();
                }
                else if (ComboBoxTCPReceiveWindowAutotuning.Text == "Normal")
                {
                    Process autotuningnormal = new Process();
                    autotuningnormal.StartInfo.FileName = "netsh.exe";
                    autotuningnormal.StartInfo.Arguments = "interface tcp set global autotuning=normal";
                    autotuningnormal.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    autotuningnormal.StartInfo.CreateNoWindow = true;
                    autotuningnormal.Start();
                    autotuningnormal.WaitForExit();
                }
                else if (ComboBoxTCPReceiveWindowAutotuning.Text == "Restricted")
                {
                    Process autotuningrestricted = new Process();
                    autotuningrestricted.StartInfo.FileName = "netsh.exe";
                    autotuningrestricted.StartInfo.Arguments = "interface tcp set global autotuning=restricted";
                    autotuningrestricted.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    autotuningrestricted.StartInfo.CreateNoWindow = true;
                    autotuningrestricted.Start();
                    autotuningrestricted.WaitForExit();
                }
                else if (ComboBoxTCPReceiveWindowAutotuning.Text == "Experimental")
                {
                    Process autotuningexperimental = new Process();
                    autotuningexperimental.StartInfo.FileName = "netsh.exe";
                    autotuningexperimental.StartInfo.Arguments = "interface tcp set global autotuning=experimental";
                    autotuningexperimental.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    autotuningexperimental.StartInfo.CreateNoWindow = true;
                    autotuningexperimental.Start();
                    autotuningexperimental.WaitForExit();
                }

                // Transmit Buffers
                {
                    AdapterKey.SetValue("*TransmitBuffers", Convert.ToString(NumericUpDownTransmitBuffers.Value), RegistryValueKind.String);
                }

                // UDP Checksum Offload (IPv4)
                if (ComboBoxUDPChecksumOffloadIPv4.Text == "Disabled")
                {
                    AdapterKey.SetValue("*UDPChecksumOffloadIPv4", 0, RegistryValueKind.String);
                }
                else if (ComboBoxUDPChecksumOffloadIPv4.Text == "Rx & Tx Enabled")
                {
                    AdapterKey.SetValue("*UDPChecksumOffloadIPv4", 3, RegistryValueKind.String);
                }
                else if (ComboBoxUDPChecksumOffloadIPv4.Text == "Rx Enabled")
                {
                    AdapterKey.SetValue("*UDPChecksumOffloadIPv4", 2, RegistryValueKind.String);
                }
                else if (ComboBoxUDPChecksumOffloadIPv4.Text == "Tx Enabled")
                {
                    AdapterKey.SetValue("*UDPChecksumOffloadIPv4", 1, RegistryValueKind.String);
                }

                // UDP Checksum Offload (IPv6)
                if (ComboBoxUDPChecksumOffloadIPv6.Text == "Disabled")
                {
                    AdapterKey.SetValue("*UDPChecksumOffloadIPv6", 0, RegistryValueKind.String);
                }
                else if (ComboBoxUDPChecksumOffloadIPv6.Text == "Rx & Tx Enabled")
                {
                    AdapterKey.SetValue("*UDPChecksumOffloadIPv6", 3, RegistryValueKind.String);
                }
                else if (ComboBoxUDPChecksumOffloadIPv6.Text == "Rx Enabled")
                {
                    AdapterKey.SetValue("*UDPChecksumOffloadIPv6", 2, RegistryValueKind.String);
                }
                else if (ComboBoxUDPChecksumOffloadIPv6.Text == "Tx Enabled")
                {
                    AdapterKey.SetValue("*UDPChecksumOffloadIPv6", 1, RegistryValueKind.String);
                }
            }

            // IP, Subnet Mask and Default Gateway
            {
                Process ipsubnetmaskdefaultgateway = new Process();
                ipsubnetmaskdefaultgateway.StartInfo.FileName = "netsh.exe";
                ipsubnetmaskdefaultgateway.StartInfo.Arguments = "interface ip set address " + "\"" + CONNECTION + "\"" + " static " + IP + " " + SubnetMask + " " + DefaultGateway;
                ipsubnetmaskdefaultgateway.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                ipsubnetmaskdefaultgateway.StartInfo.CreateNoWindow = true;
                ipsubnetmaskdefaultgateway.Start();
                ipsubnetmaskdefaultgateway.WaitForExit();
            }

            // Primary DNS
            {
                Process dns1 = new Process();
                dns1.StartInfo.FileName = "netsh.exe";
                dns1.StartInfo.Arguments = "interface ip add dns " + "\"" + CONNECTION + "\"" + " " + DNS1;
                dns1.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                dns1.StartInfo.CreateNoWindow = true;
                dns1.Start();
                dns1.WaitForExit();
            }

            // Secondary DNS
            {
                Process dns2 = new Process();
                dns2.StartInfo.FileName = "netsh.exe";
                dns2.StartInfo.Arguments = "interface ip add dns " + "\"" + CONNECTION + "\"" + " " + DNS2 + " index=2";
                dns2.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                dns2.StartInfo.CreateNoWindow = true;
                dns2.Start();
                dns2.WaitForExit();
            }

            // Restart Adapter
            {
                Process restartadapter1 = new Process();
                restartadapter1.StartInfo.FileName = "netsh.exe";
                restartadapter1.StartInfo.Arguments = "interface set interface " + "\"" + CONNECTION + "\"" + " " + "admin=" + "\"" + "disabled" + "\"";
                restartadapter1.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                restartadapter1.StartInfo.CreateNoWindow = true;
                restartadapter1.Start();
                restartadapter1.WaitForExit();

                System.Threading.Thread.Sleep(500);

                Process restartadapter2 = new Process();
                restartadapter2.StartInfo.FileName = "netsh.exe";
                restartadapter2.StartInfo.Arguments = "interface set interface " + "\"" + CONNECTION + "\"" + " " + "admin=" + "\"" + "enabled" + "\"";
                restartadapter2.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                restartadapter2.StartInfo.CreateNoWindow = true;
                restartadapter2.Start();
                restartadapter2.WaitForExit();
            }

            // Disable Heuristics
            {
                Process disableheuristics = new Process();
                disableheuristics.StartInfo.FileName = "netsh.exe";
                disableheuristics.StartInfo.Arguments = "int tcp set heuristics disabled";
                disableheuristics.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                disableheuristics.StartInfo.CreateNoWindow = true;
                disableheuristics.Start();
                disableheuristics.WaitForExit();
            }

            this.Close();
        }

        private void ComboBoxAdapterName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void ComboBoxConnectionName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void ComboBoxGigabitMasterSlaveMode_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void ComboBoxInterruptModeration_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void ComboBoxInterruptModerationRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void ComboBoxIPv4ChecksumOffload_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void ComboBoxJumboFrame_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void ComboBoxJumboPacket_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void ComboBoxLargeSendOffloadv2IPv4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void ComboBoxLargeSendOffloadv2IPv6_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void ComboBoxMaximumNumberOfRSSQueues_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void ComboBoxPacketPriorityAndVLAN_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void ComboBoxPriorityAndVLAN_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void ComboBoxQoSTimerResolution_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void ComboBoxReceiveSideScaling_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void ComboBoxRSSBaseProcessorNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void ComboBoxSpeedAndDuplex_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void ComboBoxTCPChecksumOffloadIPv4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void ComboBoxTCPChecksumOffloadIPv6_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void ComboBoxTCPReceiveWindowAutotuning_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void ComboBoxUDPChecksumOffloadIPv4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void ComboBoxUDPChecksumOffloadIPv6_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void ComboBoxWOLAndShutdownLinkSpeed_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void NumericUpDownReceiveBuffers_Validated(object sender, EventArgs e)
        {
            if (NumericUpDownReceiveBuffers.Text == "")
            {
                NumericUpDownReceiveBuffers.Value = 0;
            }
        }

        private void NumericUpDownTransmitBuffers_Validated(object sender, EventArgs e)
        {
            if (NumericUpDownTransmitBuffers.Text == "")
            {
                NumericUpDownTransmitBuffers.Value = 0;
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
