using System;
using System.Collections.Generic;
using Trees;

namespace BinaryTreeMax
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //instantiating a tree to work with
            BinaryTree binaryTree = new BinaryTree();

            Node nodeA = new Node(2);
            Node nodeB = new Node(7);
            Node nodeC = new Node(5);
            Node nodeD = new Node(2);
            Node nodeE = new Node(6);
            Node nodeF = new Node(5);
            Node nodeG = new Node(11);
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

            //display the max value that was found
            Console.WriteLine(FindMax(nodeA));
            Console.Read();
        }

        /// <summary>
        /// Traverses the given tree via a breadth first route and
        /// returns the max value in the tree
        /// </summary>
        /// <param name="node"></param>
        /// <returns>max value</returns>
        public static int FindMax(Node node)
        {
            Queue<Node> breadth = new Queue<Node>();
            //enqueue the first node and set it as the initial max value
            breadth.Enqueue(node);
            int max = node.Value;

            //start traversing through the tree
            while (breadth.TryPeek(out node))
            {
                Node front = breadth.Dequeue();
                //check if the current front value is greater than the max
                if (front.Value > max)
                    max = front.Value;

                //the following 2 if statements adds the nodes to our queue
                if (front.LeftChild != null)  
                    breadth.Enqueue(front.LeftChild);
                if (front.RightChild != null)  
                    breadth.Enqueue(front.RightChild);
            }
            return max;
        }
    }
}
