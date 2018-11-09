using System;

namespace DeleteNode
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Delete a node");
			LinkList LL = new LinkList(new Node(10));
			LL.Add(new Node(15));
			LL.Add(new Node(51));
			LL.Add(new Node(20));
			LL.Add(new Node(34));
			DeleteNode(LL);

			Console.WriteLine("Delete a node nth from the end");
		}

		//delete a node
		public static void DeleteNode(LinkList LL)
		{

		}

		//delete a node nth from the end
	}
}
