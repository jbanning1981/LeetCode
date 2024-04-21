using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LeetCode.Submissions.Easy
{
    /*
        https://leetcode.com/problems/search-insert-position/description/     
        Given a sorted array of distinct integers and a target value, return the index if the target is found. If not, return the index where it would be if it were inserted in order.

        You must write an algorithm with O(log n) runtime complexity.

 

        Example 1:

        Input: nums = [1,3,5,6], target = 5
        Output: 2

        Example 2:

        Input: nums = [1,3,5,6], target = 2
        Output: 1

        Example 3:

        Input: nums = [1,3,5,6], target = 7
        Output: 4

 

        Constraints:

            1 <= nums.length <= 104
            -104 <= nums[i] <= 104
            nums contains distinct values sorted in ascending order.
            -104 <= target <= 104
    */

    public class SearchInsertPositionService
    {
    
        public int SearchInsert(int[] nums, int target)
        {
            return SearchV2(nums, target);

        }

        //Runtime - 68ms beats 62.75%
        //Memory - 42.06MB beats 53.28%
        private int SearchV1(int[] nums, int target)
        {
            if (nums.Length == 0)
            {
                return 0;
            }


            //int insertIndex = 0;
            for (int insertCounter = 0; insertCounter < nums.Length; insertCounter++)
            {
                //insertIndex = insertCounter;
                if (nums[insertCounter] >= target)
                {
                    return insertCounter;
                }
            }

            return nums.Length;
        }

        //Runtime - 65ms beats 77.62%
        //Memory - 42.21MB beats 20.8%
        private int SearchV2(int[] nums, int target) 
        {
            for (int insertCounter = 0; insertCounter < nums.Length; insertCounter++)
            {
                if (nums[insertCounter] >= target)
                {
                    return insertCounter;
                }
            }

            return nums.Length;


        }

    }
}
