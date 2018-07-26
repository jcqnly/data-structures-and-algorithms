using System;
using System.Collections.Generic;
using System.Text;

namespace InsertionSort.Classes
{
    public class Sort
    {
        public int[] InsertionSort(int[] arrayToSort)
        {
            int temp;
            for (int i = 0; i < arrayToSort.Length; i++)
            {
                //current index is larger than the one to the right
                if (arrayToSort[i] > arrayToSort[i + 1])
                {
                    temp = arrayToSort[i];
                    arrayToSort[i + 1] = arrayToSort[i];
                    arrayToSort[i + 1] = temp;
                }

            }
            return arrayToSort;
        }
    }
}