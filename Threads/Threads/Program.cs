using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Threads
{
    class Program
    {
        private static readonly object Locker = new object();
        private static string x;
        static void Main(string[] args)
        {
            #region Legacy
            ////Thread t = new Thread(WriteY);
            ////t.Start();
            ////Console.WriteLine(t.IsAlive);
            ////t.Join();
            ////Console.WriteLine(t.IsAlive);
            ////Console.WriteLine("Finished"); 

            //new Thread(new Program().Go).Start();
            //bool done = false;
            //ThreadStart action = () =>
            //{
            //    if (!done)
            //    {
            //        done = true; Console.WriteLine("Done");
            //    }
            //};
            //new Thread(action).Start();
            #endregion

            var signal = new ManualResetEvent(false);
            #region Old
            //new Thread(() =>
            //{
            //    Console.WriteLine("Thread T1 waiting for signal....");
            //    signal.WaitOne();
            //    signal.Dispose();
            //    Console.WriteLine("Signal acquired!");
            //}).Start();
            //done = false;
            //Program p = new Program();
            //new Thread(p.Go).Start();
            //new Thread(p.Go2).Start();
            //Thread.Sleep(2000);
            //Console.ReadLine();
            //signal.Set(); 
            //Task.Run(() =>
            //{
            //    while (true)
            //    {
            //        if (x != "exit")
            //        {
            //            Console.WriteLine(x);
            //            Thread.Sleep(1000);
            //        }
            //        else break;
            //    }
            //}); 
            #endregion
            Task<int> primeNumberTask1 = Task.Run(() =>
                Enumerable.Range(2, 3000000).Count(n =>
                    Enumerable.Range(2, (int)Math.Sqrt(n) - 1).All(i => n % i > 0)));
            Console.WriteLine("Task is running...");
            var awaiter = primeNumberTask1.GetAwaiter();
            awaiter.OnCompleted(() =>
            {
                Console.WriteLine("Sleeping");
                Thread.Sleep(2000);
                int result = awaiter.GetResult();
                Console.WriteLine(result);
            });
            var tcs = new TaskCompletionSource<int>();
            new Thread(() =>
            {
                Thread.Sleep(500);
                tcs.SetResult(42);
            }) {IsBackground = false}.Start();
            Console.WriteLine(tcs.Task.Result);
            Console.ReadLine();
        }

        static void WriteY()
        {
            for (long i = 0; i < 1000000; i++) ;
        }

        void Go()
        {
            for (int i = 0; i < 10; i++)
                lock (Locker)
                {
                    Console.WriteLine("T1 w sekcji krytycznej");
                    Thread.Sleep(1000);
                }
        }

        void Go2()
        {
            for (int i = 0; i < 10; i++)
                lock (Locker)
                {
                    Console.WriteLine("T2 w sekcji krytycznej");
                    Thread.Sleep(1000);
                }
        }
    }
}
