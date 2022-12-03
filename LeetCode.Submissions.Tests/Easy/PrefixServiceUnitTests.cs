﻿using LeetCode.Submissions.Easy;
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
        PrefixService prefixService;

        public PrefixServiceUnitTests()
        {
            prefixService = new PrefixService();
        }


        [Theory]
        [MemberData(nameof(TestCases))]
        public void ConvertNumeral_WhenGivenNumeral_ConvertsToInt(string[] testValues, string expectedResult)
        {
            var returnedValue = prefixService.LongestCommonPrefix(testValues);

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
