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
			Console.WriteLine(RemoveDupes(array1));

			Console.WriteLine("----");

			int[] array2 = new int[] { 1, 2, 2, 2, 2, 3, 4, 4 };
			Console.WriteLine(RemoveDupes(array2));
		}

		public static int RemoveDupes(int[] arr)
		{
			var numsList = new List<int>(arr);

			int counter = 1;

			for (int i = 0; i < numsList.Count; i++)
			{
				if (i != numsList.Count - 1)
				{
					if (numsList[i] == numsList[i + 1])
					{
						counter++;
						if (counter > 2)
						{
							numsList.Remove(numsList[i]);
							counter = 1;
						}
					}
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
