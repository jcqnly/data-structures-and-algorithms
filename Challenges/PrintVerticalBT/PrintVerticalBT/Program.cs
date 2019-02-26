using PrintVerticalBT.Classes;
using System;
using System.Collections;
using System.Collections.Generic;

namespace PrintVerticalBT
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Vertically print a BT");

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

			Vertical(node1, 0);
		}

		public static void Vertical(Node root, int level)
		{
			if (root == null) return;
			Queue<Layer> q = new Queue<Layer>();

			var vertical = new Dictionary<int, List<int>>();

			q.Enqueue(new Layer(0, root));

			while (q.Count > 0)
			{
				Layer temp = q.Dequeue();
				Node tnode = temp.Root;
				int HD = temp.HD;

				//if the dictionary has that key, add the other nodes found at that HD
				if (vertical.ContainsKey(HD))
				{
					vertical[HD].Add(tnode.Value);
				}
				else
				{
					vertical.Add(HD, new List<int> { tnode.Value });
				}

				if (tnode.Left != null) 
				{
					q.Enqueue(new Layer(HD - 1, tnode.Left));
				}

				if (tnode.Right != null)
				{
					q.Enqueue(new Layer(HD + 1, tnode.Right));
				}
			}

			foreach (KeyValuePair<int, List<int>> entry in vertical)
			{
				Console.WriteLine($"Key: {entry.Key}");
				foreach (int nodes in entry.Value)
				{
					Console.WriteLine($"{nodes}");
				}
			}
		}
	}
}
