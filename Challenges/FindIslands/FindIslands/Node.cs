using System;
using System.Collections.Generic;
using System.Text;

namespace FindIslands
{
    public class Node
    {
        public bool Visited { get; set; }
        public int Value { get; set; }
        public List<Node> Edges { get; set; }

        /// <summary>
        /// Grabs the info for every Node instantiated with a value for value
        /// and a new list of Edges
        /// </summary>
        /// <param name="value"></param>
        public Node(int value)
        {
            Value = value;
            Edges = new List<Node>();
        }
    }
}
