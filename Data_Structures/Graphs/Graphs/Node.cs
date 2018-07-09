using System;
using System.Collections.Generic;
using System.Text;

namespace Graphs
{
    public class Node
    {
        public bool Visited { get; set; }
        public int Value { get; set; }
        public Node Next { get; set; }
        public List<int> edges = new List<int>();

        public Node(int value)
        {
            Value = value;
            Next = null;
        }
    }
}