namespace Auto_Tweaking_Utility
{
    partial class InterruptPriorityDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InterruptPriorityDialog));
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.ButtonOK = new System.Windows.Forms.Button();
            this.Undefined = new System.Windows.Forms.RadioButton();
            this.Low = new System.Windows.Forms.RadioButton();
            this.Normal = new System.Windows.Forms.RadioButton();
            this.High = new System.Windows.Forms.RadioButton();
            this.Titlebar = new System.Windows.Forms.Panel();
            this.Titlebar_Label = new System.Windows.Forms.Label();
            this.Titlebar_Close = new System.Windows.Forms.Button();
            this.Titlebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(72)))));
            this.ButtonCancel.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ButtonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCancel.Location = new System.Drawing.Point(249, 147);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(75, 23);
            this.ButtonCancel.TabIndex = 54;
            this.ButtonCancel.Text = "Cancel";
            this.ButtonCancel.UseVisualStyleBackColor = false;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // ButtonOK
            // 
            this.ButtonOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(72)))));
            this.ButtonOK.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ButtonOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonOK.Location = new System.Drawing.Point(168, 147);
            this.ButtonOK.Name = "ButtonOK";
            this.ButtonOK.Size = new System.Drawing.Size(75, 23);
            this.ButtonOK.TabIndex = 53;
            this.ButtonOK.Text = "OK";
            this.ButtonOK.UseVisualStyleBackColor = false;
            this.ButtonOK.Click += new System.EventHandler(this.ButtonOK_Click);
            // 
            // Undefined
            // 
            this.Undefined.AutoSize = true;
            this.Undefined.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Undefined.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Undefined.Location = new System.Drawing.Point(12, 37);
            this.Undefined.Name = "Undefined";
            this.Undefined.Size = new System.Drawing.Size(79, 17);
            this.Undefined.TabIndex = 55;
            this.Undefined.TabStop = true;
            this.Undefined.Text = "Undefined";
            this.Undefined.UseVisualStyleBackColor = true;
            // 
            // Low
            // 
            this.Low.AutoSize = true;
            this.Low.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Low.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Low.Location = new System.Drawing.Point(12, 61);
            this.Low.Name = "Low";
            this.Low.Size = new System.Drawing.Size(45, 17);
            this.Low.TabIndex = 56;
            this.Low.TabStop = true;
            this.Low.Text = "Low";
            this.Low.UseVisualStyleBackColor = true;
            // 
            // Normal
            // 
            this.Normal.AutoSize = true;
            this.Normal.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Normal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Normal.Location = new System.Drawing.Point(12, 85);
            this.Normal.Name = "Normal";
            this.Normal.Size = new System.Drawing.Size(61, 17);
            this.Normal.TabIndex = 57;
            this.Normal.TabStop = true;
            this.Normal.Text = "Normal";
            this.Normal.UseVisualStyleBackColor = true;
            // 
            // High
            // 
            this.High.AutoSize = true;
            this.High.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.High.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.High.Location = new System.Drawing.Point(12, 109);
            this.High.Name = "High";
            this.High.Size = new System.Drawing.Size(49, 17);
            this.High.TabIndex = 58;
            this.High.TabStop = true;
            this.High.Text = "High";
            this.High.UseVisualStyleBackColor = true;
            // 
            // Titlebar
            // 
            this.Titlebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(63)))), ((int)(((byte)(76)))));
            this.Titlebar.Controls.Add(this.Titlebar_Label);
            this.Titlebar.Controls.Add(this.Titlebar_Close);
            this.Titlebar.Location = new System.Drawing.Point(0, 0);
            this.Titlebar.Name = "Titlebar";
            this.Titlebar.Size = new System.Drawing.Size(336, 25);
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
            this.Titlebar_Label.Size = new System.Drawing.Size(93, 13);
            this.Titlebar_Label.TabIndex = 3;
            this.Titlebar_Label.Text = "Interrupt priority";
            this.Titlebar_Label.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Titlebar_MouseDown);
            // 
            // Titlebar_Close
            // 
            this.Titlebar_Close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Titlebar_Close.BackgroundImage")));
            this.Titlebar_Close.FlatAppearance.BorderSize = 0;
            this.Titlebar_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Titlebar_Close.Location = new System.Drawing.Point(317, 5);
            this.Titlebar_Close.Name = "Titlebar_Close";
            this.Titlebar_Close.Size = new System.Drawing.Size(15, 15);
            this.Titlebar_Close.TabIndex = 0;
            this.Titlebar_Close.UseVisualStyleBackColor = true;
            this.Titlebar_Close.Click += new System.EventHandler(this.Titlebar_Close_Click);
            // 
            // InterruptPriorityDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(75)))), ((int)(((byte)(87)))));
            this.ClientSize = new System.Drawing.Size(336, 182);
            this.Controls.Add(this.Titlebar);
            this.Controls.Add(this.High);
            this.Controls.Add(this.Normal);
            this.Controls.Add(this.Low);
            this.Controls.Add(this.Undefined);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonOK);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InterruptPriorityDialog";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Interrupt priority";
            this.Load += new System.EventHandler(this.InterruptPriorityDialog_Load);
            this.Titlebar.ResumeLayout(false);
            this.Titlebar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.Button ButtonOK;
        private System.Windows.Forms.RadioButton Undefined;
        private System.Windows.Forms.RadioButton Low;
        private System.Windows.Forms.RadioButton Normal;
        private System.Windows.Forms.RadioButton High;
        private System.Windows.Forms.Panel Titlebar;
        private System.Windows.Forms.Label Titlebar_Label;
        private System.Windows.Forms.Button Titlebar_Close;
    }
}