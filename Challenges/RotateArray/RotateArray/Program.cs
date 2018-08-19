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

            //store up to the number of values in tempArr
            for (int i = 0; i <= rotations - 1; i++)
            {
                tempArr[i] = arr[i];
            }

            //rotate arr, this will leave null values at the end
            for (int j = 0; j < arr.Length - rotations; j++)
            {
                arr[j] = arr[j + rotations];
            }

            //append the tempArr elements to the end of arr
            for (int k = 0; k < tempArr.Length-1; k++)
            {
                arr[k] = tempArr[k];
            }

            return arr;
        }
    }
}
