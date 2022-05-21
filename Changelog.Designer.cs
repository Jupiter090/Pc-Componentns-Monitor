namespace PcComponentsMonitor
{
    partial class Changelog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Changelog));
            this.iconName = new System.Windows.Forms.PictureBox();
            this.panelName = new System.Windows.Forms.Panel();
            this.btnHide = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.txtChangelog = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.iconName)).BeginInit();
            this.panelName.SuspendLayout();
            this.SuspendLayout();
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
            this.iconName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ClickWindow);
            this.iconName.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MoveWindow);
            this.iconName.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseUp);
            // 
            // panelName
            // 
            this.panelName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelName.Controls.Add(this.iconName);
            this.panelName.Controls.Add(this.btnHide);
            this.panelName.Controls.Add(this.btnExit);
            this.panelName.Controls.Add(this.labelName);
            this.panelName.ForeColor = System.Drawing.Color.Black;
            this.panelName.Location = new System.Drawing.Point(0, 0);
            this.panelName.Name = "panelName";
            this.panelName.Size = new System.Drawing.Size(843, 33);
            this.panelName.TabIndex = 24;
            this.panelName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ClickWindow);
            this.panelName.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MoveWindow);
            this.panelName.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseUp);
            // 
            // btnHide
            // 
            this.btnHide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnHide.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHide.Font = new System.Drawing.Font("Segoe UI Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnHide.ForeColor = System.Drawing.Color.DimGray;
            this.btnHide.Location = new System.Drawing.Point(765, -2);
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
            this.btnExit.Location = new System.Drawing.Point(807, -2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(36, 35);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
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
            this.labelName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ClickWindow);
            this.labelName.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MoveWindow);
            this.labelName.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseUp);
            // 
            // txtChangelog
            // 
            this.txtChangelog.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtChangelog.Font = new System.Drawing.Font("Segoe UI Semibold", 12.2F, System.Drawing.FontStyle.Bold);
            this.txtChangelog.Location = new System.Drawing.Point(-7, 26);
            this.txtChangelog.Multiline = true;
            this.txtChangelog.Name = "txtChangelog";
            this.txtChangelog.ReadOnly = true;
            this.txtChangelog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtChangelog.Size = new System.Drawing.Size(850, 425);
            this.txtChangelog.TabIndex = 25;
            this.txtChangelog.Text = "Changelog\r\n";
            this.txtChangelog.Enter += new System.EventHandler(this.textBox1_Enter);
            // 
            // Changelog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 450);
            this.Controls.Add(this.panelName);
            this.Controls.Add(this.txtChangelog);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Changelog";
            this.Text = "Changelog";
            this.Load += new System.EventHandler(this.Changelog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconName)).EndInit();
            this.panelName.ResumeLayout(false);
            this.panelName.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox iconName;
        private System.Windows.Forms.Panel panelName;
        private System.Windows.Forms.Button btnHide;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox txtChangelog;
    }
}