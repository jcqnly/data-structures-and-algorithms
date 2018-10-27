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
			ll.Add(new Node(16));

			ll.Print();
			FindMiddle(ll);

			LinkList ll2 = new LinkList(new Node(11));
			ll2.Add(new Node(5));
			ll2.Add(new Node(21));
			ll2.Add(new Node(2));
			ll2.Add(new Node(12));

			ll2.Print();
			FindMiddleWithArray(ll2);
		}

		/// <summary>
		/// Finds the Middle of a LinkedList; 2N time solution
		/// </summary>
		/// <param name="ll">a linked list</param>
		public static void FindMiddle(LinkList ll)
		{
			ll.Current = ll.Head;
			double counter = 0;
			while (ll.Current.Next != null)
			{
				ll.Current = ll.Current.Next;
				counter++;
			}

			double midIndex = Math.Ceiling(counter/2);

			while(midIndex > 0)
			{
				ll.Head = ll.Head.Next;
				midIndex--;
			}

			Console.WriteLine($"Middle of the Linked List is {ll.Head.Value}");
		}

		//stretch goal - find another solution
		public static void FindMiddleWithArray(LinkList ll2)
		{

		}
	}
}
