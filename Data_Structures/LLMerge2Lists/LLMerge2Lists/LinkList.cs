using System;
using System.Collections.Generic;
using System.Text;

namespace LLMerge2Lists
{
    public class LinkList
    {
        public Node Head { get; set; }
        public Node Current { get; set; }
        //Runner nodes as additional points
        public Node Runner1 { get; set; }
        public Node Runner2 { get; set; }

        /// <summary>
        /// Set the initial values of Head and Current to the beginnig of the list
        /// </summary>
        /// <param name="node"></param>
        public void SinglyLinkList(Node node)
        {
            Head = node;
            Current = node;
        }

        /// <summary>
        /// Merge 2 given singly linked lists
        /// </summary>
        /// <param name="llOne"></param>
        /// <param name="llTwo"></param>
        public Node Merge2(LinkList llOne, LinkList llTwo)
        {
            //set an initial value for the runner nodes
            Runner1 = llOne.Head;
            Runner2 = llTwo.Head;
            //set an initial value for the current nodes of each list
            llOne.Current = llOne.Head;
            llTwo.Current = llTwo.Head;

            //Loop through both llOne and llTwo as long as the next node neither is not null
            while ((llOne.Current.Next != null) && (llTwo.Current.Next != null))
            {
                //move the runner nodes along both lists
                Runner1 = llOne.Current.Next;
                Runner2 = llTwo.Current.Next;
                //this will place the node of llOne before the nodes of llTwo
                llOne.Current.Next = llTwo.Current;
                //point the node on llTwo to the runner, which is pointing to the next node in llOne
                llTwo.Current.Next = Runner1;
                //reset the nodes of both lists
                llTwo.Current = Runner2;
                llOne.Current = Runner1;
            }
            //accounting for when 1 list is longer than the other
            if ((llTwo.Current.Next == null) && (llOne.Current.Next != null))
            {
                //set the final node of llTwo as the node of the next node along llOne
                llTwo.Current.Next = llOne.Current.Next;
                llOne.Current.Next = llTwo.Current;
            }//if the opposite condition is true, then...
            else
            {
                //set the findal node of llOneto the current node at llTwo
                llOne.Current.Next = llTwo.Current;
            }
            return llOne.Head;          
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
        /// Find a node, which takes O(N) time
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public Node Find(int value)
        {   //set the Head to the Current as a starting point:
            Current = Head;
            //keep looping if the next value doesn't point to null
            while (Current.Next != null)
            {   //if that value is value we're looking for, return it
                if (Current.Value == value)
                {
                    return Current;
                }
                //otherwise, set the current value to the next one to repeat the process
                Current = Current.Next;
            }
            //If the while condition doesn't hit, it means we're at the last node
            //if the last value is the one we're looking for, return it
            //otherwise, retun null because the value is not in the list
            return Current.Value == value ? Current : null;
        }

        /// <summary>
        /// Print out all values in the list by iterating through until null is reached
        /// This will take O(N)
        /// </summary>
        /// <param name="node"></param>
        public void Print()
        {
            Console.WriteLine("Printing out: \n");
            //set the Head to the Current as a starting point:
            Current = Head;
            //keep looping if the next value doesn't point to null
            while (Current.Next != null)
            {   //if it doesn't point to null, print out the value
                Console.Write($"  {Current.Value}  ");
                //set the current value to the next value to repeat the process
                Current = Current.Next;
            }
            Console.WriteLine($"  {Current.Value}  ");
            Console.WriteLine("\n");
        }

        /// <summary>
        /// Add a node to the end of the linked list, which will take O(N) time
        /// </summary>
        /// <param name="newNode">this is what we're adding</param>
        public void AddLast(Node newNode)
        {   //set the Head to the Current as a starting point:
            Current = Head;
            //this will keep traversing until the last node is found
            while (Current.Next != null)
            {   //resets current to the next value to repeat the process
                Current = Current.Next;
            }
            //when that last node is found, set its pointer to new node
            Current.Next = newNode;
        }
    }
}
