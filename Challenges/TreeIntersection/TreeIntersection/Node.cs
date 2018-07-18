using System;
using System.Collections.Generic;
using System.Text;

namespace TreeIntersection
{
    public class Node
    {
        //set the properties of the Node class
        public int Value { get; set; }
        public Node LeftChild { get; set; }
        public Node RightChild { get; set; }

        /// <summary>
        /// Grabbing the value of every instantiation of a Node
        /// </summary>
        /// <param name="value"></param>
        public Node(int value)
        {
            Value = value;
        }
    }
}
