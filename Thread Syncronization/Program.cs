using System.Security.Cryptography.X509Certificates;

namespace Thread_Syncronization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int count = 0;
            //System.Threading.Lock lo = new Lock();
            //Thread thread1 = new Thread(IncrementCounter);
            //Thread thread2 = new Thread(IncrementCounter);
            //thread1.Start();
            //thread2.Start();

            //thread1.Join();
            //thread2.Join();

            //Console.WriteLine(count);


            //void IncrementCounter()
            //{
            //    lock (lo)
            //    {
            //        for (int i = 0; i < 100000; i++)
            //        {
            //            count++;
            //        }
            //    }
            //}



            //Dictionary<int, string> map = new Dictionary<int, string>();
            //ReaderWriterLockSlim _lock = new ReaderWriterLockSlim();


            //void add(int key, string value)
            //{
            //    bool lockAcquired = false;
            //    try
            //    {
            //        _lock.EnterWriteLock();
            //        lockAcquired = true;
            //        map[key] = value;
            //    }
            //    finally
            //    {
            //        if (lockAcquired) _lock.ExitWriteLock();
            //    }
            //}

            //string get(int key)
            //{
            //    bool lockAcquired = false;
            //    try
            //    {
            //        _lock.EnterReadLock();
            //        lockAcquired = true;
            //        return map[key];
            //    }
            //    finally
            //    {
            //        if (lockAcquired) _lock.ExitReadLock();
            //    }
            //}




            //using SemaphoreSlim semaphoreSlim = new SemaphoreSlim(3, 3);

            //while (true)
            //{
            //    semaphoreSlim.Wait();
            //    string input = Console.ReadLine();
            //    Thread thread = new Thread(() =>
            //    {
            //        ProcessInput(input);
            //    });

            //    thread.Start();



            //}

            //void ProcessInput(string? input)
            //{

            //    try
            //    {
            //        Thread.Sleep(500);
            //        Console.WriteLine($"Processed Input:  {input}");
            //    }
            //    finally
            //    {

            //        var prevCount = semaphoreSlim.Release();
            //        Console.WriteLine($"Thread: {Thread.CurrentThread.ManagedThreadId} released the semaphore . prev Count is {semaphoreSlim.CurrentCount}");
            //    }

            //}



            //AutoResetEvent resetEvent = new AutoResetEvent(false);

            //Thread thread = new Thread(() =>
            //{
            //    while (true)
            //    {
            //        resetEvent.WaitOne();
            //        Console.WriteLine("Procoessed");
            //    }
            //});
            //thread.Start();


            //while (true)
            //{
            //    if (Console.ReadLine() != "e")
            //    {
            //        resetEvent.Set();
            //        Console.WriteLine("hello");

            //    }

            //}


            //using ManualResetEvent resetEvent = new ManualResetEvent(false);


            //for (int i = 0; i < 3; i++)
            //{
            //    Thread thread = new Thread(work);
            //    thread.Name = $"thread {i}";
            //    thread.Start();
            //}


            //Console.ReadLine();
            //resetEvent.Set();


            //void work()
            //{
            //    Console.WriteLine($"{Thread.CurrentThread.Name} is waiting for the signal");
            //    resetEvent.WaitOne();
            //    Thread.Sleep(1000);
            //    Console.WriteLine($"{Thread.CurrentThread.Name} has been released");

            //}



            for (int i = 0; i < 10; i++)
            {
                Thread thread = new(work);
                thread.Start();
            }

            void work()
            {
                Console.WriteLine($"Thread {Thread.CurrentThread.Name} started Working");
                Thread.Sleep(10000);
                Console.WriteLine($"Thread {Thread.CurrentThread.Name} finished Working");
            }



        }
    }
}
