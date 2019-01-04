using System;
using System.Collections.Generic;
using System.Text;

namespace TopViewBT.Classes
{
	public class QueuePack
	{
		public int Level { get; set; }
		public Node Root { get; set; }

		public QueuePack(int level, Node node)
		{
			Root = node;
			Level = level;
		}
	}
}
