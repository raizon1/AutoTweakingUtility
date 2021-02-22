namespace Auto_Tweaking_Utility
{
    partial class MessageNumberLimitDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageNumberLimitDialog));
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.ButtonOK = new System.Windows.Forms.Button();
            this.MsgNumberLimit = new System.Windows.Forms.NumericUpDown();
            this.Titlebar = new System.Windows.Forms.Panel();
            this.Titlebar_Label = new System.Windows.Forms.Label();
            this.Titlebar_Close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MsgNumberLimit)).BeginInit();
            this.Titlebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(72)))));
            this.ButtonCancel.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ButtonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCancel.Location = new System.Drawing.Point(180, 81);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(75, 23);
            this.ButtonCancel.TabIndex = 58;
            this.ButtonCancel.Text = "Cancel";
            this.ButtonCancel.UseVisualStyleBackColor = false;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // ButtonOK
            // 
            this.ButtonOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(72)))));
            this.ButtonOK.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ButtonOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonOK.Location = new System.Drawing.Point(99, 81);
            this.ButtonOK.Name = "ButtonOK";
            this.ButtonOK.Size = new System.Drawing.Size(75, 23);
            this.ButtonOK.TabIndex = 57;
            this.ButtonOK.Text = "OK";
            this.ButtonOK.UseVisualStyleBackColor = false;
            this.ButtonOK.Click += new System.EventHandler(this.ButtonOK_Click);
            // 
            // MsgNumberLimit
            // 
            this.MsgNumberLimit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(72)))));
            this.MsgNumberLimit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MsgNumberLimit.ForeColor = System.Drawing.Color.White;
            this.MsgNumberLimit.Location = new System.Drawing.Point(13, 38);
            this.MsgNumberLimit.Maximum = new decimal(new int[] {
            2048,
            0,
            0,
            0});
            this.MsgNumberLimit.Name = "MsgNumberLimit";
            this.MsgNumberLimit.Size = new System.Drawing.Size(120, 22);
            this.MsgNumberLimit.TabIndex = 59;
            this.MsgNumberLimit.Validated += new System.EventHandler(this.MsgNumberLimit_Validated);
            // 
            // Titlebar
            // 
            this.Titlebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(63)))), ((int)(((byte)(76)))));
            this.Titlebar.Controls.Add(this.Titlebar_Label);
            this.Titlebar.Controls.Add(this.Titlebar_Close);
            this.Titlebar.Location = new System.Drawing.Point(0, 0);
            this.Titlebar.Name = "Titlebar";
            this.Titlebar.Size = new System.Drawing.Size(267, 25);
            this.Titlebar.TabIndex = 138;
            this.Titlebar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Titlebar_MouseDown);
            // 
            // Titlebar_Label
            // 
            this.Titlebar_Label.AutoSize = true;
            this.Titlebar_Label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Titlebar_Label.ForeColor = System.Drawing.Color.White;
            this.Titlebar_Label.Location = new System.Drawing.Point(4, 5);
            this.Titlebar_Label.Name = "Titlebar_Label";
            this.Titlebar_Label.Size = new System.Drawing.Size(120, 13);
            this.Titlebar_Label.TabIndex = 3;
            this.Titlebar_Label.Text = "Message number limit";
            this.Titlebar_Label.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Titlebar_MouseDown);
            // 
            // Titlebar_Close
            // 
            this.Titlebar_Close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Titlebar_Close.BackgroundImage")));
            this.Titlebar_Close.FlatAppearance.BorderSize = 0;
            this.Titlebar_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Titlebar_Close.Location = new System.Drawing.Point(248, 5);
            this.Titlebar_Close.Name = "Titlebar_Close";
            this.Titlebar_Close.Size = new System.Drawing.Size(15, 15);
            this.Titlebar_Close.TabIndex = 0;
            this.Titlebar_Close.UseVisualStyleBackColor = true;
            this.Titlebar_Close.Click += new System.EventHandler(this.Titlebar_Close_Click);
            // 
            // MessageNumberLimitDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(75)))), ((int)(((byte)(87)))));
            this.ClientSize = new System.Drawing.Size(267, 116);
            this.Controls.Add(this.Titlebar);
            this.Controls.Add(this.MsgNumberLimit);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonOK);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MessageNumberLimitDialog";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Message number limit";
            this.Load += new System.EventHandler(this.MessageNumberLimitDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MsgNumberLimit)).EndInit();
            this.Titlebar.ResumeLayout(false);
            this.Titlebar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.Button ButtonOK;
        private System.Windows.Forms.NumericUpDown MsgNumberLimit;
        private System.Windows.Forms.Panel Titlebar;
        private System.Windows.Forms.Label Titlebar_Label;
        private System.Windows.Forms.Button Titlebar_Close;
    }
}