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
            //declare an array, of type Node, to the size of prime number
            Node[] arrayHashTable = new Node[599];

            //instantiate a hashfunction to determine the word ASCII value
            HashFunction hf = new HashFunction();

            //convert the value of "dog" into ASCII
            //key: 287 value: 312
            string word1 = "cat";
            int wordValue = hf.ConvertWord(word1);

            //convert the value of "cat" into ASCII
            //key: 285 value: 314
            string word2 = "dog";
            int wordValue2 = hf.ConvertWord(word2);

            //instantiate a new hashtable to put the word into the array
            HashTable ht = new HashTable();

            //add "cat" ASCII value
            ht.Add(arrayHashTable, wordValue, word1);
            //add "dog" ASCII value
            ht.Add(arrayHashTable, wordValue2, word2);

            //visualize the hashtable
            for (int i = 0; i < arrayHashTable.Length; i++)
            {
                if (arrayHashTable[i] != null)
                    Console.WriteLine($"index {i} | Key: {arrayHashTable[i].Key} Value: {arrayHashTable[i].Value}");
                else if (arrayHashTable[i] == null)
                    Console.WriteLine($"index {i}");
            }

            //find the value given the array to search through and the index
            int keyToLook1 = 287;
            Node node = ht.Find(arrayHashTable, keyToLook1);
            Console.WriteLine($"At key {keyToLook1}, is a value of: {node.Value}");

            //check if the hashtable contains a key/index
            //true - a key exists
            Console.WriteLine($"Does key {keyToLook1} exist? {ht.Contains(arrayHashTable, keyToLook1)}!");

            //false = a key doesn't exist
            //randomly chosen at the moment:
            int keyToLook2 = 99;
            Console.WriteLine($"Does key {keyToLook2} exist? {ht.Contains(arrayHashTable, keyToLook2)}!");

            int keyToLook3 = 285;
            int hashValue = ht.GetHash(arrayHashTable, keyToLook3);
            Console.WriteLine($"The value is {hashValue}.");
        }
    }
}
