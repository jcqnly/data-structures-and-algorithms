using System;

namespace LengthOfLastWord
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Find the length of last word using the split method");

			//empty string
			string input1 = "";
			Console.WriteLine($"The string was '{input1}' and the length of the last word is: {LastWordLength(input1)}");

			Console.WriteLine(" ----- ");

			//regular string
			string input2 = "Hello world";
			Console.WriteLine($"The string was '{input2}' and the length of the last word is: {LastWordLength(input2)}");

			Console.WriteLine("Find length of the last word WITHOUT the split method");

			//regular string
			string input3 = "Hello world";
			Console.WriteLine($"The string was '{input3}' and the length of the last word is: {LastWordLengthNoSplit(input3)}");

		}

		/// <summary>
		/// Find the length of the last word of a given string
		/// Used the split method to split up the words
		/// </summary>
		/// <param name="input"></param>
		/// <returns></returns>
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


		public static int LastWordLengthNoSplit(string input)
		{
			int counter = 0;
			int i = input.Length - 1;
			while (!Char.IsWhiteSpace(input[i]))
			{
				counter++;
				i--;
			}
			return counter;
		}
	}
}
