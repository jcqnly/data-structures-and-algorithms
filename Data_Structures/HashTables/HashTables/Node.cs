using System;
using System.Collections.Generic;
using System.Text;

namespace HashTables
{
    public class Node
    {
        //every index in the hashtable will be a node
        //the values of the Node will consist of 
        //the given string's ASCII value and the index of it
        public Node Next { get; set; }
        public int Key { get; set; }
        public int Value { get; set; }

        /// <summary>
        /// Next is needed in order to deal with collisions
        /// This way will allow a linked list to be made
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public Node(int key, int value)
        {
            Key = key;
            Value = value;
            Next = null;
        }
    }
}
