namespace Auto_Tweaking_Utility
{
    partial class SchedulingTweaksForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SchedulingTweaksForm));
            this.ButtonOK = new System.Windows.Forms.Button();
            this.ButtonRevertSettings = new System.Windows.Forms.Button();
            this.ButtonLoadRecommendedSettings = new System.Windows.Forms.Button();
            this.ComboBoxWin32PrioritySeparation = new System.Windows.Forms.ComboBox();
            this.LabelWin32PrioritySeparation = new System.Windows.Forms.Label();
            this.LabelNetworkThrottlingIndex = new System.Windows.Forms.Label();
            this.LabelSystemResponsiveness = new System.Windows.Forms.Label();
            this.TableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ComboBoxSystemResponsiveness = new System.Windows.Forms.ComboBox();
            this.ComboBoxNetworkThrottlingIndex = new System.Windows.Forms.ComboBox();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.ComboBoxOutline = new System.Windows.Forms.Panel();
            this.ComboBoxOutline1 = new System.Windows.Forms.Panel();
            this.ComboBoxOutline2 = new System.Windows.Forms.Panel();
            this.Titlebar = new System.Windows.Forms.Panel();
            this.Titlebar_Label = new System.Windows.Forms.Label();
            this.Titlebar_Close = new System.Windows.Forms.Button();
            this.TableLayoutPanel.SuspendLayout();
            this.ComboBoxOutline.SuspendLayout();
            this.ComboBoxOutline1.SuspendLayout();
            this.ComboBoxOutline2.SuspendLayout();
            this.Titlebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonOK
            // 
            this.ButtonOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(72)))));
            this.ButtonOK.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ButtonOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonOK.Location = new System.Drawing.Point(4, 123);
            this.ButtonOK.Name = "ButtonOK";
            this.ButtonOK.Size = new System.Drawing.Size(75, 23);
            this.ButtonOK.TabIndex = 47;
            this.ButtonOK.Text = "OK";
            this.ButtonOK.UseVisualStyleBackColor = false;
            this.ButtonOK.Click += new System.EventHandler(this.ButtonOK_Click);
            // 
            // ButtonRevertSettings
            // 
            this.ButtonRevertSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(72)))));
            this.ButtonRevertSettings.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ButtonRevertSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonRevertSettings.Location = new System.Drawing.Point(341, 123);
            this.ButtonRevertSettings.Name = "ButtonRevertSettings";
            this.ButtonRevertSettings.Size = new System.Drawing.Size(98, 23);
            this.ButtonRevertSettings.TabIndex = 103;
            this.ButtonRevertSettings.Text = "Revert settings";
            this.ButtonRevertSettings.UseVisualStyleBackColor = false;
            this.ButtonRevertSettings.Click += new System.EventHandler(this.ButtonRevertSettings_Click);
            // 
            // ButtonLoadRecommendedSettings
            // 
            this.ButtonLoadRecommendedSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(72)))));
            this.ButtonLoadRecommendedSettings.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ButtonLoadRecommendedSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonLoadRecommendedSettings.Location = new System.Drawing.Point(168, 123);
            this.ButtonLoadRecommendedSettings.Name = "ButtonLoadRecommendedSettings";
            this.ButtonLoadRecommendedSettings.Size = new System.Drawing.Size(167, 23);
            this.ButtonLoadRecommendedSettings.TabIndex = 102;
            this.ButtonLoadRecommendedSettings.Text = "Load recommended settings";
            this.ButtonLoadRecommendedSettings.UseVisualStyleBackColor = false;
            this.ButtonLoadRecommendedSettings.Click += new System.EventHandler(this.ButtonLoadRecommendedSettings_Click);
            // 
            // ComboBoxWin32PrioritySeparation
            // 
            this.ComboBoxWin32PrioritySeparation.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ComboBoxWin32PrioritySeparation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(72)))));
            this.ComboBoxWin32PrioritySeparation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBoxWin32PrioritySeparation.ForeColor = System.Drawing.Color.White;
            this.ComboBoxWin32PrioritySeparation.FormattingEnabled = true;
            this.ComboBoxWin32PrioritySeparation.Items.AddRange(new object[] {
            "22",
            "24",
            "28",
            "37",
            "38",
            "40"});
            this.ComboBoxWin32PrioritySeparation.Location = new System.Drawing.Point(-1, -1);
            this.ComboBoxWin32PrioritySeparation.Name = "ComboBoxWin32PrioritySeparation";
            this.ComboBoxWin32PrioritySeparation.Size = new System.Drawing.Size(111, 21);
            this.ComboBoxWin32PrioritySeparation.TabIndex = 106;
            this.ComboBoxWin32PrioritySeparation.Text = "40";
            this.ComboBoxWin32PrioritySeparation.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Win32PrioritySeparation_KeyPress);
            // 
            // LabelWin32PrioritySeparation
            // 
            this.LabelWin32PrioritySeparation.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LabelWin32PrioritySeparation.AutoSize = true;
            this.LabelWin32PrioritySeparation.Location = new System.Drawing.Point(3, 7);
            this.LabelWin32PrioritySeparation.Name = "LabelWin32PrioritySeparation";
            this.LabelWin32PrioritySeparation.Size = new System.Drawing.Size(135, 13);
            this.LabelWin32PrioritySeparation.TabIndex = 105;
            this.LabelWin32PrioritySeparation.Text = "Win32PrioritySeparation:";
            this.LabelWin32PrioritySeparation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ToolTip.SetToolTip(this.LabelWin32PrioritySeparation, "Controls the amount of time that the Windows process scheduler allocates to each " +
        "program");
            // 
            // LabelNetworkThrottlingIndex
            // 
            this.LabelNetworkThrottlingIndex.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LabelNetworkThrottlingIndex.AutoSize = true;
            this.LabelNetworkThrottlingIndex.Location = new System.Drawing.Point(3, 35);
            this.LabelNetworkThrottlingIndex.Name = "LabelNetworkThrottlingIndex";
            this.LabelNetworkThrottlingIndex.Size = new System.Drawing.Size(133, 13);
            this.LabelNetworkThrottlingIndex.TabIndex = 107;
            this.LabelNetworkThrottlingIndex.Text = "NetworkThrottlingIndex:";
            this.LabelNetworkThrottlingIndex.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ToolTip.SetToolTip(this.LabelNetworkThrottlingIndex, "Controls the percentage of the connection\'s bandwidth that the system can reserve" +
        "");
            // 
            // LabelSystemResponsiveness
            // 
            this.LabelSystemResponsiveness.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LabelSystemResponsiveness.AutoSize = true;
            this.LabelSystemResponsiveness.Location = new System.Drawing.Point(3, 64);
            this.LabelSystemResponsiveness.Name = "LabelSystemResponsiveness";
            this.LabelSystemResponsiveness.Size = new System.Drawing.Size(126, 13);
            this.LabelSystemResponsiveness.TabIndex = 108;
            this.LabelSystemResponsiveness.Text = "SystemResponsiveness:";
            this.LabelSystemResponsiveness.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ToolTip.SetToolTip(this.LabelSystemResponsiveness, "Controls the percentage of CPU Resources that should be guaranteed to low priorit" +
        "y MMCSS tasks");
            // 
            // TableLayoutPanel
            // 
            this.TableLayoutPanel.ColumnCount = 2;
            this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TableLayoutPanel.Controls.Add(this.ComboBoxOutline1, 1, 2);
            this.TableLayoutPanel.Controls.Add(this.ComboBoxOutline2, 1, 1);
            this.TableLayoutPanel.Controls.Add(this.LabelWin32PrioritySeparation, 0, 0);
            this.TableLayoutPanel.Controls.Add(this.LabelSystemResponsiveness, 0, 2);
            this.TableLayoutPanel.Controls.Add(this.LabelNetworkThrottlingIndex, 0, 1);
            this.TableLayoutPanel.Controls.Add(this.ComboBoxOutline, 1, 0);
            this.TableLayoutPanel.Location = new System.Drawing.Point(4, 29);
            this.TableLayoutPanel.Name = "TableLayoutPanel";
            this.TableLayoutPanel.RowCount = 3;
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TableLayoutPanel.Size = new System.Drawing.Size(435, 86);
            this.TableLayoutPanel.TabIndex = 109;
            // 
            // ComboBoxSystemResponsiveness
            // 
            this.ComboBoxSystemResponsiveness.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ComboBoxSystemResponsiveness.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(72)))));
            this.ComboBoxSystemResponsiveness.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBoxSystemResponsiveness.ForeColor = System.Drawing.Color.White;
            this.ComboBoxSystemResponsiveness.FormattingEnabled = true;
            this.ComboBoxSystemResponsiveness.Items.AddRange(new object[] {
            "0",
            "10",
            "20",
            "30"});
            this.ComboBoxSystemResponsiveness.Location = new System.Drawing.Point(-1, -1);
            this.ComboBoxSystemResponsiveness.Name = "ComboBoxSystemResponsiveness";
            this.ComboBoxSystemResponsiveness.Size = new System.Drawing.Size(111, 21);
            this.ComboBoxSystemResponsiveness.TabIndex = 110;
            this.ComboBoxSystemResponsiveness.Text = "10";
            this.ComboBoxSystemResponsiveness.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SystemResponsiveness_KeyPress);
            // 
            // ComboBoxNetworkThrottlingIndex
            // 
            this.ComboBoxNetworkThrottlingIndex.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ComboBoxNetworkThrottlingIndex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(72)))));
            this.ComboBoxNetworkThrottlingIndex.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBoxNetworkThrottlingIndex.ForeColor = System.Drawing.Color.White;
            this.ComboBoxNetworkThrottlingIndex.FormattingEnabled = true;
            this.ComboBoxNetworkThrottlingIndex.Items.AddRange(new object[] {
            "10",
            "20",
            "30",
            "70"});
            this.ComboBoxNetworkThrottlingIndex.Location = new System.Drawing.Point(-1, -1);
            this.ComboBoxNetworkThrottlingIndex.Name = "ComboBoxNetworkThrottlingIndex";
            this.ComboBoxNetworkThrottlingIndex.Size = new System.Drawing.Size(111, 21);
            this.ComboBoxNetworkThrottlingIndex.TabIndex = 109;
            this.ComboBoxNetworkThrottlingIndex.Text = "10";
            this.ComboBoxNetworkThrottlingIndex.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NetworkThrottlingIndex_KeyPress);
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(72)))));
            this.ButtonCancel.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ButtonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCancel.Location = new System.Drawing.Point(87, 123);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(75, 23);
            this.ButtonCancel.TabIndex = 48;
            this.ButtonCancel.Text = "Cancel";
            this.ButtonCancel.UseVisualStyleBackColor = false;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // ComboBoxOutline
            // 
            this.ComboBoxOutline.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ComboBoxOutline.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ComboBoxOutline.Controls.Add(this.ComboBoxWin32PrioritySeparation);
            this.ComboBoxOutline.Location = new System.Drawing.Point(321, 3);
            this.ComboBoxOutline.Name = "ComboBoxOutline";
            this.ComboBoxOutline.Size = new System.Drawing.Size(111, 21);
            this.ComboBoxOutline.TabIndex = 112;
            // 
            // ComboBoxOutline1
            // 
            this.ComboBoxOutline1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ComboBoxOutline1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ComboBoxOutline1.Controls.Add(this.ComboBoxSystemResponsiveness);
            this.ComboBoxOutline1.Location = new System.Drawing.Point(321, 60);
            this.ComboBoxOutline1.Name = "ComboBoxOutline1";
            this.ComboBoxOutline1.Size = new System.Drawing.Size(111, 21);
            this.ComboBoxOutline1.TabIndex = 113;
            // 
            // ComboBoxOutline2
            // 
            this.ComboBoxOutline2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ComboBoxOutline2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ComboBoxOutline2.Controls.Add(this.ComboBoxNetworkThrottlingIndex);
            this.ComboBoxOutline2.Location = new System.Drawing.Point(321, 31);
            this.ComboBoxOutline2.Name = "ComboBoxOutline2";
            this.ComboBoxOutline2.Size = new System.Drawing.Size(111, 21);
            this.ComboBoxOutline2.TabIndex = 114;
            // 
            // Titlebar
            // 
            this.Titlebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(63)))), ((int)(((byte)(76)))));
            this.Titlebar.Controls.Add(this.Titlebar_Label);
            this.Titlebar.Controls.Add(this.Titlebar_Close);
            this.Titlebar.Location = new System.Drawing.Point(0, 0);
            this.Titlebar.Name = "Titlebar";
            this.Titlebar.Size = new System.Drawing.Size(445, 25);
            this.Titlebar.TabIndex = 141;
            this.Titlebar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Titlebar_MouseDown);
            // 
            // Titlebar_Label
            // 
            this.Titlebar_Label.AutoSize = true;
            this.Titlebar_Label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Titlebar_Label.ForeColor = System.Drawing.Color.White;
            this.Titlebar_Label.Location = new System.Drawing.Point(4, 5);
            this.Titlebar_Label.Name = "Titlebar_Label";
            this.Titlebar_Label.Size = new System.Drawing.Size(104, 13);
            this.Titlebar_Label.TabIndex = 3;
            this.Titlebar_Label.Text = "Scheduling tweaks";
            this.Titlebar_Label.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Titlebar_MouseDown);
            // 
            // Titlebar_Close
            // 
            this.Titlebar_Close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Titlebar_Close.BackgroundImage")));
            this.Titlebar_Close.FlatAppearance.BorderSize = 0;
            this.Titlebar_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Titlebar_Close.Location = new System.Drawing.Point(426, 5);
            this.Titlebar_Close.Name = "Titlebar_Close";
            this.Titlebar_Close.Size = new System.Drawing.Size(15, 15);
            this.Titlebar_Close.TabIndex = 0;
            this.Titlebar_Close.UseVisualStyleBackColor = true;
            this.Titlebar_Close.Click += new System.EventHandler(this.Titlebar_Close_Click);
            // 
            // SchedulingTweaksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(75)))), ((int)(((byte)(87)))));
            this.ClientSize = new System.Drawing.Size(445, 150);
            this.Controls.Add(this.Titlebar);
            this.Controls.Add(this.TableLayoutPanel);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonOK);
            this.Controls.Add(this.ButtonRevertSettings);
            this.Controls.Add(this.ButtonLoadRecommendedSettings);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SchedulingTweaksForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Scheduling tweaks";
            this.Shown += new System.EventHandler(this.SchedulingTweaksForm_Shown);
            this.TableLayoutPanel.ResumeLayout(false);
            this.TableLayoutPanel.PerformLayout();
            this.ComboBoxOutline.ResumeLayout(false);
            this.ComboBoxOutline1.ResumeLayout(false);
            this.ComboBoxOutline2.ResumeLayout(false);
            this.Titlebar.ResumeLayout(false);
            this.Titlebar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button ButtonOK;
        private System.Windows.Forms.Button ButtonRevertSettings;
        private System.Windows.Forms.Button ButtonLoadRecommendedSettings;
        private System.Windows.Forms.ComboBox ComboBoxWin32PrioritySeparation;
        private System.Windows.Forms.Label LabelWin32PrioritySeparation;
        private System.Windows.Forms.Label LabelNetworkThrottlingIndex;
        private System.Windows.Forms.Label LabelSystemResponsiveness;
        private System.Windows.Forms.TableLayoutPanel TableLayoutPanel;
        private System.Windows.Forms.ComboBox ComboBoxSystemResponsiveness;
        private System.Windows.Forms.ComboBox ComboBoxNetworkThrottlingIndex;
        private System.Windows.Forms.ToolTip ToolTip;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.Panel ComboBoxOutline1;
        private System.Windows.Forms.Panel ComboBoxOutline2;
        private System.Windows.Forms.Panel ComboBoxOutline;
        private System.Windows.Forms.Panel Titlebar;
        private System.Windows.Forms.Label Titlebar_Label;
        private System.Windows.Forms.Button Titlebar_Close;
    }
}