using System;
using TreeIntersection;
using Xunit;

namespace TestTreeIntersection
{
    public class TreeIntersectionTest
    {
        [Theory]
        [InlineData(40000)]
        [InlineData(1)]
        [InlineData(80)]
        public void CanFindCommonValuesInTwoTrees(int value)
        {
            BinarySearchTree BST1 = new BinarySearchTree();
            //declare nodes to add to BST1
            Node nodeA = new Node(100);
            Node nodeB = new Node(50);
            Node nodeC = new Node(150);
            Node nodeD = new Node(75);
            Node nodeE = new Node(value);
            Node nodeF = new Node(25);

            BST1.Add(nodeA, nodeB);
            BST1.Add(nodeA, nodeC);
            BST1.Add(nodeA, nodeD);
            BST1.Add(nodeA, nodeE);
            BST1.Add(nodeA, nodeF);

            BinarySearchTree BST2 = new BinarySearchTree();
            //declare nodes to add to BST2
            Node nodeG = new Node(100);
            Node nodeH = new Node(50);
            Node nodeI = new Node(150);
            Node nodeJ = new Node(175);
            Node nodeK = new Node(value);
            Node nodeL = new Node(205);

            BST2.Add(nodeG, nodeH);
            BST2.Add(nodeG, nodeI);
            BST2.Add(nodeG, nodeJ);
            BST2.Add(nodeG, nodeK);
            BST2.Add(nodeG, nodeL);

            //act
            HashTable ht = new HashTable();
            ht = ht.TreeIntersection(BST1, nodeA, BST2, nodeG);

            //assert
            Assert.True(ht.Contains(value.ToString()));
        }
    }
}
