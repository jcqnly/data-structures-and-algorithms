using System;
using System.Collections.Generic;

namespace AddToTargetNumber
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Find two numbers that add to a target number.");
			int targetNum = 700;
			int[] arr = { 1, 9, -2, 5, 6 };
			//Console.WriteLine($"Target number is {targetNum}.");
			//Console.WriteLine($"O(N^2) Solution returns {FindTwoNums(arr, targetNum)}");

			Console.WriteLine($"Target number is {targetNum}.");
			Console.WriteLine($"O(N) Solution returns {FindTwoNumsFaster(arr, targetNum)}");
		}

		/// <summary>
		/// O(N)^2 time complexity, but O(1) Space
		/// </summary>
		/// <param name="arr">array to look through</param>
		/// <param name="targetNum">the number that the 2 numbers in the array add to</param>
		/// <returns></returns>
		public static bool FindTwoNums(int[] arr, int targetNum)
		{
			if (arr.Length < 2) return false;

			for (int i = 0; i < arr.Length - 1; i++)
			{
				for (int j = 0; j < arr.Length - 1; j++)
				{
					if (i == j) continue;
					if (arr[i] + arr[j] == targetNum) return true;
				}
			}
			return false;
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
