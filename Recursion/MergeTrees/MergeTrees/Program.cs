using MergeTrees.Classes;
using System;

namespace MergeTrees
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Merge 2 trees");

			//make the 2 trees that are represented in the README
			//tree1
			Node node1 = new Node(11);
			Node node2 = new Node(3);
			Node node3 = new Node(2);
			Node node4 = new Node(5);

			node1.Left = node2;
			node1.Right = node3;
			node2.Left = node4;

			//tree2
			Node node5 = new Node(2);
			Node node6 = new Node(1);
			Node node7 = new Node(6);
			Node node8 = new Node(9);
			Node node9 = new Node(7);

			node5.Left = node6;
			node5.Right = node7;
			node6.Right = node8;
			node7.Right = node9;

			Node newTreeNode = Merge(node1, node5);
			InOrder(newTreeNode);
		}

		/// <summary>
		/// Adds the value of node2 to the value of node1, if
		/// that value exists
		/// </summary>
		/// <param name="node1">root node of tree1</param>
		/// <param name="node2">root node of tree2</param>
		/// <returns>node of the subtree</returns>
		public static Node Merge(Node node1, Node node2)
		{
			//base cases for when either node is null
			if (node1 == null) return node2;
			if (node2 == null) return node1;

			//use node1 as the base and add node2's value to it
			node1.Value += node2.Value;

			//go left
			node1.Left = Merge(node1.Left, node2.Left);
			//go right
			node1.Right = Merge(node1.Right, node2.Right);

			return node1;
		}

		/// <summary>
		/// InOrder Traversal to show that the nodes have been merged
		/// </summary>
		/// <param name="node"></param>
		public static void InOrder(Node node)
		{
			if (node.Left != null) InOrder(node.Left);
			Console.WriteLine(node.Value);
			if (node.Right != null) InOrder(node.Right);
		}

		//try iterative method
	}
}
