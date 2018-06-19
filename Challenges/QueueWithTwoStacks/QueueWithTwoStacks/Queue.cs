using System;
using System.Collections.Generic;
using System.Text;

namespace QueueWithTwoStacks
{
    public class Queue
    {
        //Since Queue will take in 2 stacks that we're working with
        //2 stack properties
        public StackStack Stack1 { get; set; }
        public StackStack Stack2 { get; set; }
        //get the property values of the 2 stacks we're working with
        public Queue(StackStack stack1, StackStack stack2)
        {
            Stack1 = stack1;
            Stack2 = stack2;
        }

        //Enqueue(value) inserts a value to the top of the stack
        public void Enqueue(Node node)
        {
            Stack1.Push(node);
            Console.WriteLine($"THe return node is {node.Value}");
        }

        //Dequeue() returns the first value that was placed into stack1
        public Node Dequeue()
        {
            //keep going through stack1 until we reach the bottom
            while (Stack1.Top.Next != null)
            {
                Stack2.Push(Stack1.Pop());
                //this looping mechanism will only leave one node behind...
            }
            //which is this node, so it'll be popped off
            //Since this method returns a node, we init a Node that references it
            //so we can return this node.  This is the node WE WANT
            Node returnNode = Stack1.Pop();

            //this will put all the guts of stack1 back from stack2
            while (Stack2.Top != null)
            {
                Stack1.Push(Stack2.Pop());
            }

            return returnNode;
        }

    }
}
