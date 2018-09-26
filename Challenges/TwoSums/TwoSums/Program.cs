using System;
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
			//TODO: modularize solution
			foreach (int i in TwoSum(nums, target))
			{
				Console.WriteLine(i);
			}
		}

		public static int[] TwoSum(int[] nums, int target)
		{
			int[] index = new int[2];

			for (int i = 0; i < nums.Length; i++)
			{
				for (int j = i + 1; j < nums.Length; j++)
				{
					if (nums[i] + nums[j] == target)
					{
						Console.WriteLine($"The 2 indices are {i} and {j}");
						index[0] = i;
						index[1] = j;
					}
				}
			}
			return index;
		}
	}
}
