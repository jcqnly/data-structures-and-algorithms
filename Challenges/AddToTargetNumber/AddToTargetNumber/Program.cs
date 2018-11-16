using System;
using System.Collections.Generic;

namespace AddToTargetNumber
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Find two numbers that add to a target number and the array is:");
			int targetNum = 6;
			int[] arr = { 0, 3, -1, -2, 5, 7 };
			foreach (int x in arr) Console.Write($"{x}  ");

			Console.WriteLine($"Target number is {targetNum}.");
			Console.WriteLine($"O(N^2) Solution returns ");
			var numsList = FindTwoNums(arr, targetNum);
			foreach (int i in numsList) Console.WriteLine(i);

			//Console.WriteLine($"Target number is {targetNum}.");
			//Console.WriteLine($"O(N) Solution returns {FindTwoNumsFaster(arr, targetNum)}");
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
				for (int j = 0; j < arr.Length; j++)
				{
					//this if statement is needed to make sure arr[i] and arr[j]
					//doesn't start at the same index because we dont want the 
					//index content to be added to itself
					if (i == j) continue;
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
	}
}
