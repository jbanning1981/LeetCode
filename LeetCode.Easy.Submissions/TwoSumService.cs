using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Easy.Submissions
{
    /// <summary>
    /// Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
    /// You may assume that each input would have exactly one solution, and you may not use the same element twice.
    /// You can return the answer in any order.
    /// URL: https://leetcode.com/problems/two-sum/
    /// Constraints:
    /// 2 <= nums.length <= 105
    /// -10^9 <= nums[i] <= 10^9
    /// -10^9 <= target <= 10^9
    /// Only one valid answer exists.
    /// </summary>
    public static class TwoSumSerivce
    {
        public static int[] GetSumComponentsBruteForce(int[] nums, int target)
        {


            if (nums.Length < 2)
            {
                return new int[0];
            }

            int[] result = new int[2];
            for (int counter = 0; counter <= nums.Length - 2; counter++)
            {
                for (int innerCounter = counter + 1; innerCounter < nums.Length; innerCounter++)
                {
                    if (nums[counter] + nums[innerCounter] == target)
                    {
                        result[0] = counter;
                        result[1] = innerCounter;
                        return result;
                    }
                }
            }

            return result;
        }

        public static int[] GetSumComponentsLookup(int[] nums, int target)
        {

            if (nums.Length < 2)
            {
                return new int[0];
            }

            int[] result = new int[2];
            Dictionary<int, int> lookupTable = new Dictionary<int, int>();
            for (int counter = 0; counter < nums.Length; counter++)
            {
                int keyToFind = target - nums[counter];
                if (lookupTable.ContainsKey(nums[counter]))
                {
                    if (target != nums[counter] + nums[lookupTable[nums[counter]]])
                    {
                        continue;
                    }

                    result[0] = counter;
                    result[1] = lookupTable[nums[counter]];
                    return result;


                }

                lookupTable.TryAdd(keyToFind, counter);



            }

            throw new InvalidOperationException("No suitable solution found.");
        }
    }
}
