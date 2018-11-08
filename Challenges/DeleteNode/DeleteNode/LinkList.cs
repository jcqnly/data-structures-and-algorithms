using System;
using System.Collections.Generic;
using System.Text;

namespace DeleteNode
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

		public void Add(Node node)
		{
			Current = Head;
			node.Next = Head;
			Head = node;
			Current = Head;
		}

		public void AddBefore(Node newNode, Node existingNode)
		{
			Current = Head;
			if (Head.Value == existingNode.Value)
			{
				Add(newNode);
				return;
			}

			while (Current.Next != null)
			{
				if (Current.Next.Value == existingNode.Value)
				{
					newNode.Next = Current.Next;
					Current.Next = newNode;
					return;
				}
				Current = Current.Next;
			}
		}
	}
}
