namespace LeetCodeTasks;

public class Testlocker
{
    private static object _key = new object();
    private static object _value = new object();

    public static void LockerRun()
    {
        Console.WriteLine("Start teslockers");

        for (int i = 0; i < 8; i++)
        {
            TestLock();
        }
    }

    private static void TestLock()
    {
        int sum = 0;

        for (int i = 0; i < 10; i++)
        {
            Thread thread = new Thread(() =>
            {
                /* тут  к этой строчке присвоения могут подойти одновременно несколько потоков
                 и допустим sum = 5 в этот момент, соответственно что 
                имея это значения все эти потоки увеличат sum на единицу на строчке buffer++
                и тут получается что некоторые из этих потоков не довоодят sum до 10
                выход в Locker
                 */

                /*
                int buffer = sum;
                Thread.Sleep(1);

                buffer++;
                sum = buffer;
                */
                

                lock (_key)
                {
                    int buffer = sum;
                    Thread.Sleep(1);

                    buffer++;
                    sum = buffer;
                }

                // object _value = new object();

                // если бы объект _value был бы объявлен не static, то сам объект бы не блокировался для каждого потока
                // и другие потоки запросто заходили бы в эту секцию
                lock (_value)
                {
                    Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} started");
                    Thread.Sleep(2000);
                    Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} stoped");
                }



                // вот так выведет всегда sum = 10
                /*
                Thread.Sleep(1);
                sum++;
                */
            });

            thread.Start();
            //Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId}");
        }

        Thread.Sleep(500);

        Console.WriteLine($"sum = {sum}");
    }

    public static void TestLockWithString()
    {
        int sum = 0;
        //AttackHacker();

        for (int i = 0; i < 10; i++)
        {
            Thread thread = new Thread(() =>
            {
                /* одинаковые строки интернируются это означает, что они хранятся в памяти как один объект
                    это состояние непостоянно, они могут ссылаться на один и тот же и объект, а могут и нет
                и если будет одновременно запущен  AttackHacker()  который также юзает в качестве локера строку "value"
                то здесь наш lock будет ожидать завершение работы Lock в методе AttackHacker

                выход в качестве локера юзать object и обязательно static object

                 lock ("value")
                {
                    Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} started");
                    Thread.Sleep(100);
                    Console.WriteLine("Finish attacking");
                }

                 */

                // если бы объект _value был бы объявлен не static, то сам объект бы не блокировался для каждого потока
                // и другие потоки запросто заходили бы в эту секцию
                //Console.WriteLine("***********TestLockWithString**********");

                lock (_key)
                {
                    
                    Console.WriteLine($"**TestLockWithString** Thread {Thread.CurrentThread.ManagedThreadId} started");
                    
                    int buffer = sum;
                    buffer++;
                    sum = buffer;
                    Thread.Sleep(500);
                    Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} stoped");
                }

                // вот так выведет всегда sum = 10
                /*
                Thread.Sleep(1);
                sum++;
                */
            });

            thread.Start();
            
            //Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId}");
        }
        
        AttackHacker(); // тут происзодит конкуренция за объект

        Thread.Sleep(500);

        Console.WriteLine($"sum = {sum}");
    }

    private static void AttackHacker()
    {
        int hackSum = 0;

        //Console.WriteLine("***********AttackHacker**********");

        for (int i = 0; i < 10; i++)
        {
            lock (_key)
            {
                Console.WriteLine($"**AttackHacker** Thread {Thread.CurrentThread.ManagedThreadId} started");
                Console.WriteLine("Start attacking");

                int buffer = hackSum;

                buffer++;
                hackSum = buffer;
                Thread.Sleep(500);
                Console.WriteLine("Finish attacking");
            }
        }
        Thread.Sleep(500);

        Console.WriteLine($"hackSum = {hackSum}");
    }

    /*
     private static void SomeMethod()
    {
        for (int i = 0; i < 10; i++)
        {
            lock ("value")
            {
                Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} started");
                Thread.Sleep(100);
                Console.WriteLine("Finish attacking");
            }
        }
    }

    public static void TestStringLocker()
    {
        for (int i = 0; i < 10; i++)
        {
            Thread thread = new Thread(() =>
            {
                lock ("value")
                {
                    Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} started");
                    Thread.Sleep(2000);
                    Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} stoped");
                }
            });

            thread.Start();
        }

        Thread.Sleep(500);
    }
     */
}
