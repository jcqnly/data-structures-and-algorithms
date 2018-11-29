using System;

namespace SortStringArray
{
	public class Program
	{		
		public static void Main(string[] args)
		{
			Console.WriteLine("Sort a String Array with a BST");
			string[] arr = new string[] { "H", "t", "M", "o", "A", "g", "c", "z", "D", "I" };
			int value = 0;
			for (int i = 0; i < arr.Length; i++)
			{
				for (int j = 0; j < arr[i].Length; j++)
				{
					value = (int)arr[i][j];	
					//Console.WriteLine(arr[i][j]);
					//Console.WriteLine(value);

				}
			}
		}

	}
}
