namespace Auto_Tweaking_Utility
{
    partial class InstallRuntimesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InstallRuntimesForm));
            this.ButtonInstallCppRuntimes = new System.Windows.Forms.Button();
            this.ButtonInstallDotNET48Runtime = new System.Windows.Forms.Button();
            this.ButtonInstallDirectXRuntime = new System.Windows.Forms.Button();
            this.ButtonInstallVulkanRuntime = new System.Windows.Forms.Button();
            this.Titlebar = new System.Windows.Forms.Panel();
            this.Titlebar_Label = new System.Windows.Forms.Label();
            this.Titlebar_Close = new System.Windows.Forms.Button();
            this.Titlebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonInstallCppRuntimes
            // 
            this.ButtonInstallCppRuntimes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(72)))));
            this.ButtonInstallCppRuntimes.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ButtonInstallCppRuntimes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonInstallCppRuntimes.Location = new System.Drawing.Point(13, 37);
            this.ButtonInstallCppRuntimes.Name = "ButtonInstallCppRuntimes";
            this.ButtonInstallCppRuntimes.Size = new System.Drawing.Size(129, 23);
            this.ButtonInstallCppRuntimes.TabIndex = 5;
            this.ButtonInstallCppRuntimes.Text = "Install C++ runtimes";
            this.ButtonInstallCppRuntimes.UseVisualStyleBackColor = false;
            this.ButtonInstallCppRuntimes.Click += new System.EventHandler(this.ButtonInstallCppRuntimes_Click);
            // 
            // ButtonInstallDotNET48Runtime
            // 
            this.ButtonInstallDotNET48Runtime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(72)))));
            this.ButtonInstallDotNET48Runtime.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ButtonInstallDotNET48Runtime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonInstallDotNET48Runtime.Location = new System.Drawing.Point(148, 37);
            this.ButtonInstallDotNET48Runtime.Name = "ButtonInstallDotNET48Runtime";
            this.ButtonInstallDotNET48Runtime.Size = new System.Drawing.Size(129, 23);
            this.ButtonInstallDotNET48Runtime.TabIndex = 6;
            this.ButtonInstallDotNET48Runtime.Text = "Install .NET 4.8 runtime";
            this.ButtonInstallDotNET48Runtime.UseVisualStyleBackColor = false;
            this.ButtonInstallDotNET48Runtime.Click += new System.EventHandler(this.ButtonInstallDotNET48Runtime_Click);
            // 
            // ButtonInstallDirectXRuntime
            // 
            this.ButtonInstallDirectXRuntime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(72)))));
            this.ButtonInstallDirectXRuntime.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ButtonInstallDirectXRuntime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonInstallDirectXRuntime.Location = new System.Drawing.Point(13, 67);
            this.ButtonInstallDirectXRuntime.Name = "ButtonInstallDirectXRuntime";
            this.ButtonInstallDirectXRuntime.Size = new System.Drawing.Size(129, 23);
            this.ButtonInstallDirectXRuntime.TabIndex = 7;
            this.ButtonInstallDirectXRuntime.Text = "Install DirectX runtime";
            this.ButtonInstallDirectXRuntime.UseVisualStyleBackColor = false;
            this.ButtonInstallDirectXRuntime.Click += new System.EventHandler(this.ButtonInstallDirectXRuntime_Click);
            // 
            // ButtonInstallVulkanRuntime
            // 
            this.ButtonInstallVulkanRuntime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(72)))));
            this.ButtonInstallVulkanRuntime.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ButtonInstallVulkanRuntime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonInstallVulkanRuntime.Location = new System.Drawing.Point(148, 67);
            this.ButtonInstallVulkanRuntime.Name = "ButtonInstallVulkanRuntime";
            this.ButtonInstallVulkanRuntime.Size = new System.Drawing.Size(129, 23);
            this.ButtonInstallVulkanRuntime.TabIndex = 8;
            this.ButtonInstallVulkanRuntime.Text = "Install Vulkan runtime";
            this.ButtonInstallVulkanRuntime.UseVisualStyleBackColor = false;
            this.ButtonInstallVulkanRuntime.Click += new System.EventHandler(this.ButtonInstallVulkanRuntime_Click);
            // 
            // Titlebar
            // 
            this.Titlebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(63)))), ((int)(((byte)(76)))));
            this.Titlebar.Controls.Add(this.Titlebar_Label);
            this.Titlebar.Controls.Add(this.Titlebar_Close);
            this.Titlebar.Location = new System.Drawing.Point(0, 0);
            this.Titlebar.Name = "Titlebar";
            this.Titlebar.Size = new System.Drawing.Size(288, 25);
            this.Titlebar.TabIndex = 137;
            this.Titlebar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Titlebar_MouseDown);
            // 
            // Titlebar_Label
            // 
            this.Titlebar_Label.AutoSize = true;
            this.Titlebar_Label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Titlebar_Label.ForeColor = System.Drawing.Color.White;
            this.Titlebar_Label.Location = new System.Drawing.Point(4, 5);
            this.Titlebar_Label.Name = "Titlebar_Label";
            this.Titlebar_Label.Size = new System.Drawing.Size(86, 13);
            this.Titlebar_Label.TabIndex = 3;
            this.Titlebar_Label.Text = "Install runtimes";
            this.Titlebar_Label.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Titlebar_MouseDown);
            // 
            // Titlebar_Close
            // 
            this.Titlebar_Close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Titlebar_Close.BackgroundImage")));
            this.Titlebar_Close.FlatAppearance.BorderSize = 0;
            this.Titlebar_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Titlebar_Close.Location = new System.Drawing.Point(269, 5);
            this.Titlebar_Close.Name = "Titlebar_Close";
            this.Titlebar_Close.Size = new System.Drawing.Size(15, 15);
            this.Titlebar_Close.TabIndex = 0;
            this.Titlebar_Close.UseVisualStyleBackColor = true;
            this.Titlebar_Close.Click += new System.EventHandler(this.Titlebar_Close_Click);
            // 
            // InstallRuntimesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(75)))), ((int)(((byte)(87)))));
            this.ClientSize = new System.Drawing.Size(288, 102);
            this.Controls.Add(this.Titlebar);
            this.Controls.Add(this.ButtonInstallVulkanRuntime);
            this.Controls.Add(this.ButtonInstallDirectXRuntime);
            this.Controls.Add(this.ButtonInstallDotNET48Runtime);
            this.Controls.Add(this.ButtonInstallCppRuntimes);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InstallRuntimesForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Install runtimes";
            this.Titlebar.ResumeLayout(false);
            this.Titlebar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonInstallCppRuntimes;
        private System.Windows.Forms.Button ButtonInstallDotNET48Runtime;
        private System.Windows.Forms.Button ButtonInstallDirectXRuntime;
        private System.Windows.Forms.Button ButtonInstallVulkanRuntime;
        private System.Windows.Forms.Panel Titlebar;
        private System.Windows.Forms.Label Titlebar_Label;
        private System.Windows.Forms.Button Titlebar_Close;
    }
}