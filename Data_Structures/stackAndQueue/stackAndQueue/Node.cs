using System;
using System.Collections.Generic;
using System.Text;

namespace stackAndQueue
{
    public class Node
    {
        //establish the properties of the node
        public int Value { get; set; }
        public Node Next { get; set; }
        
        //requirements for the instantiation of a node
        public Node(int value)
        {
            Value = value;
            Next = null;
        }
    }
}
