using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;
namespace ClientConnect
{
    public class Client
    {
        IPAddress ip = null;
        public int port = 1;
        public bool isPortValid;
        public bool isIpValid;
        public Socket clientSocket = null;
        public char[] charArray = { 'a', 'b', 'c' };
        public string userName = "adadas";
        public bool canConnect = false;

        public void getHostInfo(string ipFieldText, string portFieldText)
        {
            switch (IPAddress.TryParse(ipFieldText, out ip))
            {
                case false:
                    isIpValid = false;

                    break;

                case true:
                    isIpValid = true;
                    break;
            }

            switch (int.TryParse(portFieldText, out port))
            {
                case false:
                    isPortValid = false;
                    break;

                case true:
                    isPortValid = true;
                    break;
            }

         
        }

        public void connect(string username)
        {
            try
            {
                clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                clientSocket.Connect(ip, port);
                System.Windows.Forms.MessageBox.Show("Connected To Server");
                clientSocket.Send(Encoding.ASCII.GetBytes(username.ToCharArray()));
                canConnect = true;
            }
            catch(Exception ex)
            {
                canConnect = false;
                MessageBox.Show("Error Invalid IP/Port");
            }
        }



    }
}
