using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();
             var ipAdress = new IP();
            client.Active(ipAdress.GetIp()); 
        }
    }
}
