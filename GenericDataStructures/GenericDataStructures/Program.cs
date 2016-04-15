using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            Console.WriteLine(stack.Empty());
            for(int i = 0; i<10; i++) stack.Push(i);
            for(int i = 0; i<10; i++) Console.WriteLine(stack.Pop());
            Console.ReadLine();

            Queue<int> queue = new Queue<int>();
            Console.WriteLine(queue.Empty());
            for (int i = 0; i < 10; i++) queue.Push(i);
            for (int i = 0; i < 10; i++) Console.WriteLine(queue.Pop());
            Console.ReadLine();
        }
    }
}
