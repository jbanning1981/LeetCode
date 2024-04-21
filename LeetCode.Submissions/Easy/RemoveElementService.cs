/*
https://leetcode.com/problems/remove-element/description/
Given an integer array nums and an integer val, remove all occurrences of val in nums in-place. The order of the elements may be changed. Then return the number of elements in nums which are not equal to val.

Consider the number of elements in nums which are not equal to val be k, to get accepted, you need to do the following things:

Change the array nums such that the first k elements of nums contain the elements which are not equal to val. The remaining elements of nums are not important as well as the size of nums.
Return k.
Custom Judge:

The judge will test your solution with the following code:

int[] nums = [...]; // Input array
int val = ...; // Value to remove
int[] expectedNums = [...]; // The expected answer with correct length.
                            // It is sorted with no values equaling val.

int k = removeElement(nums, val); // Calls your implementation

assert k == expectedNums.length;
sort(nums, 0, k); // Sort the first k elements of nums
for (int i = 0; i < actualLength; i++) {
    assert nums[i] == expectedNums[i];
}


What's not mentioned here is HOW the removed elements are replaced.
The test cases are expecting you to replace elements a certain way
Given input -> [0,1,2,2,3,0,4,2]
Output -> [0,1,4,0,3]

Note the 4 and 0 leapfrogging the 3 in order, so it's pulling non-matching elements in reverse order.


*/

using System;
using System.Diagnostics;
using System.Security;

public class RemoveElementService
{
    public int RemoveElement(int[] nums, int val) {
        return RemoveElementV2(nums, val);
    }

    //Works - Accepted.
    //Runtime - 124 ms (Beats 5.54%)
    //Memory - 45.37MB (beats 95.38%)
    private int RemoveElementV1(int[] nums, int val)
    {
        //skipping null check, constraints guarantee a non-null array
        if(nums.Length == 0)
        {
            return 0;
        }

        int filteredIndex = 0;
        int[] filteredResults = new int[nums.Length];
        for(int counter = 0; counter < nums.Length; counter++)
        {
            var debug = nums[counter];
            if(nums[counter] != val)
            {
                filteredResults[filteredIndex] = nums[counter];
                filteredIndex++;
            }
        }

        for(int filterCounter = 0; filterCounter < filteredIndex; filterCounter++)
        {
            nums[filterCounter] = filteredResults[filterCounter];
        }


        return filteredIndex;
    }

    //Works - Accepted.
    //Runtime - 90 ms (Beats 91.70%)
    //Memory - 46.02MB (beats 9.25%)
    private int RemoveElementV2(int[] nums, int val)
    {
        //skipping null check, constraints guarantee a non-null array
        if (nums.Length == 0)
        {
            return 0;
        }
        //var zz = string.Join(",", nums);
        int replacementIndex = nums.Length;
        int noMatchCount = 0;
        for (int counter = 0; counter < nums.Length; counter++)
        {

            //If no match
            int debug = nums[counter];
            if (nums[counter] != val)
            {
                noMatchCount++;
                continue;
            }

            for(int z = replacementIndex-1; z > counter; z--)
            {
                if(nums[z] != val)
                {
                    nums[counter] = nums[z];
                    replacementIndex = z;
                    break;
                }
            }

            //zz = string.Join(",", nums);
        }

        return noMatchCount;
    }
}