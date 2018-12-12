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

		public void AddLast(Node newNode)
		{
			Current = Head;
			while (Current.Next != null)
			{
				Current = Current.Next;
			}

			Current.Next = newNode;
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
