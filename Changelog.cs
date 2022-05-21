using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PcComponentsMonitor
{
    public partial class Changelog : Form
    {

        private static bool enableMoving = false;
        private static Point initialClickedPoint = new Point();

        public Changelog()
        {
            InitializeComponent();
        }

        private void Changelog_Load(object sender, EventArgs e)
        {
            //Online changelog
            try
            {
                //Checks if data directory exists
                if (!Directory.Exists("Data")) Directory.CreateDirectory("Data");

                //Sets file path var
                string Filepath = "Data/changelog_online.txt";
                WebClient wc = new WebClient();
                wc.DownloadFile("https://drive.google.com/uc?id=1qI7vUd8SV-EB9RoGX4z93u-4odjcF3pI&export=download", Filepath);
                StreamReader sr = new StreamReader("Data/changelog_online.txt");
                txtChangelog.Text = sr.ReadToEnd().Replace("\n", Environment.NewLine);
            }
            //Offline changelog
            catch (Exception ex)
            {

                try
                {
                    //Reads offline changelog
                    StreamReader sr = new StreamReader("Data/Changelog.txt");

                    //Loads text into textbox
                    string changes = sr.ReadToEnd();
                    txtChangelog.Text = changes.Replace("\n", Environment.NewLine);
                }
                catch
                {
                    //Checks if data directory exists
                    if (!Directory.Exists("Data")) Directory.CreateDirectory("Data");

                    //Create offline changelog
                    StreamWriter sw = new StreamWriter("Data/Changelog.txt");
                    sw.WriteLine("Changelog for version 0.5.0:\n" +
                        " -Added new help icon \n" +
                        " -Added new chnagelog form \n" +
                        " -Added new 'gpu' panel \n" +
                        " -Added new setting");
                    sw.Close();

                    //Loads text into textbox
                    StreamReader sr = new StreamReader("Data/Changelog.txt");
                    txtChangelog.Text = sr.ReadToEnd().Replace("\n", Environment.NewLine);
                }
            }
            //Darkmode
            if (Properties.Settings.Default.Darkmode)
            {
                this.BackColor = Color.FromArgb(41, 41, 41);
                this.ForeColor = Color.White;
                txtChangelog.BackColor = Color.FromArgb(41, 41, 41);
                txtChangelog.ForeColor = Color.White;
                this.panelName.ForeColor = ForeColor;
                this.btnExit.BackColor = Color.FromArgb(55, 55, 55);
                this.btnExit.FlatAppearance.BorderColor = Color.FromArgb(55, 55, 55);
                this.btnHide.BackColor = Color.FromArgb(55, 55, 55);
                this.btnHide.FlatAppearance.BorderColor = Color.FromArgb(55, 55, 55);
                this.panelName.BackColor = Color.FromArgb(55, 55, 55);
            }
        }

        //Moving window functions
        private void MoveWindow(object sender, MouseEventArgs e)
        {
            if (enableMoving)
            {
                this.Location = new Point(e.X + this.Left - initialClickedPoint.X,
                        e.Y + this.Top - initialClickedPoint.Y);
            }
        }
        //When window is clicked
        private void ClickWindow(object sender, MouseEventArgs e)
        {
            enableMoving = true;
            initialClickedPoint = e.Location;
        }
        //When windows isn't clicked
        private new void MouseUp(object sender, MouseEventArgs e)
        {
            enableMoving = false;
        }

        //When exit button click
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        //When hide button click
        private void btnHide_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        //remove focus from textbox
        private void textBox1_Enter(object sender, EventArgs e)
        {
            panelName.Focus();
        }
    }
}
