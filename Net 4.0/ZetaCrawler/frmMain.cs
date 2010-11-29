using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ZetaCrawler
{
    public partial class frmMain : Form
    {
        private List<string> _contacts;
        private bool _flag_BIDV = false;
        private bool _flag_ASPNET = false;
        private bool _flag_Mp3Zing = false;
        private bool _flag_Newsletter = false;

        public frmMain()
        {
            _contacts = new List<string>();

            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (_flag_BIDV)
            {
                BIDVCrawler.Run();               
            }

            if (_flag_ASPNET)
            {
                ASPNETCrawler.Run();               
            }

            if (_flag_Mp3Zing)
            {
                Console.WriteLine("");
            }

            try
            {
                EmailNotify notify = new EmailNotify();
                notify.SendMail(this._contacts, "TIN TỨC TRONG NGÀY", Newsletter.BuildNewsletter(), true); ;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            string[] strSplit = {";" };
            string[] strContacts = this.textBox1.Text.Trim().Split(strSplit, StringSplitOptions.None);
            for (int i = 0; i <= strContacts.Length - 1; i++)
            {
                _contacts.Add(strContacts[i]);
            }

            this.timer1.Interval = int.Parse(this.txtInterval.Text.Trim());
            this.timer1.Enabled = !this.timer1.Enabled;
        }

        private void chkBIDV_CheckedChanged(object sender, EventArgs e)
        {
            _flag_BIDV = chkBIDV.Checked;
        }

        private void chkMp3Zing_CheckedChanged(object sender, EventArgs e)
        {
            _flag_Mp3Zing = chkMp3Zing.Checked;
        }

        private void chkASPNET_CheckedChanged(object sender, EventArgs e)
        {
            _flag_ASPNET = chkASPNET.Checked;
        }

        private void chkNewsletter_CheckedChanged(object sender, EventArgs e)
        {
            _flag_Newsletter = chkNewsletter.Checked;
        }
    }
}
