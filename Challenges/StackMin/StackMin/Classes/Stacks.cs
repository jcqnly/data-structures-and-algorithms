using System;
using System.Collections.Generic;
using System.Text;

namespace StackMin.Classes
{
	public class Stacks
	{
		public Node Top { get; set; }

		public Stacks(Node node)
		{
			Top = node;
		}

		public void Push(Node node)
		{
			node.Next = Top;
			Top = node;
		}

		public Node Pop()
		{
			Node temp = Top;
			Top = Top.Next;
			temp.Next = null;
			return temp;
		}
	}
}
