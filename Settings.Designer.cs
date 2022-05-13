namespace PcComponentsMonitor
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.toolStripDropDown1 = new System.Windows.Forms.ToolStripDropDown();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnApply = new PcComponentsMonitor.resources.customButtons();
            this.btnSettings = new PcComponentsMonitor.resources.customButtons();
            this.chcIgnoreTskbar = new System.Windows.Forms.CheckBox();
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
            // toolStripDropDown1
            // 
            this.toolStripDropDown1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripDropDown1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.toolStripDropDown1.Name = "toolStripDropDown1";
            this.toolStripDropDown1.Size = new System.Drawing.Size(2, 4);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Right, Bottom",
            "Right, Top",
            "Left, Bottom",
            "Left, Top"});
            this.comboBox1.Location = new System.Drawing.Point(21, 172);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(219, 24);
            this.comboBox1.TabIndex = 19;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 31);
            this.label1.TabIndex = 20;
            this.label1.Text = "Position:";
            // 
            // btnApply
            // 
            this.btnApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnApply.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnApply.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnApply.BorderRadius = 5;
            this.btnApply.BorderSize = 0;
            this.btnApply.FlatAppearance.BorderSize = 0;
            this.btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApply.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnApply.ForeColor = System.Drawing.Color.White;
            this.btnApply.Location = new System.Drawing.Point(431, 298);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(214, 37);
            this.btnApply.TabIndex = 21;
            this.btnApply.Text = "Apply and Close";
            this.btnApply.TextdColor = System.Drawing.Color.White;
            this.btnApply.UseVisualStyleBackColor = false;
            this.btnApply.Visible = false;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
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
            // chcIgnoreTskbar
            // 
            this.chcIgnoreTskbar.AutoSize = true;
            this.chcIgnoreTskbar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chcIgnoreTskbar.Location = new System.Drawing.Point(21, 202);
            this.chcIgnoreTskbar.Name = "chcIgnoreTskbar";
            this.chcIgnoreTskbar.Size = new System.Drawing.Size(188, 33);
            this.chcIgnoreTskbar.TabIndex = 22;
            this.chcIgnoreTskbar.Text = "Ignore taskbar";
            this.chcIgnoreTskbar.UseVisualStyleBackColor = true;
            this.chcIgnoreTskbar.CheckedChanged += new System.EventHandler(this.chcIgnoreTskbar_CheckedChanged);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 347);
            this.Controls.Add(this.chcIgnoreTskbar);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
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
        private PcComponentsMonitor.resources.customButtons btnSettings;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ToolStripDropDown toolStripDropDown1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private PcComponentsMonitor.resources.customButtons btnApply;
        private System.Windows.Forms.CheckBox chcIgnoreTskbar;
    }
}