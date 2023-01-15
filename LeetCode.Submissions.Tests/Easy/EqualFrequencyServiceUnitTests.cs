using LeetCode.Submissions.Easy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LeetCode.Submissions.Tests.Easy
{
    [Trait("Category", "Unit")]
    [Trait("Category", "Easy")]
    public class EqualFrequencyServiceUnitTests
    {
        private EqualFrequencyService _equalService;

        public EqualFrequencyServiceUnitTests()
        {
            _equalService = new EqualFrequencyService();
        }


        [Theory]
        [InlineData("abcc",true)]
        [InlineData("aazz", false)]
        [InlineData("bac", true)]
        [InlineData("ddaccb", false)]
        [InlineData("abbcc", true)]
        [InlineData("zz", true)]
        [InlineData("cccd", true)]
        [InlineData("aaaabbbbccc", false)]
        [InlineData("babbdd", false)]
        [InlineData("zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz",true)]
        public void EqualFrequencyServiceUnit(string wordToCheck, bool expectedResult)
        {
            var canEqualize = _equalService.EqualFrequency(wordToCheck);

            Assert.Equal(expectedResult, canEqualize);
        }
    }
}
