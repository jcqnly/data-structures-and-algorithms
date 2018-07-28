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
            for (var i = 0; i < arrayToSort.Length; i++)
            {
                for (var j = 1; j < arrayToSort.Length; j++)
                {
                    temp = arrayToSort[j];
                    if (arrayToSort[i] > arrayToSort[j])
                    {
                        arrayToSort[j] = arrayToSort[i];
                        arrayToSort[i] = temp;
                    }
                    i++;
                }
            }
            return arrayToSort;
        }
    }
}