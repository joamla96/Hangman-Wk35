using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Net;
using System.Net.Sockets;

namespace Client
{
	class Program
	{
		private bool programRunning = true;
		static void Main(string[] args)
		{
			Program p = new Program();
			p.Run();
		}

		private void Run()
		{
			TcpClient TCPserver = new TcpClient("127.0.0.1", 5000);
			Server server = new Server(TCPserver);

			while(pro)
		}
	}
}
