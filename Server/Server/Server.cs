using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Server
{
    class Server
    {
        static void Main(string[] args)
        {
            TcpListener listener = new TcpListener(IPAddress.Parse("127.0.0.1"), 500);
            listener.Start();

                Socket socket = listener.AcceptSocket();
                Byte[] streamMessage = new byte[2048];
                socket.Receive(streamMessage);
                string message = Encoding.ASCII.GetString(streamMessage);
                var oMessage = JsonConvert.DeserializeObject(message);
                Console.WriteLine(oMessage);
                Console.ReadKey();
                socket.Close();
                socket.Dispose();
        }
    }
}
