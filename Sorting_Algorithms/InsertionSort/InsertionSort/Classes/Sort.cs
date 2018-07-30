using System;
using System.Collections.Generic;
using System.Text;

namespace InsertionSort.Classes
{
    public class Sort
    {
        /// <summary>
        /// Sort an unsorted array in ascending order.
        /// With each iteration, one element from the given array
        /// is inserted in place into the growing sorted list.
        /// </summary>
        /// <param name="arrayToSort"></param>
        /// <returns>a sorted array in ascending order</returns>
        public int[] InsertionSort(int[] arrayToSort)
        {
            int i = 1;
            //loop through the length of the array
            while (i < arrayToSort.Length)
            {
                //store the 2nd value of the pair being analyzed
                int x = arrayToSort[i];

                //store the indexer of the  first number in the pair being analyzed
                int j = i - 1;

                //this loop will compare that 2nd value to every number in the 
                //sorted array to the left of it
                while (j >= 0 && arrayToSort[j] > x)
                {
                    //if it's larger than the number after it, swap the numbers
                    arrayToSort[j + 1] = arrayToSort[j];
                    //decrease the value of j, so that...
                    j--;
                }
                //that spot can be replaced with the value that was replaced
                arrayToSort[j + 1] = x;
                //increase the indexer of where we are in the array
                i++;
            }
            return arrayToSort;
        }
    }
}