using System;

namespace MiddleOfLinkedList
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Find the Middle of a Linked List");
			LinkList ll = new LinkList(new Node(10));
			ll.Add(new Node(5));
			ll.Add(new Node(15));
			ll.Add(new Node(52));
			ll.Add(new Node(6));

			ll.Print();
			Console.ReadLine();
		}

		public static void FindMiddle(Node head)
		{

		}
	}
}
