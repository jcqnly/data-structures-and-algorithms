using System;
using System.Text;

namespace ReverseWordInString
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Reverse Word in a String!");
			string givenString = "Hello World!";
			Console.WriteLine(ReverseWord(givenString));
		}

		public static string ReverseWord(string givenString)
		{
			string[] splitString = givenString.Split(" ");
			StringBuilder sb = new StringBuilder();
			for (int i = 0; i < splitString.Length-1; i++)
			{
				for (int j = splitString[i].Length-1; j > 0; j--)
				{
					sb.Append(splitString[i][j]);
				}
				if (i != splitString.Length)
				{
					sb.Append(" ");
				}
			}
			return sb.ToString();
		}
	}
}
