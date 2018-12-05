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

			//call method to figure Day1
			Console.WriteLine($"Frequency is {FrequencyDay1()}.");
		}

		/// <summary>
		/// Takes in the list of nums and adds the values to a sum
		/// </summary>
		/// <param name="numList"></param>
		/// <returns>integer that represents the frequency</returns>
		public static int FrequencyDay1()
		{
			string path = "../../../numbers.txt";

			int frequency = 0;
			using (StreamReader sr = File.OpenText(path))
			{
				string s = "";
				while ((s = sr.ReadLine()) != null)
				{
					//read each line as an int
					int num = Int32.Parse(s);
					frequency += num;
				}
			}
			return frequency;
		}

		public static int CheckSumDay2()
		{
			int checkSum = 1;
			var d = new Dictionary<string, int>();

			return checkSum;
		}
	}
}
