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
            FBTree(nodeA);

            Console.WriteLine("Printing the new tree via the preorder traversal : ");
            binaryTree.PreOrder(nodeA);
        }

        /// <summary>
        /// traverses the tree with using a preorder route and
        /// determines if a tree's fizzbuzzyness
        /// </summary>
        /// <param name="node"></param>
        /// <returns>node</returns>
        public static Node FBTree(Node node)
        {
            Console.WriteLine(node.Value);
            //convert the node's value to an int
            Int32.TryParse(node.Value, out int valueOfNode);
            if (valueOfNode % 5 == 0 && valueOfNode % 3 == 0)
            {   //test for the strictest condition first
                node.Value = "FizzBuzz";
            }
            else if (valueOfNode % 3 == 0)
            {   //then test if the int is divisible by 3
                node.Value = "Fizz";
            }
            else if (valueOfNode % 5 == 0)
            {   //then test if the int is divisible by 5
                node.Value = "Buzz";
            }
            if (node.LeftChild != null)
            {   //keep calling the method to continue traversing
                //the tree if there are still nodes on either
                //side
                FBTree(node.LeftChild);
            }

            if (node.RightChild != null)
            {
                FBTree(node.RightChild);
            }
            return node;
        }
    }
}
