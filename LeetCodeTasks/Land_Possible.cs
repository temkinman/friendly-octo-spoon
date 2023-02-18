/*
 As Far from Land as Possible
Given an n x n grid containing only values 0 and 1, where 0 represents water and 1 represents land,
find a water cell such that its distance to the nearest land cell is maximized, and return the distance.
If no land or water exists in the grid, return -1.

The distance used in this problem is the Manhattan distance: the distance between two cells (x0, y0) and (x1, y1) is |x0 - x1| + |y0 - y1|.

Example 1:
Input: grid = [
    [1,0,1],
    [0,0,0],
    [1,0,1]
]
Output: 2
Explanation: The cell (1, 1) is as far as possible from all the land with distance 2.

Example 2:
Input: grid = [
    [1,0,0],
    [0,0,0],
    [0,0,0]
]
Output: 4
Explanation: The cell (2, 2) is as far as possible from all the land with distance 4.
 */

namespace LeetCodeTasks
{
    public static class Land_Possible
    {
        public static int GetDistance(int[,] coordinates)
        {
            PrintArray(coordinates);

            int rows = coordinates.GetUpperBound(0) + 1;
            int columns = coordinates.Length / rows;

            int maxDistance = 0;
            int prevCoordinate = 0;
            int indexI = 0;
            int indexJ = 0;

            bool noWater = true;
            bool noLand = true;


            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if(coordinates[i, j] == 0)
                    {
                        prevCoordinate = 0;

                        if(noWater) noWater = false;
                    }

                    if (coordinates[i, j] == 1)
                    {
                        if(noLand) noLand = false;
                        
                        if((i != indexI || j != indexJ) && prevCoordinate == 0)
                        {
                            int distance = GetDistanceBetweenPoints(
                                x0: indexI,
                                x1: i - 1,
                                y0: indexJ,
                                y1: j - 1);

                            if(maxDistance < distance)
                            {
                                maxDistance = distance;
                            }

                            indexI = i;
                            indexJ = j;
                        }

                        prevCoordinate = coordinates[i, j];
                    }
                }
            }

            if (noWater && noLand) return -1;


            return maxDistance;
        }

        private static int GetDistanceBetweenPoints(int x0, int x1, int y0, int y1)
        {
            return Math.Abs(x0 - x1) + Math.Abs(y0 - y1);
        }

        private static void PrintArray(int[,] array) 
        {
            
            int rows = array.GetUpperBound(0) + 1;
            int columns = array.Length / rows;

            Console.WriteLine("Initial array:");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
