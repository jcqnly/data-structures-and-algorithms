using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace AdventOfCode
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Advent of Code");

			//call method to figure Day1
			//Console.WriteLine($"Frequency is {FrequencyDay1()}.");

			//call method to figure Day2, part 1
			Console.WriteLine($"Checksum is {CheckSumDay2()}");

			//call method to figure Day2, part 2 is in CheckSumDay2 method
			
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

		/// <summary>
		/// Calls the AddorUpdate method to figure out the core of Day2's challenge
		/// </summary>
		/// <returns>checksum is the # IDs with chars that show 2x times the # of IDs with chars that show 3x</returns>
		public static int CheckSumDay2()
		{
			string path = "../../../boxID.txt";

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

			return AddOrUpdate(idList, holder);
		}

		/// <summary>
		/// Iterates through every entry in idList and  determines if each entry
		/// has chars that show up 2x, 3x or have chars that show up 2x and 3x
		/// </summary>
		/// <param name="idList">list with initial IDs</param>
		/// <param name="holder">temp dictionary to store calcutalion for every entry</param>
		/// <returns>the checksum</returns>
		public static int AddOrUpdate(List<string> idList, Dictionary<char, int> holder)
		{
			//store IDs that have a letter that appears 2 times
			var idWithLettersThatShowTwice = new List<string>();

			//store IDs that have a letter that appears 3 times
			var idWithLettersThatShowThrice = new List<string>();

			//Dictionary of dictionaries
			var ListOfAllDictionaries = new List<Dictionary<char, int>>();

			//loop through every ID
			for (int i = 0; i < idList.Count; i++)
			{
				//go through every char of the ID and add it to the dictionary
				//along with how many times that char appeared so far
				//Console.WriteLine($"ID is {idList[i]}");
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

					//after checking the last letter,
					//go back through the dictionary and check for conditions
					if (j == idList[i].Length - 1)
					{
						foreach (KeyValuePair<char, int> entry in holder)
						{
							//if that entry has letters that show twice and thrice, add that entry to both lists
							if (holder.ContainsValue(2) && holder.ContainsValue(3))
							{
								idWithLettersThatShowTwice.Add(idList[i]);
								idWithLettersThatShowThrice.Add(idList[i]);
								break;
							}
							else if (holder.ContainsValue(2) && !holder.ContainsValue(3))
							{
								//add entry to the list where the chars only show 2x but not 3x
								idWithLettersThatShowTwice.Add(idList[i]);
								break;
							}
							else
							{
								//add entry to the list where the chars only show 3x but not 2x
								idWithLettersThatShowThrice.Add(idList[i]);
								break;
							}
						}
					}
				}
				ListOfAllDictionaries.Add(holder);
				holder.Clear(); //clear the temp dictionary for the next ID in idList
			}

			//for Day 2, part 2 challenge
			FindMatchingChars(ListOfAllDictionaries);
			return idWithLettersThatShowTwice.Count * idWithLettersThatShowThrice.Count;
		}

		public static string FindMatchingChars(List<Dictionary<char, int>> list)
		{
			StringBuilder sb = new StringBuilder();
			var IdDictionary = new Dictionary<char, int>();
			foreach (var element in list)
			{
				Console.WriteLine($"{element.Keys}");
			}
			//for (int i = 0; i < list.Count; i++)
			//{
			//	Console.WriteLine(KeyValuePair<char, int> list[i].Keys);
			//	//for (int j = i++; j < list.Count; j++)
			//	//{
					
			//	//}
			//}
			return sb.ToString();
		}
	}
}
