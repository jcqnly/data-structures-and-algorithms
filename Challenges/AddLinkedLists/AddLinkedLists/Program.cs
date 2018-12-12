using AddLinkedLists.Classes;
using System;
using System.Collections.Generic;

namespace AddLinkedLists
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Add values in a linked list and return a new list");

			//declare LLA and LLB
			LinkList LLA = new LinkList(new Node(5));
			LLA.AddLast(new Node(9));
			LLA.AddLast(new Node(4));
			LLA.Print();
			Console.WriteLine("----");

			LinkList LLB = new LinkList(new Node(5));
			LLB.AddLast(new Node(5));
			LLB.AddLast(new Node(3));
			LLB.Print();
			Console.WriteLine("----");

			//call method with the heads of LLA and LLB passed in
			Sum2Lists(LLA.Head, LLB.Head);
		}

		//method to iterate through LLs
		public static LinkList Sum2Lists(Node A, Node B)
		{
			Node currA = A;
			Node currB = B;
			int carryOver = 0;
			int sum = currA.Value + currB.Value + carryOver;
			if (sum >= 10) carryOver = 1;
			int remainder = sum % 10;

			Node currC = new Node(remainder);
			LinkList LLC = new LinkList(currC);

			currA = currA.Next;
			currB = currB.Next;

			while (currA != null)
			{
				sum = currA.Value + currB.Value + carryOver;
				remainder = sum % 10;
				if (sum >= 10) carryOver = 1;
				Node newNode = new Node(remainder);
				LLC.AddLast(newNode);
				currA = currA.Next;
				currB = currB.Next;
				currC = currC.Next;
			}

			LLC.Print();
			return LLC;
		}

		//method to sum
	}
}
