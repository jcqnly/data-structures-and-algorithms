using System;
using System.Collections.Generic;

namespace SearchBST
{
	public class Program
	{
		public static List<int> foundTree = new List<int>();

		public static void Main(string[] args)
		{
			Console.WriteLine("Search a BST");
			Node nodeA = new Node(4);
			Node nodeB = new Node(2);
			Node nodeC = new Node(7);
			Node nodeD = new Node(1);
			Node nodeE = new Node(3);
			Node nodeF = new Node(5);

			nodeA.Left = nodeB;
			nodeA.Right = nodeC;
			nodeB.Left = nodeD;
			nodeB.Right = nodeE;
			nodeE.Right = nodeF;

			int valueToSearch = 2;
			Node foundNode = SearchForValue(nodeA, valueToSearch);
			AddRestOfSubtree(foundNode);

			//print the values from the list
			foreach (int i in foundTree)
			{
				Console.WriteLine(i);
			}
		}

		public static Node SearchForValue(Node root, int valueToSearch)
		{
			//base case for recursive call
			if (root == null || root.Value == valueToSearch) return root;

			//if the value is greater than the current root's value, go right
			if (root.Value < valueToSearch) return SearchForValue(root.Right, valueToSearch);
			else return SearchForValue(root.Left, valueToSearch);		
		}

		public static void AddRestOfSubtree(Node root)
		{
			if (root == null) return;

			//add value to the list
			foundTree.Add(root.Value);
			AddRestOfSubtree(root.Left);
			AddRestOfSubtree(root.Right);
		}
	}
}
