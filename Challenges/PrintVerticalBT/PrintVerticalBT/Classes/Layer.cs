using System;
using System.Collections.Generic;
using System.Text;

namespace PrintVerticalBT.Classes
{
	//
	public class Layer
	{
		public int HD { get; set; }
		public Node Root { get; set; }

		public Layer(int hd, Node root)
		{
			HD = hd;
			Root = root;
		}
	}
}
