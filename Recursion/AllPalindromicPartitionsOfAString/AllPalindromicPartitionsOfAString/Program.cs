using System;
using System.Collections.Generic;

namespace AllPalindromicPartitionsOfAString
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Print all palindromic partitions of a string: ");

			string s = "bcc";
			List<List<string>> list = new List<List<string>>();

			Partition(s, list);
		}

		//generate all palindromic partitions of s and stores the results in v
		public static void Partition(string s, List<List<string>> v)
		{
			List<string> temp = new List<string>();

			v = AddStrings(v, s, temp, 0);

			//print
			//PrintSolution(v);
		}

		public static List<List<string>> AddStrings(List<List<string>> v, string s, List<string> temp, int index)
		{
			return v;
		}
	}
}
