using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            chbxSendNotifactionns.Checked = Properties.Settings.Default.sendMessage;
        }

        private void chbxSendNotifactionns_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox box = sender as CheckBox;
            Properties.Settings.Default.sendMessage = box.Checked;
            Properties.Settings.Default.Save();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
