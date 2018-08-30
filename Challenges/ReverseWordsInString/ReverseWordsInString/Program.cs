using System;
using System.Collections.Generic;
using System.Text;

namespace ReverseWordsInString
{
	public class Program
	{
		public static void Main(string[] args)
		{
			string givenString = "Hello world!";

			//reverse words in a string
			//Hello world -> world Hello

			Console.WriteLine(ReverseWordsStringBuilder(givenString));		
		}

		/// <summary>
		/// Solving the problem with Stringbuilder
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
