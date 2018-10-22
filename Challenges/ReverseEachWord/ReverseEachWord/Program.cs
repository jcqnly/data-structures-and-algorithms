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

		public static string ReverseWord(string input)
		{
			StringBuilder sb = new StringBuilder();
			//split word on space
			string[] splitString = input.Split(" ");

			//iterate through every word
			for (int i = 0; i <= splitString.Length - 1; i++)
			{
				//start at the end of every word
				for (int j = splitString[i].Length - 1; j >= 0; j--)
				{
					sb.Append(splitString[i][j]);
					//Console.WriteLine(splitString[i][j]);
				}
				sb.Append(" ");
			}
			return sb.ToString();
		}

		//stretch goal: find another solution
	}
}
