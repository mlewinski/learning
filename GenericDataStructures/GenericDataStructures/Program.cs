using System;

namespace GenericDataStructures
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var stack = new Stack<int>();
            Console.WriteLine(stack.Empty());
            for (var i = 0; i < 10; i++) stack.Push(i);
            for (var i = 0; i < 10; i++) Console.WriteLine(stack.Pop());
            Console.ReadLine();

            var queue = new Queue<int>();
            Console.WriteLine(queue.Empty());
            for (var i = 0; i < 10; i++) queue.Push(i);
            for (var i = 0; i < 10; i++) Console.WriteLine(queue.Pop());
            Console.ReadLine();
        }
    }
}