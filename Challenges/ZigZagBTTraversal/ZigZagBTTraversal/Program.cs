using System;
using System.Collections.Generic;
using ZigZagBTTraversal.Classes;

namespace ZigZagBTTraversal
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Zig zag traversal of a binary tree");

			//create a BT
			Node nodeA = new Node(1);
			Node nodeB = new Node(9);
			Node nodeC = new Node(5);
			Node nodeD = new Node(2);
			Node nodeE = new Node(3);
			Node nodeF = new Node(6);
			Node nodeG = new Node(4);

			nodeA.Left = nodeB;
			nodeA.Right = nodeC;
			nodeB.Left = nodeD;
			nodeC.Left = nodeE;
			nodeC.Right = nodeF;
			nodeE.Left = nodeG;

			ZigZagBFS(nodeA);
		}

		public static void ZigZagBFS(Node node)
		{
			Queue<Node> Q = new Queue<Node>();
			Queue<Node> currentLevel = new Queue<Node>();
			Queue<Node> nextLevel = new Queue<Node>();
 			Q.Enqueue(node);

			Console.WriteLine(node.Value);

			while (Q.TryPeek(out node))
			{
				Node front = Q.Dequeue();
				currentLevel.Enqueue(front);
				if (front.Left != null)
				{
					Console.Write($"{front.Left.Value}  ");
					Q.Enqueue(front.Left);
					nextLevel.Enqueue(front.Left);
				}

				if (front.Right != null)
				{
					Console.WriteLine($" {front.Right.Value}");
					Q.Enqueue(front.Right);
					nextLevel.Enqueue(front.Right);
				}
			}
		}
	}
}
