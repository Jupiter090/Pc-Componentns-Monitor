namespace PcComponentsMonitor
{
    partial class App
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(App));
            this.cpu_name = new System.Windows.Forms.Label();
            this.cpu_temp = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.CPU = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panelName = new System.Windows.Forms.Panel();
            this.btnHide = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.CPU_info = new System.Windows.Forms.Panel();
            this.Next_cpu = new PcComponentsMonitor.resources.customButtons();
            this.btnSettings = new PcComponentsMonitor.resources.customButtons();
            this.cpu_usage = new System.Windows.Forms.Label();
            this.RAM_info = new System.Windows.Forms.Panel();
            this.Previouse_RAM = new PcComponentsMonitor.resources.customButtons();
            this.customButtons3 = new PcComponentsMonitor.resources.customButtons();
            this.ram_usage = new System.Windows.Forms.Label();
            this.RAM = new System.Windows.Forms.Label();
            this.ram_name = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.Drive_info = new System.Windows.Forms.Panel();
            this.drive_used = new System.Windows.Forms.Label();
            this.drive_space = new System.Windows.Forms.Label();
            this.Previouse_Drive = new PcComponentsMonitor.resources.customButtons();
            this.customButtons2 = new PcComponentsMonitor.resources.customButtons();
            this.Drives = new System.Windows.Forms.Label();
            this.drive_name = new System.Windows.Forms.Label();
            this.Next_RAM = new PcComponentsMonitor.resources.customButtons();
            this.panelName.SuspendLayout();
            this.CPU_info.SuspendLayout();
            this.RAM_info.SuspendLayout();
            this.Drive_info.SuspendLayout();
            this.SuspendLayout();
            // 
            // cpu_name
            // 
            this.cpu_name.AutoSize = true;
            this.cpu_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cpu_name.Location = new System.Drawing.Point(15, 19);
            this.cpu_name.Name = "cpu_name";
            this.cpu_name.Size = new System.Drawing.Size(80, 16);
            this.cpu_name.TabIndex = 0;
            this.cpu_name.Text = "{cpu_name}";
            // 
            // cpu_temp
            // 
            this.cpu_temp.AutoSize = true;
            this.cpu_temp.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cpu_temp.Location = new System.Drawing.Point(15, 35);
            this.cpu_temp.Name = "cpu_temp";
            this.cpu_temp.Size = new System.Drawing.Size(76, 16);
            this.cpu_temp.TabIndex = 1;
            this.cpu_temp.Text = "{cpu_temp}";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(15, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "CPU:";
            // 
            // CPU
            // 
            this.CPU.AutoSize = true;
            this.CPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CPU.Location = new System.Drawing.Point(15, 3);
            this.CPU.Name = "CPU";
            this.CPU.Size = new System.Drawing.Size(42, 16);
            this.CPU.TabIndex = 2;
            this.CPU.Text = "CPU:";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(490, -2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(36, 35);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(279, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "PC Components Monitor";
            // 
            // panelName
            // 
            this.panelName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelName.Controls.Add(this.btnHide);
            this.panelName.Controls.Add(this.btnExit);
            this.panelName.Controls.Add(this.label2);
            this.panelName.ForeColor = System.Drawing.Color.Black;
            this.panelName.Location = new System.Drawing.Point(-3, -5);
            this.panelName.Name = "panelName";
            this.panelName.Size = new System.Drawing.Size(529, 33);
            this.panelName.TabIndex = 5;
            // 
            // btnHide
            // 
            this.btnHide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnHide.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHide.Font = new System.Drawing.Font("Segoe UI Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnHide.ForeColor = System.Drawing.Color.DimGray;
            this.btnHide.Location = new System.Drawing.Point(448, -2);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(36, 35);
            this.btnHide.TabIndex = 5;
            this.btnHide.Text = "-";
            this.btnHide.UseVisualStyleBackColor = false;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // CPU_info
            // 
            this.CPU_info.Controls.Add(this.Next_cpu);
            this.CPU_info.Controls.Add(this.btnSettings);
            this.CPU_info.Controls.Add(this.cpu_usage);
            this.CPU_info.Controls.Add(this.cpu_temp);
            this.CPU_info.Controls.Add(this.label1);
            this.CPU_info.Controls.Add(this.CPU);
            this.CPU_info.Controls.Add(this.cpu_name);
            this.CPU_info.Location = new System.Drawing.Point(0, 31);
            this.CPU_info.Name = "CPU_info";
            this.CPU_info.Size = new System.Drawing.Size(526, 90);
            this.CPU_info.TabIndex = 6;
            // 
            // Next_cpu
            // 
            this.Next_cpu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Next_cpu.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Next_cpu.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Next_cpu.BorderRadius = 5;
            this.Next_cpu.BorderSize = 0;
            this.Next_cpu.FlatAppearance.BorderSize = 0;
            this.Next_cpu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Next_cpu.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Next_cpu.ForeColor = System.Drawing.Color.White;
            this.Next_cpu.Location = new System.Drawing.Point(479, 3);
            this.Next_cpu.Name = "Next_cpu";
            this.Next_cpu.Size = new System.Drawing.Size(36, 36);
            this.Next_cpu.TabIndex = 7;
            this.Next_cpu.Text = ">";
            this.Next_cpu.TextdColor = System.Drawing.Color.White;
            this.Next_cpu.UseVisualStyleBackColor = false;
            this.Next_cpu.Click += new System.EventHandler(this.Next_cpu_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSettings.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSettings.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSettings.BorderRadius = 5;
            this.btnSettings.BorderSize = 0;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.Location = new System.Drawing.Point(398, 51);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(122, 36);
            this.btnSettings.TabIndex = 6;
            this.btnSettings.Text = "Settings";
            this.btnSettings.TextdColor = System.Drawing.Color.White;
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // cpu_usage
            // 
            this.cpu_usage.AutoSize = true;
            this.cpu_usage.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cpu_usage.Location = new System.Drawing.Point(15, 51);
            this.cpu_usage.Name = "cpu_usage";
            this.cpu_usage.Size = new System.Drawing.Size(79, 16);
            this.cpu_usage.TabIndex = 4;
            this.cpu_usage.Text = "{cpu_usage";
            // 
            // RAM_info
            // 
            this.RAM_info.Controls.Add(this.Next_RAM);
            this.RAM_info.Controls.Add(this.Previouse_RAM);
            this.RAM_info.Controls.Add(this.customButtons3);
            this.RAM_info.Controls.Add(this.ram_usage);
            this.RAM_info.Controls.Add(this.RAM);
            this.RAM_info.Controls.Add(this.ram_name);
            this.RAM_info.Location = new System.Drawing.Point(0, 157);
            this.RAM_info.Name = "RAM_info";
            this.RAM_info.Size = new System.Drawing.Size(526, 90);
            this.RAM_info.TabIndex = 8;
            // 
            // Previouse_RAM
            // 
            this.Previouse_RAM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Previouse_RAM.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Previouse_RAM.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Previouse_RAM.BorderRadius = 5;
            this.Previouse_RAM.BorderSize = 0;
            this.Previouse_RAM.FlatAppearance.BorderSize = 0;
            this.Previouse_RAM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Previouse_RAM.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Previouse_RAM.ForeColor = System.Drawing.Color.White;
            this.Previouse_RAM.Location = new System.Drawing.Point(445, 3);
            this.Previouse_RAM.Name = "Previouse_RAM";
            this.Previouse_RAM.Size = new System.Drawing.Size(36, 36);
            this.Previouse_RAM.TabIndex = 7;
            this.Previouse_RAM.Text = "<";
            this.Previouse_RAM.TextdColor = System.Drawing.Color.White;
            this.Previouse_RAM.UseVisualStyleBackColor = false;
            this.Previouse_RAM.Click += new System.EventHandler(this.Previouse_RAM_Click);
            // 
            // customButtons3
            // 
            this.customButtons3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.customButtons3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.customButtons3.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.customButtons3.BorderRadius = 5;
            this.customButtons3.BorderSize = 0;
            this.customButtons3.FlatAppearance.BorderSize = 0;
            this.customButtons3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButtons3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.customButtons3.ForeColor = System.Drawing.Color.White;
            this.customButtons3.Location = new System.Drawing.Point(398, 51);
            this.customButtons3.Name = "customButtons3";
            this.customButtons3.Size = new System.Drawing.Size(122, 36);
            this.customButtons3.TabIndex = 6;
            this.customButtons3.Text = "Settings";
            this.customButtons3.TextdColor = System.Drawing.Color.White;
            this.customButtons3.UseVisualStyleBackColor = false;
            this.customButtons3.Click += new System.EventHandler(this.customButtons3_Click);
            // 
            // ram_usage
            // 
            this.ram_usage.AutoSize = true;
            this.ram_usage.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ram_usage.Location = new System.Drawing.Point(15, 35);
            this.ram_usage.Name = "ram_usage";
            this.ram_usage.Size = new System.Drawing.Size(85, 16);
            this.ram_usage.TabIndex = 1;
            this.ram_usage.Text = "{ram_usage}";
            // 
            // RAM
            // 
            this.RAM.AutoSize = true;
            this.RAM.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RAM.Location = new System.Drawing.Point(15, 3);
            this.RAM.Name = "RAM";
            this.RAM.Size = new System.Drawing.Size(44, 16);
            this.RAM.TabIndex = 2;
            this.RAM.Text = "RAM:";
            // 
            // ram_name
            // 
            this.ram_name.AutoSize = true;
            this.ram_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ram_name.Location = new System.Drawing.Point(15, 19);
            this.ram_name.Name = "ram_name";
            this.ram_name.Size = new System.Drawing.Size(81, 16);
            this.ram_name.TabIndex = 0;
            this.ram_name.Text = "{ram_name}";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "PC Components Monitor";
            this.notifyIcon1.BalloonTipClicked += new System.EventHandler(this.notifyIcon1_BalloonTipClicked);
            this.notifyIcon1.Click += new System.EventHandler(this.notifyIcon1_Click);
            // 
            // Drive_info
            // 
            this.Drive_info.Controls.Add(this.drive_used);
            this.Drive_info.Controls.Add(this.drive_space);
            this.Drive_info.Controls.Add(this.Previouse_Drive);
            this.Drive_info.Controls.Add(this.customButtons2);
            this.Drive_info.Controls.Add(this.Drives);
            this.Drive_info.Controls.Add(this.drive_name);
            this.Drive_info.Location = new System.Drawing.Point(0, 157);
            this.Drive_info.Name = "Drive_info";
            this.Drive_info.Size = new System.Drawing.Size(526, 90);
            this.Drive_info.TabIndex = 9;
            // 
            // drive_used
            // 
            this.drive_used.AutoSize = true;
            this.drive_used.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.drive_used.Location = new System.Drawing.Point(15, 51);
            this.drive_used.Name = "drive_used";
            this.drive_used.Size = new System.Drawing.Size(84, 16);
            this.drive_used.TabIndex = 9;
            this.drive_used.Text = "{drive_used}";
            // 
            // drive_space
            // 
            this.drive_space.AutoSize = true;
            this.drive_space.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.drive_space.Location = new System.Drawing.Point(15, 35);
            this.drive_space.Name = "drive_space";
            this.drive_space.Size = new System.Drawing.Size(92, 16);
            this.drive_space.TabIndex = 8;
            this.drive_space.Text = "{drive_space}";
            // 
            // Previouse_Drive
            // 
            this.Previouse_Drive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Previouse_Drive.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Previouse_Drive.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Previouse_Drive.BorderRadius = 5;
            this.Previouse_Drive.BorderSize = 0;
            this.Previouse_Drive.FlatAppearance.BorderSize = 0;
            this.Previouse_Drive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Previouse_Drive.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Previouse_Drive.ForeColor = System.Drawing.Color.White;
            this.Previouse_Drive.Location = new System.Drawing.Point(479, 3);
            this.Previouse_Drive.Name = "Previouse_Drive";
            this.Previouse_Drive.Size = new System.Drawing.Size(36, 36);
            this.Previouse_Drive.TabIndex = 7;
            this.Previouse_Drive.Text = "<";
            this.Previouse_Drive.TextdColor = System.Drawing.Color.White;
            this.Previouse_Drive.UseVisualStyleBackColor = false;
            this.Previouse_Drive.Click += new System.EventHandler(this.Previouse_Drive_Click);
            // 
            // customButtons2
            // 
            this.customButtons2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.customButtons2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.customButtons2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.customButtons2.BorderRadius = 5;
            this.customButtons2.BorderSize = 0;
            this.customButtons2.FlatAppearance.BorderSize = 0;
            this.customButtons2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButtons2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.customButtons2.ForeColor = System.Drawing.Color.White;
            this.customButtons2.Location = new System.Drawing.Point(398, 51);
            this.customButtons2.Name = "customButtons2";
            this.customButtons2.Size = new System.Drawing.Size(122, 36);
            this.customButtons2.TabIndex = 6;
            this.customButtons2.Text = "Settings";
            this.customButtons2.TextdColor = System.Drawing.Color.White;
            this.customButtons2.UseVisualStyleBackColor = false;
            this.customButtons2.Click += new System.EventHandler(this.customButtons2_Click);
            // 
            // Drives
            // 
            this.Drives.AutoSize = true;
            this.Drives.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Drives.Location = new System.Drawing.Point(15, 3);
            this.Drives.Name = "Drives";
            this.Drives.Size = new System.Drawing.Size(48, 16);
            this.Drives.TabIndex = 2;
            this.Drives.Text = "Drive:";
            // 
            // drive_name
            // 
            this.drive_name.AutoSize = true;
            this.drive_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.drive_name.Location = new System.Drawing.Point(15, 19);
            this.drive_name.Name = "drive_name";
            this.drive_name.Size = new System.Drawing.Size(88, 16);
            this.drive_name.TabIndex = 0;
            this.drive_name.Text = "{drive_name}";
            // 
            // Next_RAM
            // 
            this.Next_RAM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Next_RAM.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Next_RAM.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Next_RAM.BorderRadius = 5;
            this.Next_RAM.BorderSize = 0;
            this.Next_RAM.FlatAppearance.BorderSize = 0;
            this.Next_RAM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Next_RAM.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Next_RAM.ForeColor = System.Drawing.Color.White;
            this.Next_RAM.Location = new System.Drawing.Point(484, 3);
            this.Next_RAM.Name = "Next_RAM";
            this.Next_RAM.Size = new System.Drawing.Size(36, 36);
            this.Next_RAM.TabIndex = 8;
            this.Next_RAM.Text = ">";
            this.Next_RAM.TextdColor = System.Drawing.Color.White;
            this.Next_RAM.UseVisualStyleBackColor = false;
            this.Next_RAM.Click += new System.EventHandler(this.Next_RAM_Click);
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(522, 121);
            this.Controls.Add(this.panelName);
            this.Controls.Add(this.CPU_info);
            this.Controls.Add(this.Drive_info);
            this.Controls.Add(this.RAM_info);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "App";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "PC Components Monitor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelName.ResumeLayout(false);
            this.panelName.PerformLayout();
            this.CPU_info.ResumeLayout(false);
            this.CPU_info.PerformLayout();
            this.RAM_info.ResumeLayout(false);
            this.RAM_info.PerformLayout();
            this.Drive_info.ResumeLayout(false);
            this.Drive_info.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion
        private System.Windows.Forms.Label cpu_name;
        private System.Windows.Forms.Label cpu_temp;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label CPU;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelName;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Panel CPU_info;
        private System.Windows.Forms.Label cpu_usage;
        private resources.customButtons btnSettings;
        private resources.customButtons Next_cpu;
        private System.Windows.Forms.Panel RAM_info;
        private resources.customButtons Previouse_RAM;
        private resources.customButtons customButtons3;
        private System.Windows.Forms.Label ram_usage;
        private System.Windows.Forms.Label RAM;
        private System.Windows.Forms.Label ram_name;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button btnHide;
        private System.Windows.Forms.Panel Drive_info;
        private resources.customButtons Previouse_Drive;
        private resources.customButtons customButtons2;
        private System.Windows.Forms.Label Drives;
        private System.Windows.Forms.Label drive_name;
        private System.Windows.Forms.Label drive_space;
        private System.Windows.Forms.Label drive_used;
        private resources.customButtons Next_RAM;
    }
}
