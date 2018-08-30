using System;
using System.Collections.Generic;
using System.Text;

namespace ReverseWordsInString
{
	public class Program
	{
		public static void Main(string[] args)
		{
			//Console.WriteLine("Hello World!");

			string givenString = "Hello world!";

			//reverse words in a string
			//Hello world -> world Hello

			//ReverseWordsBruteForce(givenString);
			Console.WriteLine(ReverseWordsStringBuilder(givenString));
			
		}

		/// <summary>
		/// Brute force
		/// </summary>
		/// <param name="givenString"></param>
		/// <returns></returns>
		public static string ReverseWordsBruteForce(string givenString)
		{
			List<string> newString = new List<string>();
			int lastSpace = -1;
			for (int i = 0; i < givenString.Length; i++)
			{
				if (char.IsWhiteSpace(givenString[i]))
				{
					//newString.Add(lastSpace++, givenString[i]);
				}
			}
			return givenString;
		}

		/// <summary>
		/// Stringbuilder
		/// </summary>
		/// <param name="givenString"></param>
		/// <returns></returns>
		public static string ReverseWordsStringBuilder(string givenString)
		{
			string[] newString = givenString.Split(" ");
			StringBuilder sb = new StringBuilder();
			for (int i = newString.Length - 1; i >= 0; i--)
			{
				sb.Append(newString[i]);
				if (i != 0)
				{
					sb.Append(" ");
				}		
			}

			return sb.ToString();
		}
	}
}
