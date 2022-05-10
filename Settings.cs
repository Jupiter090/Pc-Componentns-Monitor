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

namespace PcComponentnsStats
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            //Change the checks state
            chbxSendNotifactionns.Checked = Properties.Settings.Default.sendMessage;

            checkBox1.Checked = Properties.Settings.Default.Darkmode;

            if (Properties.Settings.Default.Darkmode)
            {
                this.BackColor = Color.FromArgb(92, 92, 92);
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
                this.BackColor = Color.FromArgb(92, 92, 92);
                this.ForeColor = Color.White;
            }
            else
            {
                this.BackColor = Color.White;
                this.ForeColor = Color.Black;
            }
        }
    }
}
