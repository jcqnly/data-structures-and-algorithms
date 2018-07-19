using System;
using System.Collections.Generic;
using System.Text;

namespace TreeIntersection
{
    public class BinarySearchTree
    {
        /// <summary>
        /// Returns the new node that was added for each condition
        /// </summary>
        /// <param name="root">root</param>
        /// <param name="newNode">newNode</param>
        /// <returns>root</returns>
        public Node Add(Node root, Node newNode)
        {
            //if there is no tree, make the newNode the root
            if (root == null)
            {
                root = newNode;
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
                }
                return newNode;
            }
            return root;
        }

        /// <summary>
        /// Searches the tree, level by level, node by node
        /// </summary>
        /// <param name="node">node</param>
        public HashTable BreadthFirst(Node node)
        {
            HashTable ht = new HashTable();
            Queue<Node> breadth = new Queue<Node>();
            breadth.Enqueue(node);

            while (breadth.TryPeek(out node))
            {   //put the reference node front in the dequeue
                Node front = breadth.Dequeue();
                ht.Add(front.Value.ToString(), 0);
                //if there is something, enqueue that front's left child
                if (front.LeftChild != null)
                {
                    ht.Add(front.LeftChild.Value.ToString(), 0);
                    breadth.Enqueue(front.LeftChild);
                }//if there is something, enqueue that front's right child
                if (front.RightChild != null)
                {
                    ht.Add(front.RightChild.Value.ToString(), 0);
                    breadth.Enqueue(front.RightChild);
                }
            }
            return ht;
        }

    }
}
