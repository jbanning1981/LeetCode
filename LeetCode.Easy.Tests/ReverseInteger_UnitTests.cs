using LeetCode.Easy.Submissions;
using System;
using Xunit;

namespace LeetCode.Easy.Tests
{
    public class ReverseInteger_UnitTests
    {
        public ReverseInteger_UnitTests()
        {

        }

        [InlineData(123,321)]
        [InlineData(-123, -321)]
        [InlineData(120, 21)]
        [InlineData(0,0)]
        [Theory]
        public void GetReversedIntegerBruteForce_Successful(int startValue, int expectedValue)
        {
            var reversedInt = ReverseInteger.ReverseViaString(startValue);

            Assert.Equal(expectedValue, reversedInt);
        }
    }
}
