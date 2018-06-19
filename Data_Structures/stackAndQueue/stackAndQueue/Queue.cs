using System;
using System.Collections.Generic;
using System.Text;

namespace stackAndQueue
{
    public class Queue
    {
        //giving the class the prop
        public Node Rear { get; set; }
        public Node Front { get; set; }

        //requirements for instantiation of a Queue
        public Queue(Node node)
        {
            Front = node;
            Rear = node;
        }

        /// <summary>
        /// Enqueue (Add) a new node to the rear of the list
        /// The time complexity is O(1)
        /// </summary>
        /// <param name="node"></param>
        public void Enqueue(Node node)
        {
            //set the current rear's next, as a reference, to the node that is being added
            Rear.Next = node;
            //reassign that rear value to the node that is added
            Rear = node;
        }

        /// <summary>
        /// Dequeue (remove) a node from the front of the list
        /// The time complexity is O(1)
        /// </summary>
        /// <param name="node"></param>
        public Node Dequeue()
        {
            //create a reference point, Temp, and point it 
            //to the same node that Front is pointing at
            Node temp = Front;
            //reassign Front to the next node that the node Front is pointing to
            Front = Front.Next;
            //reassign the Next property on the Temp node to null, so that its Next prop
            //is not pointing to anything
            temp.Next = null;
            return temp;
        }

        /// <summary>
        /// Looks at the front value of the queue
        /// </summary>
        public Node Peek()
        {
            return Front;
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
            Node current = Front;
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
