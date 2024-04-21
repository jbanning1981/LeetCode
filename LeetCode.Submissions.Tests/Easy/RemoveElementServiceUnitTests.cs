using System.Diagnostics;
using Microsoft.VisualBasic;
using Xunit;



namespace LeetCode.Submissions.Tests.Easy
{
    [Trait("Category", "Unit")]
    [Trait("Category", "Easy")]
    public class RemoveElementServiceUnitTests
    {

        private readonly RemoveElementService _removeElementService = new();

        public static IEnumerable<object[]> TestData() => new List<object[]>()
        {

            new object[] { new int[] { 3, 2, 2, 3 }, 3, new int[] { 2, 2 } },
            new object[] { new int[] { 0, 1, 2, 2, 3, 0, 4, 2 }, 2, new int[] { 0, 1, 4, 0, 3 } },
            new object[] { new int[] { 0, 1, 2, 2, 3, 0, 4, 2 }, 0, new int[] { 2, 1, 2, 2, 3, 4 } },
            new object[] { new int[] { 0, 1, 2, 2, 3, 0, 4, 2 }, 4, new int[] { 0, 1, 2, 2, 3, 0, 2 } }
        };

        [Theory]
        [MemberData(nameof(TestData))]
        public void Verify_RemoveElementService_ReturnsNonMatchingElements_And_Count(int[] inputArray, int elementToRemove, int[] expectedArray)
        {
            int nonMatchingCount = _removeElementService.RemoveElement(inputArray, elementToRemove);
            Assert.True(expectedArray.Length == nonMatchingCount, "Lengths did not match.");
            for (int i = 0; i < nonMatchingCount; i++)
            {
                Assert.True(expectedArray[i] == inputArray[i], $"Index: {i}, Expected {expectedArray[i]}, Actual {inputArray[i]}");
            }
        }
    }
}