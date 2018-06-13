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
            LinkList ll = new LinkList(new Node(10));
            ll.Add(new Node(31));
            ll.Add(new Node(8));
            ll.Add(new Node(2));
            ll.Add(new Node(19));
            ll.Add(new Node(42));

            //passing a k value to KthElementFromEnd()
            Node kEth = ll.KthElementFromEnd(0);
            Console.WriteLine($"Let's find K element and it's {kEth.Value}\n");

            //Output will be 4219 - 2 - 8 - 31 - 10
            ll.Print();
        }
    }
}
