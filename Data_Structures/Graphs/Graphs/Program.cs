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
            graph.AddEdge(node3, node8);
            graph.AddEdge(node8, node9);
            graph.AddEdge(node9, node10);

            //returns all nodes
            List<Node> allNodes = graph.GetNodes(node9);
            foreach(Node node in allNodes)
                Console.WriteLine($"The following is in the list: {node.Value}");

            //add all the nodes to a list of type Node
            List<Node> NodeList = new List<Node>();
            NodeList.Add(node1);
            NodeList.Add(node2);
            NodeList.Add(node3);
            NodeList.Add(node4);
            NodeList.Add(node5);
            NodeList.Add(node6);
            NodeList.Add(node7);
            NodeList.Add(node8);
            NodeList.Add(node9);
            NodeList.Add(node10);

            //Gets the neighbors of a given node
            List<Node> neighbors = graph.GetNeighbors(node1);
            Console.WriteLine($"Finding neighbors for {node1.Value}...");
            foreach (Node neighbor in neighbors)
                Console.WriteLine($"The neighbors are: {neighbor.Value}");

            //finds the size of the graph
            graph.Size(NodeList);
            Console.WriteLine($"Size is {graph.Size(NodeList)}");

            //Traverses through the entire graph
            List<Node> BFSNodes = graph.BreadthFirst(node9);
            foreach(Node node in BFSNodes)
                Console.WriteLine($"This is from the BreadthFirstSearch: {node.Value}");

            Console.Read();
        }
    }
}