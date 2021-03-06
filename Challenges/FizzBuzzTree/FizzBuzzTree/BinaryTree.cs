﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzzTree
{
    public class BinaryTree
    {
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

        /// <summary>
        /// This traversal method checks the root first
        /// </summary>
        /// <param name="node"></param>
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

        /// <summary>
        /// This traversal method checks the root node
        /// in between checking the left and right child nodes
        /// </summary>
        /// <param name="node"></param>
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

        /// <summary>
        /// This traversal method checks the root node last
        /// </summary>
        /// <param name="node"></param>
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

        /// <summary>
        /// Searches the tree, level by level, node by node
        /// </summary>
        /// <param name="node"></param>
        public void BreadthFirst(Node node)
        {
            Queue<Node> breadth = new Queue<Node>();
            breadth.Enqueue(node);

            while (breadth.TryPeek(out node))
            {   //put the reference node front in the dequeue
                Node front = breadth.Dequeue();
                Console.Write(front.Value);
                //if there is something, enqueue that front's left child
                if (front.LeftChild != null)
                {
                    breadth.Enqueue(front.LeftChild);
                }//if there is something, enqueue that front's right child
                if (front.RightChild != null)
                {
                    breadth.Enqueue(front.RightChild);
                }
            }
        }

        /// <summary>
        /// This searches the tree, layer by layer,
        /// node by node, for the given search value
        /// </summary>
        /// <param name="node"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool Search(Node node, string value)
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
                    {//if it's the root, return the root
                        Console.WriteLine($"Found Node: {node.Value}");
                        return true;
                    }//otherwise check the value of both the left and right child
                    if (front.LeftChild.Value == value || front.RightChild.Value == value)
                    {
                        Console.WriteLine($"Found Node: {node.Value}");
                        return true;
                    }//if the value is not there, recursively traverse the nodes
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
            {//this is for when the search value is no where in the tree
                Console.WriteLine($"Value not found");
                return false;
            }
        }
    }
}