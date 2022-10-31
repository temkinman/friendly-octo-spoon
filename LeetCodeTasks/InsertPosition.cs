namespace LeetCodeTasks;

/*
 Given a sorted array of distinct integers and a target value, return the index if the target is found. If not, return the index where it would be if it were inserted in order.

You must write an algorithm with O(log n) runtime complexity.
 */

public class InsertPosition
{
    public int SearchInsert(int[] nums, int target)
    {
        int left = 0, right = nums.Length - 1;

        while (right > left)
        {
            int m = (left + right) / 2;
            
            if (target == nums[m])
            {
                return m;
            }

            if (nums[m] < target)
            {
                left = m + 1;
            }
            else
            {
                right = m - 1;
            }
        }
        
        return nums[left] < target ? left + 1 : left;
        /*
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == target || nums[i] > target)
            {
                return i;
            }
        }

        return nums.Length;
        */
    }
}