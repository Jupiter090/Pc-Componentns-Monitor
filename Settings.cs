using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Cryptography;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using System.Drawing.Drawing2D;

namespace PcComponentsMonitor
{
    public partial class Settings : Form
    {
        private bool dont = false;
        private bool enableMoving = false;
        private Point initialClickedPoint = new Point();
        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            //Change the checks state
            chbxSendNotifactionns.Checked = Properties.Settings.Default.sendMessage;

            dont = true;
            checkBox1.Checked = Properties.Settings.Default.Darkmode;
            comboBox1.Text = Properties.Settings.Default.Position;
            chcIgnoreTskbar.Checked = Properties.Settings.Default.IgnoreTaskbar;

            if (Properties.Settings.Default.Darkmode)
            {
                this.BackColor = Color.FromArgb(41, 41, 41);
                this.ForeColor = Color.White;
            }
        }

        private void chbxSendNotifactionns_CheckedChanged(object sender, EventArgs e)
        {
            //send notifications setting
            CheckBox box = sender as CheckBox;
            Properties.Settings.Default.sendMessage = box.Checked;
            Properties.Settings.Default.Save();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            //Dark mode setting
            CheckBox check = sender as CheckBox;

            Properties.Settings.Default.Darkmode = check.Checked;
            Properties.Settings.Default.Save();
            if (Properties.Settings.Default.Darkmode)
            {
                this.BackColor = Color.FromArgb(41, 41, 41);
                this.ForeColor = Color.White;
                this.panelName.ForeColor = ForeColor;
                this.btnExit.BackColor = Color.FromArgb(55, 55, 55);
                this.btnExit.FlatAppearance.BorderColor = Color.FromArgb(55, 55, 55);
                this.btnHide.BackColor = Color.FromArgb(55, 55, 55);
                this.btnHide.FlatAppearance.BorderColor = Color.FromArgb(55, 55, 55);
                this.panelName.BackColor = Color.FromArgb(55, 55, 55);
            }
            else
            {
                this.BackColor = Color.White;
                this.ForeColor = Color.Black;
                this.panelName.ForeColor = ForeColor;
                this.btnExit.BackColor = Color.FromArgb(224, 224, 224);
                this.btnExit.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
                this.btnHide.BackColor = Color.FromArgb(224, 224, 224);
                this.btnHide.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
                this.panelName.BackColor = Color.FromArgb(224, 224, 224);
            }
        }

        //When user change position setting
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dont)
            {
                dont = false;
                return;
            }
            ComboBox comboBox = sender as ComboBox;
            btnApply.Visible = true;
            Properties.Settings.Default.Position = comboBox.Text;
            Properties.Settings.Default.DefualtPosY = 0;
            Properties.Settings.Default.DefaultPosX = 0;
            Properties.Settings.Default.Save();
        }

        //Button apply click event
        private void btnApply_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.ChangeDefaultPosition)
            {
                Properties.Settings.Default.ChangeDefaultPosition = false;
                Properties.Settings.Default.Save();
                App.reason = "change pos and apply";
                this.Close();
            }
            App.reason = "apply";
            this.Close();
        }

        //Button ignore taskbar click event
        private void chcIgnoreTskbar_CheckedChanged(object sender, EventArgs e)
        {
            if (dont)
            {
                dont = false;
                return;
            }
            CheckBox checkBox = sender as CheckBox;
            Properties.Settings.Default.IgnoreTaskbar = checkBox.Checked;
            btnApply.Visible = true;
            Properties.Settings.Default.Save();
        }

        //Button exit click event
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Button hide click event 
        private void btnHide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //When user whants to move the window
        private void panelName_MouseDown(object sender, MouseEventArgs e)
        {
            enableMoving = true;
            initialClickedPoint = e.Location;
        }

        private void panelName_MouseUp(object sender, MouseEventArgs e)
        {
            enableMoving = false;
        }

        private void panelName_MouseMove(object sender, MouseEventArgs e)
        {
            if (enableMoving)
            {
                this.Location = new Point(e.X + this.Left - initialClickedPoint.X,
                        e.Y + this.Top - initialClickedPoint.Y);
            }
        }

        //Let user to change defualt position
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.ChangeDefaultPosition = true;
            Properties.Settings.Default.Save();
            btnApply.Visible=true;
        }

        private void imgHelpIgnerTskbr_MouseHover(object sender, EventArgs e)
        {
            panelHelpChngDfltPos.Visible = true;
        }

        private void imgHelpIgnerTskbr_MouseLeave(object sender, EventArgs e)
        {
            panelHelpChngDfltPos.Visible = false;
        }

        private void btnChangelog_Click(object sender, EventArgs e)
        {
            Form changelog = new Changelog();
            changelog.Show();
        }
    }
}
