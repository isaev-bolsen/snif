using System;
using System.Net;
using System.Net.Sockets;

namespace snif
{
    public class snif
    {
        TcpListener listener = new TcpListener(IPAddress.Parse("127.0.0.1"), 80);
        byte[] message = System.Text.Encoding.ASCII.GetBytes("HAIL TORVALDS!");

        public void startSnif()
        {
            listener.Start();
            while (true)
            {
                TcpClient client = listener.AcceptTcpClient();
                NetworkStream stream = client.GetStream();
                stream.Write(message, 0, message.Length);
                client.Close();
            }
        }
    }
}

