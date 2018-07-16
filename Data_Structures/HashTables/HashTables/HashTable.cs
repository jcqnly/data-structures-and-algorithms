using System;
using System.Collections.Generic;
using System.Text;

namespace HashTables
{
    public class HashTable
    {
        /// <summary>
        /// Determine the index of where to put the ASCII value of the word
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="wordValue"></param>
        /// <param name="word"></param>
        public void Add(Node[] arr, int wordValue, string word)
        {
            //formula to determine the location of where to put the ASCII val of given word
            int index = arr.Length % wordValue;
            Console.WriteLine($"Length of array is: {arr.Length}");
            Console.WriteLine($"The word is: {word} and its ASCII value is: {wordValue}");
            Console.WriteLine($"Index in array is: {index}");

            //instantiate a new node b/c each index of the hashtable is a Node
            //this will help deal with collisions later
            Node node = new Node(index, wordValue);

            Console.WriteLine($"The Key/Index is: {node.Key} and the value is: {node.Value}");
            //place the created node into the index of the hashtable
            arr[index] = node;
        }

        /// <summary>
        /// Searches through an array of Node type with a key/index passed in
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="indexToLook"></param>
        /// <returns>a node that is found</returns>
        public Node Find(Node[] arr, int keyToLook)
        {
            Node valueToFind = arr[keyToLook];
            Console.WriteLine($"The value of index {keyToLook} is {valueToFind.Value}");
            return valueToFind;
        }

        /// <summary>
        /// Checks every node to see if a key exists
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="indexTolook"></param>
        /// <returns>true/false</returns>
        public bool Contains(Node[] arr, int keyToLook)
        {
            for (int i = 0; i < arr.Length; i++)
            {   //if there is something in the node, at that index, have a look
                if (arr[i] != null)
                    if (arr[i].Key == keyToLook) return true;
            }
            return false;
        }

        public int GetHash(Node[] arr, int keyToLook)
        {
            return arr[keyToLook].Value;
        }
    }
}
