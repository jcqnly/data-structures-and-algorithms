using System;
using System.Text.RegularExpressions;

namespace RepeatedWord
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            RepeatedWord("Once upon a time, there was a brave princess who...");
            Console.ReadLine();
        }

        public static void RepeatedWord(string words)
        {
            HashTable ht = new HashTable();
            
            //strip punctuation from a given string
            string pattern = @"[\p{P}\p{S}]";

            string strippedString = Regex.Replace(words, pattern, "").ToLower();
            string[] stringArray = strippedString.Split(" ");
            for (int i = 0; i < stringArray.Length; i++)
            {               
                ht.Add(stringArray[i], i);
                if (ht.Contains(stringArray[i])) Console.WriteLine($"found a match for {stringArray[i]}");
                Console.WriteLine(stringArray[i]);               
            }

        }
    }
}
