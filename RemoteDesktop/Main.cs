using MetroFramework.Forms;

using MSTSCLib;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RemoteDesktop
{
    public partial class Main : MetroForm
    {
        bool pingable = false;

        public Main()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {
            try
            {
                GetMyIp();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:",ex.Message,MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void GetMyIp()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());

            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    yourIPTextBox.Text = ip.ToString();
                }
            }
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            try
            {
                rdp.Server = clientIPTextBox.Text;
                rdp.UserName = usernameTextBox.Text;

                IMsTscNonScriptable Secured = (IMsTscNonScriptable)rdp.GetOcx();
                Secured.ClearTextPassword = passwordTextBox.Text;
                rdp.Connect();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void disconnectButton_Click(object sender, EventArgs e)
        {
            if (rdp.Connected.ToString() == "1")
                rdp.Disconnect();
        }

        private void clientIPTextBox_Leave(object sender, EventArgs e)
        {
            string MachineName = string.Empty;

            try
            {
                string ip = clientIPTextBox.Text;
                IPHostEntry hostEntry = Dns.GetHostEntry(ip);
                MachineName = hostEntry.HostName;

                clientNameLabel.Text = MachineName;
                usernameTextBox.Text = "Administrator";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkConnectionButton_Click(object sender, EventArgs e)
        {
            try
            {
                Ping ping = new Ping();
                string IpAddress = clientIPTextBox.Text;
                PingReply pingReply = ping.Send(IpAddress);

                pingable = pingReply.Status == IPStatus.Success;

                if(pingable)
                {
                    MessageBox.Show("Connection Success","Status",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Connection Failes","Status",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
