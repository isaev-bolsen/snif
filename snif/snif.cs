using System;
using System.Net;
using System.Net.Sockets;

namespace snif
{
	public class snif
	{
		TcpListener listener = new TcpListener (IPAddress.Any);

		public void startSnif ()
		{
			listener.Start ();
			while (true) {
				TcpClient client = listener.AcceptTcpClient ();
				NetworkStream stream = client.GetStream ();
			}
		}
	}
}

