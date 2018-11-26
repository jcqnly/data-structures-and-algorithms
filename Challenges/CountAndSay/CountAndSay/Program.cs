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
			string s = "1";

			for (int i = 1; i <= n; i++)
			{
				Count(s);
				Console.WriteLine(s);
			}
		}

		public static void Count(string s)
		{
			StringBuilder sb = new StringBuilder();
			int count = 1;
			for (int i = 0; i < s.Length; i++)
			{
				if (s[i])
				{

				}
			}
		}
	}
}
