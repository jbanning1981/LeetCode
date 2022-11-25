using LeetCode.Submissions.Medium;

namespace LeetCode.Medium.Tests
{
    [Trait("Category", "Unit")]
    [Trait("Category", "Medium")]
    public class ReverseIntegerUnitTests
    {
        public ReverseIntegerUnitTests()
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
