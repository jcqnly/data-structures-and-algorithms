using MinBST.Classes;
using System;
using System.Collections.Generic;

namespace MinBST
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Create a BST with the least amount of layers from a sorted array.");
			int[] arr = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8};
			Node root = NewBST(arr, 0, arr.Length-1);
			InOrder(root);
		}

		public static Node NewBST(int[] arr, int start, int end)
		{
			if (end < start) return null;

			int mid = (start + end) / 2;
			Node node = new Node(arr[mid]);
			node.Left = NewBST(arr, start, mid - 1);
			node.Right = NewBST(arr, mid + 1, end);

			return node;
		}

		public static void InOrder(Node node)
		{
			if (node == null) return;
			InOrder(node.Left);
			Console.WriteLine(node.Value);
			InOrder(node.Right);
		}
	}
}
