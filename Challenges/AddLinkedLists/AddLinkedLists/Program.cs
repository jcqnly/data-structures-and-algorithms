using AddLinkedLists.Classes;
using System;
using System.Collections.Generic;

namespace AddLinkedLists
{
	public class Program
	{
		public static void Main(string[] args)
		{
			//solve this challenge with the built-in LL class
			Console.WriteLine("Add values in a linked list and return a new list");
			LinkedList<Node> LLA = new LinkedList<Node>();
			//LLA.AddLast(new Node(5));
			LLA.AddLast(new Node(5));
			LLA.AddLast(new Node(9));
			LLA.AddLast(new Node(1));
			Print(LLA.First);

			LinkedList<Node> LLB = new LinkedList<Node>();
			//LLB.AddLast(new Node(5));
			//LLB.AddLast(new Node(9));
			LLB.AddLast(new Node(5));
			Print(LLB.First);

			Sum2Lists(LLA.First, LLB.First);
		}

		/// <summary>
		/// Add the values of 2 linked list.  This travels to each node and
		/// a helper method is needed to sum the values of the nodes
		/// </summary>
		/// <param name="A">Linked List A</param>
		/// <param name="B">Linked List B</param>
		/// <returns>the head node of Linked List C</returns>
		public static LinkedListNode<Node> Sum2Lists(LinkedListNode<Node> A, LinkedListNode<Node> B)
		{
			LinkedList<Node> LLC = new LinkedList<Node>();
			LinkedListNode<Node> currA = A;
			LinkedListNode<Node> currB = B;

			int carryOver = 0;

			//edge case: both LLs are empty
			if (currA == null && currB == null)
			{
				Console.WriteLine("Both lists were empty");
				return null;
			}

			while (currA != null || currB != null)
			{
				if (SumNodes(LLC, currA, currB, carryOver) == 1) carryOver = 1;
				else carryOver = 0;

				//move along the LL 
				//edge case: accounting for when an LL is longer than the other
				if (currA == null)
				{	//only move along the LL if there exists another node and if the other LL is shorter
					if (currB != null) currB = currB.Next;
				}
				if (currB == null)
				{
					if (currA != null) currA = currA.Next;
				} 
				else
				{
					currA = currA.Next;
					currB = currB.Next;
				}

				//edge case: if both nodes next in both lists are null and there's a carryOver
				//create an extra new node
				if (currA == null && currB == null && carryOver == 1)
				{
					LLC.AddLast(new Node(carryOver));
				}
			}

			Print(LLC.First);
			return LLC.First;
		}

		/// <summary>
		/// This method sums the values of 2 nodes.  
		/// It finds the remainder of a modulus equation, which represents the ones place.
		/// This value is placed into a new node in the 3rd Linked List
		/// </summary>
		/// <param name="LL">the 3rd Linked List with the sum of the nodes</param>
		/// <param name="A">Node from Linked List A</param>
		/// <param name="B">Node from Linked List B</param>
		/// <param name="carryOver">the value in the tens place after summing the values</param>
		/// <returns>an integer value, how much to carry over to the next addition</returns>
		public static int SumNodes(LinkedList<Node> LL, LinkedListNode<Node> A, LinkedListNode<Node> B, int carryOver)
		{
			int sum = 0;
			//edge cases: one of the LLs is longer than the other
			if (B != null && A == null) sum = B.Value.Value + carryOver;
			else if (A != null && B == null) sum = A.Value.Value + carryOver;
			else sum = A.Value.Value + B.Value.Value + carryOver;

			int remainder = sum % 10; //get the num in the ones place
			LL.AddLast(new Node(remainder)); //create a new node

			//get the num to carryOver
			if (sum >= 10) return carryOver = 1;
			return carryOver = 0;
		}

		/// <summary>
		/// print the LL
		/// </summary>
		/// <param name="LLNode"></param>
		public static void Print(LinkedListNode<Node> LLNode)
		{
			Console.WriteLine();
			Console.WriteLine("---");
			while (LLNode != null)
			{
				Console.Write($"  {LLNode.Value.Value}  ");
				LLNode = LLNode.Next;
			}

		}
	}
}
