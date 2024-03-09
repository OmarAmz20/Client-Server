using CS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CS { 
    internal class Program
    {
        static void Main(string[] args)
        {
            var server = new Server();
            var ipAdress = new IP();
            server.Active(ipAdress.GetIp(), 8080);
            Console.Read();
        }
    }
}
