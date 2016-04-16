using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic d = new Duck();
            d.Quack();
            d.Waddle();
            Console.ReadLine();
        }
    }
}
