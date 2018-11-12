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

			LinkList LL2 = new LinkList(new Node(10));
			LL2.Add(new Node(15));
			LL2.Add(new Node(51));
			LL2.Add(new Node(20));
			LL2.Add(new Node(34));
			LL2.Add(new Node(27));
			LL2.Add(new Node(44));

			//DeleteNode(LL2, nodeToDelete);
			//LL2.Print();

			//Console.WriteLine("Delete a node nth from the end");
		}

		//delete a node
		public static void DeleteNode(LinkList LL, Node deleteNode)
		{
			LL.Current = LL.Head;
			while (LL.Current.Next != null)
			{
				if (LL.Current.Next.Value == deleteNode.Value)
				{
					LL.Current.Next = LL.Current.Next.Next;
				}
				LL.Current = LL.Current.Next;
			}
		}

		//delete a node nth from the end
	}
}
