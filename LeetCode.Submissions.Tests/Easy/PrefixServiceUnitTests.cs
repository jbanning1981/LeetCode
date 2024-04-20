using LeetCode.Submissions.Easy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Submissions.Tests.Easy
{
    [Trait("Category", "Easy")]
    [Trait("Category", "Unit")]
    public class PrefixServiceUnitTests
    {
        PrefixService _prefixService;

        public PrefixServiceUnitTests()
        {
            _prefixService = new PrefixService();
        }

        [Theory]
        [MemberData(nameof(TestCases))]
        public void LongestCommonPrefixVersionOne_WhenProvidedValidArray_ReturnsLongestCommonPrefix(string[] testValues, string expectedResult)
        {
            var returnedValue = _prefixService.LongestCommonPrefixVersionOne(testValues);

            Assert.Equal(expectedResult, returnedValue);
        }


        [Theory]
        [MemberData(nameof(TestCases))]
        public void LongestCommonPrefixVersionTwo_WhenProvidedValidArray_ReturnsLongestCommonPrefix(string[] testValues, string expectedResult)
        {
            var returnedValue = _prefixService.LongestCommonPrefixVersionTwo(testValues);

            Assert.Equal(expectedResult, returnedValue);
        }

        [Theory]
        [MemberData(nameof(TestCases))]
        public void LongestCommonPrefixVersionThree_WhenProvidedValidArray_ReturnsLongestCommonPrefix(string[] testValues, string expectedResult)
        {
            var returnedValue = _prefixService.LongestCommonPrefixVersionThree(testValues);

            Assert.Equal(expectedResult, returnedValue);
        }

        public static IEnumerable<object[]> TestCases => new List<object[]>()
        {
            new object[] { new[] { "flower", "flow", "flight" }, "fl"  },
            new object[] { new[] { "dog", "racecar", "car" }, ""  },
            new object[] { new[] { "abcde"}, "abcde" },
            new object[] { new[] { "", } , "" },
            new object[] { new[] {"cir", "car" } ,"c" },
            new object[] { new[] {"ab", "a" } ,"a" },
            new object[] { new[] { "flower", "fkow" } ,"f" }
        };
    }
}
