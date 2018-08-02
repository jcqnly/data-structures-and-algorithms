using System;

namespace QuickSort
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //set an array to work with
            int[] unsortedArray = new int[] { 11, 4, 14, 7, 9, 1, 10, 12, 8, 15, 3, 6, 2, 13, 5 };
            Quick_Sort(unsortedArray, 0, unsortedArray.Length-1);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="array"></param>
        /// <param name="left"></param>
        /// <param name="right"></param>
        public static void Quick_Sort(int[] array, int left, int right)
        {
            //base case
            if (left >= right) return;
            //pick a pivot
            int pivot = array[(left + right)/2];
            //partition elements around pivot
            int index = Partition(array, left, right, pivot);
            //sort the halves
            Quick_Sort(array, left, index - 1);
            Quick_Sort(array, index, right);
        }

        /// <summary>
        /// 
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
                while (array[left] < pivot)
                {
                    left++;
                }

                while (array[right] < pivot)
                {
                    right--;
                }

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
            return left;
        }

        public static void Swap(int[] array, int left, int right)
        {
            int temp = array[left];
            array[left] = array[right];
            array[right] = temp;
        }
    }
}
