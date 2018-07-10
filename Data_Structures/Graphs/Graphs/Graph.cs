using System;
using System.Collections.Generic;

namespace Graphs
{
    public class Graph
    { 
        /// <summary>
        /// adds an edge between 2 nodes to the graph
        /// </summary>
        /// <param name="source"></param>
        /// <param name="destination"></param>
        public void AddEdge(Node source, Node destination)
        {   
            source.Edges.Add(destination);
            destination.Edges.Add(source);
            Console.WriteLine($"Add an edge between {source.Value} and {destination.Value}");
            //returned and represented as (source, destination), e.g (from source, to destination)?
        }

        //GetNodes() return all nodes in the graph as a collection
        //returns a List of type Node
        public List<Node> GetNodes(Node node)
        {   
            List<Node> order = new List<Node>();
            Queue<Node> breadth = new Queue<Node>();
            breadth.Enqueue(node);

            while (breadth.TryPeek(out node))
            {
                Node front = breadth.Dequeue();
                order.Add(front);

                foreach (Node child in front.Edges)
                {
                    if (!child.Visited)
                    {
                        child.Visited = true;
                        breadth.Enqueue(child);
                    }
                }
            }

            foreach (Node item in order)
            {
                Console.WriteLine($"The following were in the list {item.Value}");
            }
            return order;
        }

        //GetNeighbors()
        //returns a collection of nodes connected to a given node
        public List<Node> GetNeighbors(Node node)
        {   //instantiate the list to be returned, of type Node
            List<Node> result = new List<Node>();
            for (var i = 0; i < node.Edges.Count; i++)
                result.Add(node.Edges[i]);
            Console.WriteLine($"Finding neighbors for {node.Value}");
            foreach (Node item in result)
            {
                Console.WriteLine($"The neighbors were {item.Value}");
            }
            return result;
        }

        //Size()
        public int Size(List<Node> nodes)
        {
            int count = 0;
            foreach (Node node in nodes)
            {
                count++;
            }
            return count;
        }

        //BreadthFirst()
        public List<Node> BreadthFirst(Node node)
        {
            List<Node> order = new List<Node>();
            Queue<Node> breadth = new Queue<Node>();
            breadth.Enqueue(node);

            while (breadth.TryPeek(out node))
            {
                Node front = breadth.Dequeue();
                order.Add(front);

                foreach (Node child in front.Edges)
                {
                    if (child.Visited)
                    {
                        child.Visited = false;
                        breadth.Enqueue(child);
                    }
                }
            }

            foreach (Node item in order)
            {
                Console.WriteLine($"This is from a Breadth First Search: {item.Value}");

            }

            return order;
        }
    }
}
