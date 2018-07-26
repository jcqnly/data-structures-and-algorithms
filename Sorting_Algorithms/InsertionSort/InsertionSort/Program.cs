using InsertionSort.Classes;
using System;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //create an array to work with
            int[] unsortedArray = new int[] { 4, 10, 9, 2, 7, 6, 1, 5, 3, 8 };

            //call insertion sort
            Sort insertionSort = new Sort();

            //pass the unsorted array to the InsertionSort method in the Sort class
            int[] sortedArray = insertionSort.InsertionSort(unsortedArray);

            //output sorted contents
            for (int i = 0; i < sortedArray.Length; i++)
            {
                Console.WriteLine($"{sortedArray[i]}");
            }
        }
    }
}
