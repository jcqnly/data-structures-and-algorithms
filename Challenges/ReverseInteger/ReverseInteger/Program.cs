using System;
using System.Collections.Generic;

namespace ReverseInteger
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Reverse Integer!");
			int x = 122223;
			Reverse(x);
		}

		public static int Reverse(int x)
		{
			int modulus;
			List<int> reverseNum = new List<int>();
			while (x >= 10)
			{
				//1. find modulus of x
				modulus = x % 10;
				//2. add modulus to list
				reverseNum.Add(modulus);
				//3. divide x by 10 and store that in a diff var
				x = x / 10;
				//4. repeat 1-3 (using a while loop)
			}
			//add the last num to the list
			reverseNum.Add(x);
			return x;
		}
	}
}
