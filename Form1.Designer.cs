namespace PcComponentnsStats
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cpu_name = new System.Windows.Forms.Label();
            this.cpu_temp = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.CPU_info = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.cpu_usage = new System.Windows.Forms.Label();
            this.next_gpu = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.gpu_name = new System.Windows.Forms.Label();
            this.gpu_temp = new System.Windows.Forms.Label();
            this.gpu = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.CPU_info.SuspendLayout();
            this.gpu.SuspendLayout();
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
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(490, -2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 35);
            this.button1.TabIndex = 3;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "PC Components Stats";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(-3, -5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(529, 33);
            this.panel1.TabIndex = 5;
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // CPU_info
            // 
            this.CPU_info.Controls.Add(this.checkBox1);
            this.CPU_info.Controls.Add(this.cpu_usage);
            this.CPU_info.Controls.Add(this.next_gpu);
            this.CPU_info.Controls.Add(this.cpu_temp);
            this.CPU_info.Controls.Add(this.label1);
            this.CPU_info.Controls.Add(this.cpu_name);
            this.CPU_info.Location = new System.Drawing.Point(0, 31);
            this.CPU_info.Name = "CPU_info";
            this.CPU_info.Size = new System.Drawing.Size(526, 90);
            this.CPU_info.TabIndex = 6;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(382, 60);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(128, 20);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Send messages";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // cpu_usage
            // 
            this.cpu_usage.AutoSize = true;
            this.cpu_usage.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cpu_usage.Location = new System.Drawing.Point(15, 51);
            this.cpu_usage.Name = "cpu_usage";
            this.cpu_usage.Size = new System.Drawing.Size(76, 16);
            this.cpu_usage.TabIndex = 4;
            this.cpu_usage.Text = "{cpu_temp}";
            // 
            // next_gpu
            // 
            this.next_gpu.BackColor = System.Drawing.Color.White;
            this.next_gpu.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.next_gpu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.next_gpu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.next_gpu.Location = new System.Drawing.Point(490, 3);
            this.next_gpu.Name = "next_gpu";
            this.next_gpu.Size = new System.Drawing.Size(33, 32);
            this.next_gpu.TabIndex = 3;
            this.next_gpu.Text = ">";
            this.next_gpu.UseVisualStyleBackColor = false;
            this.next_gpu.Click += new System.EventHandler(this.next_gpu_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(15, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "GPU:";
            // 
            // gpu_name
            // 
            this.gpu_name.AutoSize = true;
            this.gpu_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gpu_name.Location = new System.Drawing.Point(15, 19);
            this.gpu_name.Name = "gpu_name";
            this.gpu_name.Size = new System.Drawing.Size(81, 16);
            this.gpu_name.TabIndex = 5;
            this.gpu_name.Text = "{gpu_name}";
            // 
            // gpu_temp
            // 
            this.gpu_temp.AutoSize = true;
            this.gpu_temp.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gpu_temp.Location = new System.Drawing.Point(15, 35);
            this.gpu_temp.Name = "gpu_temp";
            this.gpu_temp.Size = new System.Drawing.Size(77, 16);
            this.gpu_temp.TabIndex = 5;
            this.gpu_temp.Text = "{gpu_temp}";
            // 
            // gpu
            // 
            this.gpu.Controls.Add(this.button2);
            this.gpu.Controls.Add(this.gpu_name);
            this.gpu.Controls.Add(this.gpu_temp);
            this.gpu.Controls.Add(this.label3);
            this.gpu.Location = new System.Drawing.Point(0, 31);
            this.gpu.Name = "gpu";
            this.gpu.Size = new System.Drawing.Size(523, 90);
            this.gpu.TabIndex = 8;
            this.gpu.Visible = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(487, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(33, 32);
            this.button2.TabIndex = 8;
            this.button2.Text = "<";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(522, 123);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CPU_info);
            this.Controls.Add(this.gpu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.CPU_info.ResumeLayout(false);
            this.CPU_info.PerformLayout();
            this.gpu.ResumeLayout(false);
            this.gpu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label cpu_name;
        private System.Windows.Forms.Label cpu_temp;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Panel CPU_info;
        private System.Windows.Forms.Button next_gpu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label gpu_name;
        private System.Windows.Forms.Label gpu_temp;
        private System.Windows.Forms.Panel gpu;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label cpu_usage;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

