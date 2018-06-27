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

            FizzBuzzTree(nodeA);
        }

        public static Node FizzBuzzTree(Node node)
        {
            Console.WriteLine(node.Value);
            Int32.TryParse(node.Value, out int valueOfNode);
            if (valueOfNode % 5 == 0 && valueOfNode % 3 == 0)
            {
                node.Value = "FizzBuzz";
            } else if (valueOfNode%3 == 0)
            {
                node.Value = "Fizz";
            } else if (valueOfNode%5 == 0)
            {
                node.Value = "Buzz";
            }

            if (node.LeftChild != null)
            {
                FizzBuzzTree(node.LeftChild);
            }

            if (node.RightChild != null)
            {
                FizzBuzzTree(node.RightChild);
            }
            return node;
        }
    }
}
