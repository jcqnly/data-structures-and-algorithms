using System;
using System.Collections.Generic;
using System.Text;

namespace FIFOanimalShelterQueue
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
        public Node Dequeue(string pref)
        {
            //declare a current reference point to the Front
            Node current = Front;
            //if pref is neither cat or dog, return the front animal
            if (pref != "cat" && pref != "dog")
            {
                //reassign Front to the next node that the node Front is pointing to
                Front = Front.Next;
                //reassign the Next property on the Temp node to null, so we can pop it off
                current.Next = null;
                return current;
            }
            else if (pref == "dog" || pref == "cat")
            { //pref matches the first animal in line, so let's remove it
                if (Front.AnimalType == pref)
                {
                    Front = Front.Next;
                    current.Next = null;
                    return current;
                } //otherwise keep looking:
                while (current.Next != null && current.Next.AnimalType != pref)
                {   //keep moving along the queue if it's not the end of the queue
                    //and the next animal in line is not what they want
                    current = current.Next;
                }
                if (current.Next == null)//it's the end of the queue
                {
                    current = Front;
                    Front = Front.Next;
                    current.Next = null;
                    return current;
                }
            }       
            //if this hits, it means we've found what they're looking for
            Node temp = current.Next;
            current.Next = temp.Next;
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
            //keep looping if the next value doesn't point to null
            while (current.Next != null)
            {   //if it doesn't point to null, print out the value
                Console.Write($"  {current.AnimalType}  ");
                //set the current value to the next value to repeat the process
                current = current.Next;
            }
            Console.WriteLine($"  {current.AnimalType}  ");
            Console.WriteLine("\n");
        }
    }
}