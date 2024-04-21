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
    public class RomanNumeralUnitTests
    {
        RomanNumeralService _numeralService;

        public RomanNumeralUnitTests()
        {
            _numeralService = new RomanNumeralService();
        }


        [Theory]
        [MemberData(nameof(TestNumerals))]
        public void ConvertNumeral_WhenGivenNumeral_ConvertsToInt(string romanNumeral, int expectedValue)
        {
            var returnedValue = _numeralService.ConvertNumeralToNumber(romanNumeral);

            Assert.Equal(expectedValue, returnedValue);
        }

        public static IEnumerable<object[]> TestNumerals => new List<object[]>()
        {
            new object[] { "I", 1 },
            new object[] { "II", 2 },
            new object[] { "III", 3 },
            new object[] { "IV", 4 },
            new object[] { "IX", 9 },
            new object[] { "M", 1000 },
            new object[] { "MM", 2000 },
            new object[] { "MCM", 1900 },
            new object[] { "MCMXL", 1940 }
        };
        
    }
}
