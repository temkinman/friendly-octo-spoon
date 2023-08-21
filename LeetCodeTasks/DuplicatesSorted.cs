namespace LeetCodeTasks;

public class DuplicatesSorted
{
    public static ListNode DeleteDuplicates(ListNode head)
    {
        while(head.next != null)
        {
            Console.WriteLine($"val = {head.val}");
        }

        return head;
    }
}
