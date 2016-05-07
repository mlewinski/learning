using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Async
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayPrimeCountsAsync();
            Console.WriteLine("-------------------------------------------");
            TestAsync();
            Console.ReadLine();
        }

        static int GetPrimesCount(int start, int count)
        {
            return
                ParallelEnumerable.Range(start, count)
                    .Count(n => Enumerable.Range(2, (int)Math.Sqrt(n) - 1).All(i => n % i > 0));
        }

        static Task<int> GetPrimesCountAsync(int start, int count)
        {
            return Task.Run(() =>
                ParallelEnumerable.Range(start, count).Count(n =>
                    Enumerable.Range(2, (int)Math.Sqrt(n) - 1).All(i => n % i > 0)));
        }

        static async void DisplayPrimeCountsAsync()
        {
            for (int i = 0; i < 10; i++)
                Console.WriteLine(await GetPrimesCountAsync(i * 1000000 + 2, 1000000) +
                " primes between " + (i * 1000000) + " and " + ((i + 1) * 1000000 - 1));
            Console.WriteLine("Done!");
        }

        static async void TestAsync()
        {
            int result = 21*2;
            Console.WriteLine(result);
        }
    }
}
