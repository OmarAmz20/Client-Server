using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace CS { 
public class Server
{
    private TcpListener _listener;

    public void Active(string ip,int port)
    {

        var hostAdress = IPAddress.Parse(ip);

        this._listener = new TcpListener(hostAdress,port);
        this._listener.Start();
        Console.WriteLine("server is started IP : {0} // Port : {1} !!!",ip,port);

        byte[] buffer = new byte[1024];

        TcpClient client = _listener.AcceptTcpClient();
        
        var Stream = client.GetStream();

        int read = Stream.Read(buffer, 0, buffer.Length);

        byte[] msg2 = Encoding.UTF8.GetBytes("server send data");

        Stream.Write(msg2, 0, msg2.Length);

        var msg = Encoding.UTF8.GetString(buffer, 0, read);

        Console.WriteLine("Client : " + msg);

        client.Close();
    }
}
}
