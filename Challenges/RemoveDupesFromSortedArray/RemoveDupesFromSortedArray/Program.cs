using System;

namespace RemoveDupesFromSortedArray
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Remove dupes from sorted array.");

			int[] array = new int[] { 1, 1, 1, 2, 2, 3 };
			RemoveDupes(array);
		}

		public static void RemoveDupes(int[] arr)
		{
			foreach (int i in arr)
			{
				Console.WriteLine(i);
			}


		}
	}
}
