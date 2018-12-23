using CheckIfBalance.Classes;
using System;

namespace CheckIfBalance
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");

			//create tree
			Node nodeA = new Node(1);
			Node nodeB = new Node(2);
			Node nodeC = new Node(3);
			Node nodeD = new Node(4);
			Node nodeE = new Node(5);

			nodeA.Left = nodeB;
			nodeA.Right = nodeC;
			nodeC.Left = nodeD;
			nodeD.Right = nodeE;


			Console.WriteLine(CheckBalance(nodeA));
		}

		public static bool CheckBalance(Node node)
		{
			return Max(node) - Min(node) <= 1;
		}

		public static int Min(Node node)
		{
			if (node == null) return 0;
			return 1 + Math.Min(Min(node.Left), Min(node.Right));
		}

		public static int Max(Node node)
		{
			if (node == null) return 0; 
			return 1 + Math.Max(Max(node.Left), Max(node.Right));
		}
	}
}
