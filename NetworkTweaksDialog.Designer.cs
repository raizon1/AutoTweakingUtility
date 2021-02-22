namespace Auto_Tweaking_Utility
{
    partial class NetworkTweaksDialog
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NetworkTweaksDialog));
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.ButtonOK = new System.Windows.Forms.Button();
            this.ButtonLoadAllAddresses = new System.Windows.Forms.Button();
            this.ComboBoxConnectionName = new System.Windows.Forms.ComboBox();
            this.TextBoxDNS2Address = new System.Windows.Forms.TextBox();
            this.TextBoxDNS1Address = new System.Windows.Forms.TextBox();
            this.TextBoxDefaultGatewayAddress = new System.Windows.Forms.TextBox();
            this.TextBoxSubnetMaskAddress = new System.Windows.Forms.TextBox();
            this.TextBoxIPAddress = new System.Windows.Forms.TextBox();
            this.CheckBoxDNS2 = new System.Windows.Forms.CheckBox();
            this.CheckBoxDNS1 = new System.Windows.Forms.CheckBox();
            this.CheckBoxDefaultGateway = new System.Windows.Forms.CheckBox();
            this.CheckBoxSubnetMask = new System.Windows.Forms.CheckBox();
            this.ComboBoxPacketPriorityAndVLAN = new System.Windows.Forms.ComboBox();
            this.ComboBoxJumboPacket = new System.Windows.Forms.ComboBox();
            this.ComboBoxInterruptModerationRate = new System.Windows.Forms.ComboBox();
            this.ComboBoxGigabitMasterSlaveMode = new System.Windows.Forms.ComboBox();
            this.ComboBoxQoSTimerResolution = new System.Windows.Forms.ComboBox();
            this.ComboBoxTCPReceiveWindowAutotuning = new System.Windows.Forms.ComboBox();
            this.ComboBoxInterruptModeration = new System.Windows.Forms.ComboBox();
            this.ComboBoxIPv4ChecksumOffload = new System.Windows.Forms.ComboBox();
            this.ComboBoxJumboFrame = new System.Windows.Forms.ComboBox();
            this.ComboBoxLargeSendOffloadv2IPv4 = new System.Windows.Forms.ComboBox();
            this.ComboBoxLargeSendOffloadv2IPv6 = new System.Windows.Forms.ComboBox();
            this.ComboBoxMaximumNumberOfRSSQueues = new System.Windows.Forms.ComboBox();
            this.ComboBoxPriorityAndVLAN = new System.Windows.Forms.ComboBox();
            this.NumericUpDownReceiveBuffers = new System.Windows.Forms.NumericUpDown();
            this.ComboBoxReceiveSideScaling = new System.Windows.Forms.ComboBox();
            this.ComboBoxRSSBaseProcessorNumber = new System.Windows.Forms.ComboBox();
            this.ComboBoxSpeedAndDuplex = new System.Windows.Forms.ComboBox();
            this.ComboBoxTCPChecksumOffloadIPv4 = new System.Windows.Forms.ComboBox();
            this.ComboBoxTCPChecksumOffloadIPv6 = new System.Windows.Forms.ComboBox();
            this.NumericUpDownTransmitBuffers = new System.Windows.Forms.NumericUpDown();
            this.ComboBoxUDPChecksumOffloadIPv4 = new System.Windows.Forms.ComboBox();
            this.ComboBoxUDPChecksumOffloadIPv6 = new System.Windows.Forms.ComboBox();
            this.ComboBoxWOLAndShutdownLinkSpeed = new System.Windows.Forms.ComboBox();
            this.ButtonRevertSettings = new System.Windows.Forms.Button();
            this.ButtonLoadRecommendedSettings = new System.Windows.Forms.Button();
            this.ListBoxSettings = new System.Windows.Forms.ListBox();
            this.LabelValue = new System.Windows.Forms.Label();
            this.LabelSetting = new System.Windows.Forms.Label();
            this.ButtonDisableAllPowerSaving = new System.Windows.Forms.Button();
            this.GroupBoxIPv4Settings = new System.Windows.Forms.GroupBox();
            this.ComboBoxOutline2 = new System.Windows.Forms.Panel();
            this.LabelConnectionName = new System.Windows.Forms.Label();
            this.CheckBoxIP = new System.Windows.Forms.CheckBox();
            this.GroupBoxNetworkAdapterSettings = new System.Windows.Forms.GroupBox();
            this.ButtonApplyExtraNetworkTweaks = new System.Windows.Forms.Button();
            this.ComboBoxOutline = new System.Windows.Forms.Panel();
            this.ComboBoxOutline1 = new System.Windows.Forms.Panel();
            this.ComboBoxAdapterName = new System.Windows.Forms.ComboBox();
            this.LabelAdapterName = new System.Windows.Forms.Label();
            this.Titlebar = new System.Windows.Forms.Panel();
            this.Titlebar_Label = new System.Windows.Forms.Label();
            this.Titlebar_Close = new System.Windows.Forms.Button();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownReceiveBuffers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownTransmitBuffers)).BeginInit();
            this.GroupBoxIPv4Settings.SuspendLayout();
            this.ComboBoxOutline2.SuspendLayout();
            this.GroupBoxNetworkAdapterSettings.SuspendLayout();
            this.ComboBoxOutline.SuspendLayout();
            this.ComboBoxOutline1.SuspendLayout();
            this.Titlebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(72)))));
            this.ButtonCancel.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ButtonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCancel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCancel.ForeColor = System.Drawing.Color.White;
            this.ButtonCancel.Location = new System.Drawing.Point(342, 626);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(75, 23);
            this.ButtonCancel.TabIndex = 46;
            this.ButtonCancel.Text = "Cancel";
            this.ButtonCancel.UseVisualStyleBackColor = false;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // ButtonOK
            // 
            this.ButtonOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(72)))));
            this.ButtonOK.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ButtonOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonOK.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonOK.ForeColor = System.Drawing.Color.White;
            this.ButtonOK.Location = new System.Drawing.Point(261, 626);
            this.ButtonOK.Name = "ButtonOK";
            this.ButtonOK.Size = new System.Drawing.Size(75, 23);
            this.ButtonOK.TabIndex = 45;
            this.ButtonOK.Text = "OK";
            this.ButtonOK.UseVisualStyleBackColor = false;
            this.ButtonOK.Click += new System.EventHandler(this.ButtonOK_Click);
            // 
            // ButtonLoadAllAddresses
            // 
            this.ButtonLoadAllAddresses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(72)))));
            this.ButtonLoadAllAddresses.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ButtonLoadAllAddresses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonLoadAllAddresses.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonLoadAllAddresses.ForeColor = System.Drawing.Color.White;
            this.ButtonLoadAllAddresses.Location = new System.Drawing.Point(9, 187);
            this.ButtonLoadAllAddresses.Name = "ButtonLoadAllAddresses";
            this.ButtonLoadAllAddresses.Size = new System.Drawing.Size(121, 23);
            this.ButtonLoadAllAddresses.TabIndex = 81;
            this.ButtonLoadAllAddresses.Text = "Load all addresses\r\n";
            this.ToolTip.SetToolTip(this.ButtonLoadAllAddresses, "Load IP, subnet mask, default gateway and DNS addresses.");
            this.ButtonLoadAllAddresses.UseVisualStyleBackColor = false;
            this.ButtonLoadAllAddresses.Click += new System.EventHandler(this.ButtonLoadAllAddresses_Click);
            // 
            // ComboBoxConnectionName
            // 
            this.ComboBoxConnectionName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(72)))));
            this.ComboBoxConnectionName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBoxConnectionName.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxConnectionName.ForeColor = System.Drawing.Color.White;
            this.ComboBoxConnectionName.FormattingEnabled = true;
            this.ComboBoxConnectionName.Location = new System.Drawing.Point(-1, -1);
            this.ComboBoxConnectionName.Name = "ComboBoxConnectionName";
            this.ComboBoxConnectionName.Size = new System.Drawing.Size(141, 21);
            this.ComboBoxConnectionName.TabIndex = 24;
            this.ToolTip.SetToolTip(this.ComboBoxConnectionName, "Select the connection name to change IPv4 settings on.");
            this.ComboBoxConnectionName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ComboBoxConnectionName_KeyPress);
            // 
            // TextBoxDNS2Address
            // 
            this.TextBoxDNS2Address.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(72)))));
            this.TextBoxDNS2Address.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxDNS2Address.Enabled = false;
            this.TextBoxDNS2Address.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxDNS2Address.ForeColor = System.Drawing.Color.White;
            this.TextBoxDNS2Address.Location = new System.Drawing.Point(227, 164);
            this.TextBoxDNS2Address.Name = "TextBoxDNS2Address";
            this.TextBoxDNS2Address.Size = new System.Drawing.Size(169, 22);
            this.TextBoxDNS2Address.TabIndex = 23;
            // 
            // TextBoxDNS1Address
            // 
            this.TextBoxDNS1Address.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(72)))));
            this.TextBoxDNS1Address.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxDNS1Address.Enabled = false;
            this.TextBoxDNS1Address.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxDNS1Address.ForeColor = System.Drawing.Color.White;
            this.TextBoxDNS1Address.Location = new System.Drawing.Point(227, 138);
            this.TextBoxDNS1Address.Name = "TextBoxDNS1Address";
            this.TextBoxDNS1Address.Size = new System.Drawing.Size(169, 22);
            this.TextBoxDNS1Address.TabIndex = 22;
            // 
            // TextBoxDefaultGatewayAddress
            // 
            this.TextBoxDefaultGatewayAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(72)))));
            this.TextBoxDefaultGatewayAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxDefaultGatewayAddress.Enabled = false;
            this.TextBoxDefaultGatewayAddress.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxDefaultGatewayAddress.ForeColor = System.Drawing.Color.White;
            this.TextBoxDefaultGatewayAddress.Location = new System.Drawing.Point(227, 112);
            this.TextBoxDefaultGatewayAddress.Name = "TextBoxDefaultGatewayAddress";
            this.TextBoxDefaultGatewayAddress.Size = new System.Drawing.Size(169, 22);
            this.TextBoxDefaultGatewayAddress.TabIndex = 19;
            // 
            // TextBoxSubnetMaskAddress
            // 
            this.TextBoxSubnetMaskAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(72)))));
            this.TextBoxSubnetMaskAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxSubnetMaskAddress.Enabled = false;
            this.TextBoxSubnetMaskAddress.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxSubnetMaskAddress.ForeColor = System.Drawing.Color.White;
            this.TextBoxSubnetMaskAddress.Location = new System.Drawing.Point(227, 86);
            this.TextBoxSubnetMaskAddress.Name = "TextBoxSubnetMaskAddress";
            this.TextBoxSubnetMaskAddress.Size = new System.Drawing.Size(169, 22);
            this.TextBoxSubnetMaskAddress.TabIndex = 17;
            // 
            // TextBoxIPAddress
            // 
            this.TextBoxIPAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(72)))));
            this.TextBoxIPAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxIPAddress.Enabled = false;
            this.TextBoxIPAddress.ForeColor = System.Drawing.Color.White;
            this.TextBoxIPAddress.Location = new System.Drawing.Point(227, 59);
            this.TextBoxIPAddress.Name = "TextBoxIPAddress";
            this.TextBoxIPAddress.Size = new System.Drawing.Size(169, 22);
            this.TextBoxIPAddress.TabIndex = 15;
            // 
            // CheckBoxDNS2
            // 
            this.CheckBoxDNS2.AutoSize = true;
            this.CheckBoxDNS2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(75)))), ((int)(((byte)(87)))));
            this.CheckBoxDNS2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.CheckBoxDNS2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckBoxDNS2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBoxDNS2.ForeColor = System.Drawing.Color.White;
            this.CheckBoxDNS2.Location = new System.Drawing.Point(9, 164);
            this.CheckBoxDNS2.Name = "CheckBoxDNS2";
            this.CheckBoxDNS2.Size = new System.Drawing.Size(205, 17);
            this.CheckBoxDNS2.TabIndex = 21;
            this.CheckBoxDNS2.Text = "Custom static secondary DNS server";
            this.CheckBoxDNS2.UseVisualStyleBackColor = false;
            this.CheckBoxDNS2.CheckedChanged += new System.EventHandler(this.CheckBoxDNS2_CheckedChanged);
            // 
            // CheckBoxDNS1
            // 
            this.CheckBoxDNS1.AutoSize = true;
            this.CheckBoxDNS1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(75)))), ((int)(((byte)(87)))));
            this.CheckBoxDNS1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.CheckBoxDNS1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckBoxDNS1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBoxDNS1.ForeColor = System.Drawing.Color.White;
            this.CheckBoxDNS1.Location = new System.Drawing.Point(9, 138);
            this.CheckBoxDNS1.Name = "CheckBoxDNS1";
            this.CheckBoxDNS1.Size = new System.Drawing.Size(191, 17);
            this.CheckBoxDNS1.TabIndex = 20;
            this.CheckBoxDNS1.Text = "Custom static primary DNS server";
            this.CheckBoxDNS1.UseVisualStyleBackColor = false;
            this.CheckBoxDNS1.CheckedChanged += new System.EventHandler(this.CheckBoxDNS1_CheckedChanged);
            // 
            // CheckBoxDefaultGateway
            // 
            this.CheckBoxDefaultGateway.AutoSize = true;
            this.CheckBoxDefaultGateway.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(75)))), ((int)(((byte)(87)))));
            this.CheckBoxDefaultGateway.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.CheckBoxDefaultGateway.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckBoxDefaultGateway.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBoxDefaultGateway.ForeColor = System.Drawing.Color.White;
            this.CheckBoxDefaultGateway.Location = new System.Drawing.Point(9, 112);
            this.CheckBoxDefaultGateway.Name = "CheckBoxDefaultGateway";
            this.CheckBoxDefaultGateway.Size = new System.Drawing.Size(178, 17);
            this.CheckBoxDefaultGateway.TabIndex = 18;
            this.CheckBoxDefaultGateway.Text = "Custom static default gateway";
            this.CheckBoxDefaultGateway.UseVisualStyleBackColor = false;
            this.CheckBoxDefaultGateway.CheckedChanged += new System.EventHandler(this.CheckBoxDefaultGateway_CheckedChanged);
            // 
            // CheckBoxSubnetMask
            // 
            this.CheckBoxSubnetMask.AutoSize = true;
            this.CheckBoxSubnetMask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(75)))), ((int)(((byte)(87)))));
            this.CheckBoxSubnetMask.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.CheckBoxSubnetMask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckBoxSubnetMask.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBoxSubnetMask.ForeColor = System.Drawing.Color.White;
            this.CheckBoxSubnetMask.Location = new System.Drawing.Point(9, 86);
            this.CheckBoxSubnetMask.Name = "CheckBoxSubnetMask";
            this.CheckBoxSubnetMask.Size = new System.Drawing.Size(160, 17);
            this.CheckBoxSubnetMask.TabIndex = 16;
            this.CheckBoxSubnetMask.Text = "Custom static subnet mask";
            this.CheckBoxSubnetMask.UseVisualStyleBackColor = false;
            this.CheckBoxSubnetMask.CheckedChanged += new System.EventHandler(this.CheckBoxSubnetMask_CheckedChanged);
            // 
            // ComboBoxPacketPriorityAndVLAN
            // 
            this.ComboBoxPacketPriorityAndVLAN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(72)))));
            this.ComboBoxPacketPriorityAndVLAN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBoxPacketPriorityAndVLAN.ForeColor = System.Drawing.Color.White;
            this.ComboBoxPacketPriorityAndVLAN.FormattingEnabled = true;
            this.ComboBoxPacketPriorityAndVLAN.Items.AddRange(new object[] {
            "Packet Priority & VLAN Disabled",
            "Packet Priority & VLAN Enabled",
            "Packet Priority Enabled",
            "VLAN Enabled"});
            this.ComboBoxPacketPriorityAndVLAN.Location = new System.Drawing.Point(-1, -1);
            this.ComboBoxPacketPriorityAndVLAN.Name = "ComboBoxPacketPriorityAndVLAN";
            this.ComboBoxPacketPriorityAndVLAN.Size = new System.Drawing.Size(138, 21);
            this.ComboBoxPacketPriorityAndVLAN.TabIndex = 91;
            this.ComboBoxPacketPriorityAndVLAN.Text = "Packet Priority & VLAN Disabled";
            this.ComboBoxPacketPriorityAndVLAN.Visible = false;
            this.ComboBoxPacketPriorityAndVLAN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ComboBoxPacketPriorityAndVLAN_KeyPress);
            // 
            // ComboBoxJumboPacket
            // 
            this.ComboBoxJumboPacket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(72)))));
            this.ComboBoxJumboPacket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBoxJumboPacket.ForeColor = System.Drawing.Color.White;
            this.ComboBoxJumboPacket.FormattingEnabled = true;
            this.ComboBoxJumboPacket.Items.AddRange(new object[] {
            "4088 Bytes",
            "9014 Bytes",
            "Disabled"});
            this.ComboBoxJumboPacket.Location = new System.Drawing.Point(-1, -1);
            this.ComboBoxJumboPacket.Name = "ComboBoxJumboPacket";
            this.ComboBoxJumboPacket.Size = new System.Drawing.Size(138, 21);
            this.ComboBoxJumboPacket.TabIndex = 88;
            this.ComboBoxJumboPacket.Text = "Disabled";
            this.ComboBoxJumboPacket.Visible = false;
            this.ComboBoxJumboPacket.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ComboBoxJumboPacket_KeyPress);
            // 
            // ComboBoxInterruptModerationRate
            // 
            this.ComboBoxInterruptModerationRate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(72)))));
            this.ComboBoxInterruptModerationRate.Enabled = false;
            this.ComboBoxInterruptModerationRate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBoxInterruptModerationRate.ForeColor = System.Drawing.Color.White;
            this.ComboBoxInterruptModerationRate.FormattingEnabled = true;
            this.ComboBoxInterruptModerationRate.Items.AddRange(new object[] {
            "Off",
            "Minimal",
            "Low",
            "Medium",
            "High",
            "Extreme",
            "Adaptive"});
            this.ComboBoxInterruptModerationRate.Location = new System.Drawing.Point(-1, -1);
            this.ComboBoxInterruptModerationRate.Name = "ComboBoxInterruptModerationRate";
            this.ComboBoxInterruptModerationRate.Size = new System.Drawing.Size(138, 21);
            this.ComboBoxInterruptModerationRate.TabIndex = 87;
            this.ComboBoxInterruptModerationRate.Text = "Disabled";
            this.ComboBoxInterruptModerationRate.Visible = false;
            this.ComboBoxInterruptModerationRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ComboBoxInterruptModerationRate_KeyPress);
            // 
            // ComboBoxGigabitMasterSlaveMode
            // 
            this.ComboBoxGigabitMasterSlaveMode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(72)))));
            this.ComboBoxGigabitMasterSlaveMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBoxGigabitMasterSlaveMode.ForeColor = System.Drawing.Color.White;
            this.ComboBoxGigabitMasterSlaveMode.FormattingEnabled = true;
            this.ComboBoxGigabitMasterSlaveMode.Items.AddRange(new object[] {
            "Auto Detect",
            "Force Master Mode",
            "Force Slave Mode"});
            this.ComboBoxGigabitMasterSlaveMode.Location = new System.Drawing.Point(-1, -1);
            this.ComboBoxGigabitMasterSlaveMode.Name = "ComboBoxGigabitMasterSlaveMode";
            this.ComboBoxGigabitMasterSlaveMode.Size = new System.Drawing.Size(138, 21);
            this.ComboBoxGigabitMasterSlaveMode.TabIndex = 86;
            this.ComboBoxGigabitMasterSlaveMode.Text = "Disabled";
            this.ComboBoxGigabitMasterSlaveMode.Visible = false;
            this.ComboBoxGigabitMasterSlaveMode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ComboBoxGigabitMasterSlaveMode_KeyPress);
            // 
            // ComboBoxQoSTimerResolution
            // 
            this.ComboBoxQoSTimerResolution.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(72)))));
            this.ComboBoxQoSTimerResolution.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBoxQoSTimerResolution.ForeColor = System.Drawing.Color.White;
            this.ComboBoxQoSTimerResolution.FormattingEnabled = true;
            this.ComboBoxQoSTimerResolution.Items.AddRange(new object[] {
            "1ms",
            "2ms",
            "3ms",
            "4ms",
            "5ms",
            "6ms",
            "7ms",
            "8ms",
            "9ms",
            "10ms",
            "11ms",
            "12ms",
            "13ms",
            "14ms",
            "15ms",
            "16ms",
            "17ms",
            "18ms",
            "19ms",
            "20ms (default)"});
            this.ComboBoxQoSTimerResolution.Location = new System.Drawing.Point(-1, -1);
            this.ComboBoxQoSTimerResolution.Name = "ComboBoxQoSTimerResolution";
            this.ComboBoxQoSTimerResolution.Size = new System.Drawing.Size(138, 21);
            this.ComboBoxQoSTimerResolution.TabIndex = 82;
            this.ComboBoxQoSTimerResolution.Text = "1ms";
            this.ComboBoxQoSTimerResolution.Visible = false;
            this.ComboBoxQoSTimerResolution.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ComboBoxQoSTimerResolution_KeyPress);
            // 
            // ComboBoxTCPReceiveWindowAutotuning
            // 
            this.ComboBoxTCPReceiveWindowAutotuning.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(72)))));
            this.ComboBoxTCPReceiveWindowAutotuning.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBoxTCPReceiveWindowAutotuning.ForeColor = System.Drawing.Color.White;
            this.ComboBoxTCPReceiveWindowAutotuning.FormattingEnabled = true;
            this.ComboBoxTCPReceiveWindowAutotuning.Items.AddRange(new object[] {
            "Disabled",
            "Normal",
            "Restricted",
            "Experimental"});
            this.ComboBoxTCPReceiveWindowAutotuning.Location = new System.Drawing.Point(-1, -1);
            this.ComboBoxTCPReceiveWindowAutotuning.Name = "ComboBoxTCPReceiveWindowAutotuning";
            this.ComboBoxTCPReceiveWindowAutotuning.Size = new System.Drawing.Size(138, 21);
            this.ComboBoxTCPReceiveWindowAutotuning.TabIndex = 81;
            this.ComboBoxTCPReceiveWindowAutotuning.Text = "Disabled";
            this.ComboBoxTCPReceiveWindowAutotuning.Visible = false;
            this.ComboBoxTCPReceiveWindowAutotuning.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ComboBoxTCPReceiveWindowAutotuning_KeyPress);
            // 
            // ComboBoxInterruptModeration
            // 
            this.ComboBoxInterruptModeration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(72)))));
            this.ComboBoxInterruptModeration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBoxInterruptModeration.ForeColor = System.Drawing.Color.White;
            this.ComboBoxInterruptModeration.FormattingEnabled = true;
            this.ComboBoxInterruptModeration.Items.AddRange(new object[] {
            "Disabled",
            "Enabled"});
            this.ComboBoxInterruptModeration.Location = new System.Drawing.Point(-1, -1);
            this.ComboBoxInterruptModeration.Name = "ComboBoxInterruptModeration";
            this.ComboBoxInterruptModeration.Size = new System.Drawing.Size(138, 21);
            this.ComboBoxInterruptModeration.TabIndex = 57;
            this.ComboBoxInterruptModeration.Text = "Enabled";
            this.ComboBoxInterruptModeration.Visible = false;
            this.ComboBoxInterruptModeration.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ComboBoxInterruptModeration_KeyPress);
            // 
            // ComboBoxIPv4ChecksumOffload
            // 
            this.ComboBoxIPv4ChecksumOffload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(72)))));
            this.ComboBoxIPv4ChecksumOffload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBoxIPv4ChecksumOffload.ForeColor = System.Drawing.Color.White;
            this.ComboBoxIPv4ChecksumOffload.FormattingEnabled = true;
            this.ComboBoxIPv4ChecksumOffload.Items.AddRange(new object[] {
            "Disabled",
            "Rx & Tx Enabled",
            "Rx Enabled",
            "Tx Enabled"});
            this.ComboBoxIPv4ChecksumOffload.Location = new System.Drawing.Point(-1, -1);
            this.ComboBoxIPv4ChecksumOffload.Name = "ComboBoxIPv4ChecksumOffload";
            this.ComboBoxIPv4ChecksumOffload.Size = new System.Drawing.Size(138, 21);
            this.ComboBoxIPv4ChecksumOffload.TabIndex = 58;
            this.ComboBoxIPv4ChecksumOffload.Text = "Rx & Tx Enabled";
            this.ComboBoxIPv4ChecksumOffload.Visible = false;
            this.ComboBoxIPv4ChecksumOffload.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ComboBoxIPv4ChecksumOffload_KeyPress);
            // 
            // ComboBoxJumboFrame
            // 
            this.ComboBoxJumboFrame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(72)))));
            this.ComboBoxJumboFrame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBoxJumboFrame.ForeColor = System.Drawing.Color.White;
            this.ComboBoxJumboFrame.FormattingEnabled = true;
            this.ComboBoxJumboFrame.Items.AddRange(new object[] {
            "4088 Bytes",
            "9014 Bytes",
            "Disabled"});
            this.ComboBoxJumboFrame.Location = new System.Drawing.Point(-1, -1);
            this.ComboBoxJumboFrame.Name = "ComboBoxJumboFrame";
            this.ComboBoxJumboFrame.Size = new System.Drawing.Size(138, 21);
            this.ComboBoxJumboFrame.TabIndex = 59;
            this.ComboBoxJumboFrame.Text = "Disabled";
            this.ComboBoxJumboFrame.Visible = false;
            this.ComboBoxJumboFrame.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ComboBoxJumboFrame_KeyPress);
            // 
            // ComboBoxLargeSendOffloadv2IPv4
            // 
            this.ComboBoxLargeSendOffloadv2IPv4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(72)))));
            this.ComboBoxLargeSendOffloadv2IPv4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBoxLargeSendOffloadv2IPv4.ForeColor = System.Drawing.Color.White;
            this.ComboBoxLargeSendOffloadv2IPv4.FormattingEnabled = true;
            this.ComboBoxLargeSendOffloadv2IPv4.Items.AddRange(new object[] {
            "Disabled",
            "Enabled"});
            this.ComboBoxLargeSendOffloadv2IPv4.Location = new System.Drawing.Point(-1, -1);
            this.ComboBoxLargeSendOffloadv2IPv4.Name = "ComboBoxLargeSendOffloadv2IPv4";
            this.ComboBoxLargeSendOffloadv2IPv4.Size = new System.Drawing.Size(138, 21);
            this.ComboBoxLargeSendOffloadv2IPv4.TabIndex = 60;
            this.ComboBoxLargeSendOffloadv2IPv4.Text = "Disabled";
            this.ComboBoxLargeSendOffloadv2IPv4.Visible = false;
            this.ComboBoxLargeSendOffloadv2IPv4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ComboBoxLargeSendOffloadv2IPv4_KeyPress);
            // 
            // ComboBoxLargeSendOffloadv2IPv6
            // 
            this.ComboBoxLargeSendOffloadv2IPv6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(72)))));
            this.ComboBoxLargeSendOffloadv2IPv6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBoxLargeSendOffloadv2IPv6.ForeColor = System.Drawing.Color.White;
            this.ComboBoxLargeSendOffloadv2IPv6.FormattingEnabled = true;
            this.ComboBoxLargeSendOffloadv2IPv6.Items.AddRange(new object[] {
            "Disabled",
            "Enabled"});
            this.ComboBoxLargeSendOffloadv2IPv6.Location = new System.Drawing.Point(-1, -1);
            this.ComboBoxLargeSendOffloadv2IPv6.Name = "ComboBoxLargeSendOffloadv2IPv6";
            this.ComboBoxLargeSendOffloadv2IPv6.Size = new System.Drawing.Size(138, 21);
            this.ComboBoxLargeSendOffloadv2IPv6.TabIndex = 61;
            this.ComboBoxLargeSendOffloadv2IPv6.Text = "Disabled";
            this.ComboBoxLargeSendOffloadv2IPv6.Visible = false;
            this.ComboBoxLargeSendOffloadv2IPv6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ComboBoxLargeSendOffloadv2IPv6_KeyPress);
            // 
            // ComboBoxMaximumNumberOfRSSQueues
            // 
            this.ComboBoxMaximumNumberOfRSSQueues.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(72)))));
            this.ComboBoxMaximumNumberOfRSSQueues.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBoxMaximumNumberOfRSSQueues.ForeColor = System.Drawing.Color.White;
            this.ComboBoxMaximumNumberOfRSSQueues.FormattingEnabled = true;
            this.ComboBoxMaximumNumberOfRSSQueues.Items.AddRange(new object[] {
            "1 Queue",
            "2 Queues",
            "3 Queues",
            "4 Queues",
            "5 Queues",
            "6 Queues",
            "7 Queues",
            "8 Queues"});
            this.ComboBoxMaximumNumberOfRSSQueues.Location = new System.Drawing.Point(-1, -1);
            this.ComboBoxMaximumNumberOfRSSQueues.Name = "ComboBoxMaximumNumberOfRSSQueues";
            this.ComboBoxMaximumNumberOfRSSQueues.Size = new System.Drawing.Size(138, 21);
            this.ComboBoxMaximumNumberOfRSSQueues.TabIndex = 62;
            this.ComboBoxMaximumNumberOfRSSQueues.Text = "2 Queues";
            this.ComboBoxMaximumNumberOfRSSQueues.Visible = false;
            this.ComboBoxMaximumNumberOfRSSQueues.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ComboBoxMaximumNumberOfRSSQueues_KeyPress);
            // 
            // ComboBoxPriorityAndVLAN
            // 
            this.ComboBoxPriorityAndVLAN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(72)))));
            this.ComboBoxPriorityAndVLAN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBoxPriorityAndVLAN.ForeColor = System.Drawing.Color.White;
            this.ComboBoxPriorityAndVLAN.FormattingEnabled = true;
            this.ComboBoxPriorityAndVLAN.Items.AddRange(new object[] {
            "Priority & VLAN Disabled",
            "Priority & VLAN Enabled",
            "Priority Enabled",
            "VLAN Enabled"});
            this.ComboBoxPriorityAndVLAN.Location = new System.Drawing.Point(-1, -1);
            this.ComboBoxPriorityAndVLAN.Name = "ComboBoxPriorityAndVLAN";
            this.ComboBoxPriorityAndVLAN.Size = new System.Drawing.Size(138, 21);
            this.ComboBoxPriorityAndVLAN.TabIndex = 65;
            this.ComboBoxPriorityAndVLAN.Text = "Priority & VLAN Disabled";
            this.ComboBoxPriorityAndVLAN.Visible = false;
            this.ComboBoxPriorityAndVLAN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ComboBoxPriorityAndVLAN_KeyPress);
            // 
            // NumericUpDownReceiveBuffers
            // 
            this.NumericUpDownReceiveBuffers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(72)))));
            this.NumericUpDownReceiveBuffers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NumericUpDownReceiveBuffers.ForeColor = System.Drawing.Color.White;
            this.NumericUpDownReceiveBuffers.Increment = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.NumericUpDownReceiveBuffers.Location = new System.Drawing.Point(259, 78);
            this.NumericUpDownReceiveBuffers.Maximum = new decimal(new int[] {
            2048,
            0,
            0,
            0});
            this.NumericUpDownReceiveBuffers.Minimum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.NumericUpDownReceiveBuffers.Name = "NumericUpDownReceiveBuffers";
            this.NumericUpDownReceiveBuffers.Size = new System.Drawing.Size(138, 22);
            this.NumericUpDownReceiveBuffers.TabIndex = 67;
            this.NumericUpDownReceiveBuffers.Value = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.NumericUpDownReceiveBuffers.Visible = false;
            this.NumericUpDownReceiveBuffers.Validated += new System.EventHandler(this.NumericUpDownReceiveBuffers_Validated);
            // 
            // ComboBoxReceiveSideScaling
            // 
            this.ComboBoxReceiveSideScaling.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(72)))));
            this.ComboBoxReceiveSideScaling.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBoxReceiveSideScaling.ForeColor = System.Drawing.Color.White;
            this.ComboBoxReceiveSideScaling.FormattingEnabled = true;
            this.ComboBoxReceiveSideScaling.Items.AddRange(new object[] {
            "Disabled",
            "Enabled"});
            this.ComboBoxReceiveSideScaling.Location = new System.Drawing.Point(-1, -1);
            this.ComboBoxReceiveSideScaling.Name = "ComboBoxReceiveSideScaling";
            this.ComboBoxReceiveSideScaling.Size = new System.Drawing.Size(138, 21);
            this.ComboBoxReceiveSideScaling.TabIndex = 68;
            this.ComboBoxReceiveSideScaling.Text = "Enabled";
            this.ComboBoxReceiveSideScaling.Visible = false;
            this.ComboBoxReceiveSideScaling.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ComboBoxReceiveSideScaling_KeyPress);
            // 
            // ComboBoxRSSBaseProcessorNumber
            // 
            this.ComboBoxRSSBaseProcessorNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(72)))));
            this.ComboBoxRSSBaseProcessorNumber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBoxRSSBaseProcessorNumber.ForeColor = System.Drawing.Color.White;
            this.ComboBoxRSSBaseProcessorNumber.FormattingEnabled = true;
            this.ComboBoxRSSBaseProcessorNumber.Items.AddRange(new object[] {
            "CPU 0",
            "CPU 1",
            "CPU 2",
            "CPU 3",
            "CPU 4",
            "CPU 5",
            "CPU 6",
            "CPU 7"});
            this.ComboBoxRSSBaseProcessorNumber.Location = new System.Drawing.Point(-1, -1);
            this.ComboBoxRSSBaseProcessorNumber.Name = "ComboBoxRSSBaseProcessorNumber";
            this.ComboBoxRSSBaseProcessorNumber.Size = new System.Drawing.Size(138, 21);
            this.ComboBoxRSSBaseProcessorNumber.TabIndex = 69;
            this.ComboBoxRSSBaseProcessorNumber.Text = "CPU 1";
            this.ComboBoxRSSBaseProcessorNumber.Visible = false;
            this.ComboBoxRSSBaseProcessorNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ComboBoxRSSBaseProcessorNumber_KeyPress);
            // 
            // ComboBoxSpeedAndDuplex
            // 
            this.ComboBoxSpeedAndDuplex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(72)))));
            this.ComboBoxSpeedAndDuplex.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBoxSpeedAndDuplex.ForeColor = System.Drawing.Color.White;
            this.ComboBoxSpeedAndDuplex.FormattingEnabled = true;
            this.ComboBoxSpeedAndDuplex.Items.AddRange(new object[] {
            "1.0 Gbps Full Duplex",
            "10 Mbps Full Duplex",
            "10 Mbps Half Duplex",
            "100 Mbps Full Duplex",
            "100 Mbps Half Duplex",
            "Auto Negotiation"});
            this.ComboBoxSpeedAndDuplex.Location = new System.Drawing.Point(-1, -1);
            this.ComboBoxSpeedAndDuplex.Name = "ComboBoxSpeedAndDuplex";
            this.ComboBoxSpeedAndDuplex.Size = new System.Drawing.Size(138, 21);
            this.ComboBoxSpeedAndDuplex.TabIndex = 71;
            this.ComboBoxSpeedAndDuplex.Text = "Auto Negotiation";
            this.ComboBoxSpeedAndDuplex.Visible = false;
            this.ComboBoxSpeedAndDuplex.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ComboBoxSpeedAndDuplex_KeyPress);
            // 
            // ComboBoxTCPChecksumOffloadIPv4
            // 
            this.ComboBoxTCPChecksumOffloadIPv4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(72)))));
            this.ComboBoxTCPChecksumOffloadIPv4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBoxTCPChecksumOffloadIPv4.ForeColor = System.Drawing.Color.White;
            this.ComboBoxTCPChecksumOffloadIPv4.FormattingEnabled = true;
            this.ComboBoxTCPChecksumOffloadIPv4.Items.AddRange(new object[] {
            "Disabled",
            "Rx & Tx Enabled",
            "Rx Enabled",
            "Tx Enabled"});
            this.ComboBoxTCPChecksumOffloadIPv4.Location = new System.Drawing.Point(-1, -1);
            this.ComboBoxTCPChecksumOffloadIPv4.Name = "ComboBoxTCPChecksumOffloadIPv4";
            this.ComboBoxTCPChecksumOffloadIPv4.Size = new System.Drawing.Size(138, 21);
            this.ComboBoxTCPChecksumOffloadIPv4.TabIndex = 72;
            this.ComboBoxTCPChecksumOffloadIPv4.Text = "Disabled";
            this.ComboBoxTCPChecksumOffloadIPv4.Visible = false;
            this.ComboBoxTCPChecksumOffloadIPv4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ComboBoxTCPChecksumOffloadIPv4_KeyPress);
            // 
            // ComboBoxTCPChecksumOffloadIPv6
            // 
            this.ComboBoxTCPChecksumOffloadIPv6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(72)))));
            this.ComboBoxTCPChecksumOffloadIPv6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBoxTCPChecksumOffloadIPv6.ForeColor = System.Drawing.Color.White;
            this.ComboBoxTCPChecksumOffloadIPv6.FormattingEnabled = true;
            this.ComboBoxTCPChecksumOffloadIPv6.Items.AddRange(new object[] {
            "Disabled",
            "Rx & Tx Enabled",
            "Rx Enabled",
            "Tx Enabled"});
            this.ComboBoxTCPChecksumOffloadIPv6.Location = new System.Drawing.Point(-1, -1);
            this.ComboBoxTCPChecksumOffloadIPv6.Name = "ComboBoxTCPChecksumOffloadIPv6";
            this.ComboBoxTCPChecksumOffloadIPv6.Size = new System.Drawing.Size(138, 21);
            this.ComboBoxTCPChecksumOffloadIPv6.TabIndex = 73;
            this.ComboBoxTCPChecksumOffloadIPv6.Text = "Disabled";
            this.ComboBoxTCPChecksumOffloadIPv6.Visible = false;
            this.ComboBoxTCPChecksumOffloadIPv6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ComboBoxTCPChecksumOffloadIPv6_KeyPress);
            // 
            // NumericUpDownTransmitBuffers
            // 
            this.NumericUpDownTransmitBuffers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(72)))));
            this.NumericUpDownTransmitBuffers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NumericUpDownTransmitBuffers.ForeColor = System.Drawing.Color.White;
            this.NumericUpDownTransmitBuffers.Increment = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.NumericUpDownTransmitBuffers.Location = new System.Drawing.Point(259, 78);
            this.NumericUpDownTransmitBuffers.Maximum = new decimal(new int[] {
            2048,
            0,
            0,
            0});
            this.NumericUpDownTransmitBuffers.Minimum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.NumericUpDownTransmitBuffers.Name = "NumericUpDownTransmitBuffers";
            this.NumericUpDownTransmitBuffers.Size = new System.Drawing.Size(137, 22);
            this.NumericUpDownTransmitBuffers.TabIndex = 74;
            this.NumericUpDownTransmitBuffers.Value = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.NumericUpDownTransmitBuffers.Visible = false;
            this.NumericUpDownTransmitBuffers.Validated += new System.EventHandler(this.NumericUpDownTransmitBuffers_Validated);
            // 
            // ComboBoxUDPChecksumOffloadIPv4
            // 
            this.ComboBoxUDPChecksumOffloadIPv4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(72)))));
            this.ComboBoxUDPChecksumOffloadIPv4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBoxUDPChecksumOffloadIPv4.ForeColor = System.Drawing.Color.White;
            this.ComboBoxUDPChecksumOffloadIPv4.FormattingEnabled = true;
            this.ComboBoxUDPChecksumOffloadIPv4.Items.AddRange(new object[] {
            "Disabled",
            "Rx & Tx Enabled",
            "Rx Enabled",
            "Tx Enabled"});
            this.ComboBoxUDPChecksumOffloadIPv4.Location = new System.Drawing.Point(-1, -1);
            this.ComboBoxUDPChecksumOffloadIPv4.Name = "ComboBoxUDPChecksumOffloadIPv4";
            this.ComboBoxUDPChecksumOffloadIPv4.Size = new System.Drawing.Size(138, 21);
            this.ComboBoxUDPChecksumOffloadIPv4.TabIndex = 75;
            this.ComboBoxUDPChecksumOffloadIPv4.Text = "Rx & Tx Enabled";
            this.ComboBoxUDPChecksumOffloadIPv4.Visible = false;
            this.ComboBoxUDPChecksumOffloadIPv4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ComboBoxUDPChecksumOffloadIPv4_KeyPress);
            // 
            // ComboBoxUDPChecksumOffloadIPv6
            // 
            this.ComboBoxUDPChecksumOffloadIPv6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(72)))));
            this.ComboBoxUDPChecksumOffloadIPv6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBoxUDPChecksumOffloadIPv6.ForeColor = System.Drawing.Color.White;
            this.ComboBoxUDPChecksumOffloadIPv6.FormattingEnabled = true;
            this.ComboBoxUDPChecksumOffloadIPv6.Items.AddRange(new object[] {
            "Disabled",
            "Rx & Tx Enabled",
            "Rx Enabled",
            "Tx Enabled"});
            this.ComboBoxUDPChecksumOffloadIPv6.Location = new System.Drawing.Point(-1, -1);
            this.ComboBoxUDPChecksumOffloadIPv6.Name = "ComboBoxUDPChecksumOffloadIPv6";
            this.ComboBoxUDPChecksumOffloadIPv6.Size = new System.Drawing.Size(138, 21);
            this.ComboBoxUDPChecksumOffloadIPv6.TabIndex = 76;
            this.ComboBoxUDPChecksumOffloadIPv6.Text = "Rx & Tx Enabled";
            this.ComboBoxUDPChecksumOffloadIPv6.Visible = false;
            this.ComboBoxUDPChecksumOffloadIPv6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ComboBoxUDPChecksumOffloadIPv6_KeyPress);
            // 
            // ComboBoxWOLAndShutdownLinkSpeed
            // 
            this.ComboBoxWOLAndShutdownLinkSpeed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(72)))));
            this.ComboBoxWOLAndShutdownLinkSpeed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBoxWOLAndShutdownLinkSpeed.ForeColor = System.Drawing.Color.White;
            this.ComboBoxWOLAndShutdownLinkSpeed.FormattingEnabled = true;
            this.ComboBoxWOLAndShutdownLinkSpeed.Items.AddRange(new object[] {
            "10 Mbps First",
            "100 Mbps First",
            "Not Speed Down"});
            this.ComboBoxWOLAndShutdownLinkSpeed.Location = new System.Drawing.Point(-1, -1);
            this.ComboBoxWOLAndShutdownLinkSpeed.Name = "ComboBoxWOLAndShutdownLinkSpeed";
            this.ComboBoxWOLAndShutdownLinkSpeed.Size = new System.Drawing.Size(138, 21);
            this.ComboBoxWOLAndShutdownLinkSpeed.TabIndex = 79;
            this.ComboBoxWOLAndShutdownLinkSpeed.Text = "Not Speed Down";
            this.ComboBoxWOLAndShutdownLinkSpeed.Visible = false;
            this.ComboBoxWOLAndShutdownLinkSpeed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ComboBoxWOLAndShutdownLinkSpeed_KeyPress);
            // 
            // ButtonRevertSettings
            // 
            this.ButtonRevertSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(72)))));
            this.ButtonRevertSettings.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ButtonRevertSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonRevertSettings.Location = new System.Drawing.Point(206, 296);
            this.ButtonRevertSettings.Name = "ButtonRevertSettings";
            this.ButtonRevertSettings.Size = new System.Drawing.Size(124, 23);
            this.ButtonRevertSettings.TabIndex = 101;
            this.ButtonRevertSettings.Text = "Revert settings";
            this.ToolTip.SetToolTip(this.ButtonRevertSettings, "Reverts settings.");
            this.ButtonRevertSettings.UseVisualStyleBackColor = false;
            this.ButtonRevertSettings.Click += new System.EventHandler(this.ButtonRevertSettings_Click);
            // 
            // ButtonLoadRecommendedSettings
            // 
            this.ButtonLoadRecommendedSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(72)))));
            this.ButtonLoadRecommendedSettings.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ButtonLoadRecommendedSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonLoadRecommendedSettings.Location = new System.Drawing.Point(9, 296);
            this.ButtonLoadRecommendedSettings.Name = "ButtonLoadRecommendedSettings";
            this.ButtonLoadRecommendedSettings.Size = new System.Drawing.Size(191, 23);
            this.ButtonLoadRecommendedSettings.TabIndex = 80;
            this.ButtonLoadRecommendedSettings.Text = "Load recommended settings";
            this.ToolTip.SetToolTip(this.ButtonLoadRecommendedSettings, "Loads recommended settings.");
            this.ButtonLoadRecommendedSettings.UseVisualStyleBackColor = false;
            this.ButtonLoadRecommendedSettings.Click += new System.EventHandler(this.ButtonLoadRecommendedSettings_Click);
            // 
            // ListBoxSettings
            // 
            this.ListBoxSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(72)))));
            this.ListBoxSettings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ListBoxSettings.ForeColor = System.Drawing.Color.White;
            this.ListBoxSettings.FormattingEnabled = true;
            this.ListBoxSettings.Location = new System.Drawing.Point(9, 78);
            this.ListBoxSettings.Name = "ListBoxSettings";
            this.ListBoxSettings.Size = new System.Drawing.Size(235, 210);
            this.ListBoxSettings.TabIndex = 47;
            this.ListBoxSettings.SelectedIndexChanged += new System.EventHandler(this.ListBoxSettings_SelectedIndexChanged);
            // 
            // LabelValue
            // 
            this.LabelValue.AutoSize = true;
            this.LabelValue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LabelValue.Location = new System.Drawing.Point(6, 62);
            this.LabelValue.Name = "LabelValue";
            this.LabelValue.Size = new System.Drawing.Size(38, 13);
            this.LabelValue.TabIndex = 66;
            this.LabelValue.Text = "Value:";
            // 
            // LabelSetting
            // 
            this.LabelSetting.AutoSize = true;
            this.LabelSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LabelSetting.Location = new System.Drawing.Point(256, 62);
            this.LabelSetting.Name = "LabelSetting";
            this.LabelSetting.Size = new System.Drawing.Size(47, 13);
            this.LabelSetting.TabIndex = 48;
            this.LabelSetting.Text = "Setting:";
            // 
            // ButtonDisableAllPowerSaving
            // 
            this.ButtonDisableAllPowerSaving.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(72)))));
            this.ButtonDisableAllPowerSaving.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ButtonDisableAllPowerSaving.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonDisableAllPowerSaving.Location = new System.Drawing.Point(9, 325);
            this.ButtonDisableAllPowerSaving.Name = "ButtonDisableAllPowerSaving";
            this.ButtonDisableAllPowerSaving.Size = new System.Drawing.Size(191, 23);
            this.ButtonDisableAllPowerSaving.TabIndex = 102;
            this.ButtonDisableAllPowerSaving.Text = "Disable power saving features";
            this.ToolTip.SetToolTip(this.ButtonDisableAllPowerSaving, "Disables power saving / sleep features.");
            this.ButtonDisableAllPowerSaving.UseVisualStyleBackColor = false;
            this.ButtonDisableAllPowerSaving.Click += new System.EventHandler(this.ButtonDisableAllPowerSaving_Click);
            // 
            // GroupBoxIPv4Settings
            // 
            this.GroupBoxIPv4Settings.Controls.Add(this.ComboBoxOutline2);
            this.GroupBoxIPv4Settings.Controls.Add(this.LabelConnectionName);
            this.GroupBoxIPv4Settings.Controls.Add(this.CheckBoxIP);
            this.GroupBoxIPv4Settings.Controls.Add(this.CheckBoxDefaultGateway);
            this.GroupBoxIPv4Settings.Controls.Add(this.CheckBoxSubnetMask);
            this.GroupBoxIPv4Settings.Controls.Add(this.ButtonLoadAllAddresses);
            this.GroupBoxIPv4Settings.Controls.Add(this.CheckBoxDNS1);
            this.GroupBoxIPv4Settings.Controls.Add(this.CheckBoxDNS2);
            this.GroupBoxIPv4Settings.Controls.Add(this.TextBoxIPAddress);
            this.GroupBoxIPv4Settings.Controls.Add(this.TextBoxSubnetMaskAddress);
            this.GroupBoxIPv4Settings.Controls.Add(this.TextBoxDNS2Address);
            this.GroupBoxIPv4Settings.Controls.Add(this.TextBoxDefaultGatewayAddress);
            this.GroupBoxIPv4Settings.Controls.Add(this.TextBoxDNS1Address);
            this.GroupBoxIPv4Settings.ForeColor = System.Drawing.Color.White;
            this.GroupBoxIPv4Settings.Location = new System.Drawing.Point(12, 401);
            this.GroupBoxIPv4Settings.Name = "GroupBoxIPv4Settings";
            this.GroupBoxIPv4Settings.Size = new System.Drawing.Size(405, 219);
            this.GroupBoxIPv4Settings.TabIndex = 103;
            this.GroupBoxIPv4Settings.TabStop = false;
            this.GroupBoxIPv4Settings.Text = "IPv4 settings";
            // 
            // ComboBoxOutline2
            // 
            this.ComboBoxOutline2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ComboBoxOutline2.Controls.Add(this.ComboBoxConnectionName);
            this.ComboBoxOutline2.Location = new System.Drawing.Point(9, 32);
            this.ComboBoxOutline2.Name = "ComboBoxOutline2";
            this.ComboBoxOutline2.Size = new System.Drawing.Size(141, 21);
            this.ComboBoxOutline2.TabIndex = 110;
            // 
            // LabelConnectionName
            // 
            this.LabelConnectionName.AutoSize = true;
            this.LabelConnectionName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LabelConnectionName.Location = new System.Drawing.Point(6, 16);
            this.LabelConnectionName.Name = "LabelConnectionName";
            this.LabelConnectionName.Size = new System.Drawing.Size(101, 13);
            this.LabelConnectionName.TabIndex = 105;
            this.LabelConnectionName.Text = "Connection name:";
            // 
            // CheckBoxIP
            // 
            this.CheckBoxIP.AutoSize = true;
            this.CheckBoxIP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(75)))), ((int)(((byte)(87)))));
            this.CheckBoxIP.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.CheckBoxIP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckBoxIP.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBoxIP.ForeColor = System.Drawing.Color.White;
            this.CheckBoxIP.Location = new System.Drawing.Point(9, 59);
            this.CheckBoxIP.Name = "CheckBoxIP";
            this.CheckBoxIP.Size = new System.Drawing.Size(104, 17);
            this.CheckBoxIP.TabIndex = 14;
            this.CheckBoxIP.Text = "Custom static IP";
            this.CheckBoxIP.UseVisualStyleBackColor = false;
            this.CheckBoxIP.CheckedChanged += new System.EventHandler(this.CheckBoxIP_CheckedChanged);
            // 
            // GroupBoxNetworkAdapterSettings
            // 
            this.GroupBoxNetworkAdapterSettings.Controls.Add(this.ButtonApplyExtraNetworkTweaks);
            this.GroupBoxNetworkAdapterSettings.Controls.Add(this.NumericUpDownReceiveBuffers);
            this.GroupBoxNetworkAdapterSettings.Controls.Add(this.ComboBoxOutline);
            this.GroupBoxNetworkAdapterSettings.Controls.Add(this.ComboBoxOutline1);
            this.GroupBoxNetworkAdapterSettings.Controls.Add(this.NumericUpDownTransmitBuffers);
            this.GroupBoxNetworkAdapterSettings.Controls.Add(this.ButtonRevertSettings);
            this.GroupBoxNetworkAdapterSettings.Controls.Add(this.ButtonLoadRecommendedSettings);
            this.GroupBoxNetworkAdapterSettings.Controls.Add(this.LabelAdapterName);
            this.GroupBoxNetworkAdapterSettings.Controls.Add(this.ButtonDisableAllPowerSaving);
            this.GroupBoxNetworkAdapterSettings.Controls.Add(this.ListBoxSettings);
            this.GroupBoxNetworkAdapterSettings.Controls.Add(this.LabelValue);
            this.GroupBoxNetworkAdapterSettings.Controls.Add(this.LabelSetting);
            this.GroupBoxNetworkAdapterSettings.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBoxNetworkAdapterSettings.ForeColor = System.Drawing.Color.White;
            this.GroupBoxNetworkAdapterSettings.Location = new System.Drawing.Point(12, 37);
            this.GroupBoxNetworkAdapterSettings.Name = "GroupBoxNetworkAdapterSettings";
            this.GroupBoxNetworkAdapterSettings.Size = new System.Drawing.Size(405, 358);
            this.GroupBoxNetworkAdapterSettings.TabIndex = 104;
            this.GroupBoxNetworkAdapterSettings.TabStop = false;
            this.GroupBoxNetworkAdapterSettings.Text = "Network adapter settings";
            // 
            // ButtonApplyExtraNetworkTweaks
            // 
            this.ButtonApplyExtraNetworkTweaks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(72)))));
            this.ButtonApplyExtraNetworkTweaks.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ButtonApplyExtraNetworkTweaks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonApplyExtraNetworkTweaks.ForeColor = System.Drawing.Color.White;
            this.ButtonApplyExtraNetworkTweaks.Location = new System.Drawing.Point(206, 325);
            this.ButtonApplyExtraNetworkTweaks.Name = "ButtonApplyExtraNetworkTweaks";
            this.ButtonApplyExtraNetworkTweaks.Size = new System.Drawing.Size(124, 23);
            this.ButtonApplyExtraNetworkTweaks.TabIndex = 112;
            this.ButtonApplyExtraNetworkTweaks.Text = "Apply hitreg tweaks";
            this.ToolTip.SetToolTip(this.ButtonApplyExtraNetworkTweaks, "Applies extra network tweaks. Improves hitreg/overall network performance.");
            this.ButtonApplyExtraNetworkTweaks.UseVisualStyleBackColor = false;
            this.ButtonApplyExtraNetworkTweaks.Click += new System.EventHandler(this.ButtonApplyExtraNetworkTweaks_Click);
            // 
            // ComboBoxOutline
            // 
            this.ComboBoxOutline.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ComboBoxOutline.Controls.Add(this.ComboBoxTCPChecksumOffloadIPv6);
            this.ComboBoxOutline.Controls.Add(this.ComboBoxTCPChecksumOffloadIPv4);
            this.ComboBoxOutline.Controls.Add(this.ComboBoxUDPChecksumOffloadIPv4);
            this.ComboBoxOutline.Controls.Add(this.ComboBoxUDPChecksumOffloadIPv6);
            this.ComboBoxOutline.Controls.Add(this.ComboBoxWOLAndShutdownLinkSpeed);
            this.ComboBoxOutline.Controls.Add(this.ComboBoxJumboFrame);
            this.ComboBoxOutline.Controls.Add(this.ComboBoxPriorityAndVLAN);
            this.ComboBoxOutline.Controls.Add(this.ComboBoxRSSBaseProcessorNumber);
            this.ComboBoxOutline.Controls.Add(this.ComboBoxIPv4ChecksumOffload);
            this.ComboBoxOutline.Controls.Add(this.ComboBoxReceiveSideScaling);
            this.ComboBoxOutline.Controls.Add(this.ComboBoxGigabitMasterSlaveMode);
            this.ComboBoxOutline.Controls.Add(this.ComboBoxMaximumNumberOfRSSQueues);
            this.ComboBoxOutline.Controls.Add(this.ComboBoxInterruptModeration);
            this.ComboBoxOutline.Controls.Add(this.ComboBoxSpeedAndDuplex);
            this.ComboBoxOutline.Controls.Add(this.ComboBoxInterruptModerationRate);
            this.ComboBoxOutline.Controls.Add(this.ComboBoxPacketPriorityAndVLAN);
            this.ComboBoxOutline.Controls.Add(this.ComboBoxLargeSendOffloadv2IPv6);
            this.ComboBoxOutline.Controls.Add(this.ComboBoxTCPReceiveWindowAutotuning);
            this.ComboBoxOutline.Controls.Add(this.ComboBoxQoSTimerResolution);
            this.ComboBoxOutline.Controls.Add(this.ComboBoxLargeSendOffloadv2IPv4);
            this.ComboBoxOutline.Controls.Add(this.ComboBoxJumboPacket);
            this.ComboBoxOutline.Location = new System.Drawing.Point(259, 78);
            this.ComboBoxOutline.Name = "ComboBoxOutline";
            this.ComboBoxOutline.Size = new System.Drawing.Size(138, 21);
            this.ComboBoxOutline.TabIndex = 111;
            this.ComboBoxOutline.Visible = false;
            // 
            // ComboBoxOutline1
            // 
            this.ComboBoxOutline1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ComboBoxOutline1.Controls.Add(this.ComboBoxAdapterName);
            this.ComboBoxOutline1.Location = new System.Drawing.Point(9, 32);
            this.ComboBoxOutline1.Name = "ComboBoxOutline1";
            this.ComboBoxOutline1.Size = new System.Drawing.Size(220, 21);
            this.ComboBoxOutline1.TabIndex = 109;
            // 
            // ComboBoxAdapterName
            // 
            this.ComboBoxAdapterName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(72)))));
            this.ComboBoxAdapterName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBoxAdapterName.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxAdapterName.ForeColor = System.Drawing.Color.White;
            this.ComboBoxAdapterName.FormattingEnabled = true;
            this.ComboBoxAdapterName.Location = new System.Drawing.Point(-1, -1);
            this.ComboBoxAdapterName.Name = "ComboBoxAdapterName";
            this.ComboBoxAdapterName.Size = new System.Drawing.Size(220, 21);
            this.ComboBoxAdapterName.TabIndex = 24;
            this.ComboBoxAdapterName.Text = "Realtek PCIe 2.5GbE Family Controller";
            this.ToolTip.SetToolTip(this.ComboBoxAdapterName, "Select the adapter to change settings on.");
            this.ComboBoxAdapterName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ComboBoxAdapterName_KeyPress);
            // 
            // LabelAdapterName
            // 
            this.LabelAdapterName.AutoSize = true;
            this.LabelAdapterName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LabelAdapterName.Location = new System.Drawing.Point(6, 16);
            this.LabelAdapterName.Name = "LabelAdapterName";
            this.LabelAdapterName.Size = new System.Drawing.Size(82, 13);
            this.LabelAdapterName.TabIndex = 106;
            this.LabelAdapterName.Text = "Adapter name:";
            // 
            // Titlebar
            // 
            this.Titlebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(63)))), ((int)(((byte)(76)))));
            this.Titlebar.Controls.Add(this.Titlebar_Label);
            this.Titlebar.Controls.Add(this.Titlebar_Close);
            this.Titlebar.Location = new System.Drawing.Point(0, 0);
            this.Titlebar.Name = "Titlebar";
            this.Titlebar.Size = new System.Drawing.Size(428, 25);
            this.Titlebar.TabIndex = 111;
            this.Titlebar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Titlebar_MouseDown);
            // 
            // Titlebar_Label
            // 
            this.Titlebar_Label.AutoSize = true;
            this.Titlebar_Label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Titlebar_Label.ForeColor = System.Drawing.Color.White;
            this.Titlebar_Label.Location = new System.Drawing.Point(4, 5);
            this.Titlebar_Label.Name = "Titlebar_Label";
            this.Titlebar_Label.Size = new System.Drawing.Size(90, 13);
            this.Titlebar_Label.TabIndex = 3;
            this.Titlebar_Label.Text = "Network tweaks";
            this.Titlebar_Label.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Titlebar_MouseDown);
            // 
            // Titlebar_Close
            // 
            this.Titlebar_Close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Titlebar_Close.BackgroundImage")));
            this.Titlebar_Close.FlatAppearance.BorderSize = 0;
            this.Titlebar_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Titlebar_Close.Location = new System.Drawing.Point(410, 5);
            this.Titlebar_Close.Name = "Titlebar_Close";
            this.Titlebar_Close.Size = new System.Drawing.Size(15, 15);
            this.Titlebar_Close.TabIndex = 0;
            this.Titlebar_Close.UseVisualStyleBackColor = true;
            this.Titlebar_Close.Click += new System.EventHandler(this.Titlebar_Close_Click);
            // 
            // NetworkTweaksDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(75)))), ((int)(((byte)(87)))));
            this.ClientSize = new System.Drawing.Size(428, 662);
            this.Controls.Add(this.Titlebar);
            this.Controls.Add(this.GroupBoxNetworkAdapterSettings);
            this.Controls.Add(this.GroupBoxIPv4Settings);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonOK);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NetworkTweaksDialog";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "n";
            this.Load += new System.EventHandler(this.NetworkTweaksForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownReceiveBuffers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownTransmitBuffers)).EndInit();
            this.GroupBoxIPv4Settings.ResumeLayout(false);
            this.GroupBoxIPv4Settings.PerformLayout();
            this.ComboBoxOutline2.ResumeLayout(false);
            this.GroupBoxNetworkAdapterSettings.ResumeLayout(false);
            this.GroupBoxNetworkAdapterSettings.PerformLayout();
            this.ComboBoxOutline.ResumeLayout(false);
            this.ComboBoxOutline1.ResumeLayout(false);
            this.Titlebar.ResumeLayout(false);
            this.Titlebar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.Button ButtonOK;
        private System.Windows.Forms.Button ButtonLoadAllAddresses;
        public System.Windows.Forms.ComboBox ComboBoxConnectionName;
        public System.Windows.Forms.TextBox TextBoxDNS2Address;
        public System.Windows.Forms.TextBox TextBoxDNS1Address;
        public System.Windows.Forms.TextBox TextBoxDefaultGatewayAddress;
        public System.Windows.Forms.TextBox TextBoxSubnetMaskAddress;
        public System.Windows.Forms.TextBox TextBoxIPAddress;
        public System.Windows.Forms.CheckBox CheckBoxDNS2;
        public System.Windows.Forms.CheckBox CheckBoxDNS1;
        public System.Windows.Forms.CheckBox CheckBoxDefaultGateway;
        public System.Windows.Forms.CheckBox CheckBoxSubnetMask;
        private System.Windows.Forms.Button ButtonRevertSettings;
        private System.Windows.Forms.ComboBox ComboBoxPacketPriorityAndVLAN;
        private System.Windows.Forms.ComboBox ComboBoxJumboPacket;
        private System.Windows.Forms.ComboBox ComboBoxInterruptModerationRate;
        private System.Windows.Forms.ComboBox ComboBoxGigabitMasterSlaveMode;
        private System.Windows.Forms.ComboBox ComboBoxQoSTimerResolution;
        private System.Windows.Forms.ComboBox ComboBoxTCPReceiveWindowAutotuning;
        private System.Windows.Forms.Button ButtonLoadRecommendedSettings;
        private System.Windows.Forms.ComboBox ComboBoxInterruptModeration;
        private System.Windows.Forms.ComboBox ComboBoxIPv4ChecksumOffload;
        private System.Windows.Forms.ComboBox ComboBoxJumboFrame;
        private System.Windows.Forms.ComboBox ComboBoxLargeSendOffloadv2IPv4;
        private System.Windows.Forms.ComboBox ComboBoxLargeSendOffloadv2IPv6;
        private System.Windows.Forms.ComboBox ComboBoxMaximumNumberOfRSSQueues;
        private System.Windows.Forms.ComboBox ComboBoxPriorityAndVLAN;
        private System.Windows.Forms.NumericUpDown NumericUpDownReceiveBuffers;
        private System.Windows.Forms.ComboBox ComboBoxReceiveSideScaling;
        private System.Windows.Forms.ComboBox ComboBoxRSSBaseProcessorNumber;
        private System.Windows.Forms.ComboBox ComboBoxSpeedAndDuplex;
        private System.Windows.Forms.ComboBox ComboBoxTCPChecksumOffloadIPv4;
        private System.Windows.Forms.ComboBox ComboBoxTCPChecksumOffloadIPv6;
        private System.Windows.Forms.NumericUpDown NumericUpDownTransmitBuffers;
        private System.Windows.Forms.ComboBox ComboBoxUDPChecksumOffloadIPv4;
        private System.Windows.Forms.ComboBox ComboBoxUDPChecksumOffloadIPv6;
        private System.Windows.Forms.ComboBox ComboBoxWOLAndShutdownLinkSpeed;
        public System.Windows.Forms.ListBox ListBoxSettings;
        private System.Windows.Forms.Label LabelValue;
        private System.Windows.Forms.Label LabelSetting;
        private System.Windows.Forms.Button ButtonDisableAllPowerSaving;
        private System.Windows.Forms.GroupBox GroupBoxIPv4Settings;
        private System.Windows.Forms.GroupBox GroupBoxNetworkAdapterSettings;
        public System.Windows.Forms.ComboBox ComboBoxAdapterName;
        private System.Windows.Forms.Label LabelConnectionName;
        public System.Windows.Forms.CheckBox CheckBoxIP;
        private System.Windows.Forms.Label LabelAdapterName;
        private System.Windows.Forms.Panel ComboBoxOutline2;
        private System.Windows.Forms.Panel ComboBoxOutline1;
        private System.Windows.Forms.Panel ComboBoxOutline;
        private System.Windows.Forms.Panel Titlebar;
        private System.Windows.Forms.Label Titlebar_Label;
        private System.Windows.Forms.Button Titlebar_Close;
        private System.Windows.Forms.ToolTip ToolTip;
        public System.Windows.Forms.Button ButtonApplyExtraNetworkTweaks;
    }
}