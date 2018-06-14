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

        static void TestLL()
        {
            //Add() llOne
            LinkList llOne = new LinkList();
            llOne.Add(new Node(31));
            llOne.Add(new Node(8));
            llOne.Add(new Node(2));
            llOne.Add(new Node(19));

            //the order will be 19 - 2 - 8 - 31
            llOne.Print();

            //Add() llTwo
            LinkList llTwo = new LinkList();
            llTwo.Add(new Node(31));
            llTwo.Add(new Node(8));
            llTwo.Add(new Node(2));
            llTwo.Add(new Node(19));

            //the order will be 19 - 2 - 8 - 31 
            llTwo.Print();

            //creating a new link list
            LinkList llThree = new LinkList();
            //passing the first and second linked list into the merge method found in LinkList.cs
            llThree.Merge2(llOne, llTwo);

        }
    }
}
