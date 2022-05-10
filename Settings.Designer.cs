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
            this.label1 = new System.Windows.Forms.Label();
            this.cmBoxReason = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtText = new System.Windows.Forms.TextBox();
            this.customButtons1 = new PcComponentnsStats.resources.customButtons();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.msgError = new System.Windows.Forms.Label();
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
            this.btnSettings.Location = new System.Drawing.Point(651, 652);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(137, 37);
            this.btnSettings.TabIndex = 7;
            this.btnSettings.Text = "Go back";
            this.btnSettings.TextdColor = System.Drawing.Color.White;
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(15, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(567, 31);
            this.label1.TabIndex = 8;
            this.label1.Text = "Found an issue or do you want to submit suggestion?";
            // 
            // cmBoxReason
            // 
            this.cmBoxReason.FormattingEnabled = true;
            this.cmBoxReason.Items.AddRange(new object[] {
            "Suggestion",
            "Report a bug"});
            this.cmBoxReason.Location = new System.Drawing.Point(23, 276);
            this.cmBoxReason.Name = "cmBoxReason";
            this.cmBoxReason.Size = new System.Drawing.Size(577, 24);
            this.cmBoxReason.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(17, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 31);
            this.label2.TabIndex = 10;
            this.label2.Text = "Reason:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(17, 359);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 31);
            this.label3.TabIndex = 11;
            this.label3.Text = "Text:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtText
            // 
            this.txtText.Location = new System.Drawing.Point(23, 394);
            this.txtText.Multiline = true;
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(577, 124);
            this.txtText.TabIndex = 12;
            // 
            // customButtons1
            // 
            this.customButtons1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.customButtons1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.customButtons1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.customButtons1.BorderRadius = 5;
            this.customButtons1.BorderSize = 0;
            this.customButtons1.FlatAppearance.BorderSize = 0;
            this.customButtons1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButtons1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.customButtons1.ForeColor = System.Drawing.Color.White;
            this.customButtons1.Location = new System.Drawing.Point(21, 524);
            this.customButtons1.Name = "customButtons1";
            this.customButtons1.Size = new System.Drawing.Size(137, 37);
            this.customButtons1.TabIndex = 13;
            this.customButtons1.Text = "Send";
            this.customButtons1.TextdColor = System.Drawing.Color.White;
            this.customButtons1.UseVisualStyleBackColor = false;
            this.customButtons1.Click += new System.EventHandler(this.customButtons1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(17, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 31);
            this.label4.TabIndex = 14;
            this.label4.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(21, 337);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(579, 22);
            this.txtName.TabIndex = 15;
            // 
            // msgError
            // 
            this.msgError.AutoSize = true;
            this.msgError.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.msgError.ForeColor = System.Drawing.Color.Red;
            this.msgError.Location = new System.Drawing.Point(195, 418);
            this.msgError.Name = "msgError";
            this.msgError.Size = new System.Drawing.Size(0, 31);
            this.msgError.TabIndex = 16;
            this.msgError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.ClientSize = new System.Drawing.Size(800, 701);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.msgError);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.customButtons1);
            this.Controls.Add(this.txtText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmBoxReason);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmBoxReason;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtText;
        private resources.customButtons customButtons1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label msgError;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}