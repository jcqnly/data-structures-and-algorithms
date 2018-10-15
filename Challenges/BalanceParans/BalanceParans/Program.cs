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
				//if char is open parens and there are no other open parens
				if (givenString[i] == parens[0] && counter == 0)
				{
					//append it and incr counter
					sb.Append(givenString[i]);
					counter++;
				}
				else if (i == givenString.Length - 1 && counter > 0)
				{
					//append matching closing parens for as many open parens as there are
					while (counter >= 0)
					{
						sb.Append(parens[1]);
						counter--;
					}
				}
				else if (givenString[i] == parens[1] && counter == 0)
				{
					//remove closing parens if we haven't come across an open parens yet
					//do that by not appending anything
					
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
