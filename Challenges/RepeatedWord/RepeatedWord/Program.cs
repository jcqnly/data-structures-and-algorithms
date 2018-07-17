using System;
using System.Text.RegularExpressions;

namespace RepeatedWord
{
    public class Program
    {
        public static void Main(string[] args)
        {
            HashTable ht = new HashTable();

            string foundWord = ht.RepeatedWord("Once upon a time, there was a brave princess who...");

            Console.WriteLine($"The first repeated word is '{foundWord}'");
            Console.ReadLine();
        }
    }
}
