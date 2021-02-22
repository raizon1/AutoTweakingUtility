namespace Auto_Tweaking_Utility
{
    partial class InterruptMSITweaksForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InterruptMSITweaksForm));
            this.ListBoxDevices = new System.Windows.Forms.ListBox();
            this.LabelDevices = new System.Windows.Forms.Label();
            this.ButtonSetMask = new System.Windows.Forms.Button();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.ButtonOK = new System.Windows.Forms.Button();
            this.ButtonEnableDisableMSIMode = new System.Windows.Forms.Button();
            this.ButtonChangeMessageNumberLimit = new System.Windows.Forms.Button();
            this.ButtonChangeDevicePolicy = new System.Windows.Forms.Button();
            this.ButtonChangeInterruptPriority = new System.Windows.Forms.Button();
            this.ListBoxDeviceIDs = new System.Windows.Forms.ListBox();
            this.ButtonDeleteMask = new System.Windows.Forms.Button();
            this.ListBoxBinaryAffinityMasks = new System.Windows.Forms.ListBox();
            this.ListBoxDevicePolicies = new System.Windows.Forms.ListBox();
            this.DeviceIdentifiers = new System.Windows.Forms.Label();
            this.ListBoxDevicePriorities = new System.Windows.Forms.ListBox();
            this.ListBoxMessageNumberLimits = new System.Windows.Forms.ListBox();
            this.ListBoxMSISupported = new System.Windows.Forms.ListBox();
            this.Titlebar = new System.Windows.Forms.Panel();
            this.Titlebar_Label = new System.Windows.Forms.Label();
            this.Titlebar_Close = new System.Windows.Forms.Button();
            this.Titlebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListBoxDevices
            // 
            this.ListBoxDevices.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(72)))));
            this.ListBoxDevices.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ListBoxDevices.ForeColor = System.Drawing.Color.White;
            this.ListBoxDevices.FormattingEnabled = true;
            this.ListBoxDevices.HorizontalScrollbar = true;
            this.ListBoxDevices.Items.AddRange(new object[] {
            " "});
            this.ListBoxDevices.Location = new System.Drawing.Point(9, 51);
            this.ListBoxDevices.Name = "ListBoxDevices";
            this.ListBoxDevices.Size = new System.Drawing.Size(241, 184);
            this.ListBoxDevices.TabIndex = 0;
            // 
            // LabelDevices
            // 
            this.LabelDevices.AutoSize = true;
            this.LabelDevices.Location = new System.Drawing.Point(6, 35);
            this.LabelDevices.Name = "LabelDevices";
            this.LabelDevices.Size = new System.Drawing.Size(48, 13);
            this.LabelDevices.TabIndex = 1;
            this.LabelDevices.Text = "Devices:";
            // 
            // ButtonSetMask
            // 
            this.ButtonSetMask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(72)))));
            this.ButtonSetMask.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ButtonSetMask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSetMask.ForeColor = System.Drawing.Color.White;
            this.ButtonSetMask.Location = new System.Drawing.Point(9, 243);
            this.ButtonSetMask.Name = "ButtonSetMask";
            this.ButtonSetMask.Size = new System.Drawing.Size(67, 23);
            this.ButtonSetMask.TabIndex = 2;
            this.ButtonSetMask.Text = "Set mask";
            this.ButtonSetMask.UseVisualStyleBackColor = false;
            this.ButtonSetMask.Click += new System.EventHandler(this.ButtonSetMask_Click);
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(72)))));
            this.ButtonCancel.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ButtonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCancel.ForeColor = System.Drawing.Color.White;
            this.ButtonCancel.Location = new System.Drawing.Point(724, 277);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(75, 23);
            this.ButtonCancel.TabIndex = 50;
            this.ButtonCancel.Text = "Cancel";
            this.ButtonCancel.UseVisualStyleBackColor = false;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // ButtonOK
            // 
            this.ButtonOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(72)))));
            this.ButtonOK.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ButtonOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonOK.ForeColor = System.Drawing.Color.White;
            this.ButtonOK.Location = new System.Drawing.Point(643, 277);
            this.ButtonOK.Name = "ButtonOK";
            this.ButtonOK.Size = new System.Drawing.Size(75, 23);
            this.ButtonOK.TabIndex = 49;
            this.ButtonOK.Text = "OK";
            this.ButtonOK.UseVisualStyleBackColor = false;
            this.ButtonOK.Click += new System.EventHandler(this.ButtonOK_Click);
            // 
            // ButtonEnableDisableMSIMode
            // 
            this.ButtonEnableDisableMSIMode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(72)))));
            this.ButtonEnableDisableMSIMode.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ButtonEnableDisableMSIMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonEnableDisableMSIMode.ForeColor = System.Drawing.Color.White;
            this.ButtonEnableDisableMSIMode.Location = new System.Drawing.Point(307, 243);
            this.ButtonEnableDisableMSIMode.Name = "ButtonEnableDisableMSIMode";
            this.ButtonEnableDisableMSIMode.Size = new System.Drawing.Size(152, 23);
            this.ButtonEnableDisableMSIMode.TabIndex = 51;
            this.ButtonEnableDisableMSIMode.Text = "Enable/disable MSI mode";
            this.ButtonEnableDisableMSIMode.UseVisualStyleBackColor = false;
            this.ButtonEnableDisableMSIMode.Click += new System.EventHandler(this.ButtonEnableDisableMSIMode_Click);
            // 
            // ButtonChangeMessageNumberLimit
            // 
            this.ButtonChangeMessageNumberLimit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(72)))));
            this.ButtonChangeMessageNumberLimit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ButtonChangeMessageNumberLimit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonChangeMessageNumberLimit.ForeColor = System.Drawing.Color.White;
            this.ButtonChangeMessageNumberLimit.Location = new System.Drawing.Point(465, 243);
            this.ButtonChangeMessageNumberLimit.Name = "ButtonChangeMessageNumberLimit";
            this.ButtonChangeMessageNumberLimit.Size = new System.Drawing.Size(177, 23);
            this.ButtonChangeMessageNumberLimit.TabIndex = 52;
            this.ButtonChangeMessageNumberLimit.Text = "Change message number limit";
            this.ButtonChangeMessageNumberLimit.UseVisualStyleBackColor = false;
            this.ButtonChangeMessageNumberLimit.Click += new System.EventHandler(this.ButtonChangeMessageNumberLimit_Click);
            // 
            // ButtonChangeDevicePolicy
            // 
            this.ButtonChangeDevicePolicy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(72)))));
            this.ButtonChangeDevicePolicy.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ButtonChangeDevicePolicy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonChangeDevicePolicy.ForeColor = System.Drawing.Color.White;
            this.ButtonChangeDevicePolicy.Location = new System.Drawing.Point(171, 243);
            this.ButtonChangeDevicePolicy.Name = "ButtonChangeDevicePolicy";
            this.ButtonChangeDevicePolicy.Size = new System.Drawing.Size(130, 23);
            this.ButtonChangeDevicePolicy.TabIndex = 53;
            this.ButtonChangeDevicePolicy.Text = "Change device policy";
            this.ButtonChangeDevicePolicy.UseVisualStyleBackColor = false;
            this.ButtonChangeDevicePolicy.Click += new System.EventHandler(this.ButtonChangeDevicePolicy_Click);
            // 
            // ButtonChangeInterruptPriority
            // 
            this.ButtonChangeInterruptPriority.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(72)))));
            this.ButtonChangeInterruptPriority.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ButtonChangeInterruptPriority.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonChangeInterruptPriority.ForeColor = System.Drawing.Color.White;
            this.ButtonChangeInterruptPriority.Location = new System.Drawing.Point(648, 243);
            this.ButtonChangeInterruptPriority.Name = "ButtonChangeInterruptPriority";
            this.ButtonChangeInterruptPriority.Size = new System.Drawing.Size(151, 23);
            this.ButtonChangeInterruptPriority.TabIndex = 54;
            this.ButtonChangeInterruptPriority.Text = "Change interrupt priority";
            this.ButtonChangeInterruptPriority.UseVisualStyleBackColor = false;
            this.ButtonChangeInterruptPriority.Click += new System.EventHandler(this.ButtonChangeInterruptPriority_Click);
            // 
            // ListBoxDeviceIDs
            // 
            this.ListBoxDeviceIDs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(72)))));
            this.ListBoxDeviceIDs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ListBoxDeviceIDs.ForeColor = System.Drawing.Color.White;
            this.ListBoxDeviceIDs.FormattingEnabled = true;
            this.ListBoxDeviceIDs.HorizontalScrollbar = true;
            this.ListBoxDeviceIDs.Items.AddRange(new object[] {
            " "});
            this.ListBoxDeviceIDs.Location = new System.Drawing.Point(256, 51);
            this.ListBoxDeviceIDs.Name = "ListBoxDeviceIDs";
            this.ListBoxDeviceIDs.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.ListBoxDeviceIDs.Size = new System.Drawing.Size(543, 184);
            this.ListBoxDeviceIDs.TabIndex = 56;
            // 
            // ButtonDeleteMask
            // 
            this.ButtonDeleteMask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(72)))));
            this.ButtonDeleteMask.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ButtonDeleteMask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonDeleteMask.ForeColor = System.Drawing.Color.White;
            this.ButtonDeleteMask.Location = new System.Drawing.Point(82, 243);
            this.ButtonDeleteMask.Name = "ButtonDeleteMask";
            this.ButtonDeleteMask.Size = new System.Drawing.Size(83, 23);
            this.ButtonDeleteMask.TabIndex = 58;
            this.ButtonDeleteMask.Text = "Delete mask";
            this.ButtonDeleteMask.UseVisualStyleBackColor = false;
            this.ButtonDeleteMask.Click += new System.EventHandler(this.ButtonDeleteMask_Click);
            // 
            // ListBoxBinaryAffinityMasks
            // 
            this.ListBoxBinaryAffinityMasks.FormattingEnabled = true;
            this.ListBoxBinaryAffinityMasks.Items.AddRange(new object[] {
            " "});
            this.ListBoxBinaryAffinityMasks.Location = new System.Drawing.Point(9, 283);
            this.ListBoxBinaryAffinityMasks.Name = "ListBoxBinaryAffinityMasks";
            this.ListBoxBinaryAffinityMasks.Size = new System.Drawing.Size(39, 17);
            this.ListBoxBinaryAffinityMasks.TabIndex = 59;
            this.ListBoxBinaryAffinityMasks.Visible = false;
            // 
            // ListBoxDevicePolicies
            // 
            this.ListBoxDevicePolicies.FormattingEnabled = true;
            this.ListBoxDevicePolicies.Items.AddRange(new object[] {
            " "});
            this.ListBoxDevicePolicies.Location = new System.Drawing.Point(189, 283);
            this.ListBoxDevicePolicies.Name = "ListBoxDevicePolicies";
            this.ListBoxDevicePolicies.Size = new System.Drawing.Size(37, 17);
            this.ListBoxDevicePolicies.TabIndex = 60;
            this.ListBoxDevicePolicies.Visible = false;
            // 
            // DeviceIdentifiers
            // 
            this.DeviceIdentifiers.AutoSize = true;
            this.DeviceIdentifiers.Location = new System.Drawing.Point(253, 35);
            this.DeviceIdentifiers.Name = "DeviceIdentifiers";
            this.DeviceIdentifiers.Size = new System.Drawing.Size(98, 13);
            this.DeviceIdentifiers.TabIndex = 61;
            this.DeviceIdentifiers.Text = "Device identifiers:";
            // 
            // ListBoxDevicePriorities
            // 
            this.ListBoxDevicePriorities.FormattingEnabled = true;
            this.ListBoxDevicePriorities.Items.AddRange(new object[] {
            " "});
            this.ListBoxDevicePriorities.Location = new System.Drawing.Point(146, 283);
            this.ListBoxDevicePriorities.Name = "ListBoxDevicePriorities";
            this.ListBoxDevicePriorities.Size = new System.Drawing.Size(37, 17);
            this.ListBoxDevicePriorities.TabIndex = 62;
            this.ListBoxDevicePriorities.Visible = false;
            // 
            // ListBoxMessageNumberLimits
            // 
            this.ListBoxMessageNumberLimits.FormattingEnabled = true;
            this.ListBoxMessageNumberLimits.Items.AddRange(new object[] {
            " "});
            this.ListBoxMessageNumberLimits.Location = new System.Drawing.Point(54, 283);
            this.ListBoxMessageNumberLimits.Name = "ListBoxMessageNumberLimits";
            this.ListBoxMessageNumberLimits.Size = new System.Drawing.Size(37, 17);
            this.ListBoxMessageNumberLimits.TabIndex = 63;
            this.ListBoxMessageNumberLimits.Visible = false;
            // 
            // ListBoxMSISupported
            // 
            this.ListBoxMSISupported.FormattingEnabled = true;
            this.ListBoxMSISupported.Items.AddRange(new object[] {
            " "});
            this.ListBoxMSISupported.Location = new System.Drawing.Point(97, 283);
            this.ListBoxMSISupported.Name = "ListBoxMSISupported";
            this.ListBoxMSISupported.Size = new System.Drawing.Size(43, 17);
            this.ListBoxMSISupported.TabIndex = 64;
            this.ListBoxMSISupported.Visible = false;
            // 
            // Titlebar
            // 
            this.Titlebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(63)))), ((int)(((byte)(76)))));
            this.Titlebar.Controls.Add(this.Titlebar_Label);
            this.Titlebar.Controls.Add(this.Titlebar_Close);
            this.Titlebar.Location = new System.Drawing.Point(0, 0);
            this.Titlebar.Name = "Titlebar";
            this.Titlebar.Size = new System.Drawing.Size(807, 25);
            this.Titlebar.TabIndex = 136;
            this.Titlebar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Titlebar_MouseDown);
            // 
            // Titlebar_Label
            // 
            this.Titlebar_Label.AutoSize = true;
            this.Titlebar_Label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Titlebar_Label.ForeColor = System.Drawing.Color.White;
            this.Titlebar_Label.Location = new System.Drawing.Point(4, 5);
            this.Titlebar_Label.Name = "Titlebar_Label";
            this.Titlebar_Label.Size = new System.Drawing.Size(115, 13);
            this.Titlebar_Label.TabIndex = 3;
            this.Titlebar_Label.Text = "Interrupt/MSI tweaks";
            this.Titlebar_Label.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Titlebar_MouseDown);
            // 
            // Titlebar_Close
            // 
            this.Titlebar_Close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Titlebar_Close.BackgroundImage")));
            this.Titlebar_Close.FlatAppearance.BorderSize = 0;
            this.Titlebar_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Titlebar_Close.Location = new System.Drawing.Point(788, 5);
            this.Titlebar_Close.Name = "Titlebar_Close";
            this.Titlebar_Close.Size = new System.Drawing.Size(15, 15);
            this.Titlebar_Close.TabIndex = 0;
            this.Titlebar_Close.UseVisualStyleBackColor = true;
            this.Titlebar_Close.Click += new System.EventHandler(this.Titlebar_Close_Click);
            // 
            // InterruptMSITweaksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(75)))), ((int)(((byte)(87)))));
            this.ClientSize = new System.Drawing.Size(807, 312);
            this.Controls.Add(this.Titlebar);
            this.Controls.Add(this.ListBoxMSISupported);
            this.Controls.Add(this.ListBoxMessageNumberLimits);
            this.Controls.Add(this.ListBoxDevicePriorities);
            this.Controls.Add(this.DeviceIdentifiers);
            this.Controls.Add(this.ListBoxDevicePolicies);
            this.Controls.Add(this.ListBoxBinaryAffinityMasks);
            this.Controls.Add(this.ButtonDeleteMask);
            this.Controls.Add(this.ListBoxDeviceIDs);
            this.Controls.Add(this.ButtonChangeInterruptPriority);
            this.Controls.Add(this.ButtonChangeDevicePolicy);
            this.Controls.Add(this.ButtonChangeMessageNumberLimit);
            this.Controls.Add(this.ButtonEnableDisableMSIMode);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonOK);
            this.Controls.Add(this.ButtonSetMask);
            this.Controls.Add(this.LabelDevices);
            this.Controls.Add(this.ListBoxDevices);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InterruptMSITweaksForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Interrupt/MSI tweaks";
            this.Load += new System.EventHandler(this.AffinityPriorityTweaksForm_Load);
            this.Shown += new System.EventHandler(this.InterruptTweaksForm_Shown);
            this.Titlebar.ResumeLayout(false);
            this.Titlebar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListBox ListBoxDevices;
        private System.Windows.Forms.Label LabelDevices;
        private System.Windows.Forms.Button ButtonSetMask;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.Button ButtonOK;
        private System.Windows.Forms.Button ButtonEnableDisableMSIMode;
        private System.Windows.Forms.Button ButtonChangeMessageNumberLimit;
        private System.Windows.Forms.Button ButtonChangeDevicePolicy;
        private System.Windows.Forms.Button ButtonChangeInterruptPriority;
        private System.Windows.Forms.ListBox ListBoxDeviceIDs;
        private System.Windows.Forms.Button ButtonDeleteMask;
        private System.Windows.Forms.ListBox ListBoxBinaryAffinityMasks;
        private System.Windows.Forms.ListBox ListBoxDevicePolicies;
        private System.Windows.Forms.Label DeviceIdentifiers;
        private System.Windows.Forms.ListBox ListBoxDevicePriorities;
        private System.Windows.Forms.ListBox ListBoxMessageNumberLimits;
        private System.Windows.Forms.ListBox ListBoxMSISupported;
        private System.Windows.Forms.Panel Titlebar;
        private System.Windows.Forms.Label Titlebar_Label;
        private System.Windows.Forms.Button Titlebar_Close;
    }
}