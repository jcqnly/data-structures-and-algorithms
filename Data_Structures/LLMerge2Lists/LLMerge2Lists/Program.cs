using System;

namespace LLMerge2Lists
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Oh, hello again");
            TestLL();
        }

        public static void TestLL()
        {
            //Add() llOne
            LinkList llOne = new LinkList();
            llOne.Add(new Node(41));
            llOne.Add(new Node(10));
            llOne.Add(new Node(2));
            llOne.Add(new Node(19));

            //the order will be 19 - 2 - 10 - 41
            llOne.Print();

            //Add() llTwo
            LinkList llTwo = new LinkList();
            llTwo.Add(new Node(31));
            llTwo.Add(new Node(8));
            llTwo.Add(new Node(9));
            llTwo.Add(new Node(20));

            //the order will be 20 - 9 - 8 - 31 
            llTwo.Print();

            //creating a new link list
            llOne.Merge2(llOne, llTwo);
            Console.WriteLine("Newly merged list is: \n");
            llOne.Print();
        }
    }
}
