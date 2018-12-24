using MinBST.Classes;
using System;

namespace MinBST
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Create a BST with the least amount of layers from a sorted array.");
			int[] arr = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8};
			NewBST(arr, 0, arr.Length - 1);
		}

		public static Node NewBST(int[] arr, int start, int end)
		{
			while (start < end)
			{
				int mid = (start + end) / 2;
				Node root = new Node(arr[mid]);

				root.Left = NewBST(arr, 0, mid - 1);
				root.Right = NewBST(arr, mid + 1, end);
			}
		}
	}
}
