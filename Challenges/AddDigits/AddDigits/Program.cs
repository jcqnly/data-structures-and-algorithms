using System;

namespace AddDigits
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Repeatedly add digits in a number until 1 remains:");

			int num = 49;

			Console.WriteLine(AddDigitsTogether(num));
		}

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
	}
}
