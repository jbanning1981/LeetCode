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
    public class ParenthesisServiceUnitTests
    {
        ParenthesisService ParenthesisService;

        public ParenthesisServiceUnitTests()
        {
            ParenthesisService = new ParenthesisService();
        }

        [Theory]
        [MemberData(nameof(TestCases))]
        public void IsValidParenthesis_ReturnsSuccessfully(string testValue, bool expectedResult)
        {
            var returnedValue = ParenthesisService.IsValid(testValue);

            Assert.Equal(expectedResult, returnedValue);
        }

        public static IEnumerable<object[]> TestCases => new List<object[]>()
        {
            new object[] { "", false  },
            new object[] { "[", false  },
            new object[] { "}", false  },
            new object[] { null, false  },
            new object[] { "[{", false },
            new object[] { "[}", false },
            new object[] { "[)", false },
            new object[] { "[()", false },
            new object[] { "[(])", false },
            new object[] { "(){}}{", false },
            new object[] { "(]", false },
            new object[] { "[{}]", true },
            new object[] { "[]{}", true },
            new object[] { "()", true },
            new object[] { "()[]{}", true }

        };
    }
}
