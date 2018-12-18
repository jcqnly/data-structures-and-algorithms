using System;
using ValidateBST.Classes;

namespace ValidateBST
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Validate a BST");

			BST bst = new BST();

			Node nodeA = new Node(10);
			Node nodeB = new Node(5);
			Node nodeC = new Node(15);
			Node nodeD = new Node(2);
			Node nodeE = new Node(7);
			Node nodeF = new Node(30);

			bst.Add(nodeA, nodeB);
			bst.Add(nodeA, nodeC);
			bst.Add(nodeA, nodeD);
			bst.Add(nodeA, nodeE);
			bst.Add(nodeA, nodeF);

			InOrder(nodeA);
		}

		public static void InOrder(Node node)
		{
			if (node.Left != null) InOrder(node.Left);
			Console.WriteLine($"{node.Value}");
			if (node.Right != null) InOrder(node.Right);
		}

		public bool Validate(Node node)
		{			

			return true;
		}
	}
}
