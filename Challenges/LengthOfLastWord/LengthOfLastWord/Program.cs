using System;

namespace LengthOfLastWord
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Find the length of last word using the split method:");

			//empty string
			string input1 = "";
			Console.WriteLine($"The string was '{input1}' and the length of the last word is: " +
				$"{LastWordLength(input1)}");

			Console.WriteLine(" ----- ");

			//regular string
			string input2 = "Hello world";
			Console.WriteLine($"The string was '{input2}' and the length of the last word is: " +
				$"{LastWordLength(input2)}");

			Console.WriteLine(" ----- ");

			string input3 = "a";
			Console.WriteLine($"The string was '{input3}' and the length of the last word is: " +
				$"{LastWordLength(input3)}");

			Console.WriteLine(" ----- ");

			string input4 = " a";
			Console.WriteLine($"The string was '{input4}' and the length of the last word is: " +
				$"{LastWordLength(input4)}");


			Console.WriteLine("\nFind length of the last word WITHOUT the split method:");

			//regular string
			string input5 = "Hello world";
			Console.WriteLine($"The string was '{input5}' and the length of the last word is: " +
				$"{LastWordLengthNoSplit(input5)}");

			Console.WriteLine(" ----- ");

			//edge case: 1 letter
			string input6 = "a";
			Console.WriteLine($"The string was '{input6}' and the length of the last word is: " +
				$"{LastWordLengthNoSplit(input6)}");

			Console.WriteLine(" ----- ");

			//edge case: space and 1 letter
			string input7 = " a";
			Console.WriteLine($"The string was '{input7}' and the length of the last word is: " +
				$"{LastWordLengthNoSplit(input7)}");

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
			}
			return counter;
		}


		public static int LastWordLengthNoSplit(string input)
		{
			int counter = 0;
			int i = input.Length - 1;
			if (input.Length == 1 && !Char.IsWhiteSpace(input[0]))
			{
				return 1;
			}

			while (!Char.IsWhiteSpace(input[i]))
			{
				counter++;
				i--;
			}

			return counter;
		}
	}
}
