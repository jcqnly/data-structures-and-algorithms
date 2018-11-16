using System;
using System.Collections.Generic;

namespace AddToTargetNumber
{
	public class Program
	{
		public static void Main(string[] args)
		{
			//*Find 2 numbers that add to a target number.*
			//Console.WriteLine("Find two numbers that add to a target number.  Return those 2" +
			//	"numbers.  The array is:");
			//int targetNum = 6;
			//int[] arr = { 0, 1, -1, -2, 9, 3 };
			//foreach (int x in arr) Console.Write($"{x}  ");

			//Console.WriteLine($"Target number is {targetNum}.");
			//Console.WriteLine($"O(N^2) Solution returns ");
			//var numsList = FindTwoNums(arr, targetNum);
			////if conditional is needed to check if the return value is null, so the proper msg
			////or list of values can be displayed
			//if (numsList == null)
			//{
			//	Console.WriteLine("No integers were found that added to the target.");
			//}
			//else
			//{
			//	foreach (int i in numsList) Console.WriteLine(i);
			//}

			////Console.WriteLine($"Target number is {targetNum}.");
			////Console.WriteLine($"O(N) Solution returns {FindTwoNumsFaster(arr, targetNum)}");


			//*Find 3 numbers that add to a target number*
			Console.WriteLine("Find 3 numbers that add to a target number. Return those 3 numbers. " +
				"The array is: ");
			int targetNum = 6;
			int[] arr = { 0, 1, -1, -2, 9, 3 };
			foreach (int x in arr) Console.Write($"{x}  ");
			var numsList = FindThreeNums(arr, targetNum);
			if (numsList == null)
			{
				Console.WriteLine("No integers were found that added to the target.");
			}
			else
			{
				foreach (int i in numsList) Console.WriteLine(i);
			}
		}

		/// <summary>
		/// O(N)^2 time complexity, but O(1) Space
		/// </summary>
		/// <param name="arr">array to look through</param>
		/// <param name="targetNum">the number that the 2 numbers in the array add to</param>
		/// <returns></returns>
		public static List<int> FindTwoNums(int[] arr, int targetNum)
		{
			var numsList = new List<int>();

			if (arr.Length < 2) return null;

			for (int i = 0; i < arr.Length; i++)
			{
				//start at i + 1, so that i and j is not the same
				for (int j = i+1; j < arr.Length; j++)
				{
					if (arr[i] + arr[j] == targetNum)
					{
						numsList.Add(arr[i]);
						Console.WriteLine($"i is {i}");
						numsList.Add(arr[j]);
						Console.WriteLine($"j is {j}");
						return numsList;
					}
				}
			}
			return null;
		}

		/// <summary>
		/// O(N) solution in terms of time, and O(N) in terms of space
		/// .Contains still iterates through something.  Under the hood, it's another for loop
		/// </summary>
		/// <param name="arr"></param>
		/// <param name="targetNum"></param>
		/// <returns></returns>
		public static bool FindTwoNumsFaster(int[] arr, int targetNum)
		{
			var numsList = new List<int>();

			for (int i = 0; i < arr.Length; i++)
			{
				int num2 = targetNum - arr[i];
				if (numsList.Contains(num2)) return true;
				numsList.Add(arr[i]);
			}
			return false;
		}

		public static List<int> FindThreeNums(int[] arr, int targetNum)
		{
			var numsList = new List<int>();
			if (arr.Length < 3) return null;
			for (int i  = 0; i < arr.Length; i++)
			{
				for (int j = i + 1; j < arr.Length; j++)
				{
					for (int k = j + 1; k < arr.Length; k++)
					{
						//if ((i == j) && (j == k)) continue;
						if (arr[i] + arr[j] + arr[k] == targetNum)
						{
							numsList.Add(arr[i]);
							Console.WriteLine($"arr[i] is {arr[i]}");
							numsList.Add(arr[j]);
							Console.WriteLine($"arr[j] is {arr[j]}");
							numsList.Add(arr[k]);
							Console.WriteLine($"arr[k] is {arr[k]}");
							return numsList;
						}
					}
				}
			}
			return null;
		}
	}
}
