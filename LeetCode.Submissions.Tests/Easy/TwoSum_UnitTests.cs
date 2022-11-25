using LeetCode.Submissions.Easy;
using System;
using Xunit;

namespace LeetCode.Easy.Tests
{
    [Trait("Category", "Unit")]
    [Trait("Category", "Easy")]
    public class TwoSum_UnitTests
    {
        public TwoSum_UnitTests()
        {

        }

        [InlineData(new int[] { 2, 7, 11,15 }, 9)]
        [InlineData(new int[] { 3, 2, 4 }, 6)]
        [InlineData(new int[] { -1, -2, -3, -4, -5 }, -8)]
        [InlineData(new int[] { 230, 863, 916, 585, 981, 404, 316, 785, 88, 12, 70, 435, 384, 778, 887, 755, 740, 337, 86, 92, 325, 422, 815, 650, 920, 125, 277, 336, 221, 847, 168, 23, 677, 61, 400, 136, 874, 363, 394, 199, 863, 997, 794, 587, 124, 321, 212, 957, 764, 173, 314, 422, 927, 783, 930, 282, 306, 506, 44, 926, 691, 568, 68, 730, 933, 737, 531, 180, 414, 751, 28, 546, 60, 371, 493, 370, 527, 387, 43, 541, 13, 457, 328, 227, 652, 365, 430, 803, 59, 858, 538, 427, 583, 368, 375, 173, 809, 896, 370, 789 }, 542)]
        [Theory]
        public void GetSumComponentsBruteForce_Successful(int[] testNums, int target)
        {
            var result = TwoSumSerivce.GetSumComponentsBruteForce(testNums, target);

            var expectedTotal = testNums[result[0]] + testNums[result[1]];

            Assert.Equal(target, expectedTotal);
        }

        [InlineData(new int[] { 2, 7, 11, 15 }, 9)]
        [InlineData(new int[] { 3, 2, 4 }, 6)]
        [InlineData(new int[] { -1, -2, -3, -4, -5 }, -8)]
        [InlineData(new int[] { 230, 863, 916, 585, 981, 404, 316, 785, 88, 12, 70, 435, 384, 778, 887, 755, 740, 337, 86, 92, 325, 422, 815, 650, 920, 125, 277, 336, 221, 847, 168, 23, 677, 61, 400, 136, 874, 363, 394, 199, 863, 997, 794, 587, 124, 321, 212, 957, 764, 173, 314, 422, 927, 783, 930, 282, 306, 506, 44, 926, 691, 568, 68, 730, 933, 737, 531, 180, 414, 751, 28, 546, 60, 371, 493, 370, 527, 387, 43, 541, 13, 457, 328, 227, 652, 365, 430, 803, 59, 858, 538, 427, 583, 368, 375, 173, 809, 896, 370, 789 },542)]
        [Theory]
        public void GetSumComponentsLookup_Successful(int[] testNums, int target)
        {
            var result = TwoSumSerivce.GetSumComponentsLookup(testNums, target);

            var valueOne = testNums[result[0]];
            var valueTwo = testNums[result[1]];

            var expectedTotal =  valueOne + valueTwo;

            Assert.Equal(target, expectedTotal);
        }
    }
}
