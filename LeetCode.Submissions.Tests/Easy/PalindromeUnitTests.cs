using LeetCode.Submissions.Easy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Submissions.Tests.Easy
{
    [Trait("Category", "Unit")]
    [Trait("Category", "Easy")]
    public class PalindromeUnitTests
    {

        [Theory]
        [MemberData(nameof(PalindromeValues))]
        public void IsPalindromeStringBased_WhenNumberIsPalindrome_ReturnsTrue(int testNumber)
        {
            Assert.True(PalindromeService.IsPalindromeStringBased(testNumber));
        }

        [Theory]
        [MemberData(nameof(PalindromeValues))]
        public void IsPalindromeIntegerBased_WhenNumberIsPalindrome_ReturnsTrue(int testNumber)
        {
            Assert.True(PalindromeService.IsPalindromeIntegerBased(testNumber));
        }

        public static IEnumerable<object[]> PalindromeValues =>
            new List<object[]>
            {
                new object[] { 0 },
                new object[] { 11 },
                new object[] { 101 },
                new object[] { 121 },
                new object[] { 12321 },
                new object[] { 123321 },
                new object[] { 303 },
                new object[] { 30003 },
            };

        [Theory]
        [MemberData(nameof(NonPalindromeValues))]
        public void IsPalindromeStringBased_WhenNumberIsPalindrome_ReturnsFalse(int testNumber)
        {
            Assert.False(PalindromeService.IsPalindromeStringBased(testNumber));
        }

        [Theory]
        [MemberData(nameof(NonPalindromeValues))]
        public void IsPalindromeIntegerBased_WhenNumberIsNotPalindrome_ReturnsFalse(int testNumber)
        {
            Assert.False(PalindromeService.IsPalindromeIntegerBased(testNumber), $"Failed for {testNumber}");
        }

        public static IEnumerable<object[]> NonPalindromeValues =>
            new List<object[]>
            {
                new object[] { 12 },
                new object[] { -11 },
                new object[] { 122 },
                new object[] { 12311 },
                new object[] { 123421 },
            };
    }
}
