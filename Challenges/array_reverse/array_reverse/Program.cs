using System;

namespace array_reverse
{
    public class Program
    {
        static void Main(string[] args)
        {   //hard code a given array to pass to method to reverse
			//O(N) Solution:
            int[] givenArray = new int[] { 1, 2, 3 };
            var arrayToReverse = ReverseArray(givenArray);
			Console.WriteLine("O(N) Solution: ");
			foreach (int item in arrayToReverse) Console.Write(item + " ");
			Console.WriteLine("\n");

			//Recursive solution for an array with an odd amount of numbers:
			int[] givenArray2 = new int[] { 1, 2, 3, 4, 5};
			int i = 0;
			int j = givenArray2.Length-1;
			ReverseArrayRecursive(givenArray2, i, j);
			Console.WriteLine("Recursive solution for an array with an odd number of ints: \n");
			foreach (int k in givenArray2) Console.Write(k + " ");
			Console.WriteLine("\n");

			//Recursive solution for an array with an even amount of numbers:
			int[] givenArray3 = new int[] { 1, 2, 3, 4, 5, 6 };
			int l = 0;
			int m = givenArray3.Length - 1;
			ReverseArrayRecursive(givenArray3, l, m);
			Console.WriteLine("Recursive solution for an array with an even number of ints: \n");
			foreach (int n in givenArray3) Console.Write(n + " ");

		}

		/// <summary>
		/// O(N) solution
		/// </summary>
		/// <param name="arrayToReverse"></param>
		/// <returns></returns>
        static int[] ReverseArray(int[] arr)
        {
            int counter = 0;
            //set new array to the length of givenArray
            int[] reverseArray = new int[arr.Length];
            //working from the end of givenArray
            for (int i = arr.Length - 1; i >= 0; i--)
            {   //add that value to the beginning of the new array
                reverseArray[counter] = arr[i];
                counter++;
            }
			
            return reverseArray;
        }

		/// <summary>
		/// Recursive method
		/// </summary>
		/// <param name="arrayToReverse">array to reverse</param>
		/// <param name="i">incrementing from the beginning of the array</param>
		/// <param name="j">decrementing from the end of the array</param>
		static void ReverseArrayRecursive(int[] arr, int i, int j)
		{
			//base case for arrays with an odd amount of numbers
			//if (i == j) return;

			//base case for arrays with an even amount of numbers
			//if (j == i - 1) return;
			//if (i == j + 1) return;

			//the if conditional is another base case to for swapping
			if (i < j)
			{
				//swap the 2 numbers
				int temp;
				temp = arr[j];
				arr[j] = arr[i];
				arr[i] = temp;
				i++;
				j--;
				ReverseArrayRecursive(arr, i, j);
			}
		}
    }
}
