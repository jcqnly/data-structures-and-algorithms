using System;

namespace FizzBuzzTree
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //instantiating a tree to work with
            BinaryTree binaryTree = new BinaryTree();

            Node nodeA = new Node("15");
            Node nodeB = new Node("3");
            Node nodeC = new Node("5");
            Node nodeD = new Node("4");
            Node nodeE = new Node("51");
            Node nodeF = new Node("60");

            //setting the values of left and right child of each node
            nodeA.LeftChild = nodeB;
            nodeA.RightChild = nodeC;
            nodeB.LeftChild = nodeD;
            nodeB.RightChild = nodeE;
            nodeC.LeftChild = nodeF;

            //call the method that will test the tree's fizzbuzzyness
            BinaryTree.FBTree(nodeA);

            Console.WriteLine("Printing the new tree via the preorder traversal : ");
            binaryTree.PreOrder(nodeA);
        }
    }
}