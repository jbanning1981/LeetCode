using Xunit;
using LeetCode.Submissions.Easy;

namespace LeetCode.Submissions.Tests.Easy
{

    [Trait("Category", "Unit")]
    [Trait("Category", "Easy")]
    public class FirstOccuranceServiceUnitTests
    {

        private FirstOccuranceService _testService = new(); 

        [Theory]
        [MemberData(nameof(TestData))]
        public void SubStringTest(string haystack, string needle, int expected)
        {
            // Arrange
            // Act
            var result = _testService.StrStr(haystack, needle);
            // Assert
            Assert.Equal(expected, result);
        }

        public static IEnumerable<object[]> TestData = new List<object[]>
        {
            new object[] { "sadbutsad", "sad", 0 },
            new object[] { "leetcode", "leeto", -1 }
        };
    }
}