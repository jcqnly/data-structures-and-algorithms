using System;
using System.Collections;
using System.Collections.Generic;

namespace TwoSums
{
	public class Program
	{
		public static void Main(string[] args)
		{
			int[] nums = new int[] { 2, 5, 7, 9, 11, 15};
			int target = 13;
			//brute force using O(N)^2 complexity
			foreach (int i in TwoSum(nums, target)) Console.WriteLine(i);

			//Using a dictionary for O(N) complexity
			foreach (int i in TwoSumDictionary(nums, target)) Console.WriteLine(i);

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
		/// Dictionaly route
		/// </summary>
		/// <param name="nums"></param>
		/// <param name="target"></param>
		/// <returns></returns>
		public static int[] TwoSumDictionary(int[] nums, int target)
		{
			Dictionary<int, int> storeArray = new Dictionary<int, int>();
			for (int i = 0; i < nums.Length; i++)
			{
				int otherValue = target - nums[i];
				if (storeArray.ContainsKey(nums[i]))
				{
					return new int[] { i, storeArray[nums[i]] };
				}
				storeArray.Add(otherValue, i);
			}
			return null;
		}
	}
}
