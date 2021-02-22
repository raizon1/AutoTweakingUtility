namespace Auto_Tweaking_Utility
{
    partial class ServicesTweaksForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServicesTweaksForm));
            this.ComboBoxServicesConfig = new System.Windows.Forms.ComboBox();
            this.Label = new System.Windows.Forms.Label();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.ButtonOK = new System.Windows.Forms.Button();
            this.ComboBoxOutline = new System.Windows.Forms.Panel();
            this.Titlebar = new System.Windows.Forms.Panel();
            this.Titlebar_Label = new System.Windows.Forms.Label();
            this.Titlebar_Close = new System.Windows.Forms.Button();
            this.ComboBoxOutline.SuspendLayout();
            this.Titlebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // ComboBoxServicesConfig
            // 
            this.ComboBoxServicesConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(72)))));
            this.ComboBoxServicesConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBoxServicesConfig.ForeColor = System.Drawing.Color.White;
            this.ComboBoxServicesConfig.FormattingEnabled = true;
            this.ComboBoxServicesConfig.Items.AddRange(new object[] {
            "Bare 7",
            "Default 7",
            "Bare 8.1",
            "Default 8.1",
            "Bare 1709",
            "Default 1709",
            "Bare 2004",
            "Default 2004",
            "Bare 2009",
            "Default 2009"});
            this.ComboBoxServicesConfig.Location = new System.Drawing.Point(-1, -1);
            this.ComboBoxServicesConfig.Name = "ComboBoxServicesConfig";
            this.ComboBoxServicesConfig.Size = new System.Drawing.Size(121, 21);
            this.ComboBoxServicesConfig.TabIndex = 0;
            this.ComboBoxServicesConfig.Text = "Unknown";
            this.ComboBoxServicesConfig.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ServicesConfig_KeyPress);
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Location = new System.Drawing.Point(9, 37);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(201, 13);
            this.Label.TabIndex = 1;
            this.Label.Text = "Current services config (please select):";
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(72)))));
            this.ButtonCancel.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ButtonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCancel.Location = new System.Drawing.Point(267, 70);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(75, 21);
            this.ButtonCancel.TabIndex = 48;
            this.ButtonCancel.Text = "Cancel";
            this.ButtonCancel.UseVisualStyleBackColor = false;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // ButtonOK
            // 
            this.ButtonOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(72)))));
            this.ButtonOK.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ButtonOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonOK.Location = new System.Drawing.Point(186, 70);
            this.ButtonOK.Name = "ButtonOK";
            this.ButtonOK.Size = new System.Drawing.Size(75, 21);
            this.ButtonOK.TabIndex = 47;
            this.ButtonOK.Text = "OK";
            this.ButtonOK.UseVisualStyleBackColor = false;
            this.ButtonOK.Click += new System.EventHandler(this.ButtonOK_Click);
            // 
            // ComboBoxOutline
            // 
            this.ComboBoxOutline.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ComboBoxOutline.Controls.Add(this.ComboBoxServicesConfig);
            this.ComboBoxOutline.Location = new System.Drawing.Point(221, 34);
            this.ComboBoxOutline.Name = "ComboBoxOutline";
            this.ComboBoxOutline.Size = new System.Drawing.Size(121, 21);
            this.ComboBoxOutline.TabIndex = 111;
            // 
            // Titlebar
            // 
            this.Titlebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(63)))), ((int)(((byte)(76)))));
            this.Titlebar.Controls.Add(this.Titlebar_Label);
            this.Titlebar.Controls.Add(this.Titlebar_Close);
            this.Titlebar.Location = new System.Drawing.Point(0, 0);
            this.Titlebar.Name = "Titlebar";
            this.Titlebar.Size = new System.Drawing.Size(354, 25);
            this.Titlebar.TabIndex = 140;
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
            this.Titlebar_Label.Text = "Services tweaks";
            this.Titlebar_Label.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Titlebar_MouseDown);
            // 
            // Titlebar_Close
            // 
            this.Titlebar_Close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Titlebar_Close.BackgroundImage")));
            this.Titlebar_Close.FlatAppearance.BorderSize = 0;
            this.Titlebar_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Titlebar_Close.Location = new System.Drawing.Point(335, 5);
            this.Titlebar_Close.Name = "Titlebar_Close";
            this.Titlebar_Close.Size = new System.Drawing.Size(15, 15);
            this.Titlebar_Close.TabIndex = 0;
            this.Titlebar_Close.UseVisualStyleBackColor = true;
            this.Titlebar_Close.Click += new System.EventHandler(this.Titlebar_Close_Click);
            // 
            // ServicesTweaksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(75)))), ((int)(((byte)(87)))));
            this.ClientSize = new System.Drawing.Size(354, 103);
            this.Controls.Add(this.Titlebar);
            this.Controls.Add(this.ComboBoxOutline);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonOK);
            this.Controls.Add(this.Label);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ServicesTweaksForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Services tweaks";
            this.Load += new System.EventHandler(this.ServicesTweaksForm_Load);
            this.ComboBoxOutline.ResumeLayout(false);
            this.Titlebar.ResumeLayout(false);
            this.Titlebar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ComboBoxServicesConfig;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.Button ButtonOK;
        private System.Windows.Forms.Panel ComboBoxOutline;
        private System.Windows.Forms.Panel Titlebar;
        private System.Windows.Forms.Label Titlebar_Label;
        private System.Windows.Forms.Button Titlebar_Close;
    }
}