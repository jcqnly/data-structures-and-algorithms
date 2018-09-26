using System;
using System.Collections;
using System.Collections.Generic;

namespace TwoSums
{
	public class Program
	{
		public static void Main(string[] args)
		{
			int[] nums = new int[] { 2, 7, 11, 15};
			int target = 13;
			//brute force route
			foreach (int i in TwoSum(nums, target)) Console.WriteLine(i);

			//TODO: solve with a hashtable/dictionary
			foreach (int i in TwoSumHashTable(nums, target)) Console.WriteLine(i);

		}

		/// <summary>
		/// Brute force
		/// </summary>
		/// <param name="nums"></param>
		/// <param name="target"></param>
		/// <returns></returns>
		public static int[] TwoSum(int[] nums, int target)
		{
			for (int i = 0; i < nums.Length; i++)
			{
				for (int j = i + 1; j < nums.Length; j++)
				{
					if (nums[i] + nums[j] == target)
					{
						//Console.WriteLine($"The 2 indices are {i} and {j}");
						return new int[] { i, j};
					}
				}
			}
			//TODO: find out how to return an exception
			return new int[] { 0 };
		}

		/// <summary>
		/// Hashtable route
		/// </summary>
		/// <param name="nums"></param>
		/// <param name="target"></param>
		/// <returns></returns>
		public static int[] TwoSumHashTable(int[] nums, int target)
		{
			Dictionary<int, int> storeArray = new Dictionary<int, int>();
			//Hashtable ht = new Hashtable();
			for (int i = 0; i < nums.Length; i++)
			{
				int otherValue = target - nums[i];
				if (storeArray.ContainsKey(otherValue))
				{
					return new int[] { i, otherValue};
				}
				storeArray.Add(i, nums[i]);
			}
			return new int[] { 100 };
		}
	}
}
