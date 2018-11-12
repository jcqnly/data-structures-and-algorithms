using System;

namespace DeleteNode
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Delete a node");
			LinkList LL = new LinkList(new Node(10));
			LL.Add(new Node(15));
			LL.Add(new Node(51));
			LL.Add(new Node(20));
			LL.Add(new Node(34));
			LL.Add(new Node(27));
			LL.Add(new Node(44));
			Console.WriteLine($"Original list is: ");
			LL.Print();

			Node nodeToDelete = new Node(34);
			Console.WriteLine($"Node to delete is {nodeToDelete.Value}");
			DeleteNode(LL, nodeToDelete);
			LL.Print();

			LinkList LL2 = new LinkList(new Node(6));
			LL2.Add(new Node(5));
			LL2.Add(new Node(1));
			LL2.Add(new Node(2));
			LL2.Add(new Node(4));
			LL2.Add(new Node(7));
			LL2.Add(new Node(9));
			Console.WriteLine("Original list is ");
			LL2.Print();

			Node nodeToDelete2 = new Node(1);
			Console.WriteLine($"Node to delete is {nodeToDelete2.Value}");
			DeleteNode(LL2, nodeToDelete2);
			LL2.Print();

			//Console.WriteLine("Delete a node nth from the end");
		}

		/// <summary>
		/// Delete a node by setting the current.next to point to current.next.next
		/// </summary>
		/// <param name="LL">A singly linked list</param>
		/// <param name="deleteNode">the node to be deleted</param>
		public static void DeleteNode(LinkList LL, Node nodeToDelete)
		{
			LL.Current = LL.Head;
			while (LL.Current.Next != null)
			{
				if (LL.Current.Next.Value == nodeToDelete.Value)
				{
					LL.Current.Next = LL.Current.Next.Next;
				}
				LL.Current = LL.Current.Next;
			}
		}

		public static void DeleteNodeSwap(Node nodeToDelete)
		{
			nodeToDelete.Value = nodeToDelete.Next.Value;
			nodeToDelete.Next = nodeToDelete.Next.Next;
		}
		//delete a node nth from the end
	}
}
