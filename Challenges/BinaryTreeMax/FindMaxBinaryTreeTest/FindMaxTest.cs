using System;
using Trees;
using Xunit;
using static BinaryTreeMax.Program;

namespace FindMaxBinaryTreeTest
{
    public class FindMaxTest
    {
        [Theory]
        [InlineData(12, 12)]
        [InlineData(200, 200)]
        [InlineData(20, 20)]
        public void CanFindMax(int expected, int value)
        {
            //act
            //instantiating a tree to work with
            BinaryTree binaryTree = new BinaryTree();

            Node nodeA = new Node(2);
            Node nodeB = new Node(7);
            Node nodeC = new Node(5);
            Node nodeD = new Node(2);
            Node nodeE = new Node(6);
            Node nodeF = new Node(5);
            Node nodeG = new Node(value);
            Node nodeH = new Node(9);
            Node nodeI = new Node(5);

            //setting the values of left and right child of each node
            nodeA.LeftChild = nodeB;
            nodeA.RightChild = nodeC;
            nodeB.LeftChild = nodeD;
            nodeB.RightChild = nodeE;
            nodeE.LeftChild = nodeF;
            nodeE.RightChild = nodeG;
            nodeF.RightChild = nodeI;
            nodeC.RightChild = nodeF;

            //assert
            Assert.Equal(expected, FindMax(nodeA));
        }
    }
}
