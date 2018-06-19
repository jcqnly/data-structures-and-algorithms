using System;
using System.Collections.Generic;
using System.Text;

namespace stackAndQueue
{
    public class Stack
    {
        //estalishing the properties
        public Node Top { get; set; }

        //set the value of the Top
        public Stack(Node node)
        {
            Top = node;
        }

        /// <summary>
        /// Push, add, a node to the top.  This takes O(1) time.
        /// </summary>
        /// <param name="node"></param>
        public void Push(Node node)
        {
            //assign the next property of node, to be added, to point to the top
            node.Next = Top;
            //reassign the value of top to the newly added node
            Top = node;
        }

        /// <summary>
        /// Pop, remove, a node from the top.  This takes O(1) time.
        /// the Top node will be reassigned to the node below the current top
        /// </summary>
        public Node Pop()
        {
            //create a reference that points to the same top node
            Node temp = Top;

            //reassign the value of Top to the value Next is pointing to
            Top = Top.Next;

            //set the Next pointer of temp to point to null
            temp.Next = null;
            return temp;
        }

        /// <summary>
        /// view the top node of the stack, which takes O(1) time
        /// It's best to peek before popping, otherwise a NullException
        /// error will be thrown
        /// </summary>
        public Node Peek()
        {
            return Top;
        }

        /// <summary>
        /// Print out all values in the list by iterating through until null is reached
        /// This will take O(N)
        /// </summary>
        /// <param name="node"></param>
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
