using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
namespace ClientConnect
{
    public partial class connectionWindow : Form
    {
        public Client client = new Client();
        public chat chatWindow = null;
        public connectionWindow()
        {
            InitializeComponent();
            connectButton.Enabled = false;
            ipField.Text = Settings1.Default.IpAddress;
            portField.Text = Settings1.Default.Port;
            usernameField.Text = Settings1.Default.Username;
           
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ipField_TextChanged(object sender, EventArgs e)
        {
            client.getHostInfo(ipField.Text, portField.Text);

            if (client.isIpValid == false)
            {
                ipField.ForeColor = Color.Red;
                connectButton.Enabled = false;
            }

            else
            {
                ipField.ForeColor = Color.Green;

                if (client.isPortValid == true)
                {
                    connectButton.Enabled = true;
                }
            }

            if (client.isIpValid && client.isPortValid == true)
            {
                connectButton.Enabled = true;
            }
        }

        private void portField_TextChanged(object sender, EventArgs e)
        {
            client.getHostInfo(ipField.Text, portField.Text);

            if (client.isPortValid == false)
            {
                portField.ForeColor = Color.Red;
                connectButton.Enabled = false;
            }

            else
            {
                portField.ForeColor = Color.Green;

                if (client.isPortValid == true)
                {
                   connectButton.Enabled = true;
                }
            }

            if (client.isIpValid && client.isPortValid == true)
            {
                connectButton.Enabled = true;
            }

        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            if (client.isIpValid && client.isPortValid == true)
            {
                client.connect(usernameField.Text);
                if (client.canConnect == true)
                {
                    chatWindow = new chat();
                    chatWindow.socketInstance = client.clientSocket;
                    chatWindow.clientInstance = client;
                    chatWindow.Show();
                    client.userName = usernameField.Text;
                }
            }

        }

        private void usernameField_TextChanged(object sender, EventArgs e)
        {

        }

        private void saveConfigurationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings1.Default.IpAddress = ipField.Text;
            Settings1.Default.Port = portField.Text;
            Settings1.Default.Username = usernameField.Text;
            Settings1.Default.Save();

        }
    }
}
