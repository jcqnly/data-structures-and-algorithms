using System;
using System.Collections.Generic;
using System.Text;

namespace Trees
{
    public class BinaryTree
    {
        //public Node Root { get; set; }

        public void PreOrder(Node node)
        {
            Console.WriteLine(node.Value);

            if (node.LeftChild != null)
            {
                PreOrder(node.LeftChild);
            }

            if (node.RightChild != null)
            {
                PreOrder(node.RightChild);
            }
        }

        public void InOrder(Node node)
        {
            if (node.LeftChild != null)
            {
                InOrder(node.LeftChild);
            }

            Console.WriteLine(node.Value);

            if (node.RightChild != null)
            {
                InOrder(node.RightChild);
            }
        }

        public void PostOrder(Node node)
        {
            if (node.LeftChild != null)
            {
                PostOrder(node.LeftChild);
            }

            if (node.RightChild != null)
            {
                PostOrder(node.RightChild);
            }

            Console.WriteLine(node.Value);
        }

        public void BreadthFirst(Node node)
        {
            Queue<Node> breadth = new Queue<Node>();
            breadth.Enqueue(node);

            while (breadth.TryPeek(out node))
            {
                Node front = breadth.Dequeue();
                Console.Write(front.Value);

                if (front.LeftChild != null)
                {
                    breadth.Enqueue(front.LeftChild);
                }
                if (front.RightChild != null)
                {
                    breadth.Enqueue(front.RightChild);
                }
            }
        }

        public bool Search(Node node, int value)
        {
            Queue<Node> breadth = new Queue<Node>();
            breadth.Enqueue(node);
            Console.WriteLine($"Searching for {node.Value}");

            try
            {
                while (breadth.TryPeek(out node))
                {
                    Node front = breadth.Dequeue();
                    Console.WriteLine(front.Value);

                    if (front.LeftChild.Value == value || front.LeftChild.Value == value)
                    {
                        Console.WriteLine($"Found Node: {node.Value}");
                        return true;
                    }
                    if (front.LeftChild != null)
                    {
                        breadth.Enqueue(front.LeftChild);
                    }
                    if (front.RightChild != null)
                    {
                        breadth.Enqueue(front.RightChild);
                    }
                }
                throw new NullReferenceException();
            }
            catch (NullReferenceException)
            {
                Console.WriteLine($"Value not found");
                return false;
            }
        }

    }
}
