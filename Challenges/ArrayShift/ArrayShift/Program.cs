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
			int[] arr2 = { 2, 1, 3, 8, 5 };

			int midNum1 = 5;
			int midNum2 = 7;

			int[] result1 = Array_Shift(arr1, midNum1);
			int[] result2 = Array_Shift(arr2, midNum2);
		}

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
				else if (i != midIndex && i > midIndex) newArr[i] = arr[i - 1];
				else newArr[i] = arr[i];
			}

			foreach (int i in newArr) Console.Write(i);

			Console.WriteLine("");
			return newArr;
		}

		//public static void Main(string[] args)
		//{
		//	int[] array = { 2, 4, 6, 8, 10 };
		//	int middleNum = 5;
		//	int[] result = Array_Shift(array, middleNum);
		//	string arrayAsString = "";
		//	for (int i = 0; i < array.Length; i++)
		//	{
		//		arrayAsString = arrayAsString + array[i];
		//	}
		//	Console.WriteLine(arrayAsString);
		//	Console.WriteLine(middleNum);
		//	string resultString = "";

		//	for (int i = 0; i < result.Length; i++)
		//	{
		//		resultString = resultString + result[i];
		//	}
		//	Console.WriteLine(resultString);
		//}

		//public static int[] Array_Shift(int[] array, int middleNum)
		//{
		//	int[] newArray = new int[array.Length + 1];
		//	int counter = 0;
		//	decimal midIndex = Math.Ceiling((decimal)array.Length / 2);
		//	for (int i = 0; i < newArray.Length; i++)
		//	{
		//		if (midIndex == i)
		//		{
		//			newArray[i] = middleNum;
		//		}
		//		else
		//		{
		//			newArray[i] = array[counter++];
		//		}
		//	}
		//	return newArray;
		//}
	}
}
