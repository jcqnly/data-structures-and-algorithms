using System;

namespace array_binary_search
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] givenArray = new int[] { 4, 8, 15, 16, 23, 42};
            int key = 100;
            //pass the givenArray and key to the method to search
            int result = BinarySearch(givenArray, key);
            //assign the BinarySearch method call to result in order for the returned -1 to show
            Console.WriteLine(result);
            Console.ReadLine();
        }

        public static int BinarySearch(int[] arrayToSearch, int key)
        {   
            int max = arrayToSearch.Length;
            int min = 0;
            for (var i = 0; i <= arrayToSearch.Length-1; i++)
            {   //reset the mid every time the key is not found
                int mid = (min + max) / 2;
                //if the array at that mid value == key, return that index
                if (arrayToSearch[mid] == key)
                {
                    Console.WriteLine(mid);
                    return mid;
                }
                //if the array at that mid value > key, set the new max value to that mid
                if (arrayToSearch[mid] > key)
                {
                    max = mid;
                }
                //if the array at that mid value < key, set the new min value to that mid
                if (arrayToSearch[mid] < key)
                {
                    min = mid;
                }
            }
            return -1;
        }
    }
}
