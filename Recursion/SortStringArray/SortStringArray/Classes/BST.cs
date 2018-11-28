using System;
using System.Collections.Generic;
using System.Text;

namespace SortStringArray.Classes
{
	public class BST
	{
		public Node Add(Node root, Node newNode)
		{
			if (root == null)
			{
				root = newNode;
				return newNode;
			}

			if (newNode.Value < root.Value)
			{
				if (root.Left != null)
				{

				}
				else
				{
					root.Left = newNode;
				}
				return newNode;
			}
		}
	}
}
