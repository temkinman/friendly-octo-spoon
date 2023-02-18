namespace LeetCodeTasks;

public static class MultiTasks
{
    public static void RunTasks()
    {
        for (int i = 0; i < 100; i++)
        {
            /* так создаются много потоков*/
            //Thread thread = new Thread(DoWork);
            //thread.Start(i);


            /* так создаются 2-3 потоков  помещаем делеагат в очередь потоков.
             * и отличие в то что новый поток не создается, если какой-то из этих что в очереди уже освободился
             потому как создание и запуск потока энергозатратно для системы
            */
            ThreadPool.QueueUserWorkItem(DoWork, i);
            Thread.Sleep(100);
            
            
        }

        Console.WriteLine("Main thread finished!!!!");
    }

    private static void DoWork(object i)
    {
        
        Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} number {i}");
    }
}
