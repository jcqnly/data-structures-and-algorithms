using System;

namespace array_reverse
{
    class Program
    {
        static void Main(string[] args)
        {   //hard code a given array to pass to method to reverse
            int[] givenArray = new int[] { 3, 2, 1 };
            ReverseArray(givenArray);
            Console.Read();
        }

        static int[] ReverseArray(int[] arrayToReverse)
        {
            int counter = 0;
            //set new array to the length of givenArray
            int[] reverseArray = new int[arrayToReverse.Length];
            //working from the end of givenArray
            for (int i = arrayToReverse.Length - 1; i >= 0; i--)
            {   //add that value to the beginning of the new array
                reverseArray[counter] = arrayToReverse[i];
                counter++;
            }
            //print for show
            foreach (var item in reverseArray)
            {
                Console.WriteLine(item.ToString());
            }
            return reverseArray;
        }
    }
}
