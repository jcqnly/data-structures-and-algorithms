using System;
using System.Collections.Generic;
using System.Text;

namespace InsertionSort.Classes
{
    public class Sort
    {
        public int[] InsertionSort(int[] arrayToSort)
        {
            int i = 1;
            while (i < arrayToSort.Length)
            {
                int j = i;
                while (j > 0 && arrayToSort[j-1] > arrayToSort[j])
                {
                    arrayToSort[j] = arrayToSort[j - 1];
                    j = j - 1;
                }
                i++;
            }
            return arrayToSort;
        }
    }
}