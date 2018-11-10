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
			foreach (int i in array1)
			{
				Console.WriteLine(i);
			}
			Console.WriteLine("----");
			Console.WriteLine($"Total number of numbers is {RemoveDupesEasy(array1)}");
			//Console.WriteLine($"Total number of numbers is {RemoveDupesMedium(array1)}");

			Console.WriteLine("----");
			//lots of dupes in the middle
			int[] array2 = new int[] { 1, 2, 2, 2, 2, 3, 4, 4 };
			foreach (int i in array2)
			{
				Console.WriteLine(i);
			}
			Console.WriteLine("----");
			Console.WriteLine($"Total number of numbers is {RemoveDupesEasy(array2)}");
			//Console.WriteLine($"Total number of numbers is {RemoveDupesMedium(array2)}");

			Console.WriteLine("----");
			//lots of dupes at the end
			int[] array3 = new int[] { 1, 2, 3, 4, 4, 4, 4 };
			foreach (int i in array3)
			{
				Console.WriteLine(i);
			}
			Console.WriteLine("----");
			Console.WriteLine($"Total number of numbers is {RemoveDupesEasy(array3)}");
			//Console.WriteLine($"Total number of numbers is {RemoveDupesMedium(array3)}");
		}

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

		public static int RemoveDupesMedium(int[] arr)
		{
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

			foreach (var i in numsList)
			{
				Console.WriteLine(i);
			}
			return numsList.Count;
		}

	}
}
