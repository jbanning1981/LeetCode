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


*/

using System;
using System.Diagnostics;

public class RemoveElementService
{
    public int RemoveElement(int[] nums, int val) {
        return RemoveElementV2(nums, val);
    }

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

    private int RemoveElementFailed(int[] nums, int val)
    {
        //skipping null check, constraints guarantee a non-null array
        if(nums.Length == 0)
        {
            return 0;
        }

        int replacementIndex = nums.Length;
        int noMatchCount = 0;
        for(int counter = 0; counter < nums.Length; counter++)
        {
            int debug = nums[counter];
            if(nums[counter] != val)
            {
                noMatchCount++;


                if(replacementIndex != nums.Length)
                {
                    nums[replacementIndex] = nums[counter];
                    for(int nextReplacementIndex = replacementIndex+1; nextReplacementIndex < counter; nextReplacementIndex++)
                    {
                        if(nums[nextReplacementIndex] == val)
                        {
                            replacementIndex = nextReplacementIndex;
                            break;
                        }
                    }
                    continue;
                }

                replacementIndex = nums.Length;
                continue;
            }

            if (replacementIndex == nums.Length)
            {
                replacementIndex = counter;                
            }
            

                // {
                //     nums[replacementIndex] = nums[counter];
                //     //find the next replacementIndex
                //     for(int i = 0; i<= counter; i++)
                //     {
                //         if(nums[i] == val)
                //         {
                //             replacementIndex = i;
                //             break;
                //         }
                //     }
                // }

            // if(replacementIndex > counter)
            // {
            //     replacementIndex = counter;
            // }
        }

        return noMatchCount;
    }    
    
    private int RemoveElementV2(int[] nums, int val)
    {
        //skipping null check, constraints guarantee a non-null array
        if(nums.Length == 0)
        {
            return 0;
        }

        int replacementIndex = nums.Length;
        int noMatchCount = 0;
        for (int counter = 0; counter < nums.Length; counter++)
        {
            int debug = nums[counter];
            if (nums[counter] != val)
            {
                noMatchCount++;
                if (replacementIndex < counter)
                {
                    nums[replacementIndex] = nums[counter];                    
                }
                for (int i = replacementIndex; i < counter; i++)
                {
                    if (nums[i] == val)
                    {
                        replacementIndex = i;
                        break;
                    }
                }
                continue;
            }

            if (replacementIndex >= counter)
            {
                replacementIndex = counter;                
            }


        }

        return noMatchCount;
    }        

}