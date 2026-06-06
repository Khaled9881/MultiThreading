namespace MultiThreading
{
    internal class Program
    {
        static Queue<string> requestQueue = new Queue<string>();
        static void Main(string[] args)
        {

            Thread MoniThread = new Thread(() => MonitorThread());
            MoniThread.Start();

            // 1. Enqueue the requests
            Console.WriteLine("Server is running. Type 'exit' to stop.");
            while (true)
            {
                string? input = Console.ReadLine();
                if (input?.ToLower() == "exit")
                {
                    break;
                }

                requestQueue.Enqueue(input);
            }

            void ProcessInput(string? input)
            {
                // Simulate processing time
                Thread.Sleep(2000);
                Console.WriteLine($"Processed input: {input}");
            }


            void MonitorThread()
            {
                while (true)
                {
                    if (requestQueue.Count > 0)
                    {
                        string? s = requestQueue.Dequeue();
                        Thread thread = new Thread(() =>
                        {
                            ProcessInput(s);
                        });
                        thread.Start();

                    }
                }
            }
        }
    }
}







