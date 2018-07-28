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
                int x = arrayToSort[i];
                int j = i - 1;
                while (j >= 0 && arrayToSort[j] > x)
                {
                    arrayToSort[j + 1] = arrayToSort[j];
                    j = j - 1;
                }
                arrayToSort[j + 1] = x;
                i = i + 1;
            }
            return arrayToSort;
        }
    }
}