using System;
using System.Collections.Generic;
using System.Text;

namespace TreeIntersection
{
    public class HashTable
    {
        //a prop of every HashTable is a HashArray of Node type
        public HTNode[] HashArray { get; set; }

        public HashTable()
        {
            HashArray = new HTNode[211];
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
            index = (int)Math.Floor(total % 211);
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
            HTNode node = new HTNode(key, value);
            int index = GetHash(key);
            //if there is a collision, chain the new node to the one already there
            if (HashArray[index] != null) node.Next = HashArray[index];
            //if that index is unoccupied, add the node
            HashArray[index] = node;
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
            HTNode current = HashArray[index];
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
