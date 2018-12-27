using System;
using System.Collections.Generic;
using ValidateBST.Classes;

namespace ValidateBST
{
	public class Program
	{
		public static Node prev = null;
		public static void Main(string[] args)
		{
			Console.WriteLine("Validate a BST");
			//creating the tree from the README
			Node nodeA = new Node(4);
			Node nodeB = new Node(1);
			Node nodeC = new Node(6);

			Node nodeD = new Node(0);
			Node nodeE = new Node(12);

			Node nodeF = new Node(5);
			Node nodeG = new Node(7);
			//additional node on an additional level to show
			//that the iterative method can go deeper
			//Node nodeH = new Node(1);

			nodeA.Left = nodeB;
			nodeA.Right = nodeC;

			nodeB.Left = nodeD;
			nodeB.Right = nodeE;

			nodeC.Left = nodeF;
			nodeC.Right = nodeG;

			//nodeG.Right = nodeH;

			Console.WriteLine(CheckValidityRecursive(nodeA));
			Console.WriteLine(CheckValidityIterative(nodeA));
			
		}

		/// <summary>
		/// DFS InOrder Recursive Solution
		/// </summary>
		/// <param name="node">node to check along with the left and right</param>
		/// <returns>bool value if the tree is balanced or not</returns>
		public static bool CheckValidityRecursive(Node node)
		{
			if (node == null) return true;
			if (CheckValidityRecursive(node.Left) == false) return false;

			if ((prev != null) && (prev.Value >= node.Value)) return false;
			prev = node;

			if (CheckValidityRecursive(node.Right) == false) return false;

			return true;
		}

		/// <summary>
		/// 2 Ways to write the iterative solution
		/// Uses a stack to hold the nodes
		/// </summary>
		/// <param name="node">node to start with</param>
		/// <returns>bool if this tree is a BST or not</returns>
		public static bool CheckValidityIterative(Node node)
		{
			//Stack<Node> stack = new Stack<Node>();
			//Node prev = null;
			//while (prev != null || stack.Count == 0)
			//{
			//	while (node != null)
			//	{
			//		stack.Push(node);
			//		node = node.Left;
			//	}
			//	if (stack.Count > 0)
			//	{
			//		node = stack.Pop();
			//		if (prev != null && node.Value <= prev.Value) return false;
			//		prev = node;
			//		node = node.Right;
			//	}
			//}
			//return true;
			if (node == null) return true;
			Stack<Node> stack = new Stack<Node>();
			Node prev = null;
			bool done = false;

			while (!done)
			{
				if (node != null)
				{
					stack.Push(node);
					node = node.Left;
				}
				else if (stack.Count > 0)
				{
					node = stack.Pop();
					if (prev != null && node.Value <= prev.Value) return false;
					prev = node;
					node = node.Right;
				}
				else
				{
					done = true;
				}
			}
			return true;
		}
	}
}
