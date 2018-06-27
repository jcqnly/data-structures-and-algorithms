using FizzBuzzTree;
using System;
using Xunit;

namespace FizzBuzzTreeTest
{
    public class TestFizzBuzzTree
    {
        [Fact]
        public void CanFizzBuzzTree()
        {
            //act
            BinaryTree binaryTree = new BinaryTree();

            Node nodeA = new Node("15");
            Node nodeB = new Node("23");
            Node nodeC = new Node("57");
            Node nodeD = new Node("45");
            Node nodeE = new Node("50");
            Node nodeF = new Node("63");

            //setting the values of left and right child of each node
            nodeA.LeftChild = nodeB;
            nodeA.RightChild = nodeC;
            nodeB.LeftChild = nodeD;
            nodeB.RightChild = nodeE;
            nodeC.LeftChild = nodeF;

            //arrange
            Node found = FizzBuzzTree(nodeA);

            //assert
        }
    }
}
