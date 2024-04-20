using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Submissions.Easy
{
    /*
     * You are given the heads of two sorted linked lists list1 and list2.
     * Merge the two lists in a one sorted list. The list should be made by splicing together the nodes of the first two lists.
     * Return the head of the merged linked list.
     */
    public class SortListMergeService
    {
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            if (list1 == null && list2 == null)
            {
                return null;
            }

            if (list1 == null && list2 != null)
            {
                return list2;
            }

            if (list1 != null && list2 == null)
            {
                return list1;
            }


            var mergedList = new ListNode();
            var lastNode = mergedList;

            int breakCounter = 0; //Safety check to prevent infinite loop
            while ((list1 != null || list2 != null) && breakCounter < 200)
            {
                if (list1 == null)
                {
                    lastNode.next = list2;
                    break;
                }

                if (list2 == null)
                {
                    lastNode.next = list1;
                    break;
                }

                if (list1.val == list2.val)
                {
                    lastNode.next = new ListNode(list1.val);
                    lastNode.next.next = new ListNode(list2.val);
                    list1 = list1.next;
                    list2 = list2.next;
                    lastNode = lastNode.next.next;
                    continue;

                }

                if (list1.next == null && list2.next == null)
                {
                    if (list1.val <= list2.val)
                    {
                        lastNode.next = new ListNode(list1.val);
                        lastNode.next.next = new ListNode(list2.val);
                    }
                    else
                    {
                        lastNode.next = new ListNode(list2.val);
                        lastNode.next.next = new ListNode(list1.val);
                    }
                    lastNode = lastNode.next.next;
                    break;
                }



                if (list1.val <= list2.val)
                {
                    lastNode.next = list1;
                    list1 = list1.next;
                }
                else
                {
                    lastNode.next = list2;
                    list2 = list2.next;
                }
                lastNode = lastNode.next;
                breakCounter++;
            }

            return mergedList.next;
        }
    }


    /* Definition for singly-linked list. */
    [SuppressMessage("ReSharper", "FieldCanBeMadeReadOnly.Global")]
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

}
