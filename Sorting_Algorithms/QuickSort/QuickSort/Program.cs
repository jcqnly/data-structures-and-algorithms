using System;

namespace QuickSort
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //set an array to work with
            int[] unsortedArray = new int[] { 4, 7, 9, 1, 10, 8, 3, 6, 2, 5 };
            Quick_Sort(unsortedArray, 0, unsortedArray.Length-1);
        }

        /// <summary>
        /// Find a central pivot value and call Quick_Sort to 
        /// sort both halves
        /// </summary>
        /// <param name="array"></param>
        /// <param name="left"></param>
        /// <param name="right"></param>
        public static void Quick_Sort(int[] array, int left, int right)
        {
            //base case
            if (left >= right) return;
            //pick a pivot
            int pivot = array[(left + right) / 2];
            //partition elements around pivot
            int index = Partition(array, left, right, pivot);
            //sort the left half
            Quick_Sort(array, left, index - 1);
            //sort the right half
            Quick_Sort(array, index, right);
        }

        /// <summary>
        /// Look for an element on the left that is bigger than the pivot,
        /// which means it is out of order
        /// </summary>
        /// <param name="array"></param>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <param name="pivot"></param>
        /// <returns></returns>
        public static int Partition(int[] array, int left, int right, int pivot)
        {
            while (left <= right)
            {
                while (array[left] < pivot) left++;

                while (array[right] > pivot) right--;

                //if the element is out of order, swap it to the other side
                if (left <= right)
                {
                    Swap(array, left, right);
                    left++;
                    right--;
                }
            }

            foreach (var num in array)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("-----------");
            //return the new partition point
            return left;
        }

        /// <summary>
        /// swap the centents of an index if it's out of order
        /// </summary>
        /// <param name="array"></param>
        /// <param name="left"></param>
        /// <param name="right"></param>
        public static void Swap(int[] array, int left, int right)
        {
            int temp = array[left];
            array[left] = array[right];
            array[right] = temp;
        }
    }
}
