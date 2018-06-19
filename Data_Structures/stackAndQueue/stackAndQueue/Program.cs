using System;

namespace stackAndQueue
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //instantiate stack and push(add) a few nodes
            Stacks stacks = new Stacks(new Node(9));
            stacks.Push(new Node(4));
            stacks.Push(new Node(41));
            stacks.Push(new Node(1));

            Console.WriteLine("The stack we'e working with is: ");
            //output will be (top) 1    41    4    9
            stacks.Print();

            Console.WriteLine("The popped node is: ");
            //Popping a node off the stack
            Node poppedNode = stacks.Pop();
            Console.WriteLine(poppedNode.Value);


            Console.WriteLine("The peeked(top) node is: ");
            //Peeking at the top node of the stack
            Node peekedNode = stacks.Peek();
            Console.WriteLine(peekedNode.Value);

            //instantiate queue and enqueue (add) a few nodes
            Queue queue = new Queue(new Node(100));
            queue.Enqueue(new Node(666));
            queue.Enqueue(new Node(222));
            queue.Enqueue(new Node(444));

            //output will be 100   666   222   444
            Console.WriteLine("The queue we'e working with is: ");
            queue.Print();

            Console.WriteLine("The dequeued(removed) node is: ");
            //Dequeue a node off of the queue
            Node dequeuedNode = queue.Dequeue();
            Console.WriteLine(dequeuedNode.Value);

            Console.WriteLine("The front of the queue is: ");
            //Peek at the front of your queue.
            Node frontNode = queue.Peek();
            Console.WriteLine(frontNode.Value);
        }
    }
}
