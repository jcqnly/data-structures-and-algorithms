using GetEdge;
using System;
using System.Collections.Generic;
using Xunit;

namespace TestGetEdges
{
    public class GetEdgesTest
    {
        [Theory]
        [InlineData("New New York", true)]
        public void CanGetDirectFlight(string cityName, bool expected)
        {
            //arrange
            //instantiate a new graph
            Graph graph = new Graph();
            Node node1 = new Node("Seattle");
            Node node2 = new Node("Narnia");
            Node node3 = new Node("Winterfell");
            Node node4 = new Node("North Pole");
            Node node5 = new Node("Eden");
            Node node6 = new Node("Mesopotamia");
            Node node7 = new Node(cityName);

            //add edges between nodes
            graph.AddEdge(node1, node2, 100);
            graph.AddEdge(node1, node3, 50);
            graph.AddEdge(node1, node4, 200);
            graph.AddEdge(node1, node7, 500);
            graph.AddEdge(node4, node5, 10);
            graph.AddEdge(node4, node6, 50);

            //act
            Tuple<bool, decimal> flight = graph.GetEdge(node1, node7);

            //assert
            Assert.Equal(flight.Item1, expected);
        }

        [Theory]
        [InlineData("Narnia", true)]
        public void CanGetAnotherDirectFlight(string cityName, bool expected)
        {
            //arrange
            //instantiate a new graph
            Graph graph = new Graph();
            Node node1 = new Node("Seattle");
            Node node2 = new Node(cityName);
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

            //act
            Tuple<bool, decimal> flight = graph.GetEdge(node1, node2);

            //assert
            Assert.Equal(flight.Item1, expected);
        }

        [Theory]
        [InlineData("Mesopotamia", false)]
        public void CannotGetDirectFlight(string cityName, bool expected)
        {
            //arrange
            //instantiate a new graph
            Graph graph = new Graph();
            Node node1 = new Node("Seattle");
            Node node2 = new Node("Narnia");
            Node node3 = new Node("Winterfell");
            Node node4 = new Node("North Pole");
            Node node5 = new Node("Eden");
            Node node6 = new Node(cityName);

            //add edges between nodes
            graph.AddEdge(node1, node2, 100);
            graph.AddEdge(node1, node3, 50);
            graph.AddEdge(node1, node4, 200);
            graph.AddEdge(node4, node5, 10);
            graph.AddEdge(node4, node6, 50);

            //act
            Tuple<bool, decimal> flight = graph.GetEdge(node1, node6);

            //assert
            Assert.Equal(flight.Item1, expected);
        }
    }
}
