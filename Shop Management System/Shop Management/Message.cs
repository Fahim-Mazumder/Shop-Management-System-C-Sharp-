using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace Shop_Management
{
    public partial class Message : MetroForm
    {
        public Message()
        {
            InitializeComponent();
        }

        private void Message_Load(object sender, EventArgs e)
        {

        }

        private void buttonsave_Click(object sender, EventArgs e)
        {
            using (System.Net.WebClient client = new System.Net.WebClient())
            {
                try
                {
                    string url= " http://smsc.vianett.no/v3/send.ashx?"+
                           "src="+textBoxPhoneNumber.Text+"&"+
                           "dst="+textBoxPhoneNumber.Text+"&"+
                           "msg="+System.Web.HttpUtility.UrlEncode(textBoxMessage.Text,System.Text.Encoding.GetEncoding("ISO-8859-1"))+"&"+
                           "username="+System.Web.HttpUtility.UrlEncode(textBoxUserName.Text)+"&"+
                           "password="+System.Web.HttpUtility.UrlEncode(textBoxPassword.Text);
                    string result = client.DownloadString(url);
                    if (result.Contains("OK"))
                        MessageBox.Show("Your message has been send.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Your message not send.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Admin ad = new Admin();
            ad.Show();
            this.Hide();
        }

        private void textBoxUserName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
