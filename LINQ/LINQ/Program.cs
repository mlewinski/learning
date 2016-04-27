using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = {"Tom", "Dick", "Harry"};
            IEnumerable<string> filteredNames = System.Linq.Enumerable.Where(names, n => n.Length >= 4);
            foreach (string name in filteredNames)
            {
                Console.WriteLine(name);
            }
            foreach(string name in names.Where(n=>n.Contains("a"))) Console.WriteLine(name);
            IEnumerable<string> nm = from n in names
                where n.Contains("a")
                select n;

            Console.ReadLine();
        }
    }
}
