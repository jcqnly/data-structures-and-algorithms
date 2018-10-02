using System;
using System.Collections.Generic;
using System.Text;

namespace ReverseInteger
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Reverse Integer!");
			int x = 122223;
			int y = -1983;
			//Reverse(x);
			Console.WriteLine(Reverse(x));
			Console.WriteLine(Reverse(y));
			//Reverse(y);
		}

		public static int Reverse(int num)
		{
			//StackOverflow answer:
			//int result = 0;
			//while (num > 0)
			//{
			//	result = result * 10 + num % 10;
			//	num /= 10;
			//}
			//return result;
			int modulus;
			List<int> reverseNum = new List<int>();
			while (num >= 10)
			{
				//1. find modulus of x
				modulus = num % 10;
				//2. add modulus to list
				reverseNum.Add(modulus);
				//3. divide x by 10 and store that in a diff var
				num = num / 10;
				//4. repeat 1-3 (using a while loop)
			}
			//add the last num to the list
			reverseNum.Add(num);
			StringBuilder sb = new StringBuilder();
			foreach (int x in reverseNum)
			{
				sb.Append(x.ToString());
			}
			string answer = sb.ToString();
			return int.Parse(answer);
		}
	}
}
