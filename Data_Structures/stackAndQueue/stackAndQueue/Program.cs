using System;

namespace stackAndQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //instantiate stack and push(add) a few nodes
            Stack stack = new Stack(new Node(9));
            stack.Push(new Node(4));
            stack.Push(new Node(41));
            stack.Push(new Node(1));

            //output will be (top) 1    41    4    9
            Console.WriteLine("The stack we'e working with is: ");
            stack.Print();

            //Popping a node off the stack
            Console.WriteLine("The popped node is: ");
            Node poppedNode = stack.Pop();
            Console.WriteLine(poppedNode.Value);


            //Peeking at the top node of the stack
            Console.WriteLine("The peeked(top) node is: ");
            Node peekedNode = stack.Peek();
            Console.WriteLine(peekedNode.Value);

            //instantiate queue and enqueue (add) a few nodes
            Queue queue = new Queue(new Node(100));
            queue.Enqueue(new Node(666));
            queue.Enqueue(new Node(222));
            queue.Enqueue(new Node(444));

            //output will be 100   666   222   444
            Console.WriteLine("The queue we'e working with is: ");
            queue.Print();

            //Dequeue a node off of the queue
            Console.WriteLine("The dequeued(removed) node is: ");
            Node dequeuedNode = queue.Dequeue();
            Console.WriteLine(dequeuedNode.Value);

            //Peek at the front of your queue.
            Console.WriteLine("The front of the queue is: ");
            Node frontNode = queue.Peek();
            Console.WriteLine(frontNode.Value);

        }
    }
}
