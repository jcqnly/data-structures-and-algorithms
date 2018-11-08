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

		}
	}
}
