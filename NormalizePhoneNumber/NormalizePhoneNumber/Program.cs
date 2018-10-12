using System;
using System.Linq;
using System.Text;

namespace NormalizePhoneNumber
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Find Phone Number!");
			string input1 = "";
			string input2 = "ABCDEFGHIJK";
			string input3 = "XYZ12223334444";
			string input4 = "eu.OOe";
			Console.WriteLine(FindPhoneNumber(input1));
			Console.WriteLine(FindPhoneNumber(input2));
			Console.WriteLine(FindPhoneNumber(input3));
			Console.WriteLine(FindPhoneNumber(input4));
		}

		public static string FindPhoneNumber(string input)
		{
			if (input.Length == 0)
			{
				return "null";
			}

			if (!input.Any(char.IsDigit))
			{
				return "null";
			}

			StringBuilder sb = new StringBuilder();
			sb.Append("+");
			for (int i = 0; i < input.Length; i++)
			{
				if (char.IsDigit(input[i]))
				{
					sb.Append(input[i]);
				}
			}
			return sb.ToString();
		}
	}
}
