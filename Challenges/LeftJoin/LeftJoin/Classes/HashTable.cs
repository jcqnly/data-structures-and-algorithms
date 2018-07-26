using System;
using System.Collections.Generic;
using System.Text;

namespace LeftJoin
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

        /// <summary>
        /// Checks if hashtable2 has the hashtable1 key
        /// if it exists, add the value of that key from HashTable2 and Hashtabel1 to Hashtable3
        /// if it doesn't exist, add only the key value pair from Hashtable1 to Hashtable3 along
        /// with the string "null" to indicate that Hashtable2 did not have that key
        /// </summary>
        /// <param name="ht1">HashTable1</param>
        /// <param name="ht2">HashTable2</param>
        /// <returns>HashTable3 with a left join</returns>
        public HashTable LeftJoinHashTable(HashTable ht1, HashTable ht2)
        {
            //instantiate a new hashtable to store the left join table
            HashTable ht3 = new HashTable();
            for (int i = 0; i < ht1.HashArray.Length; i++)
            {
                if (ht1.HashArray[i] != null)
                {
                    Console.WriteLine($"checking {ht1.HashArray[i].Key}");
                    if (ht2.Contains(ht1.HashArray[i].Key))
                    {
                        //ht2 has ht1 key, so add it to ht3                   
                        ht3.Add(ht1.HashArray[i].Key, ht1.HashArray[i].Value);
                        //add ht2's value to the same key
                        ht3.Add(ht1.HashArray[i].Key, ht2.HashArray[i].Value);
                        Console.WriteLine($"found a match for {ht1.HashArray[i].Key}");
                    } else if (!ht2.Contains(ht1.HashArray[i].Key))
                    {   
                        Console.WriteLine($"didn't find a match for {ht1.HashArray[i].Key}");
                        //ht2 does not have ht1 key, so add ht1's current key value pair
                        ht3.Add(ht1.HashArray[i].Key, ht1.HashArray[i].Value);
                        //also add ht1's key and a "null" to represent that ht2 did not have ht1's key
                        ht3.Add(ht1.HashArray[i].Key, "null");
                    }
                }
            }
            return ht3;
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
        public void Add(string key, string value)
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
        public string Find(string key)
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
            return "0";
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
