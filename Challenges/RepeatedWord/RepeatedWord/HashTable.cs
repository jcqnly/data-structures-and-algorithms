using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RepeatedWord
{
    public class HashTable
    {
        //a prop of every HashTable is a HashArray of Node type
        public Node[] HashArray { get; set; }

        public HashTable()
        {
            //set this length to 1024
            HashArray = new Node[1024];
        }

        public string RepeatedWord(string words)
        {
            HashTable ht = new HashTable();

            //strip punctuation from a given string and convert all letters to lowercase
            string pattern = @"[\p{P}\p{S}]";
            string strippedString = Regex.Replace(words, pattern, "").ToLower();

            //split string on the spaces and put all words into an array
            string[] stringArray = strippedString.Split(" ");

            //loop through each word, hash the words and store them in a hashtable
            for (int i = 0; i < stringArray.Length; i++)
            {
                //first check if the hashtable contains word at the current index
                if (ht.Contains(stringArray[i]))
                {
                    string foundWord = stringArray[i];
                    //if there is a mathch, stop searching
                    return foundWord;
                }
                //otherwise add the word at the current index to the table
                ht.Add(stringArray[i], i);
                Console.WriteLine(stringArray[i]);
            }
            return "Found no repeating words";
        }

        /// <summary>
        /// Calculates the index, within the array, to place a value later on
        /// </summary>
        /// <param name="key">string</param>
        /// <returns>the index based on the hash value of a key</returns>
        public int GetHash(string key)
        {
            decimal total = 0;
            int index = 0;
            //total the ASCII value of each character in the given key
            foreach (char c in key) total += c;
            //determine where to place a value based on the hash of the key
            index = (int)Math.Floor((total * 599) / 1024);
            return index;
        }

        /// <summary>
        /// Create a new node, find a hash for the key, and check if the index is occupied
        /// If it is occupied, chain the nodes together
        /// </summary>
        /// <param name="key">string</param>
        /// <param name="value">int</param>
        public void Add(string key, int value)
        {
            Node node = new Node(key, value);
            int index = GetHash(key);
            //if there is a collision, chain the new node to the one already there
            if (HashArray[index] != null) node.Next = HashArray[index];
            //if that index is unoccupied, add the node
            HashArray[index] = node;
        }

        /// <summary>
        /// Finds the value at the given key
        /// </summary>
        /// <param name="key"></param>
        /// <returns>value of a given key</returns>
        public int Find(string key)
        {
            //get the hash value of the key
            int index = GetHash(key);
            //go straight to that index in the array
            Node current = HashArray[index];
            //look through linkedlist, if there is one at that index, for the key
            while (current.Next != null)
            {   //return the value if the key is found
                if (current.Key == key) return current.Value;
                //reset counter to continue traversal
                current = current.Next;
            }
            //otherwise, return the value of the last node
            if (current.Key == key) return current.Value;
            //If the key doesn't exist, return 0;
            return 0;
        }

        /// <summary>
        /// Determines if a given key exists in the hashtable
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public bool Contains(string key)
        {
            //get the hash value of the key
            int index = GetHash(key);
            //go straight to that index
            Node current = HashArray[index];
            if (current == null) return false;
            //travel through the linkedlist at an index, if there is one
            //to check if the key is there
            while (current.Next != null)
            {
                if (current.Key == key) return true;
                current = current.Next;
            }
            //check the last node for the key
            if (current.Key == key) return true;
            //return false if the key is not found
            return false;
        }
    }
}
