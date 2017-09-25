using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;
using System.IO;
using Newtonsoft.Json;

namespace Client
{
    class Client
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Name");
            var first = Console.ReadLine();
            Console.WriteLine("Enter Middle Name");
            var middle = Console.ReadLine();
            Console.WriteLine("Enter Last Name");
            var last = Console.ReadLine();
            var person = new Person(first, middle, last);
            var converted = JsonConvert.SerializeObject(person);
            string ipAddress = "127.0.0.1";
            int port = 500;
            TcpClient client = new TcpClient();
            client.Connect(ipAddress, port);
            NetworkStream channel = client.GetStream();
            {
                byte[] byteMessage = Encoding.ASCII.GetBytes(converted);
                channel.Write(byteMessage, 0, byteMessage.Length);
            }
        }
    }
}
