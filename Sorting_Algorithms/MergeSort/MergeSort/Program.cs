using MergeSort.Classes;
using System;

namespace MergeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] unsortedArray = new int[] { 11, 4, 14, 7, 9, 1, 10, 12, 8, 15, 3, 6, 2, 13, 5};
            MergeSort(unsortedArray);
        }

        public static void MergeSort(int[] unsortedArray)
        {
            MergeSort(unsortedArray, new int[unsortedArray.Length], 0, unsortedArray.Length-1);
        }

        public static void MergeSort(int[] arrayToSort, int[] temp, int leftStart, int rightEnd)
        {
            //base case
            if (leftStart >= rightEnd) return;
            else
            {
                int midIndex = (leftStart + rightEnd) / 2;
                MergeSort(arrayToSort, temp, leftStart, midIndex);
                MergeSort(arrayToSort, temp, midIndex + 1, rightEnd);
                MergeHalves(arrayToSort, temp, leftStart, rightEnd);
            }
        }

        public static void MergeHalves(int[] arrayToSort, int[] temp, int leftStart, int rightEnd)
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
                }
                else
                {
                    temp[index] = arrayToSort[right];
                    right++;
                }
                index++;
            }

            Array.Copy(arrayToSort, left, temp, index, leftEnd - left + 1);
            Array.Copy(arrayToSort, right, temp, index, rightEnd - right + 1);
            Array.Copy(temp, leftStart, arrayToSort, leftStart, size);

            foreach (var num in arrayToSort)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("-----------");
        }
    }
}
