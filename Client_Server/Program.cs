using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client_Server
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cl = new CS.Client();
            cl.Active();
        }
    }
}
