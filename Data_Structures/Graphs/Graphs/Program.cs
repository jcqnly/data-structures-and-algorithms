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
            //implement graph
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

            //add vertices to graph WWWWWWWOOOOOORRRRRRKKKSS
            graph.AddEdge(node1, node2);
            graph.AddEdge(node1, node3);
            graph.AddEdge(node3, node4);
            graph.AddEdge(node3, node5);
            graph.AddEdge(node5, node7);
            graph.AddEdge(node5, node6);
            graph.AddEdge(node3, node8);
            graph.AddEdge(node8, node9);
            graph.AddEdge(node9, node10);

            //GetNodes returns all nodes WOOOORKS
            graph.GetNodes(node9);

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

            //GetNeighbors, 11 & 3 are neighbors of 50 WWWWWWWOOOOOORRRRRRKKKSS
            graph.GetNeighbors(node1);

            //Size WWWWWWWOOOOOORRRRRRKKKSS
            graph.Size(NodeList);
            Console.WriteLine($"Size is {graph.Size(NodeList)}");

            //BreadthFirst
            graph.BreadthFirst(node9);

            Console.Read();
        }
    }
}