namespace PcComponentnsStats
{
    partial class Settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.txtSettings = new System.Windows.Forms.Label();
            this.chbxSendNotifactionns = new System.Windows.Forms.CheckBox();
            this.btnSettings = new PcComponentnsStats.resources.customButtons();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtSettings
            // 
            this.txtSettings.AutoSize = true;
            this.txtSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtSettings.Location = new System.Drawing.Point(12, 9);
            this.txtSettings.Name = "txtSettings";
            this.txtSettings.Size = new System.Drawing.Size(200, 54);
            this.txtSettings.TabIndex = 0;
            this.txtSettings.Text = "Settings";
            // 
            // chbxSendNotifactionns
            // 
            this.chbxSendNotifactionns.AutoSize = true;
            this.chbxSendNotifactionns.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chbxSendNotifactionns.Location = new System.Drawing.Point(21, 66);
            this.chbxSendNotifactionns.Name = "chbxSendNotifactionns";
            this.chbxSendNotifactionns.Size = new System.Drawing.Size(219, 33);
            this.chbxSendNotifactionns.TabIndex = 1;
            this.chbxSendNotifactionns.Text = "Send notifactions";
            this.chbxSendNotifactionns.UseVisualStyleBackColor = true;
            this.chbxSendNotifactionns.CheckedChanged += new System.EventHandler(this.chbxSendNotifactionns_CheckedChanged);
            // 
            // btnSettings
            // 
            this.btnSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSettings.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSettings.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSettings.BorderRadius = 5;
            this.btnSettings.BorderSize = 0;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.Location = new System.Drawing.Point(651, 298);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(137, 37);
            this.btnSettings.TabIndex = 7;
            this.btnSettings.Text = "Go back";
            this.btnSettings.TextdColor = System.Drawing.Color.White;
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBox1.Location = new System.Drawing.Point(21, 105);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(153, 33);
            this.checkBox1.TabIndex = 17;
            this.checkBox1.Text = "Dark mode";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 347);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.chbxSendNotifactionns);
            this.Controls.Add(this.txtSettings);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Settings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtSettings;
        private System.Windows.Forms.CheckBox chbxSendNotifactionns;
        private resources.customButtons btnSettings;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}