
namespace LeetCodeTasks
{
    public static class SortArray
    {
        public static int[] SortArrayFromMinToMax(int[] arr)
        {
            
            for (int i = 1; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - i; j++)
                {
                    if (arr[j] > arr[j+1])
                    {
                        (arr[j], arr[j+1]) = (arr[j+1], arr[j]);
                    }
                }
            }

            return arr;
        }
    }
}
