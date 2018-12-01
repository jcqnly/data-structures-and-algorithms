using MaxPathSum.Classes;
using System;
using System.Collections.Generic;

namespace MaxPathSum
{
	public class Program
	{
		public static int Max = Int32.MinValue;

		public static void Main(string[] args)
		{
			Console.WriteLine("Find max path sum");

			//make BT
			//Since placement of nodes don't matter in BT, as long as there are no more than 
			//2 nodes per parent node, the BT created here will only use Node class

			Node nodeA = new Node(1);
			Node nodeB = new Node(5);
			Node nodeC = new Node(9);
			Node nodeD = new Node(4);
			Node nodeE = new Node(10);
			Node nodeF = new Node(2);
			Node nodeG = new Node(5);
			Node nodeH = new Node(4);
			Node nodeI = new Node(1);

			nodeA.Left = nodeB;
			nodeA.Right = nodeD;
			nodeB.Right = nodeC;
			nodeD.Left = nodeE;
			nodeD.Right = nodeF;
			nodeF.Left = nodeG;
			nodeG.Right = nodeH;
			nodeH.Left = nodeI;

			int maxSum = DFS(nodeA);
			Console.WriteLine(maxSum);
		}

		public static int DFS(Node node)
		{
			//at a leaf, return 0
			if (node == null) return 0;
			
			//go all the way left
			int left = DFS(node.Left);

			//go all the way right
			int right = DFS(node.Right);

			int currentMax = 0;

			currentMax = Math.Max(currentMax, Math.Max(left + node.Value, right + node.Value));
			Max = Math.Max(Max, left + node.Value + right);

			return currentMax;
		}
	}
}
