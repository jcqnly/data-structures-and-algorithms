using System;
using System.Collections.Generic;
using System.Text;

namespace AddLinkedLists.Classes
{
	public class LinkList
	{
		public Node Head { get; set; }
		public Node Current { get; set; }

		public LinkList(Node node)
		{
			Head = node;
			Current = node;
		}

		public void Add(Node newNode)
		{
			newNode.Next = Head;
			Head = newNode;
			Current = Head;
		}

		public void Print()
		{
			Current = Head;
			while (Current.Next != null)
			{
				Console.Write($"  {Current.Value}  ");
				Current = Current.Next;
			}

			Console.WriteLine($"  {Current.Value}  (last value)");
		}
	}
}
