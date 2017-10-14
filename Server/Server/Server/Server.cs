using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Threading;
using System.Net.Sockets;
using System.Windows.Forms;
namespace ServerProgram
{
    class Server
    {
        Socket listenerSocket = null;
        List <Socket> connectionList = new List<Socket>();
        IPAddress ip;
        public int port = 1;
        public bool isPortValid;
        public bool isIpValid;
        Thread acceptMessagesThread;
        Thread acceptClientThread;

        public void getHostInfo(string ipFieldText, string portFieldText)
        {
            switch(IPAddress.TryParse(ipFieldText, out ip))
            { 
                case false:
                    isIpValid = false;
   
                    break;

                case true:
                    isIpValid = true;
                    break;
            }

            switch(int.TryParse(portFieldText, out port))
            {
                case false:
                    isPortValid = false;
                    break;

                case true:
                    isPortValid = true;
                    break;
            }
        }

        public bool listen()
        {
            try
            {
                listenerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IPEndPoint serverEndPoint = new IPEndPoint(ip, port);

                listenerSocket.Bind(serverEndPoint);
                Console.WriteLine("Binding");

                listenerSocket.Listen(99);
                Console.WriteLine("Listening");

                Console.WriteLine("about to accept");
                acceptClientThread = new Thread(acceptClient);
                acceptClientThread.Start();


                return true;

            } catch(Exception ex)
            {
                Console.WriteLine("Error Problem with connecting. Most likely an invalid ip or port was typed.");
                return false;
            }
        }

        public void acceptClient()
        {

            while (true)
            {
                Socket client = listenerSocket.Accept();
                connectionList.Add(client);
                Console.WriteLine("Accepting CLients");
                acceptMessagesThread = new Thread(acceptMessages);
                acceptMessagesThread.Start(client);
                Console.WriteLine("accepted client: " + client.RemoteEndPoint);
            }
        }

        public void acceptMessages(object clientInstance)
        {
            Socket client = (Socket)clientInstance;
            byte[] buffer = new byte[256];
            client.Receive(buffer);
            string userName = Encoding.UTF8.GetString(buffer);
            try
            {
                while (true)
                {
                    if (client.Poll(2000, SelectMode.SelectRead) == false)
                    {
                        buffer = new byte[256];
                        client.Receive(buffer);
                        foreach(Socket c in connectionList)
                        {
                            if (c.RemoteEndPoint != client.RemoteEndPoint && c.Poll(90000, SelectMode.SelectRead) == false)
                            {
                                string tempMessage = userName + ": " + Encoding.UTF8.GetString(buffer);
                                c.Send(Encoding.UTF8.GetBytes(tempMessage));
                            }
                        }
                       
                        Console.WriteLine(userName + " : " + Encoding.UTF8.GetString(buffer));
                    }
                    else
                    {
                        break;
                 
                    }
                }
            }
            catch (Exception ex)
            {
                
            }
        }

    }
}
