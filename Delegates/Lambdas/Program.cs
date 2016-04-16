using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Lambdas
{
    class Program
    {
        static void Main(string[] args)
        {
            int factor = 2;
            Func<int, int> multiplier = x => x*factor;
            Func<string, string, int> totalLength = (s1, s2) => s1.Length + s2.Length;
            Console.WriteLine(multiplier(3));
            factor = 30;
            Console.WriteLine(multiplier(10));
            int value = 0;
            Func<int> inc = () => value++;
            Console.Write(totalLength("Hello","World"));
            Console.ReadLine();
        }
    }
}
