using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;


namespace Server
{
    class Server
    {
        static byte[] Buffer { get; set; }
        Server() { 
            Socket sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint ep = new IPEndPoint(IPAddress.Any, 5000);
            sock.Bind(ep);
            sock.Listen(10);
            Socket accept = sock.Accept();
            Buffer = new byte[accept.SendBufferSize];
            int read = accept.Receive(Buffer);
            byte[] format = new byte[read];
            for (int i = 0; i < read; ++i)
            {
                format[i] = Buffer[i];
            }
            string strdata = Encoding.UTF8.GetString(format);
            
            Console.Write(strdata + "\r\n");
            Console.Read();
            accept.Close();
            sock.Close();

        }
        public static void Main(String[] args)
        {
            new Server();
        }


    }
}