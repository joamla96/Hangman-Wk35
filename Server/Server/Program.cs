using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Net.Sockets;
using System.Net;
using System.IO;

namespace Server
{
	class Program
	{
		private static bool ProgramRunning = true;
		List<Client> Clients = new List<Client>();

		Hangman game;
		static void Main(string[] args)
		{
			Program program = new Program();
			program.Run();
		}

		public delegate void MakeGuess(char letter);
		public event MakeGuess Guess;

		private void Run()
		{
			Thread ClientThread = new Thread(AcceptClients);
			ClientThread.Start();

			while (ProgramRunning)
			{
				Console.WriteLine("Write word for hangman:");
				string word = Console.ReadLine();
				game = new Hangman(word);
			}

		}

		private void AcceptClients()
		{
			IPAddress ip = IPAddress.Any;
			TcpListener listener = new TcpListener(ip, 5000);
			listener.Start();

			while (ProgramRunning)
			{
				TcpClient TCPclient = listener.AcceptTcpClient();
				Client client = new Client(TCPclient);

				Clients.Add(client);
			}
		}
	}
}
