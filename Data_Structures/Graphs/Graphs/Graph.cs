using System;
using System.Collections.Generic;
using System.Text;

namespace Graphs
{
    public class Graph
    {
        public Node Current { get; set; }
        //ctor
        //set a starting point for the graph
        public Graph(Node vertex)
        {
            Current = vertex;
        }

        //Add Nodes
        //bring in the newNode and the vertex the newNode will be attached to
        public Node AddVertices(Node vertex, Node newNode)
        {
            if (vertex == null)
            {
                vertex = newNode;
                return vertex;
            }
            vertex.Next = newNode;
            return vertex.Next;
        }

        //AddEdge()
        //connect the source node/vertex with the destination node
        public void AddEdge(Node source, Node destination)
        {
            Current = source;
            source.Next = destination;
        }

        //GetNodes()

        //GetNeighbors()
        //Size()
        //BreadthFirst()
        //public List<Node> BreadthFirst(Node root)
        //{
        //    List<Node> order = new List<Node>();
        //    Queue<Node> breadth = new Queue<Node>();
        //    breadth.Enqueue(root);

        //    while (breadth.TryPeek(out root))
        //    {
        //        Node front = breadth.Dequeue();
        //        order.Add(front);

        //        foreach (Node child in front.Children)
        //        {
        //            if (!child.Visited)
        //            {
        //                child.Visited = true;
        //                breadth.Enqueue(child);
        //            }
        //        }
        //    }

        //    return order;
        //}
    }
}
