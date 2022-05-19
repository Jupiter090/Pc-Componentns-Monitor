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
            this.chcIgnoreTskbar = new System.Windows.Forms.CheckBox();
            this.labelName = new System.Windows.Forms.Label();
            this.panelName = new System.Windows.Forms.Panel();
            this.iconName = new System.Windows.Forms.PictureBox();
            this.btnHide = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.imgHelpChngDfltPos = new System.Windows.Forms.PictureBox();
            this.panelHelpChngDfltPos = new PcComponentsMonitor.customPanels();
            this.label2 = new System.Windows.Forms.Label();
            this.btnApply = new PcComponentsMonitor.resources.customButtons();
            this.btnSettings = new PcComponentsMonitor.resources.customButtons();
            this.panelName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgHelpChngDfltPos)).BeginInit();
            this.panelHelpChngDfltPos.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSettings
            // 
            this.txtSettings.AutoSize = true;
            this.txtSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtSettings.Location = new System.Drawing.Point(12, 34);
            this.txtSettings.Name = "txtSettings";
            this.txtSettings.Size = new System.Drawing.Size(200, 54);
            this.txtSettings.TabIndex = 0;
            this.txtSettings.Text = "Settings";
            // 
            // chbxSendNotifactionns
            // 
            this.chbxSendNotifactionns.AutoSize = true;
            this.chbxSendNotifactionns.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chbxSendNotifactionns.Location = new System.Drawing.Point(21, 91);
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
            this.checkBox1.Location = new System.Drawing.Point(21, 130);
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
            this.comboBox1.Location = new System.Drawing.Point(21, 197);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(219, 24);
            this.comboBox1.TabIndex = 19;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 31);
            this.label1.TabIndex = 20;
            this.label1.Text = "Position:";
            // 
            // chcIgnoreTskbar
            // 
            this.chcIgnoreTskbar.AutoSize = true;
            this.chcIgnoreTskbar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chcIgnoreTskbar.Location = new System.Drawing.Point(21, 227);
            this.chcIgnoreTskbar.Name = "chcIgnoreTskbar";
            this.chcIgnoreTskbar.Size = new System.Drawing.Size(188, 33);
            this.chcIgnoreTskbar.TabIndex = 22;
            this.chcIgnoreTskbar.Text = "Ignore taskbar";
            this.chcIgnoreTskbar.UseVisualStyleBackColor = true;
            this.chcIgnoreTskbar.CheckedChanged += new System.EventHandler(this.chcIgnoreTskbar_CheckedChanged);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(42, 2);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(388, 31);
            this.labelName.TabIndex = 4;
            this.labelName.Text = "PC Components Monitor - Settings";
            this.labelName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelName_MouseDown);
            this.labelName.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelName_MouseMove);
            this.labelName.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelName_MouseUp);
            // 
            // panelName
            // 
            this.panelName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelName.Controls.Add(this.iconName);
            this.panelName.Controls.Add(this.btnHide);
            this.panelName.Controls.Add(this.btnExit);
            this.panelName.Controls.Add(this.labelName);
            this.panelName.ForeColor = System.Drawing.Color.Black;
            this.panelName.Location = new System.Drawing.Point(1, -2);
            this.panelName.Name = "panelName";
            this.panelName.Size = new System.Drawing.Size(799, 33);
            this.panelName.TabIndex = 23;
            this.panelName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelName_MouseDown);
            this.panelName.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelName_MouseMove);
            this.panelName.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelName_MouseUp);
            // 
            // iconName
            // 
            this.iconName.BackColor = System.Drawing.Color.Transparent;
            this.iconName.Image = ((System.Drawing.Image)(resources.GetObject("iconName.Image")));
            this.iconName.Location = new System.Drawing.Point(3, 2);
            this.iconName.Name = "iconName";
            this.iconName.Size = new System.Drawing.Size(46, 31);
            this.iconName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconName.TabIndex = 12;
            this.iconName.TabStop = false;
            this.iconName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelName_MouseDown);
            this.iconName.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelName_MouseMove);
            this.iconName.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelName_MouseUp);
            // 
            // btnHide
            // 
            this.btnHide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnHide.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHide.Font = new System.Drawing.Font("Segoe UI Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnHide.ForeColor = System.Drawing.Color.DimGray;
            this.btnHide.Location = new System.Drawing.Point(721, -2);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(36, 35);
            this.btnHide.TabIndex = 5;
            this.btnHide.Text = "-";
            this.btnHide.UseVisualStyleBackColor = false;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(763, -2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(36, 35);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBox2.Location = new System.Drawing.Point(21, 266);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(288, 33);
            this.checkBox2.TabIndex = 24;
            this.checkBox2.Text = "Change defualt position";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // imgHelpChngDfltPos
            // 
            this.imgHelpChngDfltPos.Cursor = System.Windows.Forms.Cursors.Help;
            this.imgHelpChngDfltPos.Image = ((System.Drawing.Image)(resources.GetObject("imgHelpChngDfltPos.Image")));
            this.imgHelpChngDfltPos.Location = new System.Drawing.Point(327, 261);
            this.imgHelpChngDfltPos.Name = "imgHelpChngDfltPos";
            this.imgHelpChngDfltPos.Size = new System.Drawing.Size(35, 35);
            this.imgHelpChngDfltPos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgHelpChngDfltPos.TabIndex = 25;
            this.imgHelpChngDfltPos.TabStop = false;
            this.imgHelpChngDfltPos.MouseLeave += new System.EventHandler(this.imgHelpIgnerTskbr_MouseLeave);
            this.imgHelpChngDfltPos.MouseHover += new System.EventHandler(this.imgHelpIgnerTskbr_MouseHover);
            // 
            // panelHelpChngDfltPos
            // 
            this.panelHelpChngDfltPos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelHelpChngDfltPos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelHelpChngDfltPos.BorderColor = System.Drawing.Color.Black;
            this.panelHelpChngDfltPos.BorderRadius = 20;
            this.panelHelpChngDfltPos.BorderSize = 1;
            this.panelHelpChngDfltPos.Controls.Add(this.label2);
            this.panelHelpChngDfltPos.ForeColor = System.Drawing.Color.Black;
            this.panelHelpChngDfltPos.Location = new System.Drawing.Point(358, 197);
            this.panelHelpChngDfltPos.Name = "panelHelpChngDfltPos";
            this.panelHelpChngDfltPos.Size = new System.Drawing.Size(210, 66);
            this.panelHelpChngDfltPos.TabIndex = 26;
            this.panelHelpChngDfltPos.TextdColor = System.Drawing.Color.Black;
            this.panelHelpChngDfltPos.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(13, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 48);
            this.label2.TabIndex = 27;
            this.label2.Text = "When is clicked you \r\ncan move main window\r\nand then click apply to save.";
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
            this.btnApply.Location = new System.Drawing.Point(431, 351);
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
            this.btnSettings.Location = new System.Drawing.Point(651, 351);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(137, 37);
            this.btnSettings.TabIndex = 7;
            this.btnSettings.Text = "Go back";
            this.btnSettings.TextdColor = System.Drawing.Color.White;
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 400);
            this.Controls.Add(this.panelHelpChngDfltPos);
            this.Controls.Add(this.imgHelpChngDfltPos);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.panelName);
            this.Controls.Add(this.chcIgnoreTskbar);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.chbxSendNotifactionns);
            this.Controls.Add(this.txtSettings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Settings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.panelName.ResumeLayout(false);
            this.panelName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgHelpChngDfltPos)).EndInit();
            this.panelHelpChngDfltPos.ResumeLayout(false);
            this.panelHelpChngDfltPos.PerformLayout();
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
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Panel panelName;
        private System.Windows.Forms.Button btnHide;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox iconName;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.PictureBox imgHelpChngDfltPos;
        private customPanels panelHelpChngDfltPos;
        private System.Windows.Forms.Label label2;
    }
}