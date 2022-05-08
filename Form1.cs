using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PcComponentnsStats
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
            }
            //Will set the text to the temperatures
            cpu_temp.Text = "Temp: " + temperature.ToString() + "°C";

            //Resets the timer
            Timer timer  = sender as Timer;
            timer.Interval = 5000;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            Rectangle workingArea = Screen.GetWorkingArea(this);
            this.Location = new Point(workingArea.Right - Size.Width,
                                      workingArea.Bottom - Size.Height);
            this.TopMost = true;

            double temperature = 0;
            //Create new ManagementObjectSearcher
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(@"root\WMI", "SELECT * FROM MSAcpi_ThermalZoneTemperature");
            foreach (ManagementObject obj in searcher.Get())
            {
                //Gets the cpu temp and converts it to °C
                temperature = Convert.ToDouble(obj["CurrentTemperature"].ToString());
                temperature = (temperature - 2732) / 10.0;
            }
            //Will set the text to the temperatures
            cpu_temp.Text = "Temp: " + temperature.ToString() + "°C";

            //Thing to get the processor name (Idk what it does I just copied it.)
            string cpuName = String.Empty;
            ManagementClass mc = new ManagementClass("win32_processor");
            ManagementObjectCollection managCollec = mc.GetInstances();
            foreach (ManagementObject managObj in managCollec)
            {
                cpuName = managObj.Properties["Name"].Value.ToString();
                cpu_name.Text = "Name: " + cpuName;
                break;
            }
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
    }
}
