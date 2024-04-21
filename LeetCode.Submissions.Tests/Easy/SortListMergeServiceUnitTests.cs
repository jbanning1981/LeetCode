using LeetCode.Submissions.Easy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LeetCode.Submissions.Tests.Easy
{
    [Trait("Category", "Easy")]
    [Trait("Category", "Unit")]
    public class SortListMergeServiceUnitTests
    {
        SortListMergeService _sortListMergeService = new();

        /*
            Input: list1 = [1,2,4], list2 = [1,3,4]
            Output: [1,1,2,3,4,4]

            Example 2:

            Input: list1 = [], list2 = []
            Output: []

            Example 3:

            Input: list1 = [], list2 = [0]
            Output: [0]
        */
        [Theory]
        [MemberData(nameof(CreateTestLists))]
        public void SortListMerge_WhenGivenTwoLists_ReturnsMergedList(ListNode nodeOne, ListNode nodeTwo, int expectedResultCount)
        {
            var sortedList = _sortListMergeService.MergeTwoLists(nodeOne, nodeTwo);

            int currentValue = -int.MaxValue;
            int nodeCount = 0;
            if (sortedList != null)
            {
                for (var currentNode = sortedList; currentNode != null; currentNode = currentNode.next)
                {
                    Assert.True(currentNode.val >= currentValue);
                    currentValue = currentNode.val;
                    nodeCount++;
                }
            }


            Assert.Equal(expectedResultCount, nodeCount);


        }

        public static IEnumerable<object[]> CreateTestLists()
        {
            var listOneItemFour = new ListNode(4, null);
            var listOneItemTwo = new ListNode(2, listOneItemFour);
            var listOneItemOne = new ListNode(1, listOneItemTwo);

            var listTwoItemFour = new ListNode(4, null);
            var listTwoItemThree = new ListNode(3, listTwoItemFour);
            var listTwoItemOne = new ListNode(1, listTwoItemThree);

            /*
                list1 = [-9,3]
                list2 = [5,7]
            */

            var listThreeItemOne = new ListNode(-9, new ListNode(3, null));
            var listFourItemOne = new ListNode(5, new ListNode(7, null));

            return new List<object[]>
            {
                new object[] { listThreeItemOne, listFourItemOne, 4 },
                new object[] { null, new ListNode(0), 1 },
                new object[] { listOneItemOne, listTwoItemOne, 6 },
                new object[] { null, null, 0 },
                new object[] { new ListNode(2), new ListNode(1), 2 }
            };
        }




    }
}
