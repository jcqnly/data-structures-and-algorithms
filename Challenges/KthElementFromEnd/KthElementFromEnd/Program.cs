using System;

namespace KthElementFromEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ahoy!");
            TestLL();
        }

        /// <summary>
        /// This method will implement the following linked list concepts in order:
        /// Add(), Print(), Find(), AddBefore(), AddAfter(), AddLast()
        /// </summary>
        static void TestLL()
        {
            //Add()
            //the order will be 19 - 2 - 8 - 31 - 10
            LinkList ll = new LinkList(new Node(10));
            ll.Add(new Node(31));
            ll.Add(new Node(8));
            ll.Add(new Node(2));
            ll.Add(new Node(19));

            //Print()
            //Output will be 19 - 2 - 8 - 31 - 10
            ll.Print();

            //Find()
            //found points to a reference in memory that is returned
            //If that value is null, then the output would be null
            //In this case, it's not null
            //finding where 31 is:
            Node found = ll.Find(31);
            Console.WriteLine($"Let's find node 31 and it's at {found.Value}\n");

            //AddBefore()
            Console.WriteLine("AddBefore()");
            ll.AddBefore(new Node(33), new Node(2));
            ll.Print();

            //AddAfter()
            Console.WriteLine("AddAfter()");
            ll.AddAfter(new Node(10101), new Node(8));
            ll.Print();

            //AddLast()
            Console.WriteLine("AddLast()");
            ll.AddLast(new Node(666));
            ll.Print();
        }
    }
}
