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

        /// <summary>
        /// Merge 2 given singly linked lists
        /// </summary>
        /// <param name="llOne"></param>
        /// <param name="llTwo"></param>
        public void Merge2(LinkList llOne, LinkList llTwo)
        {
            //set the head to the current node of each of the 2 created lists
            llOne.Current = llOne.Head;
            llTwo.Current = llTwo.Head;
            //create the 3rd link list to store information to
            LinkList llThree = new LinkList();
            //add the value of the current node of llOne as the first node of llThree
            llThree.Add(new Node(llOne.Current.Value));
            //set the value of the next node of llTwo as the 2nd node of llThree
            llThree.AddLast(new Node(llTwo.Current.Value));
            //reset the Current nodes of both llOne and llTwo
            llOne.Current = llOne.Current.Next;
            llTwo.Current = llTwo.Current.Next;

            //Loop through both llOne and llTwo as long as neither is not null
            while (llOne.Current.Next != null || llTwo.Current.Next != null)
            {
                //if the current value of llOne is not null
                if (llOne.Current != null)
                {   //add the value of that node to the end llThree
                    llThree.AddLast(new Node(llOne.Current.Next.Value));
                    //reset the Current pointer to the next node of llOne
                    llOne.Current = llOne.Current.Next;
                }
                //if the current value of llTwo is not null
                if (llTwo.Current.Next != null)
                {
                    //add the value of that node to the end llThree
                    llThree.AddLast(new Node(llTwo.Current.Next.Value));
                    //reset the Current pointer to the next node of llTwo
                    llTwo.Current = llTwo.Current.Next;
                }
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
