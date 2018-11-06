using System;
using System.Text;

namespace ReverseEachWord
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Reverse each word in a string, but maintain the word order");
			string input = "Hello world";
			//Console.WriteLine(ReverseWord(input));
			Console.WriteLine(ReverseWordNoSplit(input));
		}

		/// <summary>
		/// Takes in a string and reverses each word and maintains word order
		/// </summary>
		/// <param name="input">type string to reverse</param>
		/// <returns>string where each word is reversed</returns>
		public static string ReverseWord(string input)
		{
			StringBuilder sb = new StringBuilder();
			//split word on space
			//in some IDE, the " " will throw an error "cannot convert type string[] to char"
			//string[] splitString = input.Split(" ");
			//changing this to ' ' helps and is the fastest option of all 
			string[] splitString = input.Split(' ');
			//another way to split on a space is:
			//string[] splitString = input.Split(new char[] {' '});

			//iterate through every word
			for (int i = 0; i <= splitString.Length - 1; i++)
			{
				//start at the end of every word
				for (int j = splitString[i].Length - 1; j >= 0; j--)
				{
					sb.Append(splitString[i][j]);
				}
				sb.Append(" ");
			}
			return sb.ToString();
		}

		/// <summary>
		/// Reverse each word, but don't use the split method
		/// </summary>
		/// <param name="input"></param>
		/// <returns></returns>
		public static string ReverseWordNoSplit(string input)
		{
			StringBuilder sb = new StringBuilder();
			//set a counter.  this will determine where i needs to be
			int letterCount = 0;
			//loop through length of string
			for (int i = 0; i < input.Length; i++)
			{
				//if it's not a white space, increment counter
				if (!Char.IsWhiteSpace(input[i])) letterCount++;

				//this is the pointer for where we are in the word to append
				int temp = i;

				//start appending process if i is a space or 
				//we're at the end of the string
				if (Char.IsWhiteSpace(input[i]) || i == input.Length - 1)
				{
					//since we're at a space, and temp = i, decrement i because
					//we want the stuff before the space
					if (Char.IsWhiteSpace(input[i])) temp--;

					//start appending from the end of the word for however many letters there are
					while (letterCount > 0)
					{
						sb.Append(input[temp]);
						letterCount--;
						//get out of this while loop if there are no more letters
						if (letterCount == 0) break;
						temp--;
					}
				}

				//finally, append a space if we're at a space after appending previous letters
				if (Char.IsWhiteSpace(input[i])) sb.Append(" ");			
			}
			return sb.ToString();
		}

		//stretch goal: figure out edge cases
	}
}
