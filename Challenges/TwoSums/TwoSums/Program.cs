using System;
using System.Collections;
using System.Collections.Generic;

namespace TwoSums
{
	public class Program
	{
		public static void Main(string[] args)
		{
			//iterate through array
			//if the number is greater than the target, ignore it and move on
			//if the number is not greater than the target, store its index in a var
				//iterate through the rest of the array
				//if the number at each index, added to that first value, is the target
				//store that index in a var

			int[] nums = new int[] { 2, 7, 11, 15};
			int target = 13;
			//brute force route
			//foreach (int i in TwoSum(nums, target)) Console.WriteLine(i);

			//TODO: solve with a hashtable
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
			Hashtable ht = new Hashtable();
			for (int i = 0; i < nums.Length; i++)
			{
				ht.Add(i, nums[i]);
				int otherValue = target - nums[i];
				if (ht.Contains(otherValue))
				{
					return new int[] { i, otherValue };
				}
			}
			return new int[] { 100 };
		}
	}
}
