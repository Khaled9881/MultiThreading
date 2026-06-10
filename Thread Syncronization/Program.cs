using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace Thread_Syncronization
{
    internal class Program
    {
        static async Task Main(string[] args)
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



            //for (int i = 0; i < 10; i++)
            //{
            //    Thread thread = new(work);
            //    thread.Start();
            //}

            //void work()
            //{
            //    Console.WriteLine($"Thread {Thread.CurrentThread.Name} started Working");
            //    Thread.Sleep(10000);
            //    Console.WriteLine($"Thread {Thread.CurrentThread.Name} finished Working");
            //}


            //ThreadPool.QueueUserWorkItem(state =>
            //{
            //    Console.WriteLine(state);
            //}, "Ahmed");


            //Thread.CurrentThread.Join();
            //Console.ReadLine();


            //+++++++++++++++++++++


            //List<Exception> exceptions = new List<Exception>();
            //object lockOb = new object();


            //Thread thread1 = new Thread(work);
            //Thread thread2 = new Thread(work);

            //thread1.Start();
            //thread2.Start();

            //thread1.Join();
            //thread2.Join();


            //foreach (var item in exceptions)
            //{
            //    Console.WriteLine(item.Message);
            //    Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
            //}



            //void work()
            //{
            //    try
            //    {
            //        throw new InvalidOperationException("Error");
            //    }
            //    catch (Exception ex)
            //    {
            //        lock (lockOb)
            //        {
            //            exceptions.Add(ex);
            //        }
            //    }
            //}



            //using var client = new HttpClient();
            //var task = client.GetStringAsync("https://pokeapiss.co/api/v2/pokemon");

            //task.ContinueWith(t =>
            //{
            //    var result = t.Result;
            //    Console.WriteLine(result);

            //});


            //Console.ReadLine();


            //Console.WriteLine("start");

            //await Task.Delay(10000);

            //Console.WriteLine("End");


            //Console.WriteLine("Start");

            //var delayTask = Task.Delay(10000);

            //var workTask = Task.Run(() =>
            //{
            //    for (int i = 0; i < 5; i++)
            //    {
            //        Console.WriteLine($"Work {i}");
            //        Thread.Sleep(1000);
            //    }
            //});

            //await delayTask;

            //Console.WriteLine("Delay finished");

            //await workTask;

            //Console.WriteLine("Done");


            //Console.WriteLine("progeam Startedd");
            //workAsunc();
            //await work2();

            //Console.WriteLine("program Ended");
            //Console.ReadLine();




            //async Task workAsunc()
            //{
            //    Console.WriteLine("Taask Started");
            //    await Task.Delay(2000);
            //    Console.WriteLine("Taask Finihsed");
            //}

            //async Task work2()
            //{
            //    Console.WriteLine("Taask22 Started");
            //    await Task.Delay(10);
            //    Console.WriteLine("Taask22 Finihsed");
            //}

            int[] arr = Enumerable.Range(0, 100).ToArray();
            object l = new object();

            int sum = 0;

            Parallel.For(0, arr.Length, (i) =>
            {
                lock (l)
                {
                    sum += arr[i];
                    Console.WriteLine(Task.CurrentId + "  " + Thread.CurrentThread.IsThreadPoolThread);

                }
            });

            Console.WriteLine(sum);



        }
    }
}
