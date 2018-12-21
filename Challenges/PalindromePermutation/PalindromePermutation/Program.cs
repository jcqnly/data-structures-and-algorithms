using System;
using System.Collections;
using System.Collections.Generic;

namespace PalindromePermutation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string string1 = "civic";
            string string2 = "ivicc";
            string string3 = "llic";
			//Console.WriteLine(HasPalindromePermutation(string1));
			//Console.WriteLine(HasPalindromePermutation(string2));
			//Console.WriteLine(HasPalindromePermutation(string3));

			string string4 = "Tacocat";
			Console.WriteLine(IsPalindrome(string4));
        }

        public static bool HasPalindromePermutation(string stringToTest)
        {
            var unpairedChar = new HashSet<char>();

            foreach (char c in stringToTest)
            {
                 if (unpairedChar.Contains(c))
                {
                    unpairedChar.Remove(c);
                }
                else
                {
                    unpairedChar.Add(c);
                }
            }

            return unpairedChar.Count <= 1;
        }

		public static bool IsPalindrome(string input)
		{
			//char[] inputArr = input.ToLower().ToCharArray();
			string newString = input.ToLower();
			int start = 0;
			int end = input.Length - 1;

			while (start < end)
			{
				if (newString[start] != newString[end]) return false;
				start++;
				end--;
			}
			return true;
		}


    }
}