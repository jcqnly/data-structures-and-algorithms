using System;
using System.Collections.Generic;
using System.Text;

namespace TreeIntersection
{
    public class Node
    {
        //set the properties of the Node class
        public string Key { get; set; }
        public int Value { get; set; }
        public Node Next { get; set; }
        public Node LeftChild { get; set; }
        public Node RightChild { get; set; }

        /// <summary>
        /// Grabbing the value of every instantiation of a Node
        /// </summary>
        /// <param name="value"></param>
        public Node(string key, int value)
        {
            Value = value;
            Key = key;
            Next = null;
        }
    }
}
