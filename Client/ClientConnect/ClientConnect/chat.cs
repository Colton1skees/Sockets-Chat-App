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
using System.Threading;

namespace ClientConnect
{

    public partial class chat : Form
    {
        public Socket socketInstance;
        public Client clientInstance = null;

        public chat()
        {
            InitializeComponent();
            Thread acceptMessagesThread = new Thread(() => acceptMessages(chatList));
            acceptMessagesThread.Start();

        }

        public void reconnect()
        {
            DialogResult canReconnected = MessageBox.Show("Would you like to reconnect?", "Error Server Disconnected", MessageBoxButtons.YesNo);
            if (canReconnected == DialogResult.Yes)
            {
                socketInstance = null;
                clientInstance.connect(clientInstance.userName);
                socketInstance = clientInstance.clientSocket;
                Thread acceptMessagesThread = new Thread(() => acceptMessages(chatList));
                acceptMessagesThread.Start();
                chatList.Invoke(new Action(() => chatList.Items.Add("Reconnected To Server:")));
                chatField.Invoke(new Action(() => chatField.Enabled = true));
                sendButton.Invoke(new Action(() => sendButton.Enabled = true));
            }
        }

        private void chatList_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            socketInstance.Send(Encoding.UTF8.GetBytes(chatField.Text.ToCharArray()));
            chatList.Items.Add(clientInstance.userName + ": " + chatField.Text);
            chatField.Text = "";
            
        }

        private void chatField_TextChanged(object sender, EventArgs e)
        {
            
        }

        public void acceptMessages(ListBox lb)
        {

            while (true)
            {

                byte[] buffer = new byte[256];

                try
                {
                    clientInstance.clientSocket.Receive(buffer);
                    lb.Invoke(new Action(() => lb.Items.Add(Encoding.UTF8.GetString(buffer))));
                }
                catch (Exception ex)
                {
                    chatField.Invoke(new Action(() => chatField.Enabled = false));
                    sendButton.Invoke(new Action(() => sendButton.Enabled = false));
                    chatField.Enabled = false;
                    MessageBox.Show("about to reconnect");
                    reconnect();
                    MessageBox.Show("Reconnected");
                    Thread.CurrentThread.Abort();
                }

       
           
            }
        }

        public delegate void acceptDelegate(ListBox lb);

        acceptDelegate acceptDg => new acceptDelegate(acceptMessages);


    }
}
