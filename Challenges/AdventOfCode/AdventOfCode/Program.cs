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
			//list to store numbers that will be read in using StreamReader
			List<int> numList = new List<int>();
			string path = "../../../numbers.txt";

			using (StreamReader sr = File.OpenText(path))
			{
				string s = "";
				while ((s = sr.ReadLine()) != null)
				{
					//read each line as an int
					int num = Int32.Parse(s);
					numList.Add(num);
				}
			}
			int sum = 0;
			for (int i = 0; i < numList.Count; i++)
			{
				sum += numList[i];
			}
			return sum;
		}

		public static int CheckSumDay2()
		{
			int checkSum = 1;

			return checkSum;
		}
	}
}
