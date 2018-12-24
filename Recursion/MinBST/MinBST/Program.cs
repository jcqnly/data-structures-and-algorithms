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
			//kick start the recursive method
			Node root = NewBST(arr, 0, arr.Length-1);
			//to show that the tree was correctly made
			InOrder(root);
		}

		public static Node NewBST(int[] arr, int start, int end)
		{
			//base case
			if (end < start) return null;

			int mid = (start + end) / 2;
			//every time the mid is found, make a new node
			Node node = new Node(arr[mid]);
			//then recursively find the mid of the left half
			node.Left = NewBST(arr, start, mid - 1);
			//and the mid of the right half
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
