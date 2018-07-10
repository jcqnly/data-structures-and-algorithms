using System.Collections.Generic;

namespace Graphs
{
    public class Node
    {
        public bool Visited { get; set; }
        //added another bool prop b/c the inial flag does not get reverted
        public bool BFSVisited { get; set; } = true;
        public int Value { get; set; }
        public List<Node> Edges { get; set; }

        public Node(int value)
        {
            Value = value;
            Edges = new List<Node>();
        }
    }
}