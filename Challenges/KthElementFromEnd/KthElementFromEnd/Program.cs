using System;

namespace KthElementFromEnd
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Ahoy!");
            TestLL();
            Console.Read();
        }

        /// <summary>
        /// This method will implement the following linked list concepts in order:
        /// Add(), Print(), Find(), AddBefore(), AddAfter(), AddLast()
        /// </summary>
        static void TestLL()
        {
            //Add nodes to a link list
            //the order will be 42 - 19 - 2 - 8 - 31 - 10
            LinkList ll = new LinkList();
            ll.Add(new Node(10));
            ll.Add(new Node(31));
            ll.Add(new Node(8));
            ll.Add(new Node(2));
            ll.Add(new Node(19));
            ll.Add(new Node(42));
            //Output will be 42 - 19 - 2 - 8 - 31 - 10
            Console.WriteLine("The singly linked list is: ");
            ll.Print();

            //k value that passes
            Node kEth = ll.KthElementFromEnd(5);
            Console.WriteLine($"This is the value when k is 5 from the end: {kEth.Value}\n");

            //k value that doesn't pass
            ll.KthElementFromEnd(6);
            Console.WriteLine($"This is the value when k is 6 from the end: {kEth.Value}\n");
        }
    }
}
