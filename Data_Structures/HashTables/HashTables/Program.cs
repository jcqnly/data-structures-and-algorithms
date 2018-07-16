using System;
using System.Collections.Generic;

namespace HashTables
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            TryOutHashTable();
        }

        public static void TryOutHashTable()
        {
            //declare an array to the size of prime number
            int[] arrayHashTable = new int[599];
            HashFunction hf = new HashFunction();
            //convert the value of "cat" into ASCII
            string word = "cat";
            int wordValue = hf.ConvertWord(word);
            //convert the value of "dog" into ASCII
            string word2 = "dog";
            int wordValue2 = hf.ConvertWord(word2);
            Console.WriteLine($"Total from main is {wordValue}");

            HashTable ht = new HashTable();
            //add "cat" ASCII value
            ht.Add(arrayHashTable, wordValue, word);
            //add "dog" ASCII value
            ht.Add(arrayHashTable, wordValue2, word);

            //visualize the hashtable
            for (int i = 0; i < arrayHashTable.Length; i++)
                Console.WriteLine($"index {i} | {arrayHashTable[i]}");
        }
    }
}
