using System;
using System.Collections.Generic;

namespace Graphs
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            TryOutGraphs();
        }

        public static void TryOutGraphs()
        {
            //instantiate new graph
            Graph graph = new Graph();

            Node node1 = new Node(50);
            Node node2 = new Node(11);
            Node node3 = new Node(3);
            Node node4 = new Node(7);
            Node node5 = new Node(1);
            Node node6 = new Node(9);
            Node node7 = new Node(5);
            Node node8 = new Node(15);
            Node node9 = new Node(2);
            Node node10 = new Node(17);

            //add edges between nodes
            graph.AddEdge(node1, node2);
            graph.AddEdge(node1, node3);
            graph.AddEdge(node3, node4);
            graph.AddEdge(node3, node5);
            graph.AddEdge(node5, node7);
            graph.AddEdge(node5, node6);
            graph.AddEdge(node6, node8);
            graph.AddEdge(node7, node9);
            graph.AddEdge(node8, node10);

            //returns all nodes
            List<Node> allNodes = graph.GetNodes(node1);
            foreach(Node node in allNodes)
                Console.WriteLine($"The following is in the list: {node.Value}");

            //Gets the neighbors of a given node
            List<Node> neighbors = graph.GetNeighbors(node1);
            Console.WriteLine($"Finding neighbors for {node1.Value}...");
            foreach (Node neighbor in neighbors)
                Console.WriteLine($"The neighbors are: {neighbor.Value}");

            //finds the size of the graph
            int graphSize = graph.Size(allNodes);

            Console.WriteLine($"Size is {graphSize}");

            //Traverses through the entire graph
            List<Node> BFSNodes = graph.BreadthFirst(node9);
            foreach(Node node in BFSNodes)
                Console.WriteLine($"This is from the BreadthFirstSearch: {node.Value}");

            Console.Read();
        }
    }
}