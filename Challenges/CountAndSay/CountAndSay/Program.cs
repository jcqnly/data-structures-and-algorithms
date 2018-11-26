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
				//Count(s);
				Console.WriteLine(Count(s));
			}
		}

		public static string Count(string s)
		{
			StringBuilder sb = new StringBuilder();
			int count = 1;
			char c = s[0];
			for (int i = 1; i < s.Length; i++)
			{
				if (s[i] == c)
				{
					count++;
				}
				else
				{
					sb.Append(count);
					sb.Append(c);
					c = s[i];
					count = 1;
				}				
			}
			sb.Append(count);
			sb.Append(c);
			return sb.ToString();
		}
	}
}
