using System;

namespace Trees
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            BinarySearch();
        }

        static void BinarySearch()
        {
            //instantiating a new object of the BinarySearchTree class
            BinaryTree binaryTree = new BinaryTree();
            //setting the values, so we can get a visualization
            Node nodeA = new Node(1);
            Node nodeB = new Node(2);
            Node nodeC = new Node(3);
            Node nodeD = new Node(4);
            Node nodeE = new Node(5);
            Node nodeF = new Node(6);

            //setting the values of left and right child of each node
            nodeA.LeftChild = nodeB;
            nodeA.RightChild = nodeC;
            nodeB.LeftChild = nodeD;
            nodeB.RightChild = nodeE;
            nodeC.LeftChild = nodeF;

            Console.WriteLine("PreOrder: ");
            //PreOrder, output values should be in the following order:
            //A, B, D, E, C, F
            //1, 2, 4, 5, 3, 6
            binaryTree.PreOrder(nodeA);

            Console.WriteLine("InOrder: ");
            //InOrder, output values should be in the following order:
            //D, B, E, A, F, C
            //4, 2, 5, 1, 6, 3
            binaryTree.InOrder(nodeA);

            Console.WriteLine("PostOrder: ");
            //PostOrder, output values should be in the following order:
            //D, E, B, F, C, A
            //4, 5, 2, 6, 3, 1
            binaryTree.PostOrder(nodeA);

            Console.WriteLine("BreadthFirst: ");
            //Breadth, output values should be in the following order:
            //A, B, C, D, E, F
            //1, 2, 3, 4, 5, 6
            binaryTree.BreadthFirst(nodeA);

            Console.WriteLine($"Searching a Binary Tree for a value: ");
            binaryTree.Search(nodeA, 1);
        }
    }
}
