using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.Toolkit.Uwp.Notifications;

namespace PcComponentnsStats
{
    public partial class Form1 : Form
    {
        PerformanceCounter cpuCounter;
        private bool sendMessages = Properties.Settings.Default.sendMessage;
        private bool sendedWarning_cpu = false;
        public Form1()
        {
            InitializeComponent();
            cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            double temperature = 0;
            //Create new ManagementObjectSearcher
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(@"root\WMI", "SELECT * FROM MSAcpi_ThermalZoneTemperature");
            foreach (ManagementObject obj in searcher.Get())
            {
                //Gets the cpu temp and converts it to °C
                temperature = Convert.ToDouble(obj["CurrentTemperature"].ToString());
                temperature = (temperature - 2732) / 10.0;
                //Chanegs color of text dependign on temp
                if (temperature > 40 && temperature < 50)
                {
                    cpu_temp.ForeColor = Color.Orange;
                    sendedWarning_cpu = false;
                }
                else if (temperature > 50 && temperature < 75) cpu_temp.ForeColor = Color.DarkOrange;
                else if (temperature > 75)
                {
                    cpu_temp.ForeColor = Color.Red;
                }
                else if (temperature < 40)
                {
                    cpu_temp.ForeColor = Color.Black;
                    sendedWarning_cpu = false;
                }
                //When cpu temps get too high it will send a warning
                if(temperature > 75 && !sendedWarning_cpu && sendMessages) 
                {
                    new ToastContentBuilder()
                        .AddText("Warning!")
                        .AddText("Your cpu temps are getting high!")
                        .Show();
                    sendedWarning_cpu = true;
                }
            }
            //Will set the text to the temperatures
            cpu_temp.Text = "Temp: " + temperature.ToString() + "°C";

            cpu_usage.Text = "Usage: " + Math.Round(cpuCounter.NextValue(), MidpointRounding.ToEven) + "%";

            //Resets the timer
            Timer timer  = sender as Timer;
            timer.Interval = 5000;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Sets the styles
            this.FormBorderStyle = FormBorderStyle.None;
            Rectangle workingArea = Screen.GetWorkingArea(this);
            this.Location = new Point(workingArea.Right - Size.Width,
                                      workingArea.Bottom - Size.Height);
            this.TopMost = true;
            this.ShowInTaskbar = false;

            checkBox1.Checked = Properties.Settings.Default.sendMessage;


            double temperature = 0;  
            //Create new ManagementObjectSearcher
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(@"root\WMI", "SELECT * FROM MSAcpi_ThermalZoneTemperature");
            foreach (ManagementObject obj in searcher.Get())
            {
                //Gets the cpu temp and converts it to °C
                temperature = Convert.ToDouble(obj["CurrentTemperature"].ToString());
                temperature = (temperature - 2732) / 10.0;
                if (temperature > 40) cpu_temp.ForeColor = Color.Orange;
                else if (temperature > 50 && temperature < 65) cpu_temp.ForeColor = Color.DarkOrange;
                else if (temperature < 40) cpu_temp.ForeColor = Color.Black;
            }
            //Will set the text to the temperatures
            cpu_temp.Text = "Temp: " + temperature.ToString() + "°C";

            ManagementClass mc = new ManagementClass("win32_processor");
            ManagementObjectCollection managCollec = mc.GetInstances();
            foreach (ManagementObject managObj in managCollec)
            {
                //Thing to get the processor name (Idk what it does I just copied it.)
                string cpuName = managObj.Properties["Name"].Value.ToString();
                cpu_name.Text = "Name: " + cpuName;
                break;
            }
            //Gets cpu usage in precentage
            cpu_usage.Text = "Usage: " + Math.Round(cpuCounter.NextValue(), MidpointRounding.ToEven) + "%";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.TopMost = true;
            timer2.Interval = 1000;
        }

        //Shows gpu stats
        private void next_gpu_Click(object sender, EventArgs e)
        {
            gpu.Visible = true;
            CPU_info.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            gpu.Visible=false;
            CPU_info.Visible=true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            if (checkBox.Checked)
            {
                Properties.Settings.Default.sendMessage = true;
                sendMessages = true;
                Properties.Settings.Default.Save();
            }else if (!checkBox.Checked)
            {
                Properties.Settings.Default.sendMessage = false;
                sendMessages = false;
                Properties.Settings.Default.Save();
            }
        }
    }
}
