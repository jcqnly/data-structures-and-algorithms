using System;
using System.Collections.Generic;

namespace MiddleOfLinkedList
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Find the Middle of a Linked List");
			
			LinkedList<Node> ll = new LinkedList<Node>();

			ll.AddLast(3);
			ll.AddLast(2);
			ll.AddLast(1);
		}

		public static void FindMiddle(Node head)
		{
			Node current = head;
		}
	}
}
