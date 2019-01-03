using System;
using System.Collections.Generic;
using System.Text;

namespace TopViewBT.Classes
{
	public class Node
	{
		public Node Left { get; set; }
		public Node Right { get; set; }
		public int Value { get; set; }

		public Node(int value)
		{
			Value = value;
		}
	}
}
