using LeetCode.Submissions.Easy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Submissions.Tests.Easy
{
    [Trait("Category", "Unit")]
    [Trait("Category", "Easy")]
    public class FizzBuzzUnitTests
    {
        private FizzBuzzService _fizzBuzzService;

        public FizzBuzzUnitTests()
        {
            _fizzBuzzService = new FizzBuzzService();
        }

        [Theory]
        [MemberData(nameof(TestCases))]
        public void FizzBuzzV1_WhenProvidedValidInt_GeneratesListOutput(int arraySize, string[] expectedResult)
        {
            var returnedArray = _fizzBuzzService.FizzBuzzV1(arraySize);

            for(int counter = 0; counter < returnedArray.Count; counter++) 
            {
                Assert.Equal(expectedResult[counter], returnedArray[counter]);
            }
        }

        [Theory]
        [MemberData(nameof(TestCases))]
        public void FizzBuzzV2_WhenProvidedValidInt_GeneratesListOutput(int arraySize, string[] expectedResult)
        {
            var returnedArray = _fizzBuzzService.FizzBuzzV2(arraySize);

            for (int counter = 0; counter < returnedArray.Count; counter++)
            {
                Assert.Equal(expectedResult[counter], returnedArray[counter]);
            }
        }

        [Theory]
        [MemberData(nameof(TestCases))]
        public void FizzBuzzV3_WhenProvidedValidInt_GeneratesListOutput(int arraySize, string[] expectedResult)
        {
            var returnedArray = _fizzBuzzService.FizzBuzzV3(arraySize);

            for (int counter = 0; counter < returnedArray.Count; counter++)
            {
                Assert.Equal(expectedResult[counter], returnedArray[counter]);
            }
        }

        [Theory]
        [MemberData(nameof(TestCases))]
        public void FizzBuzzV4_WhenProvidedValidInt_GeneratesListOutput(int arraySize, string[] expectedResult)
        {
            var returnedArray = _fizzBuzzService.FizzBuzzV4(arraySize);

            for (int counter = 0; counter < returnedArray.Count; counter++)
            {
                Assert.Equal(expectedResult[counter], returnedArray[counter]);
            }
        }

        [Theory]
        [MemberData(nameof(TestCases))]
        public void FizzBuzzV5_WhenProvidedValidInt_GeneratesListOutput(int arraySize, string[] expectedResult)
        {
            var returnedArray = _fizzBuzzService.FizzBuzzV5(arraySize);

            for (int counter = 0; counter < returnedArray.Count; counter++)
            {
                Assert.Equal(expectedResult[counter], returnedArray[counter]);
            }
        }

        [Theory]
        [MemberData(nameof(TestCases))]
        public void FizzBuzzV6_WhenProvidedValidInt_GeneratesListOutput(int arraySize, string[] expectedResult)
        {
            var returnedArray = _fizzBuzzService.FizzBuzzV6(arraySize);

            for (int counter = 0; counter < returnedArray.Count; counter++)
            {
                Assert.Equal(expectedResult[counter], returnedArray[counter]);
            }
        }

        public static IEnumerable<object[]> TestCases => new List<object[]>()
        {
            new object[] { 3, new[] { "1", "2", "Fizz" } },
            new object[] { 5,  new[] { "1", "2", "Fizz", "4", "Buzz" }  },
            new object[] { 15, new[] { "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz" } },
        };
    }
}
