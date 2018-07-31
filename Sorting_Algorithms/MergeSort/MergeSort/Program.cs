using System;

namespace MergeSort
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //set an array to work with
            int[] unsortedArray = new int[] { 11, 4, 14, 7, 9, 1, 10, 12, 8, 15, 3, 6, 2, 13, 5};
            //pass the array to the start of the merge sorting process
            Merge_Sort(unsortedArray);
        }

        /// <summary>
        /// Sends the array, a new temp array to store the values, a starting left value, and a starting right value
        /// </summary>
        /// <param name="unsortedArray"></param>
        public static void Merge_Sort(int[] unsortedArray)
        {
            MergeSort(unsortedArray, new int[unsortedArray.Length], 0, unsortedArray.Length-1);
        }

        /// <summary>
        /// Defines the part of the array to sort and then calls the method to merge the halves
        /// </summary>
        /// <param name="arrayToSort"></param>
        /// <param name="temp"></param>
        /// <param name="leftStart"></param>
        /// <param name="rightEnd"></param>
        public static void MergeSort(int[] arrayToSort, int[] temp, int leftStart, int rightEnd)
        {
            //base case
            if (leftStart >= rightEnd) return;
            //define middle position
            int midIndex = (leftStart + rightEnd) / 2;
            //sort the left side til the middle
            MergeSort(arrayToSort, temp, leftStart, midIndex);
            //sort the right side
            MergeSort(arrayToSort, temp, midIndex + 1, rightEnd);
            //merge the halves
            MergeHalves(arrayToSort, temp, leftStart, rightEnd);
        }

        /// <summary>
        /// Merge the halves together back into 1 array
        /// </summary>
        /// <param name="arrayToSort">unsorted array</param>
        /// <param name="temp">temp array to store values</param>
        /// <param name="leftStart">starting position on the left side</param>
        /// <param name="rightEnd">starting position on the right end</param>
        public static int[] MergeHalves(int[] arrayToSort, int[] temp, int leftStart, int rightEnd)
        {
            //find where the left side ends
            int leftEnd = (leftStart + rightEnd) / 2;
            //find the next value
            int rightStart = leftEnd + 1;
            //total # of elements being copied over
            int size = rightEnd - leftStart + 1;

            //left index position
            int left = leftStart;
            //right index position
            int right = rightStart;
            //index position for the temp array
            int index = leftStart;

            //while the elements are still in bound
            while (left <= leftEnd && right <= rightEnd)
            {
                if (arrayToSort[left] <= arrayToSort[right])
                {
                    //copy the array from the left in
                    temp[index] = arrayToSort[left];
                    left++;
                }
                else
                {
                    //copy the array from the right in
                    temp[index] = arrayToSort[right];
                    right++;
                }
                //moving along the temp array
                index++;
            }

            //copy the remaining values into the sorted array
            Array.Copy(arrayToSort, left, temp, index, leftEnd - left + 1);
            Array.Copy(arrayToSort, right, temp, index, rightEnd - right + 1);
            Array.Copy(temp, leftStart, arrayToSort, leftStart, size);

            foreach (var num in arrayToSort)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("-----------");
            return arrayToSort;
        }
    }
}
