using System.Collections.Generic;

namespace GenericDataStructures
{
    public class Stack<T>
    {
        private readonly List<T> StackArray = new List<T>();

        public int Size => StackArray.Count;

        public void Push(T element)
        {
            StackArray.Add(element);
        }

        public T Pop()
        {
            var tmp = StackArray[StackArray.Count - 1];
            StackArray.RemoveAt(StackArray.Count - 1);
            return tmp;
        }

        public bool Empty()
        {
            return StackArray.Count == 0;
        }
    }
}