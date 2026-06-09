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



            Dictionary<int, string> map = new Dictionary<int, string>();
            ReaderWriterLockSlim _lock = new ReaderWriterLockSlim();


            void add(int key, string value)
            {
                bool lockAcquired = false;
                try
                {
                    _lock.EnterWriteLock();
                    lockAcquired = true;
                    map[key] = value;
                }
                finally
                {
                    if (lockAcquired) _lock.ExitWriteLock();
                }
            }

            string get(int key)
            {
                bool lockAcquired = false;
                try
                {
                    _lock.EnterReadLock();
                    lockAcquired = true;
                    return map[key];
                }
                finally
                {
                    if (lockAcquired) _lock.ExitReadLock();
                }
            }
        }
    }
}
