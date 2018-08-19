using System;

namespace RotateArray
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = new int[] {1, 2, 3, 4, 5, 6, 7 };
            int rotations = 2;
            Rotate(arr, rotations);
            foreach(int num in arr)
            {
                Console.WriteLine(num);
            }
        }

        public static int[] Rotate(int[] arr, int rotations)
        {
            //temp array to hold the number of values equal to the # of rotations
            int[] tempArr = new int[rotations];
            int length = arr.Length;

            //store up to the number of values in tempArr
            for (int i = 0; i <= rotations - 1; i++)
            {
                tempArr[i] = arr[i];
            }

            //rotate arr
            for (int j = 0; j < arr.Length - rotations; j++)
            {
                arr[j] = arr[j + rotations];
            }

            //append the tempArr elements to the end of arr
            for (int k = 0; k < tempArr.Length; k++)
            {
                arr[length - rotations] = tempArr[k];
                length++;
            }

            return arr;
        }
    }
}
