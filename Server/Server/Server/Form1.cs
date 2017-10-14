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
using System.Net;
namespace ServerProgram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            serverStartButton.Enabled = false;

        }
        Server newServer = new Server();

       

        private void ipLabel_Click(object sender, EventArgs e)
        {

        }

        private void portLabel_Click(object sender, EventArgs e)
        {

        }

        private void ipField_TextChanged(object sender, EventArgs e)
        {

            newServer.getHostInfo(ipField.Text, portField.Text);

            if (newServer.isIpValid == false)
            {
                ipField.ForeColor = Color.Red;
                serverStartButton.Enabled = false;
            }
   
            else
            {
                ipField.ForeColor = Color.Green;

                if (newServer.isPortValid == true)
                {
                    serverStartButton.Enabled = true;
                }
            }

        }

        private void portField_TextChanged(object sender, EventArgs e)
        {
            newServer.getHostInfo(ipField.Text, portField.Text);
            

            if (newServer.isPortValid == false)
            {
                portField.ForeColor = Color.Red;

                serverStartButton.Enabled = false;
            }

            else
            {
                portField.ForeColor = Color.Green;

                if (newServer.isIpValid == true)
                {
                    serverStartButton.Enabled = true;
                }

            }

        }

        private void serverStartButton_Click(object sender, EventArgs e)
        {

            if(newServer.isPortValid == true && newServer.isIpValid == true)
            {
                if(newServer.listen() == true)
                {
                    serverStartButton.Enabled = false;
                } 
                else
                {
                    serverStartButton.Enabled = true;
                }
            }

        }
    }
}
