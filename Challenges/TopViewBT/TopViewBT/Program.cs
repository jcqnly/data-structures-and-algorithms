using System;
using System.Collections.Generic;
using TopViewBT.Classes;

namespace TopViewBT
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Print the top view of a BT");

			//make the tree
			Node node1 = new Node(1);
			Node node2 = new Node(2);
			Node node3 = new Node(3);
			Node node4 = new Node(4);
			Node node5 = new Node(5);
			Node node6 = new Node(6);

			node1.Left = node2;
			node1.Right = node3;

			node2.Right = node4;

			node4.Right = node5;
			node5.Right = node6;

			TopView(node1, 0);
		}

		public static void TopView(Node root, int level)
		{
			if (root == null) return;
			//each QueuePack will hold the distance from the root and the root
			Queue<QueuePack> q = new Queue<QueuePack>();

			//the dictionary will hold only unique values
			Dictionary<int, Node> topView = new Dictionary<int, Node>();

			if (root == null) return;
			else q.Enqueue(new QueuePack(0, root));

			while (q.Count > 0)
			{
				QueuePack temp = q.Dequeue();
				Node tnode = temp.Root;
				int lvl = temp.Level;

				if (!topView.ContainsKey(lvl))
				{
					Console.WriteLine(tnode.Value + " ");
					topView.Add(lvl, tnode);
				}

				if (tnode.Left != null)
				{
					q.Enqueue(new QueuePack(lvl-1, tnode.Left));
				}

				if (tnode.Right != null)
				{
					q.Enqueue(new QueuePack(lvl+1, tnode.Right));
				}
			}
		}

		//try recursive method
	}
}
