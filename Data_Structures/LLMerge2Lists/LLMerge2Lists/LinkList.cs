using System;
using System.Collections.Generic;
using System.Text;

namespace LLMerge2Lists
{
    public class LinkList
    {
        public Node Head { get; set; }
        public Node Current { get; set; }

        /// <summary>
        /// Set the initial values of Head and Current to the beginnig of the list
        /// </summary>
        /// <param name="node"></param>
        public void SinglyLinkList(Node node)
        {
            Head = node;
            Current = node;
        }

        public void Merge2(LinkList llOne, LinkList llTwo)
        {
            llOne.Current = llOne.Head;
            llTwo.Current = llTwo.Head;
            LinkList llThree = new LinkList();
            llThree.Add(llOne.Current);
            llThree.AddLast(llTwo.Current);
            llOne.Current = llOne.Current.Next;
            llTwo.Current = llTwo.Current.Next;

            while (llOne.Current.Next != null || llTwo.Current.Next != null)
            {
                if (llOne.Current != null)
                {
                    Console.WriteLine("in beginning first if");
                    llThree.AddLast(new Node(llOne.Current.Next.Value));
                    Console.WriteLine("in first if");
                    llOne.Current = llOne.Current.Next;
                }

                if (llTwo.Current.Next != null)
                {
                    Console.WriteLine("in beginning second if");
                    llThree.AddLast(new Node(llTwo.Current.Next.Value));
                    Console.WriteLine("in second if");
                    llTwo.Current = llTwo.Current.Next;
                }
                Console.WriteLine("out");
            }
            Console.WriteLine("The newly merged list is: \n");
            llThree.Print();
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
            Console.WriteLine(Current.Value);
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
