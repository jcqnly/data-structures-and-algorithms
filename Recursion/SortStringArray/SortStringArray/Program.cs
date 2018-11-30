using SortStringArray.Classes;
using System;
using System.Collections.Generic;

namespace SortStringArray
{
	public class Program
	{
		public static List<string> list = new List<string>();

		public static void Main(string[] args)
		{
			Console.WriteLine("Sort a String Array with a BST");
			BST bst = new BST();
			string[] arr = new string[] { "h", "b", "j", "e", "a", "g", "c", "f", "d", "i" };

			//find the value of the first letter and add this as the first node in the BST
			int value = arr[0][0];

			//set a default root because the add method takes in 2 nodes
			Node firstNode = null;
			Node firstNodeOfArray = new Node(arr[0], value);
			bst.Add(firstNode, firstNodeOfArray);

			//find the rest of the values
			for (int i = 1; i < arr.Length; i++)
			{
				//add the values of each char at each index
				for (int j = 0; j < arr[i].Length; j++)
				{
					value = arr[i][j];
				}
				//Add that string to the BST based on its ASCII total
				bst.Add(firstNodeOfArray, new Node(arr[i], value));
			}
			InOrder(firstNodeOfArray);
			MinVal(firstNodeOfArray);
			MaxVal(firstNodeOfArray);

			//print the list in order
			//foreach (string s in list)
			//{
			//	Console.WriteLine(s);
			//}
		}

		/// <summary>
		/// InOrder traversal
		/// </summary>
		/// <param name="node"></param>
		public static void InOrder(Node node)
		{
			if (node.Left != null) InOrder(node.Left);
			//Add the letter to a list
			list.Add(node.Letter);
			if (node.Right != null) InOrder(node.Right);
		}

		/// <summary>
		/// Find the min value of a tree
		/// </summary>
		/// <param name="node"></param>
		public static void MinVal(Node node)
		{
			if (node.Left != null) MinVal(node.Left);
			if (node.Left == null)
			{
				Console.WriteLine($"The smallest value is {node.Value} and that letter is {node.Letter}");
				return;
			}
		}

		/// <summary>
		/// Find the max value of a tree
		/// </summary>
		/// <param name="node"></param>
		public static void MaxVal(Node node)
		{
			if (node.Right != null) MaxVal(node.Right);
			if (node.Right == null)
			{
				Console.WriteLine($"The largest value is {node.Value} and that letter is {node.Letter}.");
			}
		}
	}
}
