using System;
using System.Collections.Generic;
using System.Text;

namespace HashTables
{
    public class HashTable
    {
        public void Add(int[] arr, int wordValue, string word)
        {
            int index = arr.Length % wordValue;
            Console.WriteLine($"Length of array is: {arr.Length}");
            Console.WriteLine($"The word is: {word} and its ASCII value is: {wordValue}");
            Console.WriteLine($"Index in array is: {index}");

            arr[index] = wordValue;
        }

        public void Find(int[] arr, )
        {

        }
    }
}
