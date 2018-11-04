using System;
using System.Collections.Generic;

namespace RemoveDupesFromSortedArray
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Remove dupes from sorted array.");

			int[] array1 = new int[] { 1, 1, 1, 2, 2, 3 };
			Console.WriteLine($"Total number of numbers is {RemoveDupes(array1)}");

			Console.WriteLine("----");

			int[] array2 = new int[] { 1, 2, 2, 2, 2, 3, 4, 4 };
			Console.WriteLine($"Total number of numbers is {RemoveDupes(array2)}");

			Console.WriteLine("----");

			int[] array3 = new int[] { 1, 2, 3, 4, 4, 4, 4 };
			Console.WriteLine($"Total number of numbers is {RemoveDupes(array3)}");
		}

		public static int RemoveDupes(int[] arr)
		{
			var numsList = new List<int>(arr);

			//int counter = 0;

			//for (int i = 0; i < numsList.Count; i++)
			//{
			//	counter++;
			//	if (i != numsList.Count - 1)
			//	{
			//		if (numsList[i] == numsList[i+1] && counter > 2)
			//		{
			//			numsList.Remove(numsList[i]);
			//			counter = 0;
			//		}
			//	}
			//}

			foreach (var i in numsList)
			{
				Console.WriteLine(i);
			}

			return numsList.Count;
		}

	}
}
