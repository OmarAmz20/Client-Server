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
        public void Active(string h)
        {
            var connected = false;
            var client = new TcpClient();
            while (true)
            {
                try
                {
                    client.Connect(h, 8080);
                    connected = true;
                    NetworkStream stream = client.GetStream();

                    var msg = "Connected";

                    byte[] bytes_msg = Encoding.UTF8.GetBytes(msg);

                    stream.Write(bytes_msg, 0, bytes_msg.Length);

                    byte[] buffer = new byte[1024];

                    var m = Encoding.UTF8.GetString(buffer,0, stream.Read(buffer,0,buffer.Length));

                    Console.WriteLine(m);

                    break;
                }
                catch (Exception e)
                {
                    if (connected)
                    {
                        Console.WriteLine("Disconnected");
                        break;
                    }else
                    {
                        Console.WriteLine("Search ...");
                    }

                }


            }
            Console.ReadLine();

        }
    }
}
