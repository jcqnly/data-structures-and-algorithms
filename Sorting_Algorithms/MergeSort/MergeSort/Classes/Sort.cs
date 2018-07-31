using System;
using System.Collections.Generic;
using System.Text;

namespace MergeSort.Classes
{
    public class Sort
    {
        public int[] MergeSort(int[] arrayToSort, int[] temp, int leftStart, int rightEnd)
        {
            //base case
            if (leftStart >= rightEnd) return arrayToSort;
            else {
                int midIndex = (leftStart + rightEnd) / 2;
                MergeSort(arrayToSort, temp, leftStart, midIndex);
                MergeSort(arrayToSort, temp, midIndex + 1, rightEnd);
                MergeHalves(arrayToSort, temp, leftStart, rightEnd);
            }
            return arrayToSort;
        }

        public void MergeHalves(int[] arrayToSort, int[] temp, int leftStart, int rightEnd)
        {
            int leftEnd = (leftStart + rightEnd) / 2;
            int rightStart = leftEnd + 1;
            int size = rightEnd - leftStart + 1;

            int left = leftStart;
            int right = rightStart;
            int index = leftStart;

            while (left <= leftEnd && right <= rightEnd)
            {
                if (arrayToSort[left] <= arrayToSort[right])
                {
                    temp[index] = arrayToSort[left];
                    left++;
                } else
                {
                    temp[index] = arrayToSort[right];
                    right++;
                }
                index++;
            }

            System.Array.Copy(arrayToSort, left, temp, index, leftEnd - left +  1);
        }
    }
}
