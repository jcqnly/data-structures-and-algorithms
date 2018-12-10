using System;

namespace MaxIntInArray
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Find the max int in an array using recursion.");
			int[] arr = new int[10];
			Random num = new Random();
			for (int i = 0; i < 10; i++)
			{
				arr[i] = num.Next(1, 100);
				Console.WriteLine(arr[i]);
			}

			int max  = Recursive(arr, 0);
			Console.WriteLine($"Max int is: {max}");
		}

		/// <summary>
		/// Recursive method to compare the max values through the call stack
		/// </summary>
		/// <param name="arr"></param>
		/// <param name="position"></param>
		/// <returns></returns>
		public static int Recursive(int[] arr, int position)
		{
			if (arr.Length - 1 == position)
			{
				return arr[position];
			}
			return Math.Max(arr[position], Recursive(arr, position + 1));
		}
	}
}
