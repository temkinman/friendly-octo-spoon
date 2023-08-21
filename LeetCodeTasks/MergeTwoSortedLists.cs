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
            int n1 = first.Length;
            int n2 = second.Length;
            int[] result = new int[n1 + n2];

            int i = 0;
            int j = 0;
            int ind = 0;

            while(i < n1)
            {
                result[ind++] = first[i++];
            }

            while(j < n2)
            {
                result[ind++] = second[j++];
            }

            Array.Sort(result);

            for (int k = 1; k < result.Length; k++)
            {
                for (int m = 0; m < result.Length - k; m++)
                {
                    if(result[m + 1] < result[m])
                    {
                        (result[m], result[m + 1]) = (result[m + 1], result[m]);
                    }
                }
            }

            return result;
        }

        public static int[] MergeArraysMyVersion(int[] first, int[] second)
        {
            int n1 = first.Length;
            int n2 = second.Length;
            int[] result = new int[n1 + n2];

            int i = 0;
            int j = 0;

            for (int index = 0; index < result.Length; index++)
            {
                if (i == first.Length && j < second.Length)
                {
                    while (j < second.Length)
                    {
                        result[index++] = second[j++];
                    }

                    if (j == second.Length) break;
                }

                if (j == second.Length && i < first.Length)
                {
                    while (i < first.Length)
                    {
                        result[index++] = first[i++];
                    }
                    if (i == first.Length) break;
                }

                if (first[i] < second[j])
                {
                    result[index] = first[i++];
                }
                else if (first[i] == second[j])
                {
                    result[index++] = first[i++];
                    result[index] = second[j++];
                }
                else
                {
                    result[index] = second[j++];
                }
            }

            return result;
        }

        public static int[] MergeArraysSimpleVersion(int[] first, int[] second)
        {
            int n1 = first.Length;
            int n2 = second.Length;
            int[] result = first.Concat(second).ToArray();

            Array.Sort(result);

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

