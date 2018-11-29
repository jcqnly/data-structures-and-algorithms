using System;
using System.Collections.Generic;
using System.Text;

namespace SortStringArray.Classes
{
	public class Node
	{
		public int Value { get; set; }
		public string Letter { get; set; }
		public Node Left { get; set; }
		public Node Right { get; set; }

		public Node(string letter, int value)
		{
			Letter = letter;
			Value = value;
		}
	}
}
