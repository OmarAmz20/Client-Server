using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;


    public class IP
    {
        public string GetIp()
    {
        var n = Dns.GetHostName();
        var ipAll = Dns.GetHostByName(n).AddressList;
        foreach (var ip in ipAll)
        {
            if (ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
            {
                return ip.ToString();
            }
        }
        return null;
    }
    
    }

