using System;

namespace LengthOfLastWord
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Length of last word:");

			//empty string
			string input1 = "";
			Console.WriteLine($"The string was '{input1}' and the length of the last word is: {LastWordLength(input1)}");

			Console.WriteLine(" ----- ");

			//regular string
			string input2 = "Hello world";
			Console.WriteLine($"The string was '{input2}' and the length of the last word is: {LastWordLength(input2)}");

		}

		public static int LastWordLength(string input)
		{
			//split words on space
			string[] splitInput = input.Split(" ");

			int counter = 0;
			//iterate only through the last word
			foreach (char i in splitInput[splitInput.Length-1])
			{
				//count the number of chars in the word
				counter++;
				Console.WriteLine(i);
			}

			return counter;
		}
	}
}
