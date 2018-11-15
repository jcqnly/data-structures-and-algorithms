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
