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
			LLA.Add(new Node(9));
			LLA.Add(new Node(4));
			LLA.Print();
			Console.WriteLine("----");

			LinkList LLB = new LinkList(new Node(5));
			LLB.Add(new Node(5));
			LLB.Add(new Node(3));
			LLB.Print();

			//call method with the heads of LL1 and LL2 passed in
			Sum(LLA.Head, LLB.Head);
		}

		//method to iterate through LLs
		public static LinkList Sum(Node A, Node B)
		{
			Node currA = A;
			Node currB = B;
			//create new List with the initial value set to a dummy node
			LinkList LLC = new LinkList(new Node(null));

			int carryOver = 0;

			while (currA != null)
			{
				int sum = currA.Value + currB.Value + carryOver;
				currA = currA.Next;
				currB = currB.Next;
			}

			return LLC;
		}

		//method to sum
	}
}
