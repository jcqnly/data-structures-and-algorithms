using System;

namespace RotateAMatrix
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Rotate a Matrix");
			int[,] grid = {{1, 1, 1, 1, 5}, 
							{2, 2, 2, 2, 2}, 
							{3, 3, 3, 3, 3 },
							{4, 4, 4, 4, 4} };

			int N = 4;
			int M = 5;

			for (int rows = 0; rows < M; rows++)
			{
				for (int col = N-1; col >= 0; col--)
				{
					Console.Write("{0}\t", grid[col, rows]);
				}
				Console.WriteLine();
			}
		}
	}
}
