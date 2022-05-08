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

            //Thing to get the processor name (Idk what it does I just copied it.)
            ManagementClass mc = new ManagementClass("win32_processor");
            ManagementObjectCollection moc = mc.GetInstances();

            //Resets the timer
            Timer timer  = sender as Timer;
            timer.Interval = 5000;
        }

        private void Form1_Load(object sender, EventArgs e)
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
        }
    }
}
