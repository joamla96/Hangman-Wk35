using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.IO;


namespace Server
{
	public class Client
	{
		public StreamReader reader;
		public StreamWriter writer;
		
		public Client(TcpClient client)
		{
			writer = new StreamWriter(client.GetStream());
			reader = new StreamReader(client.GetStream());
			writer.AutoFlush = true;
		}
	}
}
