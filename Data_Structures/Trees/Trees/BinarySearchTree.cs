using System;
using System.Collections.Generic;
using System.Text;

namespace Trees
{
    public class BinarySearchTree
    {
        /// <summary>
        /// Use the breadth traversal method to search for a given value
        /// </summary>
        /// <param name="node"></param>
        /// <param name="value"></param>
        /// <returns></returns>
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
                    if (front.Value == value)
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
        /// <summary>
        /// Returns the new node that was added for each condition
        /// </summary>
        /// <param name="root"></param>
        /// <param name="newNode"></param>
        /// <returns></returns>
        public Node Add(Node root, Node newNode)
        {
            //if there is no tree, make the newNode the root
            if (root == null)
            {
                root = newNode;
                Console.WriteLine($"Root is: {root.Value}");
                return newNode;
            }
            if (newNode.Value < root.Value)
            {
                if (root.LeftChild != null)
                {
                    //Console.WriteLine($" {newNode.Value} <--");
                    //call the method again to check newNode against the
                    //the LeftChild of the node that was just checked
                    Add(root.LeftChild, newNode);
                }
                else//otherwise append it
                {
                    root.LeftChild = newNode;
                    Console.WriteLine($" {newNode.Value} <--");
                }
                return newNode;
            }

            if (newNode.Value > root.Value)
            {
                if (root.RightChild != null)
                {
                    //Console.WriteLine($" --> {newNode.Value}");
                    //call the method again to check newNode against the
                    //the RightChild of the node that was just checked
                    Add(root.RightChild, newNode);
                }
                else//otherwise append it
                {
                    root.RightChild = newNode;
                    Console.WriteLine($" --> {newNode.Value}");
                }
                return newNode;
            }
            
            return root;
        }
    }
}
