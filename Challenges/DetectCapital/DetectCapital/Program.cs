using System;

namespace DetectCapital
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Detect Capital");
			string string1 = "C"; //true
			string string2 = "c"; //true
			string string3 = "BeE"; //false

			Console.WriteLine($"{string1} is {DetectCap(string1)}");
			Console.WriteLine($"{string2} is {DetectCap(string2)}");
			Console.WriteLine($"{string3} is {DetectCap(string3)}");
		}

		public static bool DetectCap(string input)
		{
			//check if letter is 1 char long and if it's either lower or uppercase
			if (input.Length == 1 && (char.IsUpper(input[0]) || char.IsLower(input[0])))
			{
				return true;
			}

			//check if the first and second letter is a cap
			if (char.IsUpper(input[0]) && char.IsUpper(input[1]))
			{
				//check the rest of the word
				for (int i = 2; i < input.Length; i++)
				{
					//if any is a lowercase, return false
					if (char.IsLower(input[i]))
					{
						return false;
					}
				}
			}
			else //then the first letter is lowercase
			{
				//if any are caps, then return false
				for (int i = 1; i < input.Length; i++)
				{
					if (char.IsUpper(input[i]))
					{
						return false;
					}
				}
			}

			return true;
		}
	}
}
