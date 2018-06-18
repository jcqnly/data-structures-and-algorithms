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

            //output will be (top) 1   41   4   9
            stack.Print();

            //Popping a node off the stack
            Console.WriteLine("The popped node is: ");
            Node poppedNode = stack.Pop();
            Console.WriteLine(poppedNode.Value);


            //Peeking at the top node of the stack
            Console.WriteLine("The peeked(top) node is: ");
            Node peekedNode = stack.Peek();
            Console.WriteLine(peekedNode.Value);

           /* 
            //instantiate queue
            Enqueue a node into your queue
            Dequeue a node off of your queue
            Peek at the front of your queue.*/

        }
    }
}
