
namespace Auto_Tweaking_Utility
{
    partial class InstallProgramsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InstallProgramsForm));
            this.ButtonInstallMemoryCleaner = new System.Windows.Forms.Button();
            this.ButtonInstallRipcord = new System.Windows.Forms.Button();
            this.ButtonInstall7Zip = new System.Windows.Forms.Button();
            this.ButtonInstallProcessExplorer = new System.Windows.Forms.Button();
            this.ButtonInstallDDU = new System.Windows.Forms.Button();
            this.Titlebar = new System.Windows.Forms.Panel();
            this.Titlebar_Label = new System.Windows.Forms.Label();
            this.Titlebar_Close = new System.Windows.Forms.Button();
            this.Titlebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonInstallMemoryCleaner
            // 
            this.ButtonInstallMemoryCleaner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(72)))));
            this.ButtonInstallMemoryCleaner.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ButtonInstallMemoryCleaner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonInstallMemoryCleaner.Location = new System.Drawing.Point(160, 32);
            this.ButtonInstallMemoryCleaner.Name = "ButtonInstallMemoryCleaner";
            this.ButtonInstallMemoryCleaner.Size = new System.Drawing.Size(140, 23);
            this.ButtonInstallMemoryCleaner.TabIndex = 7;
            this.ButtonInstallMemoryCleaner.Text = "Install Memory Cleaner";
            this.ButtonInstallMemoryCleaner.UseVisualStyleBackColor = false;
            this.ButtonInstallMemoryCleaner.Click += new System.EventHandler(this.ButtonInstallMemoryCleaner_Click);
            // 
            // ButtonInstallRipcord
            // 
            this.ButtonInstallRipcord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(72)))));
            this.ButtonInstallRipcord.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ButtonInstallRipcord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonInstallRipcord.Location = new System.Drawing.Point(160, 62);
            this.ButtonInstallRipcord.Name = "ButtonInstallRipcord";
            this.ButtonInstallRipcord.Size = new System.Drawing.Size(140, 23);
            this.ButtonInstallRipcord.TabIndex = 6;
            this.ButtonInstallRipcord.Text = "Install Ripcord";
            this.ButtonInstallRipcord.UseVisualStyleBackColor = false;
            this.ButtonInstallRipcord.Click += new System.EventHandler(this.ButtonInstallRipcord_Click);
            // 
            // ButtonInstall7Zip
            // 
            this.ButtonInstall7Zip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(72)))));
            this.ButtonInstall7Zip.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ButtonInstall7Zip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonInstall7Zip.Location = new System.Drawing.Point(12, 62);
            this.ButtonInstall7Zip.Name = "ButtonInstall7Zip";
            this.ButtonInstall7Zip.Size = new System.Drawing.Size(142, 23);
            this.ButtonInstall7Zip.TabIndex = 5;
            this.ButtonInstall7Zip.Text = "Install 7-Zip";
            this.ButtonInstall7Zip.UseVisualStyleBackColor = false;
            this.ButtonInstall7Zip.Click += new System.EventHandler(this.ButtonInstall7Zip_Click);
            // 
            // ButtonInstallProcessExplorer
            // 
            this.ButtonInstallProcessExplorer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(72)))));
            this.ButtonInstallProcessExplorer.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ButtonInstallProcessExplorer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonInstallProcessExplorer.Location = new System.Drawing.Point(12, 32);
            this.ButtonInstallProcessExplorer.Name = "ButtonInstallProcessExplorer";
            this.ButtonInstallProcessExplorer.Size = new System.Drawing.Size(142, 23);
            this.ButtonInstallProcessExplorer.TabIndex = 4;
            this.ButtonInstallProcessExplorer.Text = "Install Process Explorer";
            this.ButtonInstallProcessExplorer.UseVisualStyleBackColor = false;
            this.ButtonInstallProcessExplorer.Click += new System.EventHandler(this.ButtonInstallProcessExplorer_Click);
            // 
            // ButtonInstallDDU
            // 
            this.ButtonInstallDDU.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(72)))));
            this.ButtonInstallDDU.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ButtonInstallDDU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonInstallDDU.Location = new System.Drawing.Point(12, 91);
            this.ButtonInstallDDU.Name = "ButtonInstallDDU";
            this.ButtonInstallDDU.Size = new System.Drawing.Size(288, 23);
            this.ButtonInstallDDU.TabIndex = 8;
            this.ButtonInstallDDU.Text = "Install Display Driver Uninstaller (DDU)";
            this.ButtonInstallDDU.UseVisualStyleBackColor = false;
            this.ButtonInstallDDU.Click += new System.EventHandler(this.ButtonInstallDDU_Click);
            // 
            // Titlebar
            // 
            this.Titlebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(63)))), ((int)(((byte)(76)))));
            this.Titlebar.Controls.Add(this.Titlebar_Label);
            this.Titlebar.Controls.Add(this.Titlebar_Close);
            this.Titlebar.Location = new System.Drawing.Point(0, 0);
            this.Titlebar.Name = "Titlebar";
            this.Titlebar.Size = new System.Drawing.Size(313, 25);
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
            this.Titlebar_Label.Size = new System.Drawing.Size(90, 13);
            this.Titlebar_Label.TabIndex = 3;
            this.Titlebar_Label.Text = "Install programs";
            this.Titlebar_Label.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Titlebar_MouseDown);
            // 
            // Titlebar_Close
            // 
            this.Titlebar_Close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Titlebar_Close.BackgroundImage")));
            this.Titlebar_Close.FlatAppearance.BorderSize = 0;
            this.Titlebar_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Titlebar_Close.Location = new System.Drawing.Point(294, 5);
            this.Titlebar_Close.Name = "Titlebar_Close";
            this.Titlebar_Close.Size = new System.Drawing.Size(15, 15);
            this.Titlebar_Close.TabIndex = 0;
            this.Titlebar_Close.UseVisualStyleBackColor = true;
            this.Titlebar_Close.Click += new System.EventHandler(this.Titlebar_Close_Click);
            // 
            // InstallProgramsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(75)))), ((int)(((byte)(87)))));
            this.ClientSize = new System.Drawing.Size(313, 126);
            this.Controls.Add(this.Titlebar);
            this.Controls.Add(this.ButtonInstallDDU);
            this.Controls.Add(this.ButtonInstallMemoryCleaner);
            this.Controls.Add(this.ButtonInstallRipcord);
            this.Controls.Add(this.ButtonInstall7Zip);
            this.Controls.Add(this.ButtonInstallProcessExplorer);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InstallProgramsForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Install programs";
            this.Titlebar.ResumeLayout(false);
            this.Titlebar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonInstallMemoryCleaner;
        private System.Windows.Forms.Button ButtonInstallRipcord;
        private System.Windows.Forms.Button ButtonInstall7Zip;
        private System.Windows.Forms.Button ButtonInstallProcessExplorer;
        private System.Windows.Forms.Button ButtonInstallDDU;
        private System.Windows.Forms.Panel Titlebar;
        private System.Windows.Forms.Label Titlebar_Label;
        private System.Windows.Forms.Button Titlebar_Close;
    }
}