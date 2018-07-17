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
            Console.Read();
        }

        public static void TryOutHashTable()
        {
            HashTable ht = new HashTable();

            //add values at a given key
            ht.Add("cat", 50);
            ht.Add("act", 5);
            ht.Add("dog", 1);
            ht.Add("god", 30);
            ht.Add("art", 75);
            ht.Add("rat", 23);
            ht.Add("man", 99);

            //prove all keys added exist in the hashtable
            //all keys given are less than 100, so you don't have to scroll
            //through 1024 values to see them
            for (int i = 0; i < ht.HashArray.Length; i++)
            {
                if (ht.HashArray[i] != null)
                    Console.WriteLine($"key: {ht.HashArray[i].Key} and value: {ht.HashArray[i].Value}");
                Console.WriteLine($"{i}");
            }

            //get hash value for a key
            int hashValue1 = ht.GetHash("art");
            Console.WriteLine($"Hash value for art is {hashValue1}");
            //find the value for a given key
            int findValue1 = ht.Find("art");
            Console.WriteLine($"Finding the value for a key that was added: {findValue1}");

            Console.WriteLine("--------------------------------------");

            //handling collision in the case that 2 keys are same
            //use 'cat' and 'act' in this case
            int hashValue2 = ht.GetHash("act");
            Console.WriteLine($"Hash value for act is {hashValue2}");
            int findValue2 = ht.Find("act");
            Console.WriteLine($"Finding the value for a key that was added: {findValue2}");
            int hashValue3 = ht.GetHash("cat");
            Console.WriteLine($"Hash value for cat is {hashValue3}");
            int findValue3 = ht.Find("cat");
            Console.WriteLine($"Finding the value for a key that was added: {findValue3}");
        }
    }
}
