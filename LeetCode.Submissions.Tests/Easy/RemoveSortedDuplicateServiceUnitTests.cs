using LeetCode.Submissions.Easy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LeetCode.Submissions.Tests.Easy
{
    [Trait("Category", "Easy")]
    [Trait("Category", "Unit")]
    public class RemoveSortedDuplicateServiceUnitTests
    {
        /*
        https://leetcode.com/problems/remove-duplicates-from-sorted-array/description/

        Example 1:

        Input: nums = [1,1,2]
        Output: 2, nums = [1,2,_]
        Explanation: Your function should return k = 2, with the first two elements of nums being 1 and 2 respectively.
        It does not matter what you leave beyond the returned k (hence they are underscores).

        Example 2:

        Input: nums = [0,0,1,1,1,2,2,3,3,4]
        Output: 5, nums = [0,1,2,3,4,_,_,_,_,_]
        Explanation: Your function should return k = 5, with the first five elements of nums being 0, 1, 2, 3, and 4 respectively.
        It does not matter what you leave beyond the returned k (hence they are underscores).
         
        */

        RemoveSortedDuplicateService _removeSortedDuplicateService = new();


        [Theory]
        [MemberData(nameof(TestCases))]
        public void Test(int[] testNums, int[] expectedNums)
        {
            var uniqueNums = _removeSortedDuplicateService.RemoveDuplicates(testNums);

            Assert.Equal(expectedNums.Length, uniqueNums);

            for (int i = 0; i < uniqueNums; i++)
            {
                Assert.Equal(expectedNums[i], testNums[i]);
            }

        }


        public static IEnumerable<object[]> TestCases => new List<object[]>()
        {
            new object[] { new int[] { 1, 1, 2 }, new int[] { 1, 2 } },
            new object[] { new int[] { 1000 }, new int[] { 1000 } },
            new object[] {
                new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 },
                new int[] { 0, 1, 2, 3, 4 }
            },
            new object[] {
                new int[] { 0, 0, 0, 0 },
                new int[] { 0 }
            },
            new object[] {
                new int[] { 1, 1, 2, 3 },
                new int[] { 1,2,3 }
            },
            new object[] {
                new int[] { -3,-3,-2,-1,-1,0,0,0,0,0 },
                new int[] { -3, -2, -1, 0 }
            }
        };

    }
}
