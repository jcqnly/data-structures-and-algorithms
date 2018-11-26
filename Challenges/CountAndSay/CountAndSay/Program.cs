using System;
using System.Text;

namespace CountAndSay
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Count and Say");
			int n = 5;
			StringBuilder sb = new StringBuilder();

			for (int i = 0; i < n; i++)
			{
				Count();
			}
		}

		public void Count()
		{

		}
	}
}
