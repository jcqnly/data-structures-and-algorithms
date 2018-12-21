using System;

namespace PascalsTriangle
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Pascal's Triangle");
			int n = 8;
			PrintPascals(n);
		}

		public static void PrintPascals(int n)
		{
			int[,] grid = new int[n, n];

			for (int row = 0; row < n; row++)
			{
				for (int col = 0; col < row; col++)
				{
					if (col == 0 || row == col)
					{
						grid[row, col] = 1;
					}
					else
					{
						grid[row, col] = grid[row - 1, col] + grid[row - 1, col - 1];
					}
					Console.Write($"{grid[row, col]}  ");
				}

				Console.WriteLine();
			}
		}
	}
}
