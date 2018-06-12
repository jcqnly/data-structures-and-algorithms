using System;
using System.Collections.Generic;
using System.Text;

namespace SinglyLinkList
{
    class LinkList
    {
        public Node Head { get; set; }

        public Node Current { get; set; }

        /// <summary>
        /// Set the initial values of Head and Current to the beginnig of the list
        /// </summary>
        /// <param name="node"></param>
        public LinkList(Node node)
        {   //set the initial Head and Current to point to the same nade
            Head = node;
            Current = node;
        }

        /// <summary>
        /// Add a node to the beginning of a list, which will take O(1) time
        /// </summary>
        /// <param name="node"></param>
        public void Add(Node node)
        {   //move the Head to the next node in line
            node.Next = Head;
            //ADD EXPLANATION
            Head = node;
            Current = Head;
        }

        //Finding a node O(N)
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
        {   //set the Head to the Current as a starting point:
            Current = Head;
            //keep looping if the next value doesn't point to null
            while (Current.Next != null)
            {   //if it doesn't point to null, print out the value
                Console.Write($"{Current.Value} -- ");
                //set the current value to the next value to repeat the process
                Current = Current.Next;
            }

            //to visually see which is the last node pointing to null
            Console.Write($"{Current.Value}");
        }

        /// <summary>
        /// Add a node before a given value, which takes O(N) time
        /// existingNode is the search key, so that we can put the newNode in front of it
        /// </summary>
        /// <param name="newNode"></param>
        /// <param name="existingNode"></param>
        public void AddBefore(Node newNode, Node existingNode)
        { //set the Head to the Current as a starting point:
            Current = Head;
            //accounting if the list is only 1 node long:
            if (Head.Value == existingNode.Value)
            {
                Add(newNode);
                return;
            }
            ///keep looping if the next value doesn't point to null
            while (Current.Next != null)
            { //if the current pointer is pointing to the search key
                //then set the next node to point to the search key
                //then point the current node to the new node
                if (Current.Next.Value == existingNode.Value)
                {
                    newNode.Next = Current.Next;
                    Current.Next = newNode;
                    return;
                }
                //this keeps traversing if the search key is not found
                Current = Current.Next;
            }
        }

        //Add after O(N)
        /// <summary>
        /// Add a new node after a given value
        /// existingNode is the search key, so that we can put the newNode in front of it
        /// </summary>
        /// <param name="newNode"></param>
        /// <param name="existingNode"></param>
        public void AddAfter(Node newNode, Node existingNode)
        {//set the Head to the Current as a starting point:
            Current = Head;
            //accounting if the list is only 1 node long:
            if (Head.Value == existingNode.Value)
            {
                Current.Next = newNode;
                return;
            }
            //keep traversing if the last node is not encountered
            while (Current.Next != null)
            {
                if (Current.Value == existingNode.Value)
                {
                    newNode.Next = existingNode.Next;
                    existingNode.Next = newNode;
                }
                Current = newNode;
            }

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
