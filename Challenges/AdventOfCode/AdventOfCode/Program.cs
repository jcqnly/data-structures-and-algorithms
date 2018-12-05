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
			//Console.WriteLine($"Frequency is {FrequencyDay1()}.");
			CheckSumDay2();
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
					//add those numbers to find the frequency
					frequency += num;
				}
			}
			return frequency;
		}

		public static int CheckSumDay2()
		{
			string path = "../../../boxID.txt";
			int checkSum = 1;

			List<string> idList = new List<string>();

			using (StreamReader sr = File.OpenText(path))
			{
				string s = "";
				while ((s = sr.ReadLine()) != null)
				{
					string ids = s;
					idList.Add(s);
				}
			}
			var holder = new Dictionary<char, int>();
			//store IDs that have a letter that appears 2 times
			var numsThatShowTwice = new Dictionary<string, int>();

			//store IDs that have a letter that appears 3 times
			var numsThatShowThrice = new Dictionary<string, int>();

			//search for IDs that have a letter that appears at most 2 times
			AddOrUpdate(idList, holder);
			//search for IDs that have a letter that appears at most 3 times

			return checkSum;
		}

		public static Dictionary<char, int> AddOrUpdate(List<string> idList, Dictionary<char, int> holder)
		{
			//store the IDs that have multiple instances
			//go through every char of the string and add it to the dictionary
			//along with how many times that char appeared so far
			for (int i = 0; i < 2; i++)
			{
				Console.WriteLine($"ID is {idList[i]}");
				for (int j = 0; j < idList[i].Length; j++)
				{
					if (!holder.ContainsKey(idList[i][j]))
					{
						//add 1 because this is the first instance of that letter
						holder.Add(idList[i][j], 1);
					}
					else 
					{
						//update the count of that letter
						holder[idList[i][j]]++;
					}

					//after we're done checking the last letter,
					//go back through the dictionary and check for conditions
					if (j == idList[i].Length - 1)
					{
						foreach (KeyValuePair<char, int> entry in holder)
						{
							if (entry.Value == 2 || entry.Value == 3)
							{
								Console.WriteLine($"{entry.Key} showed up {entry.Value} times.");

							}
						}
					}
				}				
			}

			
			return holder;
		}
	}
}
