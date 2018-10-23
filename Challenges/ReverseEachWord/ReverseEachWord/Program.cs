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
			Console.WriteLine(ReverseWord(input));
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

		//stretch goal: figure out edge cases
	}
}
