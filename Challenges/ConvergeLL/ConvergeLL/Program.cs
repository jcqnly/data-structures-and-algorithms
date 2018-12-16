using System;
using System.Collections.Generic;

namespace ConvergeLL
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Determine if 2 LLs converge.  If they do, find that conversion point.");

			LinkedList<Node> LLA = new LinkedList<Node>();
			LLA.AddFirst(new Node(30));
			LLA.AddFirst(new Node(15));
			LLA.AddFirst(new Node(9));
			LLA.AddFirst(new Node(6));
			LLA.AddFirst(new Node(3));
			//Console.WriteLine($"LLA head is {LLA.First.Value.Value}");
			//Print(LLA.First);

			LinkedList<Node> LLB = new LinkedList<Node>();
			LLB.AddFirst(new Node(30));
			LLB.AddFirst(new Node(15));
			LLB.AddFirst(new Node(10));
			//Console.WriteLine($"LLB head is {LLB.First.Value.Value}");
			//Print(LLB.First);

			StartFindPoint(LLA.First, LLB.First);
		}


		/// <summary>
		/// Initial method to start the problem solving
		/// </summary>
		/// <param name="nodeA"></param>
		/// <param name="nodeB"></param>
		public static void StartFindPoint(LinkedListNode<Node> nodeA, LinkedListNode<Node> nodeB)
		{
			//get counts of both LLs
			int countA = Count(nodeA);
			int countB = Count(nodeB);
			int diff = Math.Abs(countA - countB);

			//depending on which LL is longer, travel up to that difference within the longer LL
			if (countA > countB)
			{
				LinkedListNode<Node> startNodeA = CountTheDifference(diff, nodeA);
				Console.WriteLine($"We are at {startNodeA.Value.Value} on LLA");
				FindConvergePoint(startNodeA, nodeB);
			}
			else
			{
				LinkedListNode<Node> startNodeB = CountTheDifference(diff, nodeB);
				Console.WriteLine($"We are at {startNodeB.Value.Value} on LLB");
				FindConvergePoint(startNodeB, nodeA);
			}

		}

		/// <summary>
		/// Counts the lengths of a LL
		/// </summary>
		/// <param name="node">starting node</param>
		/// <returns>the count, which represents the length of the LL</returns>
		public static int Count(LinkedListNode<Node> node)
		{
			int counter = 0;
			LinkedListNode<Node> current = node;
			while (current != null)
			{
				counter++;
				current = current.Next;
			}
			return counter;
		}

		/// <summary>
		/// Iterates to the point where
		/// </summary>
		/// <param name="diff">difference in lengths between the 2 LLs</param>
		/// <param name="node">node to start iterating at</param>
		/// <returns>the node at which the main iteration will start at</returns>
		public static LinkedListNode<Node> CountTheDifference(int diff, LinkedListNode<Node> node)
		{
			while (diff != 0)
			{
				diff--;
				node = node.Next;
			}

			return node;
		}

		/// <summary>
		/// Travel through both LLs until a node has the same value for both LLs
		/// </summary>
		/// <param name="node1"></param>
		/// <param name="node2"></param>
		/// <returns></returns>
		public static LinkedListNode<Node> FindConvergePoint(LinkedListNode<Node> node1, LinkedListNode<Node> node2)
		{
			while (node1 != null && node2 != null)
			{
				if (node1.Value.Value == node2.Value.Value)
				{
					Console.WriteLine($" The LLs converged on {node1.Value.Value}");
					return node1;
				}
				node1 = node1.Next;
				node2 = node2.Next;
			}
			return null;
		}

		/// <summary>
		/// prints all the nodes in an LL
		/// </summary>
		/// <param name="node">node that we start printing at</param>
		public static void Print(LinkedListNode<Node> node)
		{
			while(node.Next != null)
			{
				Console.Write($"  {node.Value.Value}  -> ");
				node = node.Next;
			}
			Console.Write($"  {node.Value.Value}  ");
			Console.WriteLine("");
		}
	}
}
