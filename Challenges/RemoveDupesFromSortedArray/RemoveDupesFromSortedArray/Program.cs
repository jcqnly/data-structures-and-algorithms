using System;
using System.Collections.Generic;

namespace RemoveDupesFromSortedArray
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Remove dupes from sorted array.");
			//lots of dupes at the beginning
			int[] array1 = new int[] { 1, 1, 1, 2, 2, 3 };
			foreach (int i in array1) Console.WriteLine(i);
			Console.WriteLine("----");
			//Console.WriteLine($"Total number of numbers is {RemoveDupesEasy(array1)}");
			//Console.WriteLine($"Total number of numbers is {RemoveDupesMedium(array1)}");
			Console.WriteLine($"Total number of numbers is {RemoveDupesMediumLeetSolution(array1)}");

			Console.WriteLine("----");
			//lots of dupes in the middle
			int[] array2 = new int[] { 1, 2, 2, 2, 2, 3, 4, 4 };
			foreach (int i in array2) Console.WriteLine(i);
			Console.WriteLine("----");
			//Console.WriteLine($"Total number of numbers is {RemoveDupesEasy(array2)}");
			//Console.WriteLine($"Total number of numbers is {RemoveDupesMedium(array2)}");
			Console.WriteLine($"Total number of numbers is {RemoveDupesMediumLeetSolution(array2)}");

			Console.WriteLine("----");
			//lots of dupes at the end
			int[] array3 = new int[] { 1, 2, 3, 4, 4, 4, 4 };
			foreach (int i in array3) Console.WriteLine(i);
			Console.WriteLine("----");
			//Console.WriteLine($"Total number of numbers is {RemoveDupesEasy(array3)}");
			//Console.WriteLine($"Total number of numbers is {RemoveDupesMedium(array3)}");
			Console.WriteLine($"Total number of numbers is {RemoveDupesMediumLeetSolution(array3)}");
		}

		/// <summary>
		/// A leetcode solution
		/// </summary>
		/// <param name="arr"></param>
		/// <returns></returns>
		public static int RemoveDupesEasy(int[] arr)
		{
			if (arr.Length == 0) return 0;
			int i = 0;
			for (int j = 1; j < arr.Length; j++)
			{
				if (arr[j] != arr[i])
				{
					i++;
					arr[i] = arr[j];
				}
			}
			return i+1;
		}

		/// <summary>
		/// My solution
		/// </summary>
		/// <param name="arr">initial array</param>
		/// <returns></returns>
		public static int RemoveDupesMedium(int[] arr)
		{
			//change the array to a list, so it can be modified
			var numsList = new List<int>(arr);
			int counter = 1;

			for (int i = 1; i < numsList.Count; i++)
			{
				if (numsList[i] == numsList[i - 1])
				{
					counter++;
					if (counter > 2)
					{
						numsList.Remove(numsList[i]);
						counter--;
						i--;
					}
				}
				else
				{
					counter = 1;
				}
			}

			//for show
			foreach (var i in numsList)
			{
				Console.WriteLine(i);
			}

			return numsList.Count;
		}

		public static int RemoveDupesMediumLeetSolution(int[] arr)
		{
			int MaxDupsAllowed = 2;
			if (null == arr) return 0;
			if (arr.Length < MaxDupsAllowed) return arr.Length;

			int nextResultIndex = 1;
			int duplicateCount = 1;
			for (int i = 1; i < arr.Length; i++)
			{
				if (arr[i] == arr[i - 1]) // If duplicate
				{
					if (duplicateCount != MaxDupsAllowed)    //Check for max allowed duplicates limit.
					{
						arr[nextResultIndex++] = arr[i];  //Add the duplicate value in the result.
						duplicateCount++;                   //Increment the duplicate count.
					}
					continue;
				}
				arr[nextResultIndex++] = arr[i];  //If not duplicate, copy the current new value
				duplicateCount = 1;    //Reset the duplicateCount to 1 (since we have added 1 occourance of the new value)
			}

			foreach (int num in arr)
			{
				Console.WriteLine(num);
			}
			return nextResultIndex;
		}
	}
}
