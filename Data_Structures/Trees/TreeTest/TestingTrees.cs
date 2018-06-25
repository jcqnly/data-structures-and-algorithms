using System;
using Trees;
using Xunit;

namespace TreeTest
{
    public class TestingTrees
    {
        [Fact]
        public void CanAddNodeToBST()
        {
            //act
            BinarySearchTree binarySearchTree = new BinarySearchTree();

            Node nodeA = new Node(100);
            Node nodeB = new Node(50);
            Node nodeC = new Node(150);
            Node nodeD = new Node(25);
            Node nodeE = new Node(75);
            Node nodeF = new Node(300);
            binarySearchTree.Add(nodeA, nodeB);
            binarySearchTree.Add(nodeA, nodeC);
            binarySearchTree.Add(nodeA, nodeD);
            binarySearchTree.Add(nodeA, nodeE);
            binarySearchTree.Add(nodeA, nodeF);

            //arrange
            Node nodeG = new Node(200);
            binarySearchTree.Add(nodeA, nodeG);

            //assert
            Assert.Equal(nodeG, binarySearchTree.Add(nodeA, nodeG));
        }

        [Fact]
        public void CanFindNodeInBST()
        {
            //act
            //instantiating a new object of the BinarySearchTree class
            BinarySearchTree binarySearchTree = new BinarySearchTree();

            Node nodeA = new Node(100);
            Node nodeB = new Node(50);
            Node nodeC = new Node(150);
            Node nodeD = new Node(25);
            Node nodeE = new Node(75);
            Node nodeF = new Node(300);

            binarySearchTree.Add(nodeA, nodeB);
            binarySearchTree.Add(nodeA, nodeC);
            binarySearchTree.Add(nodeA, nodeD);
            binarySearchTree.Add(nodeA, nodeE);
            binarySearchTree.Add(nodeA, nodeF);

            //assert
            Assert.True(binarySearchTree.Search(nodeA, 150));
        }

        [Fact]
        public void CanAddNodeInBT()
        {
            //act
            //instantiating a new object of the BinarySearchTree class
            BinaryTree binaryTree = new BinaryTree();
            //setting the values, so we can get a visualization
            Node nodeA = new Node(1);
            Node nodeB = new Node(2);
            Node nodeC = new Node(3);
            Node nodeD = new Node(4);
            Node nodeE = new Node(5);
            Node nodeF = new Node(6);

            //arrange
            binaryTree.Search(nodeA, 1);

            //assert
            Assert.Equal(1, nodeA.Value);
        }
    }
}
