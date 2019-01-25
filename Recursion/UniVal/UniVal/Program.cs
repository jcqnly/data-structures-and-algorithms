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

			nodeA.Left = nodeB;
			nodeA.Right = nodeC;

			nodeB.Left = nodeD;
			nodeB.Right = nodeE;

			nodeC.Right = nodeF;
		}

		public static bool IsUnival()
		{

		}
	}
}
