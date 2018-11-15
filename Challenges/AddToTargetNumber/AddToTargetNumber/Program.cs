using System;

namespace AddToTargetNumber
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Find two numbers that add to a target number.");
			int targetNum = 7;
			int[] arr = { 1, 9, -2, 5, 6 };
			Console.WriteLine($"Target number is {targetNum}.");

			Console.WriteLine(FindTwoNums(arr, targetNum));
		}

		public static bool FindTwoNums(int[] arr, int targetNum)
		{
			if (arr.Length < 2) return false;

			for (int i = 0; i < arr.Length - 1; i++)
			{
				for (int j = 0; j < arr.Length - 1; j++)
				{
					if (i == j) continue;

					if (arr[i] + arr[j] == targetNum)
					{
						return true;
					}
				}
			}

			return false;
		}
	}
}
