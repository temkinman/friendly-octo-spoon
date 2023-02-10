/*
 21. Merge Two Sorted Lists
You are given the heads of two sorted linked lists list1 and list2.

Merge the two lists in a one sorted list. The list should be made by splicing together the nodes of the first two lists.

Return the head of the merged linked list.
 */

using System.Collections.Generic;

namespace LeetCodeTasks
{
    public static class MergeTwoSortedLists
    {
        public static int[] MergeArrays(int[] first, int[] second)
        {
            int size = first.Length + second.Length;
            int[] result = new int[size];

            int i = 0;
            int j = 0;
            int ind = 0;

            while (i < first.Length || j < second.Length)
            {
                if (first[i] == second[j])
                {
                    result[ind++] = first[i++];
                    result[ind++] = second[j++];
                    continue;
                }

                if (first[i] < second[i])
                {
                    while (first[i] < second[j])
                    {
                        result[ind++] = first[i++];
                    }
                }
                else
                {
                    while (first[i] > second[j])
                    {
                        result[ind++] = second[j++];
                    }
                }
            }

            return result;
        }

        public static ListNode MergeListNodes(ListNode list1, ListNode list2)
        {
            var head = new ListNode(0);
            var start = head;

            while (list1 != null && list2 != null)
            {
                if (list1.val <= list2.val)
                {
                    start.next = list1;
                    list1 = list1.next;
                }
                else
                {
                    start.next = list2;
                    list2 = list2.next;
                }

                start = start.next;
            }

            if (list1 != null)
            {
                start.next = list1;
            }

            if (list2 != null)
            {
                start.next = list2;
            }

            return head.next;
        }
    }
}

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
