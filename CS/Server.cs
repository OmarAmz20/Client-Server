using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;


public class Server
{
    private TcpListener _listener;

    public void Active(string ip)
    {
        var port = 8080;

        var hostAdress = IPAddress.Parse(ip);

        this._listener = new TcpListener(hostAdress,port);
        this._listener.Start();
        Console.WriteLine("server is started IP : {0} // Port : {1} !!!",ip,port);

        byte[] buffer = new byte[1024];

        int bytesRead;

        TcpClient client = _listener.AcceptTcpClient();
        

        var Stream = client.GetStream();

        int Read = Stream.Read(buffer,0,buffer.Length);

        var msg = Encoding.UTF8.GetString(buffer ,0 ,buffer.Length);
        Console.WriteLine("Client : {0}", msg);
    }
}
