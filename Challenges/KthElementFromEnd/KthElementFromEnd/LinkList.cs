using System;
using System.Collections.Generic;
using System.Text;

namespace KthElementFromEnd
{
    public class LinkList
    {
        public Node Head { get; set; }
        public Node Current { get; set; }

        /// <summary>
        /// Establish where Head and Current start
        /// </summary>
        /// <param name="node"></param>
        public void SinglyLinkList(Node node)
        {
            Head = node;
            Current = node;
        }

        /// <summary>
        /// Returns the K-th element from the end of a singly linked list
        /// </summary>
        /// <param name="k"></param>
        /// <returns></returns>
        public Node KthElementFromEnd(int k)
        {
            //set a counter to count the length of the given linked list
            int counter = 0;
            //set the head to where Current is
            Current = Head;
            //as long as it's not the end, increment the counter 
            while (Current.Next != null)
            {
                counter++;
                //set the Current to the next node
                Current = Current.Next;
            }
            //set another counter to increment up to the position, which is counter - k
            int counter2 = 0;
            Current = Head;
            //as long as the 2nd counter is less than the position, increment the counter
            while (counter2 < (counter - k))
            {
                
                Current = Current.Next;
                counter2++;
              
            }
            //add excetpion handling for when k exceeds the length of the linked list
            if (k > counter)
            {
                throw new ArgumentException("The given k value is longer than the length of the singly linked list", nameof(k));
            }
            //Current will be on the node that's k from the end after the 2nd while loop
            return Current;
        }

        /// <summary>
        /// Add a node to the beginning of a list, which will take O(1) time
        /// </summary>
        /// <param name="node"></param>
        public void Add(Node node)
        {
            //point the head to Current
            Current = Head;
            //move the Head to the next node in line
            node.Next = Head;
            //set the node, to add, as the Head
            Head = node;
            //point the head to Current
            Current = Head;
        }


        /// <summary>
        /// Print out all values in the list by iterating through until null is reached
        /// This will take O(N)
        /// </summary>
        /// <param name="node"></param>
        public void Print()
        {
            //set the Head to the Current as a starting point:
            Current = Head;
            //keep looping if the next value doesn't point to null
            while (Current.Next != null)
            {   //if it doesn't point to null, print out the value
                Console.Write($"  {Current.Value}  ");
                //set the current value to the next value to repeat the process
                Current = Current.Next;
            }
            Console.Write($"  {Current.Value}  ");
            Console.WriteLine("\n");
        }
    }
}
