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
			Node node1 = new Node(1);
			Node node2 = new Node(3);
			Node node3 = new Node(2);
			Node node4 = new Node(5);

			node1.Left = node2;
			node1.Right = node3;
			node2.Left = node4;

			Node node5 = new Node(2);
			Node node6 = new Node(1);
			Node node7 = new Node(3);
			Node node8 = new Node(4);
			Node node9 = new Node(7);

			node5.Left = node6;
			node5.Right = node7;
			node6.Right = node8;
			node7.Right = node9;

			Merge(node1, node5);
		}

		public static Node Merge(Node node1, Node node2)
		{

		}

	}
}
