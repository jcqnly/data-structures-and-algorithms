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
			SearchForValue(nodeA, valueToSearch);

			foreach (int i in foundTree)
			{
				Console.WriteLine(i);
			}
		}

		public static void SearchForValue(Node root, int valueToSearch)
		{
			//base case for recursive call
			if (root == null) return;

			//if the value is found
			if (root.Value == valueToSearch)
			{				
				//call helper to traverse that subtree
				AddRestOfSubtree(root);
			}
			//keep traversing the tree if the value is not found
			SearchForValue(root.Left, valueToSearch);
			SearchForValue(root.Right, valueToSearch);
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
