using System;
using System.Collections.Generic;

namespace GetEdge
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            GetEdge();
        }

        public static void GetEdge()
        {
            //instantiate a new graph
            Graph graph = new Graph();
            Node node1 = new Node("Seattle");
            Node node2 = new Node("Narnia");
            Node node3 = new Node("Winterfell");
            Node node4 = new Node("North Pole");
            Node node5 = new Node("Eden");
            Node node6 = new Node("Mesopotamia");

            //add edges between nodes
            graph.AddEdge(node1, node2, 100);
            graph.AddEdge(node1, node3, 50);
            graph.AddEdge(node1, node4, 200);
            graph.AddEdge(node4, node5, 10);
            graph.AddEdge(node4, node6, 50);

            graph.GetNeighbors(node1);

            List<Node> neighbors = graph.GetNeighbors(node1);
            Console.WriteLine($"Let`s go from {node1.CityName} to {node2.CityName}");

            if (neighbors.Contains(node2))
            {
                Console.WriteLine($"Yes, we can go from {node1.CityName} to {node2.CityName}.  It will cost {node2.Edges.Keys}");
                foreach (KeyValuePair<Node, decimal> value in node2.Edges)
                {
                    Console.WriteLine($"It will cost {value.Value}");
                }
            }
            else
            {
                Console.WriteLine($"Sorry, there are no direct flights from {node1.CityName} to {node5.CityName}");
            }

            Console.WriteLine($"Let`s go from {node1.CityName} to {node6.CityName}");

            if (neighbors.Contains(node6))
            {
                Console.WriteLine($"Yes, we can go from {node1.CityName} to {node6.CityName}.");
                foreach (KeyValuePair<Node, decimal> value in node6.Edges)
                {
                    Console.WriteLine($"It will cost {value.Value}");
                }
            }
            else
            {
                Console.WriteLine($"Sorry, there are no direct flights from {node1.CityName} to {node6.CityName}");
            }

        }
    }
}
