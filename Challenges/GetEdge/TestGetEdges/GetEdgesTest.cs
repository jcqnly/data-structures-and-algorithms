using GetEdge;
using System;
using System.Collections.Generic;
using Xunit;

namespace TestGetEdges
{
    public class GetEdgesTest
    {
        [Fact]
        public void CanGetDirectFlight()
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
        }
    }
}
