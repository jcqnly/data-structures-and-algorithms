using System;

namespace ArrayShift
{
	public class Program
	{
		public static void Main(string[] args)
		{
			//can insert in an even array
			int[] arr1 = { 1, 0, 6, 8 };

			//can insert in an odd array
			//number to insert will be after the number that's currently the middle num
			int[] arr2 = { 2, 1, 3, 8, 5 };

			int midNum1 = 5;
			int midNum2 = 7;

			int[] result1 = Array_Shift(arr1, midNum1);
			int[] result2 = Array_Shift(arr2, midNum2);
		}

		/// <summary>
		/// Insert a number in the middle of an array
		/// </summary>
		/// <param name="arr"></param>
		/// <param name="midNum"></param>
		/// <returns></returns>
		public static int[] Array_Shift(int[] arr, int midNum)
		{
			//make new array that will include extra digit
			int[] newArr = new int[arr.Length + 1];

			//find middle index of arr
			decimal midIndex = Math.Ceiling((decimal)arr.Length/2);

			//place midNum in middleIndex
			for (int i = 0; i < newArr.Length; i++)
			{
				//if we're at the middle index, set that value to the number being inserted
				if(i == midIndex) newArr[i] = midNum;

				//this is to account that the original array is shorter
				//and to prevent and index out of range error because of the shorter length
				else if (i != midIndex && i > midIndex) newArr[i] = arr[i - 1];

				//otherwise, add the content of the original array to the new array
				else newArr[i] = arr[i];
			}

			foreach (int i in newArr) Console.Write(i + " ");

			Console.WriteLine("");
			return newArr;
		}
	}
}
