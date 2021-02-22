namespace Auto_Tweaking_Utility
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.ButtonApplyStorageTweaks = new System.Windows.Forms.Button();
            this.ButtonDisableDefender = new System.Windows.Forms.Button();
            this.ButtonDisablePowerThrottling = new System.Windows.Forms.Button();
            this.ButtonImportATUPowerPlan = new System.Windows.Forms.Button();
            this.ButtonDisableFSO = new System.Windows.Forms.Button();
            this.ButtonNetworkTweaks = new System.Windows.Forms.Button();
            this.ButtonApplyBCDEditSettings = new System.Windows.Forms.Button();
            this.ButtonEnableClassicAltTab = new System.Windows.Forms.Button();
            this.ButtonInterruptMSITweaks = new System.Windows.Forms.Button();
            this.ButtonInstallPrograms = new System.Windows.Forms.Button();
            this.ButtonApplyKernelTweaks = new System.Windows.Forms.Button();
            this.ButtonSchedulingTweaks = new System.Windows.Forms.Button();
            this.ButtonApplyMemoryTweaks = new System.Windows.Forms.Button();
            this.ButtonServicesTweaks = new System.Windows.Forms.Button();
            this.ButtonInstallRuntimes = new System.Windows.Forms.Button();
            this.ButtonDisableFTH = new System.Windows.Forms.Button();
            this.ButtonDisableDrivers = new System.Windows.Forms.Button();
            this.ButtonApplyVisualFxTweaks = new System.Windows.Forms.Button();
            this.ButtonDeleteMicrocode = new System.Windows.Forms.Button();
            this.ButtonDebloatWindows10 = new System.Windows.Forms.Button();
            this.Titlebar_Close = new System.Windows.Forms.Button();
            this.Titlebar_Minimize = new System.Windows.Forms.Button();
            this.Titlebar_Label = new System.Windows.Forms.Label();
            this.Titlebar = new System.Windows.Forms.Panel();
            this.DebloatTimer = new System.Windows.Forms.Timer(this.components);
            this.Tab_Main = new System.Windows.Forms.Panel();
            this.Titlebar.SuspendLayout();
            this.Tab_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonApplyStorageTweaks
            // 
            this.ButtonApplyStorageTweaks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(72)))));
            this.ButtonApplyStorageTweaks.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ButtonApplyStorageTweaks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonApplyStorageTweaks.ForeColor = System.Drawing.Color.White;
            this.ButtonApplyStorageTweaks.Location = new System.Drawing.Point(180, 118);
            this.ButtonApplyStorageTweaks.Name = "ButtonApplyStorageTweaks";
            this.ButtonApplyStorageTweaks.Size = new System.Drawing.Size(160, 46);
            this.ButtonApplyStorageTweaks.TabIndex = 19;
            this.ButtonApplyStorageTweaks.Text = "Apply storage tweaks";
            this.ToolTip.SetToolTip(this.ButtonApplyStorageTweaks, "Applies storage tweaks, improves storage performance.");
            this.ButtonApplyStorageTweaks.UseVisualStyleBackColor = false;
            this.ButtonApplyStorageTweaks.Click += new System.EventHandler(this.ButtonApplyStorageTweaks_Click);
            // 
            // ButtonDisableDefender
            // 
            this.ButtonDisableDefender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(72)))));
            this.ButtonDisableDefender.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ButtonDisableDefender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonDisableDefender.ForeColor = System.Drawing.Color.White;
            this.ButtonDisableDefender.Location = new System.Drawing.Point(12, 118);
            this.ButtonDisableDefender.Name = "ButtonDisableDefender";
            this.ButtonDisableDefender.Size = new System.Drawing.Size(160, 46);
            this.ButtonDisableDefender.TabIndex = 22;
            this.ButtonDisableDefender.Text = "Disable security features";
            this.ToolTip.SetToolTip(this.ButtonDisableDefender, "Disables security related features. Improves latency/performance/smoothness.");
            this.ButtonDisableDefender.UseVisualStyleBackColor = false;
            this.ButtonDisableDefender.Click += new System.EventHandler(this.ButtonDisableDefender_Click);
            // 
            // ButtonDisablePowerThrottling
            // 
            this.ButtonDisablePowerThrottling.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(72)))));
            this.ButtonDisablePowerThrottling.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ButtonDisablePowerThrottling.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonDisablePowerThrottling.ForeColor = System.Drawing.Color.White;
            this.ButtonDisablePowerThrottling.Location = new System.Drawing.Point(517, 170);
            this.ButtonDisablePowerThrottling.Name = "ButtonDisablePowerThrottling";
            this.ButtonDisablePowerThrottling.Size = new System.Drawing.Size(160, 46);
            this.ButtonDisablePowerThrottling.TabIndex = 24;
            this.ButtonDisablePowerThrottling.Text = "Disable power throttling";
            this.ToolTip.SetToolTip(this.ButtonDisablePowerThrottling, "Disables power saving features. Improves latency/smoothness/performance.");
            this.ButtonDisablePowerThrottling.UseVisualStyleBackColor = false;
            this.ButtonDisablePowerThrottling.Click += new System.EventHandler(this.ButtonDisablePowerThrottling_Click);
            // 
            // ButtonImportATUPowerPlan
            // 
            this.ButtonImportATUPowerPlan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(72)))));
            this.ButtonImportATUPowerPlan.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ButtonImportATUPowerPlan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonImportATUPowerPlan.ForeColor = System.Drawing.Color.White;
            this.ButtonImportATUPowerPlan.Location = new System.Drawing.Point(12, 170);
            this.ButtonImportATUPowerPlan.Name = "ButtonImportATUPowerPlan";
            this.ButtonImportATUPowerPlan.Size = new System.Drawing.Size(160, 46);
            this.ButtonImportATUPowerPlan.TabIndex = 20;
            this.ButtonImportATUPowerPlan.Text = "Import Auto Tweaking Utility power plan";
            this.ToolTip.SetToolTip(this.ButtonImportATUPowerPlan, "Imports Auto Tweaking Utility power plan.");
            this.ButtonImportATUPowerPlan.UseVisualStyleBackColor = false;
            this.ButtonImportATUPowerPlan.Click += new System.EventHandler(this.ButtonImportATUPowerPlan_Click);
            // 
            // ButtonDisableFSO
            // 
            this.ButtonDisableFSO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(72)))));
            this.ButtonDisableFSO.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ButtonDisableFSO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonDisableFSO.ForeColor = System.Drawing.Color.White;
            this.ButtonDisableFSO.Location = new System.Drawing.Point(12, 13);
            this.ButtonDisableFSO.Name = "ButtonDisableFSO";
            this.ButtonDisableFSO.Size = new System.Drawing.Size(160, 46);
            this.ButtonDisableFSO.TabIndex = 25;
            this.ButtonDisableFSO.Text = "Disable fullscreen optimizations";
            this.ToolTip.SetToolTip(this.ButtonDisableFSO, "Disables fullscreen optimisations and gamebar. Improves latency by a lot, only fo" +
        "r Windows 10.");
            this.ButtonDisableFSO.UseVisualStyleBackColor = false;
            this.ButtonDisableFSO.Click += new System.EventHandler(this.ButtonDisableFSO_Click);
            // 
            // ButtonNetworkTweaks
            // 
            this.ButtonNetworkTweaks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(72)))));
            this.ButtonNetworkTweaks.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ButtonNetworkTweaks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonNetworkTweaks.ForeColor = System.Drawing.Color.White;
            this.ButtonNetworkTweaks.Location = new System.Drawing.Point(349, 66);
            this.ButtonNetworkTweaks.Name = "ButtonNetworkTweaks";
            this.ButtonNetworkTweaks.Size = new System.Drawing.Size(160, 46);
            this.ButtonNetworkTweaks.TabIndex = 1;
            this.ButtonNetworkTweaks.Text = "Network tweaks";
            this.ToolTip.SetToolTip(this.ButtonNetworkTweaks, "Network tweaks, improve hitreg/overall network performance.");
            this.ButtonNetworkTweaks.UseVisualStyleBackColor = false;
            this.ButtonNetworkTweaks.Click += new System.EventHandler(this.ButtonNetworktweaks_Click);
            // 
            // ButtonApplyBCDEditSettings
            // 
            this.ButtonApplyBCDEditSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(72)))));
            this.ButtonApplyBCDEditSettings.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ButtonApplyBCDEditSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonApplyBCDEditSettings.ForeColor = System.Drawing.Color.White;
            this.ButtonApplyBCDEditSettings.Location = new System.Drawing.Point(180, 222);
            this.ButtonApplyBCDEditSettings.Name = "ButtonApplyBCDEditSettings";
            this.ButtonApplyBCDEditSettings.Size = new System.Drawing.Size(160, 46);
            this.ButtonApplyBCDEditSettings.TabIndex = 21;
            this.ButtonApplyBCDEditSettings.Text = "Apply BCDEdit settings";
            this.ToolTip.SetToolTip(this.ButtonApplyBCDEditSettings, "Applies BCDEdit settings. Improves latency/smoothness/performance.");
            this.ButtonApplyBCDEditSettings.UseVisualStyleBackColor = false;
            this.ButtonApplyBCDEditSettings.Click += new System.EventHandler(this.ButtonApplyBCDEditSettings_Click);
            // 
            // ButtonEnableClassicAltTab
            // 
            this.ButtonEnableClassicAltTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(72)))));
            this.ButtonEnableClassicAltTab.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ButtonEnableClassicAltTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonEnableClassicAltTab.ForeColor = System.Drawing.Color.White;
            this.ButtonEnableClassicAltTab.Location = new System.Drawing.Point(12, 222);
            this.ButtonEnableClassicAltTab.Name = "ButtonEnableClassicAltTab";
            this.ButtonEnableClassicAltTab.Size = new System.Drawing.Size(160, 46);
            this.ButtonEnableClassicAltTab.TabIndex = 17;
            this.ButtonEnableClassicAltTab.Text = "Enable classic alt-tab menu";
            this.ToolTip.SetToolTip(this.ButtonEnableClassicAltTab, "Enables classic alt-tab.");
            this.ButtonEnableClassicAltTab.UseVisualStyleBackColor = false;
            this.ButtonEnableClassicAltTab.Click += new System.EventHandler(this.ButtonEnableClassicAltTab_Click);
            // 
            // ButtonInterruptMSITweaks
            // 
            this.ButtonInterruptMSITweaks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(72)))));
            this.ButtonInterruptMSITweaks.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ButtonInterruptMSITweaks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonInterruptMSITweaks.ForeColor = System.Drawing.Color.White;
            this.ButtonInterruptMSITweaks.Location = new System.Drawing.Point(349, 13);
            this.ButtonInterruptMSITweaks.Name = "ButtonInterruptMSITweaks";
            this.ButtonInterruptMSITweaks.Size = new System.Drawing.Size(160, 46);
            this.ButtonInterruptMSITweaks.TabIndex = 9;
            this.ButtonInterruptMSITweaks.Text = "Interrupt/MSI tweaks";
            this.ToolTip.SetToolTip(this.ButtonInterruptMSITweaks, "Interrupt / Message Signaled Interrupts related\r\ntweaks. Improve feels, performan" +
        "ce, everything.");
            this.ButtonInterruptMSITweaks.UseVisualStyleBackColor = false;
            this.ButtonInterruptMSITweaks.Click += new System.EventHandler(this.ButtonInterruptMSITweaks_Click);
            // 
            // ButtonInstallPrograms
            // 
            this.ButtonInstallPrograms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(72)))));
            this.ButtonInstallPrograms.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ButtonInstallPrograms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonInstallPrograms.ForeColor = System.Drawing.Color.White;
            this.ButtonInstallPrograms.Location = new System.Drawing.Point(517, 66);
            this.ButtonInstallPrograms.Name = "ButtonInstallPrograms";
            this.ButtonInstallPrograms.Size = new System.Drawing.Size(160, 46);
            this.ButtonInstallPrograms.TabIndex = 5;
            this.ButtonInstallPrograms.Text = "Install programs";
            this.ToolTip.SetToolTip(this.ButtonInstallPrograms, "Install programs.");
            this.ButtonInstallPrograms.UseVisualStyleBackColor = false;
            this.ButtonInstallPrograms.Click += new System.EventHandler(this.ButtonInstallPrograms_Click);
            // 
            // ButtonApplyKernelTweaks
            // 
            this.ButtonApplyKernelTweaks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(72)))));
            this.ButtonApplyKernelTweaks.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ButtonApplyKernelTweaks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonApplyKernelTweaks.ForeColor = System.Drawing.Color.White;
            this.ButtonApplyKernelTweaks.Location = new System.Drawing.Point(180, 170);
            this.ButtonApplyKernelTweaks.Name = "ButtonApplyKernelTweaks";
            this.ButtonApplyKernelTweaks.Size = new System.Drawing.Size(160, 46);
            this.ButtonApplyKernelTweaks.TabIndex = 16;
            this.ButtonApplyKernelTweaks.Text = "Apply kernel tweaks";
            this.ToolTip.SetToolTip(this.ButtonApplyKernelTweaks, "Apply kernel tweaks. Improves latency/smoothness/performance.");
            this.ButtonApplyKernelTweaks.UseVisualStyleBackColor = false;
            this.ButtonApplyKernelTweaks.Click += new System.EventHandler(this.ButtonApplyKernelTweaks_Click);
            // 
            // ButtonSchedulingTweaks
            // 
            this.ButtonSchedulingTweaks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(72)))));
            this.ButtonSchedulingTweaks.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ButtonSchedulingTweaks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSchedulingTweaks.ForeColor = System.Drawing.Color.White;
            this.ButtonSchedulingTweaks.Location = new System.Drawing.Point(349, 222);
            this.ButtonSchedulingTweaks.Name = "ButtonSchedulingTweaks";
            this.ButtonSchedulingTweaks.Size = new System.Drawing.Size(160, 46);
            this.ButtonSchedulingTweaks.TabIndex = 2;
            this.ButtonSchedulingTweaks.Text = "Scheduling tweaks";
            this.ToolTip.SetToolTip(this.ButtonSchedulingTweaks, "Improve responsiveness/smoothness.");
            this.ButtonSchedulingTweaks.UseVisualStyleBackColor = false;
            this.ButtonSchedulingTweaks.Click += new System.EventHandler(this.ButtonSchedulingTweaks_Click);
            // 
            // ButtonApplyMemoryTweaks
            // 
            this.ButtonApplyMemoryTweaks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(72)))));
            this.ButtonApplyMemoryTweaks.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ButtonApplyMemoryTweaks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonApplyMemoryTweaks.ForeColor = System.Drawing.Color.White;
            this.ButtonApplyMemoryTweaks.Location = new System.Drawing.Point(180, 66);
            this.ButtonApplyMemoryTweaks.Name = "ButtonApplyMemoryTweaks";
            this.ButtonApplyMemoryTweaks.Size = new System.Drawing.Size(160, 46);
            this.ButtonApplyMemoryTweaks.TabIndex = 18;
            this.ButtonApplyMemoryTweaks.Text = "Apply memory tweaks";
            this.ToolTip.SetToolTip(this.ButtonApplyMemoryTweaks, "Applies memory tweaks. Improves latency/smoothness/performance.");
            this.ButtonApplyMemoryTweaks.UseVisualStyleBackColor = false;
            this.ButtonApplyMemoryTweaks.Click += new System.EventHandler(this.ButtonApplyMemoryTweaks_Click);
            // 
            // ButtonServicesTweaks
            // 
            this.ButtonServicesTweaks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(72)))));
            this.ButtonServicesTweaks.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ButtonServicesTweaks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonServicesTweaks.ForeColor = System.Drawing.Color.White;
            this.ButtonServicesTweaks.Location = new System.Drawing.Point(517, 222);
            this.ButtonServicesTweaks.Name = "ButtonServicesTweaks";
            this.ButtonServicesTweaks.Size = new System.Drawing.Size(160, 46);
            this.ButtonServicesTweaks.TabIndex = 3;
            this.ButtonServicesTweaks.Text = "Services tweaks";
            this.ToolTip.SetToolTip(this.ButtonServicesTweaks, "Disable/enable services.");
            this.ButtonServicesTweaks.UseVisualStyleBackColor = false;
            this.ButtonServicesTweaks.Click += new System.EventHandler(this.ButtonServicesTweaks_Click);
            // 
            // ButtonInstallRuntimes
            // 
            this.ButtonInstallRuntimes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(72)))));
            this.ButtonInstallRuntimes.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ButtonInstallRuntimes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonInstallRuntimes.ForeColor = System.Drawing.Color.White;
            this.ButtonInstallRuntimes.Location = new System.Drawing.Point(517, 13);
            this.ButtonInstallRuntimes.Name = "ButtonInstallRuntimes";
            this.ButtonInstallRuntimes.Size = new System.Drawing.Size(160, 46);
            this.ButtonInstallRuntimes.TabIndex = 11;
            this.ButtonInstallRuntimes.Text = "Install runtimes";
            this.ToolTip.SetToolTip(this.ButtonInstallRuntimes, "Install runtimes.");
            this.ButtonInstallRuntimes.UseVisualStyleBackColor = false;
            this.ButtonInstallRuntimes.Click += new System.EventHandler(this.ButtonInstallRuntimes_Click);
            // 
            // ButtonDisableFTH
            // 
            this.ButtonDisableFTH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(72)))));
            this.ButtonDisableFTH.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ButtonDisableFTH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonDisableFTH.ForeColor = System.Drawing.Color.White;
            this.ButtonDisableFTH.Location = new System.Drawing.Point(12, 66);
            this.ButtonDisableFTH.Name = "ButtonDisableFTH";
            this.ButtonDisableFTH.Size = new System.Drawing.Size(160, 46);
            this.ButtonDisableFTH.TabIndex = 15;
            this.ButtonDisableFTH.Text = "Disable fault tolerant heap";
            this.ToolTip.SetToolTip(this.ButtonDisableFTH, "Disables Fault Tolerant Heap. Improves performance by a bit.");
            this.ButtonDisableFTH.UseVisualStyleBackColor = false;
            this.ButtonDisableFTH.Click += new System.EventHandler(this.ButtonDisableFTH_Click);
            // 
            // ButtonDisableDrivers
            // 
            this.ButtonDisableDrivers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(72)))));
            this.ButtonDisableDrivers.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ButtonDisableDrivers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonDisableDrivers.ForeColor = System.Drawing.Color.White;
            this.ButtonDisableDrivers.Location = new System.Drawing.Point(349, 170);
            this.ButtonDisableDrivers.Name = "ButtonDisableDrivers";
            this.ButtonDisableDrivers.Size = new System.Drawing.Size(160, 46);
            this.ButtonDisableDrivers.TabIndex = 4;
            this.ButtonDisableDrivers.Text = "Disable drivers";
            this.ToolTip.SetToolTip(this.ButtonDisableDrivers, "Disable drivers. Improves latency/smoothness/performance.");
            this.ButtonDisableDrivers.UseVisualStyleBackColor = false;
            this.ButtonDisableDrivers.Click += new System.EventHandler(this.ButtonDisableDrivers_Click);
            // 
            // ButtonApplyVisualFxTweaks
            // 
            this.ButtonApplyVisualFxTweaks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(72)))));
            this.ButtonApplyVisualFxTweaks.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ButtonApplyVisualFxTweaks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonApplyVisualFxTweaks.ForeColor = System.Drawing.Color.White;
            this.ButtonApplyVisualFxTweaks.Location = new System.Drawing.Point(517, 118);
            this.ButtonApplyVisualFxTweaks.Name = "ButtonApplyVisualFxTweaks";
            this.ButtonApplyVisualFxTweaks.Size = new System.Drawing.Size(160, 46);
            this.ButtonApplyVisualFxTweaks.TabIndex = 26;
            this.ButtonApplyVisualFxTweaks.Text = "Apply visual effect tweaks";
            this.ToolTip.SetToolTip(this.ButtonApplyVisualFxTweaks, "Apply visual effects tweaks. Disables font smoothing, animations etc.");
            this.ButtonApplyVisualFxTweaks.UseVisualStyleBackColor = false;
            this.ButtonApplyVisualFxTweaks.Click += new System.EventHandler(this.ButtonApplyVisualFxTweaks_Click);
            // 
            // ButtonDeleteMicrocode
            // 
            this.ButtonDeleteMicrocode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(72)))));
            this.ButtonDeleteMicrocode.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ButtonDeleteMicrocode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonDeleteMicrocode.ForeColor = System.Drawing.Color.White;
            this.ButtonDeleteMicrocode.Location = new System.Drawing.Point(349, 118);
            this.ButtonDeleteMicrocode.Name = "ButtonDeleteMicrocode";
            this.ButtonDeleteMicrocode.Size = new System.Drawing.Size(160, 46);
            this.ButtonDeleteMicrocode.TabIndex = 27;
            this.ButtonDeleteMicrocode.Text = "Delete microcode";
            this.ToolTip.SetToolTip(this.ButtonDeleteMicrocode, "Deletes microcode. Improves performance/latency/smoothness.");
            this.ButtonDeleteMicrocode.UseVisualStyleBackColor = false;
            this.ButtonDeleteMicrocode.Click += new System.EventHandler(this.ButtonDeleteMicrocode_Click);
            // 
            // ButtonDebloatWindows10
            // 
            this.ButtonDebloatWindows10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(72)))));
            this.ButtonDebloatWindows10.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ButtonDebloatWindows10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonDebloatWindows10.ForeColor = System.Drawing.Color.White;
            this.ButtonDebloatWindows10.Location = new System.Drawing.Point(180, 13);
            this.ButtonDebloatWindows10.Name = "ButtonDebloatWindows10";
            this.ButtonDebloatWindows10.Size = new System.Drawing.Size(160, 46);
            this.ButtonDebloatWindows10.TabIndex = 28;
            this.ButtonDebloatWindows10.Text = "Debloat Windows 10";
            this.ToolTip.SetToolTip(this.ButtonDebloatWindows10, "Debloat Windows 10. Saves disk space and can improve\r\nperformance/latency/smoothn" +
        "ess/feels.");
            this.ButtonDebloatWindows10.UseVisualStyleBackColor = false;
            this.ButtonDebloatWindows10.Click += new System.EventHandler(this.ButtonDebloatWindows10_Click);
            // 
            // Titlebar_Close
            // 
            this.Titlebar_Close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Titlebar_Close.BackgroundImage")));
            this.Titlebar_Close.FlatAppearance.BorderSize = 0;
            this.Titlebar_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Titlebar_Close.Location = new System.Drawing.Point(669, 5);
            this.Titlebar_Close.Name = "Titlebar_Close";
            this.Titlebar_Close.Size = new System.Drawing.Size(15, 15);
            this.Titlebar_Close.TabIndex = 0;
            this.Titlebar_Close.UseVisualStyleBackColor = true;
            this.Titlebar_Close.Click += new System.EventHandler(this.Titlebar_Close_Click);
            // 
            // Titlebar_Minimize
            // 
            this.Titlebar_Minimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Titlebar_Minimize.BackgroundImage")));
            this.Titlebar_Minimize.FlatAppearance.BorderSize = 0;
            this.Titlebar_Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Titlebar_Minimize.Location = new System.Drawing.Point(648, 5);
            this.Titlebar_Minimize.Name = "Titlebar_Minimize";
            this.Titlebar_Minimize.Size = new System.Drawing.Size(15, 15);
            this.Titlebar_Minimize.TabIndex = 2;
            this.Titlebar_Minimize.UseVisualStyleBackColor = true;
            this.Titlebar_Minimize.Click += new System.EventHandler(this.Titlebar_Minimize_Click);
            // 
            // Titlebar_Label
            // 
            this.Titlebar_Label.AutoSize = true;
            this.Titlebar_Label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Titlebar_Label.ForeColor = System.Drawing.Color.White;
            this.Titlebar_Label.Location = new System.Drawing.Point(4, 5);
            this.Titlebar_Label.Name = "Titlebar_Label";
            this.Titlebar_Label.Size = new System.Drawing.Size(117, 13);
            this.Titlebar_Label.TabIndex = 3;
            this.Titlebar_Label.Text = "Auto Tweaking Utility";
            this.Titlebar_Label.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Titlebar_MouseDown);
            // 
            // Titlebar
            // 
            this.Titlebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(63)))), ((int)(((byte)(76)))));
            this.Titlebar.Controls.Add(this.Titlebar_Label);
            this.Titlebar.Controls.Add(this.Titlebar_Minimize);
            this.Titlebar.Controls.Add(this.Titlebar_Close);
            this.Titlebar.Location = new System.Drawing.Point(0, 0);
            this.Titlebar.Name = "Titlebar";
            this.Titlebar.Size = new System.Drawing.Size(689, 25);
            this.Titlebar.TabIndex = 26;
            this.Titlebar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Titlebar_MouseDown);
            // 
            // DebloatTimer
            // 
            this.DebloatTimer.Interval = 500;
            this.DebloatTimer.Tick += new System.EventHandler(this.DebloatTimer_Tick);
            // 
            // Tab_Main
            // 
            this.Tab_Main.Controls.Add(this.ButtonDebloatWindows10);
            this.Tab_Main.Controls.Add(this.ButtonDeleteMicrocode);
            this.Tab_Main.Controls.Add(this.ButtonApplyVisualFxTweaks);
            this.Tab_Main.Controls.Add(this.ButtonDisableDrivers);
            this.Tab_Main.Controls.Add(this.ButtonDisableFTH);
            this.Tab_Main.Controls.Add(this.ButtonInstallRuntimes);
            this.Tab_Main.Controls.Add(this.ButtonServicesTweaks);
            this.Tab_Main.Controls.Add(this.ButtonApplyMemoryTweaks);
            this.Tab_Main.Controls.Add(this.ButtonSchedulingTweaks);
            this.Tab_Main.Controls.Add(this.ButtonApplyKernelTweaks);
            this.Tab_Main.Controls.Add(this.ButtonInstallPrograms);
            this.Tab_Main.Controls.Add(this.ButtonInterruptMSITweaks);
            this.Tab_Main.Controls.Add(this.ButtonEnableClassicAltTab);
            this.Tab_Main.Controls.Add(this.ButtonApplyBCDEditSettings);
            this.Tab_Main.Controls.Add(this.ButtonNetworkTweaks);
            this.Tab_Main.Controls.Add(this.ButtonDisableFSO);
            this.Tab_Main.Controls.Add(this.ButtonImportATUPowerPlan);
            this.Tab_Main.Controls.Add(this.ButtonDisablePowerThrottling);
            this.Tab_Main.Controls.Add(this.ButtonDisableDefender);
            this.Tab_Main.Controls.Add(this.ButtonApplyStorageTweaks);
            this.Tab_Main.Location = new System.Drawing.Point(0, 25);
            this.Tab_Main.Name = "Tab_Main";
            this.Tab_Main.Size = new System.Drawing.Size(689, 279);
            this.Tab_Main.TabIndex = 29;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(75)))), ((int)(((byte)(87)))));
            this.ClientSize = new System.Drawing.Size(689, 304);
            this.Controls.Add(this.Tab_Main);
            this.Controls.Add(this.Titlebar);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auto Tweaking Utility";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Titlebar.ResumeLayout(false);
            this.Titlebar.PerformLayout();
            this.Tab_Main.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolTip ToolTip;
        private System.Windows.Forms.Button Titlebar_Close;
        private System.Windows.Forms.Button Titlebar_Minimize;
        private System.Windows.Forms.Label Titlebar_Label;
        private System.Windows.Forms.Panel Titlebar;
        private System.Windows.Forms.Timer DebloatTimer;
        private System.Windows.Forms.Panel Tab_Main;
        public System.Windows.Forms.Button ButtonDebloatWindows10;
        public System.Windows.Forms.Button ButtonDeleteMicrocode;
        public System.Windows.Forms.Button ButtonApplyVisualFxTweaks;
        public System.Windows.Forms.Button ButtonDisableDrivers;
        public System.Windows.Forms.Button ButtonDisableFTH;
        public System.Windows.Forms.Button ButtonInstallRuntimes;
        public System.Windows.Forms.Button ButtonServicesTweaks;
        public System.Windows.Forms.Button ButtonApplyMemoryTweaks;
        public System.Windows.Forms.Button ButtonSchedulingTweaks;
        public System.Windows.Forms.Button ButtonApplyKernelTweaks;
        public System.Windows.Forms.Button ButtonInstallPrograms;
        public System.Windows.Forms.Button ButtonInterruptMSITweaks;
        public System.Windows.Forms.Button ButtonEnableClassicAltTab;
        public System.Windows.Forms.Button ButtonApplyBCDEditSettings;
        public System.Windows.Forms.Button ButtonNetworkTweaks;
        public System.Windows.Forms.Button ButtonDisableFSO;
        public System.Windows.Forms.Button ButtonImportATUPowerPlan;
        public System.Windows.Forms.Button ButtonDisablePowerThrottling;
        public System.Windows.Forms.Button ButtonDisableDefender;
        public System.Windows.Forms.Button ButtonApplyStorageTweaks;
    }
}

