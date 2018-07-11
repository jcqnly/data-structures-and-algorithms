using System;
using System.Collections.Generic;
using System.Text;

namespace GetEdge
{
    public class Graph
    {
        /// <summary>
        /// Determines if there is a direct conection between the source and destination
        /// </summary>
        /// <param name="source"></param>
        /// <param name="destination"></param>
        /// <returns>Tuple that is a bool and a value of the weight</returns>
        public Tuple<bool, decimal> GetEdge(Node source, Node destination)
        {
            List<Node> neighbors = GetNeighbors(source);
            Console.WriteLine($"Let`s go from {source.CityName} to {destination.CityName}");

            if (neighbors.Contains(destination))
            {
                Console.WriteLine($"Yes, we can go from {source.CityName} to {destination.CityName}");
                foreach (KeyValuePair<Node, decimal> value in destination.Edges)
                    return Tuple.Create(true, value.Value);
            }
            Console.WriteLine($"Sorry, there are no direct flights from {source.CityName} to {destination.CityName}");
            return (Tuple.Create<bool, decimal>(false, 0));
        }
        /// <summary>
        /// add an edge between 2 nodes to the graph
        /// </summary>
        /// <param name="source"></param>
        /// <param name="destination"></param>
        public void AddEdge(Node source, Node destination, decimal weight)
        {
            source.Edges.Add(destination, weight);
            //adding the following line to make the graph undirected:
            destination.Edges.Add(source, weight);
            Console.WriteLine($"Adding a flight from {source.CityName} to {destination.CityName}");
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
                foreach (Node child in front.Edges.Keys)
                {
                    if (!child.Visited)
                    {
                        child.Visited = true;
                        breadth.Enqueue(child);
                    }
                }
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
            foreach (Node neighbor in node.Edges.Keys)
            {
                result.Add(neighbor);
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
                foreach (Node child in front.Edges.Keys)
                {
                    if (child.Visited)
                    {
                        child.Visited = false;
                        breadth.Enqueue(child);
                    }
                }
            }
            return order;
        }
    }
}
