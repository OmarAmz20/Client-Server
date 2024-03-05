using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;


    public class IpAdress
    {
        public string GetIp()
    {
        var n = Dns.GetHostName();
        var ip = Dns.GetHostByName(n).AddressList[0].ToString();
        return ip;
    }
    
    }

