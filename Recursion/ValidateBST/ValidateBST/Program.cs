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

			//InOrder(nodeA);
			Console.WriteLine(InOrder(nodeA));
			Node node1 = new Node(2);
			Node node2 = new Node(7);
			Node node3 = new Node(5);
			Node node4 = new Node(2);
			Node node5 = new Node(6);
			Node node6 = new Node(5);
			Node nodeG = new Node(11);
			Node nodeH = new Node(9);
			Node nodeI = new Node(5);

			//setting the values of left and right of each node
			node1.Left = nodeB;
			node1.Right = nodeC;
			node2.Left = nodeD;
			node2.Right = nodeE;
			node5.Left = nodeF;
			node5.Right = nodeG;
			nodeF.Right = nodeI;
			nodeC.Right = nodeF;

			Console.WriteLine(InOrder(node1));
		}

		
		public static bool InOrder(Node node)
		{
			if (node == null) return true;

			if (node.Left != null)
			{
				if (node.Left.Value > node.Value) return false;
				InOrder(node.Left);
			}

			if (node.Right != null)
			{
				if (node.Right.Value < node.Value) return false;
				InOrder(node.Right);
			}

			return true;
		}
	
	}
}
