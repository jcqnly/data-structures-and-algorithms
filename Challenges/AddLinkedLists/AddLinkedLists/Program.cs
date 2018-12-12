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
			LLA.AddLast(new Node(5));
			LLA.AddLast(new Node(5));
			LLA.AddLast(new Node(3));

			LinkedListNode<Node> LLAHead = LLA.First;

			LinkedList<Node> LLB = new LinkedList<Node>();
			LLB.AddLast(new Node(5));
			LLB.AddLast(new Node(9));
			LLB.AddLast(new Node(4));

			Sum2Lists(LLA.First, LLB.First);
		}

		public static LinkedListNode<Node> Sum2Lists(LinkedListNode<Node> A, LinkedListNode<Node> B)
		{
			LinkedList<Node> LLC = new LinkedList<Node>();
			LinkedListNode<Node> currA = A;
			LinkedListNode<Node> currB = B;

			int carryOver = 0;

			//edge case: both LLs are empty
			if (currA == null && currB == null)
			{
				return null;
			}

			while (currA != null || currB != null)
			{
				if (SumNodes(LLC, currA, currB, carryOver) == 1) carryOver = 1;
				else carryOver = 0;
				//move along the LL
				currA = currA.Next;
				currB = currB.Next;

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

		public static int SumNodes(LinkedList<Node>LL, LinkedListNode<Node> A, LinkedListNode<Node> B, int carryOver)
		{
			int sum = A.Value.Value + B.Value.Value + carryOver;
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
		//public static void Main(string[] args)
		//{
		//	Console.WriteLine("Add values in a linked list and return a new list");

		//	//declare LLA and LLB
		//	LinkList LLA = new LinkList(new Node(5));
		//	LLA.AddLast(new Node(9));
		//	LLA.AddLast(new Node(4));
		//	LLA.Print();
		//	Console.WriteLine("----");

		//	LinkList LLB = new LinkList(new Node(5));
		//	LLB.AddLast(new Node(5));
		//	LLB.AddLast(new Node(3));
		//	LLB.Print();
		//	Console.WriteLine("----");

		//	//call method with the heads of LLA and LLB passed in
		//	Sum2Lists(LLA.Head, LLB.Head);
		//}

		////method to iterate through LLs
		//public static LinkList Sum2Lists(Node A, Node B)
		//{
		//	Node currA = A;
		//	Node currB = B;
		//	int carryOver = 0;
		//	int sum = currA.Value + currB.Value + carryOver;
		//	if (sum >= 10) carryOver = 1;
		//	int remainder = sum % 10;

		//	Node currC = new Node(remainder);
		//	LinkList LLC = new LinkList(currC);

		//	currA = currA.Next;
		//	currB = currB.Next;

		//	while (currA != null)
		//	{
		//		sum = currA.Value + currB.Value + carryOver;
		//		if (sum >= 10) carryOver = 1;
		//		remainder = sum % 10;
		//		Node newNode = new Node(remainder);
		//		LLC.AddLast(newNode);
		//		currA = currA.Next;
		//		currB = currB.Next;
		//		currC = currC.Next;
		//	}

		//	LLC.Print();
		//	return LLC;
		//}

		//method to sum
	}
}
