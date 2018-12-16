using System;

namespace AddDigits
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Repeatedly add digits in a number until 1 remains:");

			int num = 38;
			Console.WriteLine(AddDigitsTogether(num));
			Console.WriteLine(AddDigitsRecursively(num));

			int num2 = 12345;
			Console.WriteLine(AddAnyNumberOfDigits(num2));
			Console.WriteLine(AddDigitsRecursively(num2));
		}


		/// <summary>
		/// Non-recursive, iterative solution
		/// Repeatedly sums all the digits is a number
		/// </summary>
		/// <param name="num"></param>
		/// <returns>sum of all the digits</returns>
		public static int AddDigitsTogether(int num)
		{
			int sum = num;

			while (sum > 9)
			{
				//modulus the number to get to the ones place
				int onesPlace = sum % 10;

				//modulus the number to get to the ten place
				int tensPlace = sum /10 % 10;

				sum = onesPlace + tensPlace;
			}
			return sum;
		}

		//recursive method currently doesn't add the final 2 numbers
		public static int AddDigitsRecursively(int num)
		{
			if (num > 0)
			{
				return num % 10 + AddDigitsRecursively(num / 10);
			}

			return num % 10 + (num/10);
		}

		//not my solution, but comments explain how I read this
		public static int AddAnyNumberOfDigits(int num)
		{
			//x will keep the sum of each digit
			int x = 0;
			while (num != 0)
			{
				//add the value of the ones place of num to x
				x += num % 10;
				//divide num by 10 to get the tens place
				num /= 10;

				//if num is 0 and the sum is still more than 2 digits
				if (num == 0 && x >= 10)
				{
					//set num to the value of x to sum the final 2 numbers
					num = x;
					x = 0;
				}
			}
			return x;
		}
	}
}
