using Graphs;
using System;
using System.Collections.Generic;
using Xunit;

namespace TestGraphs
{
    public class GraphTests
    {
        [Fact]
        public void CanGetSize()
        {
            //arrange
            Graph graph = new Graph();

            Node node1 = new Node(100);
            Node node2 = new Node(11);
            Node node3 = new Node(30);
            Node node4 = new Node(75);
            Node node5 = new Node(12);
            Node node6 = new Node(19);
            Node node7 = new Node(15);
            Node node8 = new Node(5);
            Node node9 = new Node(20);
            Node node10 = new Node(17);

            graph.AddEdge(node1, node2);
            graph.AddEdge(node1, node3);
            graph.AddEdge(node3, node4);
            graph.AddEdge(node3, node5);
            graph.AddEdge(node5, node7);
            graph.AddEdge(node5, node6);
            graph.AddEdge(node3, node8);
            graph.AddEdge(node8, node9);
            graph.AddEdge(node9, node10);

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

            //act
            int nodeListSize = graph.Size(NodeList);

            //assert
            Assert.Equal(10, nodeListSize);
        }

        [Fact]
        public void CanGetNeighbors()
        {
            //arrange
            Graph graph = new Graph();
            Node node1 = new Node(100);
            Node node2 = new Node(111);
            Node node3 = new Node(330);
            Node node4 = new Node(705);
            Node node5 = new Node(120);

            graph.AddEdge(node1, node2);
            graph.AddEdge(node1, node3);
            graph.AddEdge(node1, node4);
            graph.AddEdge(node1, node5);

            //act
            List<Node> neighbors = graph.GetNeighbors(node1);
            int counter = 0;
            foreach (Node neighbor in neighbors) counter++;

            //assert
            Assert.Equal(4, counter);
        }

        [Fact]
        public void CanAddEdge()
        {
            //arrange
            Graph graph = new Graph();
            Node node1 = new Node(100);
            Node node2 = new Node(111);
            Node node3 = new Node(330);
            Node node4 = new Node(705);
            Node node5 = new Node(120);

            //act
            graph.AddEdge(node1, node2);
            graph.AddEdge(node1, node3);
            graph.AddEdge(node1, node4);
            graph.AddEdge(node1, node5);


            //assert
            Assert.Equal(4, node1.Edges.Count);
        }
    }
}
