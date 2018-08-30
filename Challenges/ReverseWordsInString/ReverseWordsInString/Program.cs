using System;
using System.Collections.Generic;
using System.Text;

namespace ReverseWordsInString
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");

			string givenString = "Hello World";

			//reverse words in a string
			//Hello world -> world Hello

			//ReverseWordsBruteForce(givenString);
			ReverseWordsStringBuilder(givenString);
		}

		/// <summary>
		/// Brute force
		/// </summary>
		/// <param name="givenString"></param>
		/// <returns></returns>
		public static string ReverseWordsBruteForce(string givenString)
		{

			List<string> newString = new List<string>();

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
			foreach (string s in newString)
			{
				Console.WriteLine(s);
			}
			return givenString;
		}
	}
}
