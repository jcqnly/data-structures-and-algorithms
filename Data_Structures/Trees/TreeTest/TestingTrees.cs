using System;
using Trees;
using Xunit;

namespace TreeTest
{
    public class TestingTrees
    {
        [Fact]//supposed to be search
        public void CanAddNodeToBST()
        {
            //act
            //instantiating a new object of the BinarySearchTree class
            BinarySearchTree binarySearchTree = new BinarySearchTree();
            //setting the values
            Node nodeA = new Node(100);
            Node nodeB = new Node(50);
            Node nodeC = new Node(150);
            Node nodeD = new Node(25);
            Node nodeE = new Node(75);
            Node nodeF = new Node(300);
            //add nodes to the tree
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
            //setting the values
            Node nodeA = new Node(100);
            Node nodeB = new Node(50);
            Node nodeC = new Node(150);
            Node nodeD = new Node(25);
            Node nodeE = new Node(75);
            Node nodeF = new Node(300);
            //add nodes to the tree
            binarySearchTree.Add(nodeA, nodeB);
            binarySearchTree.Add(nodeA, nodeC);
            binarySearchTree.Add(nodeA, nodeD);
            binarySearchTree.Add(nodeA, nodeE);
            binarySearchTree.Add(nodeA, nodeF);

            //assert
            Assert.True(binarySearchTree.Search(nodeA, 300));
        }

        [Fact]
        public void CanSearchNodeInBT()
        {
            //act
            //instantiating a new object of the BinarySearchTree class
            BinaryTree binaryTree = new BinaryTree();
            //setting the values
            Node nodeA = new Node(1);
            Node nodeB = new Node(2);
            Node nodeC = new Node(3);
            Node nodeD = new Node(4);
            Node nodeE = new Node(5);
            Node nodeF = new Node(6);
            //make the tree
            nodeA.LeftChild = nodeB;
            nodeA.RightChild = nodeC;
            nodeB.LeftChild = nodeD;
            nodeB.RightChild = nodeE;
            nodeC.LeftChild = nodeF;

            //arrange
            binaryTree.Search(nodeA, 6);

            //assert
            Assert.True(binaryTree.Search(nodeA, 6));
        }
    }
}
