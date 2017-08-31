using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
	class Hangman
	{
		private string word;
		public string Word {
			get {
				string result = "";
				foreach(char letter in this.word)
				{
					if (Guesses.Contains(letter))
					{
						result = result + letter;
					}
					else result = result + "_";
				}
				return result;
			}

			private set {
				this.word = value;
			}
		}
		public int Lives { get; private set; }

		private List<char> Guesses = new List<char>();

		public Hangman(string word)
		{
			this.Word = word;
			this.Lives = 10; 
		}

		public bool Guess(char letter)
		{
			if(Guesses.Contains(letter))
			{
				throw new LetterGuessedException();
			}

			bool result;
			if (Word.Contains(letter))
			{
				result = true;
			}
			else
			{
				result = false;
				Lives--;
				if(Lives == 0)
				{
					throw new OutOfLivesException();
				}
			}

			return result;
		}


	}

	public class LetterGuessedException : Exception {	}
	public class OutOfLivesException : Exception { }
}
