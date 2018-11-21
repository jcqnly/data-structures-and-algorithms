using System;
using System.Collections.Generic;

namespace PrintAllParentheses
{
	public class Program
	{

		// driver program  
		public static void Main()
		{
			int n = 3;
			char[] str = new char[2 * n];

			//printParenthesis(str, n);
			var parens = GenerateParenthesis(n);

			foreach (string c in parens)
			{
				Console.WriteLine(c);
			}
		}

		public static List<string> GenerateParenthesis(int n)
		{
			List<string> list = new List<string>();
			GenerateOneByOne("", list, n, n);
			return list;
		}

		public static void GenerateOneByOne(string sublist, List<string> list, int left, int right)
		{
			if (left > right) return;

			if (left > 0) GenerateOneByOne(sublist + "(", list, left - 1, right);

			if (right > 0) GenerateOneByOne(sublist + ")", list, left, right - 1);

			if (left == 0 && right == 0)
			{
				list.Add(sublist);
				return;
			}
		}

		// Wrapper over _printParenthesis() 
		static void printParenthesis(char[] str, int n)
		{
			if (n > 0)
				_printParenthesis(str, 0, n, 0, 0);
			return;
		}

		// Function that print all combinations of  
		// balanced parentheses 
		// open store the count of opening parenthesis 
		// close store the count of closing parenthesis 
		static void _printParenthesis(char[] str,
				int pos, int n, int open, int close)
		{
			if (close == n)
			{
				// print the possible combinations 
				for (int i = 0; i < str.Length; i++)
					Console.Write(str[i]);

				Console.WriteLine();
				return;
			}
			else
			{
				if (open > close)
				{
					str[pos] = '}';
					_printParenthesis(str, pos + 1,
									n, open, close + 1);
				}
				if (open < n)
				{
					str[pos] = '{';
					_printParenthesis(str, pos + 1,
									n, open + 1, close);
				}
			}
		}

	}
}
