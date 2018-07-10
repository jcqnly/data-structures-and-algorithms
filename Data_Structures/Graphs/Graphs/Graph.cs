using System;
using System.Collections.Generic;

namespace Graphs
{
    public class Graph
    { 
        /// <summary>
        /// add an edge between 2 nodes to the graph
        /// </summary>
        /// <param name="source"></param>
        /// <param name="destination"></param>
        public void AddEdge(Node source, Node destination)
        {   
            source.Edges.Add(destination);
            //adding the following line to make the graph undirected:
            destination.Edges.Add(source);
            Console.WriteLine($"Adding an edge between {source.Value} and {destination.Value}");
        }

        /// <summary>
        /// Gets all nodes in the graph
        /// </summary>
        /// <param name="node"></param>
        /// <returns>List of nodes</returns>
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

        /// <summary>
        /// Gets the neighbors of a given node
        /// </summary>
        /// <param name="node"></param>
        /// <returns>List of nodes</returns>
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

        /// <summary>
        /// Finds the number of vertices in a graph
        /// </summary>
        /// <param name="nodes"></param>
        /// <returns>an int that is the size of the graph</returns>
        public int Size(List<Node> nodes)
        {
            int count = 0;
            foreach (Node node in nodes) count++;
            return count;
        }

        /// <summary>
        /// Takes in a node and traverses through the entire graph
        /// </summary>
        /// <param name="node"></param>
        /// <returns>List of all the nodes in the graph</returns>
        public List<Node> BreadthFirst(Node node)
        {
            List<Node> order = new List<Node>();
            Queue<Node> breadth = new Queue<Node>();
            breadth.Enqueue(node);

            while (breadth.TryPeek(out node))
            {
                Node front = breadth.Dequeue();
                order.Add(front);
                //the Visited bool value was switched to all true in GetNodes(),
                //so this logic is the opposite to compensate for that switch
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
