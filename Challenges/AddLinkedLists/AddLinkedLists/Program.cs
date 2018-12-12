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

			while (currA != null)
			{
				int sum = currA.Value.Value + currB.Value.Value + carryOver;
				if (sum >= 10) carryOver = 1;
				//get the num in the ones place
				int remainder = sum % 10;
				LLC.AddLast(new Node(remainder));

				currA = currA.Next;
				currB = currB.Next;
			}

			Print(LLC.First);
			return LLC.First;
		}

		public static void Print(LinkedListNode<Node> LLNode)
		{
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
