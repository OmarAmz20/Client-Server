using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace CS
{
    public class Client
    {
        public void Active()
        {
            var client = new TcpClient();
            var h = "127.0.0.1";
            while (true)
            {
                try
                {
                    client.Connect(h, 8080);
                    NetworkStream network = client.GetStream();

                    var reader = new StreamReader(network);

                    var msg = "Connected";

                    byte[] bytes_msg = Encoding.UTF8.GetBytes(msg);

                    network.Write(bytes_msg, 0, bytes_msg.Length);

                    Console.WriteLine(reader.ReadToEnd());
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Search ...");
                }


            }
            Console.ReadLine();

        }
    }
}
