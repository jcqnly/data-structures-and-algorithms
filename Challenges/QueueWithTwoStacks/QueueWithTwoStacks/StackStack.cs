using System;
using System.Collections.Generic;
using System.Text;

namespace QueueWithTwoStacks
{
    public class StackStack
    {
        //establishing the properties of the StackStack
        public Node Top { get; set; }

        //set the value of the Top in this ctor
        public StackStack(Node node)
        {
            Top = node;
        }

        /// <summary>
        /// Push(add) a node to the top of a stack
        /// </summary>
        /// <param name="node"></param>
        public void Push(Node node)
        {
            //assign the Top to the next node
            node.Next = Top;
            //reassign the value of Top to the newly added node
            Top = node;
        }

        /// <summary>
        /// Remove a node from the top of the stack
        /// </summary>
        public Node Pop()
        {
            //create a reference Node that points to the same Top
            Node temp = Top;
            //reassign the value of Top to the soon-to-be top node
            Top = Top.Next;
            //set the next pointer of Temp to null, so that former top node is by itself
            temp.Next = null;
            return temp;
        }

        /// <summary>
        /// print out the nodes of the stack
        /// </summary>
        public void Print()
        {
            //establish a Node called current to help iterate through the nodes
            //without resetting what the Top value is for other methods
            Node current = Top;
            Console.WriteLine("Printing out: \n");
            //keep looping if the next value doesn't point to null
            while (current.Next != null)
            {   //if it doesn't point to null, print out the value
                Console.Write($"  {current.Value}  ");
                //set the current value to the next value to repeat the process
                current = current.Next;
            }
            Console.WriteLine($"  {current.Value}  ");
            Console.WriteLine("\n");
        }

    }
}
