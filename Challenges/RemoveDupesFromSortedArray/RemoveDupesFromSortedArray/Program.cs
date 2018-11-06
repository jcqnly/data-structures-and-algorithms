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
			Console.WriteLine($"Total number of numbers is {RemoveDupes(array1)}");

			Console.WriteLine("----");
			//lots of dupes in the middle
			int[] array2 = new int[] { 1, 2, 2, 2, 2, 3, 4, 4 };
			Console.WriteLine($"Total number of numbers is {RemoveDupes(array2)}");

			Console.WriteLine("----");
			//lots of dupes at the end
			int[] array3 = new int[] { 1, 2, 3, 4, 4, 4, 4 };
			Console.WriteLine($"Total number of numbers is {RemoveDupes(array3)}");
		}

		public static int RemoveDupes(int[] arr)
		{
			var numsList = new List<int>(arr);
			int counter = 1;

			for (int i = 0; i < numsList.Count; i++)
			{
				//make sure we're not at the end to prevent index out of range
				if (i != numsList.Count - 1)
				{
					//check if the next num is a dupe
					if (numsList[i] == numsList[i + 1])
					{
						//if it is, increment the counter
						counter++;
						//if there are more than 2 dupes, remove them
						if (counter >= 2)
						{
							//if the number has multiple dupes, the first part
							//of this if statement checks if we are at the one of the dupes
							if ((i != 0) && (numsList[i] == numsList[i - 1]))
							{
								//reset the counter
								counter = 1;
							}
							numsList.Remove(numsList[i]);
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
