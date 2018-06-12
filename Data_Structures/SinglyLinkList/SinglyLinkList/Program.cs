using System;

namespace SinglyLinkList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ahoy!");
            TestLL();
        }

        static void TestLL()
        {
            //Adding to the beginning of the list
            //the order will be 20 - 15 - 10
            LinkList ll = new LinkList(new Node(10));
            ll.Add(new Node(15));
            ll.Add(new Node(20));

            //Printing out the list
            //Output will be 20 - 15 - 10
            ll.Print();

            //Node found points to a reference in memory that is returned
            Node found = ll.Find(10);
            //If that value is null, then the output would be null
            //In this case, it's not null
            Console.WriteLine($"Let's find node 10 and it's at {found.Value}");
        }
    }
}
