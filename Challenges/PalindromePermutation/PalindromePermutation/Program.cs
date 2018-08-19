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
            Console.WriteLine(hasPalindromePermutation(string1));
            Console.WriteLine(hasPalindromePermutation(string2));
            Console.WriteLine(hasPalindromePermutation(string3));
            
        }

        public static bool hasPalindromePermutation(string stringToTest)
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
    }
}
