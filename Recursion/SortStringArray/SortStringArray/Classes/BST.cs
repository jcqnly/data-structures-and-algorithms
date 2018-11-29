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
					Add(root.Left, newNode);
				}
				else
				{
					root.Left = newNode;
				}
				return newNode;
			}

			if (newNode.Value > root.Value)
			{
				if (root.Right != null)
				{
					Add(root.Right, newNode);
				}
				else
				{
					root.Right = newNode;
				}
				return newNode;
			}

			return root;
		}
	}
}
