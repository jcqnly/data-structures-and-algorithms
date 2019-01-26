using System;

namespace UniVal
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Determine if all the nodes in a BT have the same value");
			Node nodeA = new Node(1);
			Node nodeB = new Node(1);
			Node nodeC = new Node(1);
			Node nodeD = new Node(1);
			Node nodeE = new Node(1);
			Node nodeF = new Node(1);
			Node nodeG = new Node(2);

			nodeA.Left = nodeB;
			nodeA.Right = nodeC;

			nodeB.Left = nodeD;
			nodeB.Right = nodeE;

			nodeC.Right = nodeF;
			nodeC.Left = nodeG;
			bool answer = IsUnival(nodeA);
			Console.WriteLine(answer);
		}

		/// <summary>
		/// Recursive method that only checks the value of the current 
		/// node against the value of its children's nodes
		/// </summary>
		/// <param name="root">starting node</param>
		/// <returns>boolean value</returns>
		public static bool IsUnival(Node root)
		{
			if (root.Left != null)
			{
				if (!IsUnival(root.Left)) return false;
				if (root.Left.Value != root.Value) return false;
			}

			if (root.Right != null)
			{
				if (!IsUnival(root.Right)) return false;
				if (root.Right.Value != root.Value) return false;
			}

			return true;
		}
	}
}
