using System;
using System.Text;

namespace BalanceParans
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Balance paranthesis in a string");

			string givenString1 = "g)a)v(u(r(r))";
			Console.WriteLine($"Original string\n{givenString1}");
			Console.WriteLine($"Balanced string\n{BalanceParenthesis(givenString1)}");

			string givenString2 = "1+5)+5+)6+(5+9)*9";
			Console.WriteLine($"Original string\n{givenString2}");
			Console.WriteLine($"Balanced string\n{BalanceParenthesis(givenString2)}");
		}

		public static string BalanceParenthesis(string givenString)
		{
			int counter = 0;
			char[] parens = {'(', ')'};
			StringBuilder sb = new StringBuilder();
			for(int i = 0; i < givenString.Length; i++)
			{
				//if char is open parens
				if (givenString[i] == parens[0])
				{
					//append it and incr counter
					sb.Append(givenString[i]);
					counter++;
				}
				//if we're at the end
				else if (i == givenString.Length - 1 && counter > 0)
				{
					//append matching closing parens for as many open parens that need a closing buddy
					while (counter > 0)
					{
						sb.Append(parens[1]);
						counter--;
					}
				}
				//we come across an closing parens, but there are no previous open parens
				else if (givenString[i] == parens[1] && counter == 0)
				{
					//meaning that it's by itself and we don't want it
					sb.Append("");
				}
				//if it's a closing parens that already has an opening buddy and we're not at the end
				else if (givenString[i] == parens[1] && i != givenString.Length - 1 && counter > 0)
				{
					//append that closing parens and decr counter because an open parens has been
					//accounted for with a closing parens
					sb.Append(givenString[i]);
					counter--;
				}
				else
				{
					sb.Append(givenString[i]);
				}

			}
			
			return sb.ToString();
		}
	}
}