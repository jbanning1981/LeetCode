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
    public class SearchInsertPositionServiceUnitTests
    {
        /*
            https://leetcode.com/problems/search-insert-position/description/

            Example 1:

            Input: nums = [1,3,5,6], target = 5
            Output: 2

            Example 2:

            Input: nums = [1,3,5,6], target = 2
            Output: 1

            Example 3:

            Input: nums = [1,3,5,6], target = 7
            Output: 4        
        */

        SearchInsertPositionService _searchInsertPositionService = new();


        [Theory]
        [MemberData(nameof(TestCases))]
        public void SearchInsertTest(int[] testNums, int target, int expectedOutput)
        {
            var insertPosition = _searchInsertPositionService.SearchInsert(testNums, target);

            Assert.Equal(expectedOutput, insertPosition);
        }


        public static IEnumerable<object[]> TestCases => new List<object[]>()
        {
            new object[] { new int[] { 1, 3, 5, 6 }, 5,2 },
            new object[] { new int[] { 1, 3, 5, 6 }, 2,1 },
            new object[] { new int[] { 1, 3, 5, 6 }, 7,4 }
        };

    }
}
