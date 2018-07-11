using System;
using System.Collections.Generic;

namespace GetEdge
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //instantiate a new graph
            Graph graph = new Graph();
            Node node1 = new Node("Seattle");
            Node node2 = new Node("New New York");
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

            Console.WriteLine("-------------------------------------------------------");

            //direct flight case
            Tuple<bool, decimal> flight = graph.GetEdge(node1, node2);
            Console.WriteLine($"Flight is {flight.Item1} and it costs {flight.Item2}");

            Console.WriteLine("-------------------------------------------------------");

            //non-direct flight case
            Tuple<bool, decimal> flight2 = graph.GetEdge(node1, node6);
            Console.WriteLine($"Flight is {flight2.Item1} and it costs {flight2.Item2}");
            Console.Read();

        }
    }
}
