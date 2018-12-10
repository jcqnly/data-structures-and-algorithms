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
			string s2 = "pound cake steak";
			string s3 = "pound cake steak steal";

			//reverse words in a string
			//Hello world -> world Hello
			//Console.WriteLine(ReverseWordsStringBuilder(givenString));
			//string[] answer = ReverseWithRecursion(s2);
			//foreach (string s in answer) Console.WriteLine(s);
			//Console.WriteLine("------------");
			//string[] answer2 = ReverseWithRecursion(s3);
			//foreach (string s in answer2) Console.WriteLine(s);
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

		/// <summary>
		/// Split the string on a space and put each word into an array
		/// </summary>
		/// <param name="s">an array of string type</param>
		/// <returns></returns>
		public static string[] ReverseWithRecursion(string s)
		{
			string[] newString = s.Split(" ");
			int start = 0;
			int end = newString.Length-1;
				
			return RecursingTheString(start, end, newString);
		}


		/// <summary>
		/// recursive method to swap
		/// </summary>
		/// <param name="start">start of the string</param>
		/// <param name="end">end of the string</param>
		/// <param name="s">aray of string type</param>
		/// <returns>array of the string swapped so far</returns>
		public static string[] RecursingTheString(int start, int end, string[] s)
		{
			//base case for arrays with an odd number of words
			//if (start == end) return s;
			//base case for arrays with an even number of words
			//if (start == end + 1) return s;

			//the if conditional is another base case
			if (start < end)
			{
				string temp = s[start];
				s[start] = s[end];
				s[end] = temp;
				start++;
				end--;
				RecursingTheString(start, end, s);
			}
			return s;
		}
	}
}
