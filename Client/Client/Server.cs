using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.IO;

namespace Client
{
	class Server
	{
		StreamWriter Writer;
		StreamReader Reader;
		public Server(TcpClient server)
		{
			Writer = new StreamWriter(server.GetStream());
			Reader = new StreamReader(server.GetStream());
			Writer.AutoFlush = true;
		}
	}
}
