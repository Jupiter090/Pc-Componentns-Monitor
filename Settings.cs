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


        private void customButtons1_Click(object sender, EventArgs e)
        {
            //Sends the report
            try
            {
                var smtpClient = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587,
                    Credentials = new NetworkCredential("jupiter909990@gmail.com", DecryptCipherTextToPlainText(Properties.Settings.Default.Dfhgf4578hfg)),
                    EnableSsl = true,
                };
                smtpClient.Send("jupiter909990@gmail.com", "jupiter090testing@gmail.com", cmBoxReason.Text + "/" + txtName.Text, txtText.Text);
                msgError.Text = String.Empty;
            }
            catch
            {
                msgError.Text = "Something happensd while trying to send this report!";
            }
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

        //Encrypt and decrypt
        private const string SecurityKey1 = "ThI3213sIS(ds(F)fgd//FdNo66312T213SeCuR11t2Key61143WhYArE23123yoUraeDDDinG452638";
        public static string EncryptPlainTextToCipherText(string PlainText)
        {
            byte[] toEncryptedArray = UTF8Encoding.UTF8.GetBytes(PlainText);

            MD5CryptoServiceProvider objMD5CryptoService = new MD5CryptoServiceProvider();
            byte[] securityKeyArray = objMD5CryptoService.ComputeHash(UTF8Encoding.UTF8.GetBytes(SecurityKey1));
            objMD5CryptoService.Clear();

            var objTripleDESCryptoService = new TripleDESCryptoServiceProvider();
            objTripleDESCryptoService.Key = securityKeyArray;
            objTripleDESCryptoService.Mode = CipherMode.ECB;
            objTripleDESCryptoService.Padding = PaddingMode.PKCS7;


            var objCrytpoTransform = objTripleDESCryptoService.CreateEncryptor();
            byte[] resultArray = objCrytpoTransform.TransformFinalBlock(toEncryptedArray, 0, toEncryptedArray.Length);
            objTripleDESCryptoService.Clear();
            return Convert.ToBase64String(resultArray, 0, resultArray.Length);
        }
        public static string DecryptCipherTextToPlainText(string CipherText)
        {
            byte[] toEncryptArray = Convert.FromBase64String(CipherText);
            MD5CryptoServiceProvider objMD5CryptoService = new MD5CryptoServiceProvider();

            byte[] securityKeyArray = objMD5CryptoService.ComputeHash(UTF8Encoding.UTF8.GetBytes(SecurityKey1));
            objMD5CryptoService.Clear();

            var objTripleDESCryptoService = new TripleDESCryptoServiceProvider();
            objTripleDESCryptoService.Key = securityKeyArray;
            objTripleDESCryptoService.Mode = CipherMode.ECB;
            objTripleDESCryptoService.Padding = PaddingMode.PKCS7;

            var objCrytpoTransform = objTripleDESCryptoService.CreateDecryptor();
            byte[] resultArray = objCrytpoTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);
            objTripleDESCryptoService.Clear();

            return UTF8Encoding.UTF8.GetString(resultArray);
        }

    }
}
