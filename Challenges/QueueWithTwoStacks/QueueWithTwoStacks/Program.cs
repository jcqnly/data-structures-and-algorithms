using System;

namespace QueueWithTwoStacks
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Daffodil!");
            QueueAStack();
        }

        public static void QueueAStack()
        {
            //instantiate the stacks with values
            StackStack stack1 = new StackStack
            {
                Top = new Node(20)
            };//1st node added (bottom node, so 20)

            stack1.Push(new Node(15));
            stack1.Push(new Node(10));

            //output is (top) 10   15   20 (<-20 being the first node in)
            stack1.Print();

            //Instantiate another stack to work with
            //this can be empty because we didn't define a constructor
            StackStack stack2 = new StackStack();
            //stack2 is empty


            Console.WriteLine("Enqueueing the stack:");
            //enqueueing with the push method
            Queue queue = new Queue(stack1, stack2);
            queue.Enqueue(new Node(666));

            Console.WriteLine("Dequeueing the stack:");
            //List is now:
            //666  5  10  15  20 (<-20 being the first node in)
            //Dequeue will return the FIFO value of stack1, which is 20:
            Console.WriteLine(queue.Dequeue().Value);
        }
    }
}
