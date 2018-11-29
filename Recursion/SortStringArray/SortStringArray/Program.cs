using SortStringArray.Classes;
using System;

namespace SortStringArray
{
	public class Program
	{		
		public static void Main(string[] args)
		{
			Console.WriteLine("Sort a String Array with a BST");
			BST bst = new BST();
			string[] arr = new string[] { "h", "t", "m", "o", "a", "g", "c", "z", "d", "i" };
			int value = 0;

			//find the value of the first letter and add this as the first node in the BST
			value = arr[0][0];
			Node firstNode = null;
			Node firstNodeOfArray = new Node(arr[0], value);
			bst.Add(firstNode, firstNodeOfArray);

			//add the rest
			for (int i = 1; i < arr.Length; i++)
			{
				//add the values of each char at each index
				for (int j = 0; j < arr[i].Length; j++)
				{
					value = arr[i][j];
				}
				//Add that string to the BST based on its ASCII total
				//Node node = new Node(arr[i], value);
				//insert method
				bst.Add(firstNodeOfArray, new Node(arr[i], value));
			}
			InOrder(firstNodeOfArray);
		}

		public static void InOrder(Node node)
		{
			if (node.Left != null) InOrder(node.Left);
			Console.WriteLine(node.Letter);
			if (node.Right != null) InOrder(node.Right);
		}
	}
}
