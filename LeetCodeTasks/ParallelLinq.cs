using System.Diagnostics;

namespace LeetCodeTasks;

public static class ParallelLinq
{
    public static void ParallelSum()
    {
        int[] dataArray = Enumerable.Range(0, 10000).ToArray();

        Stopwatch watch = Stopwatch.StartNew();
        Stopwatch watch_2 = Stopwatch.StartNew();

        watch.Start();

        int sum = dataArray.AsParallel().Sum(data => data);
        int sum_2 = 0;

        watch.Stop();

        watch_2.Start();

        foreach (var number in dataArray)
        {
            sum_2 += number;
        }

        watch_2.Stop();

        Console.WriteLine("sum: " + sum);
        Console.WriteLine($"time {watch.ElapsedMilliseconds} ms");
        Console.WriteLine("sum_2: " + sum_2);
        Console.WriteLine($"time_2 {watch.ElapsedMilliseconds} ms");
    }
}
