using System;
using System.Collections.Generic;
using System.IO;

namespace AdventOfCode
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Advent of Code");

			List<int> numList = new List<int>();
			string path = "../../../numbers.txt";

			using (StreamReader sr = File.OpenText(path))
			{
				string s = "";
				while ((s = sr.ReadLine()) != null)
				{
					int num = Int32.Parse(s);
					numList.Add(num);
					Console.WriteLine(num);
				}
			}

		}

		public static int FrequencyDay1()
		{

		}
	}
}
