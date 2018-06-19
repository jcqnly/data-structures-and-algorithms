using System;

namespace QueueWithTwoStacks
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Daffodil!");
            EnqueueAStack();
            DequeueAStack();
        }

        public static void EnqueueAStack()
        {
            //instantiate the stacks
            StackStack stack1 = new StackStack(new Node(20));
            stack1.Push(new Node(15));
            stack1.Push(new Node(10));

            //output is 10   15   20
            stack1.Print();

            Console.WriteLine("Enqueueing with the push method:");
            //enqueueing with the push method
            stack1.Push(new Node(5));

            //output will be 5  10  15  20
            stack1.Print();

            //HOW TO PUSH TO AN EMPTY STACK?


        }

        public static void DequeueAStack()
        {

        }
    }
}
