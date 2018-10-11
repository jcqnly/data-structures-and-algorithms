using System;
using System.Linq;

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
			FindPhoneNumber(input1);
			FindPhoneNumber(input2);
			FindPhoneNumber(input3);
			FindPhoneNumber(input4);
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

			string onlyNumbers = "";
			for (int i = 0; i < input.Length; i++)
			{
				if (Char.IsDigit(input[i]))
				{
					onlyNumbers += input[i];
				}
			}
		`	
			return input;
		}
	}
}
