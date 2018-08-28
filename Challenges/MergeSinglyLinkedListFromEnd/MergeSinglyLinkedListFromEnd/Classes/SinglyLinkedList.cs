using System;
using System.Collections.Generic;
using System.Text;

namespace MergeSinglyLinkedListFromEnd.Classes
{
	public class SinglyLinkedList
	{
		public Node Head { get; set; }
		public Node Current { get; set; }

		public SinglyLinkedList(Node node)
		{
			Head = node;
			Current = node;
		}

		public void Add(Node node)
		{
			Current = Head;
			node.Next = Head;
			node = Head;
			Current = Head;
		}
	}
}
