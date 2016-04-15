using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDataStructures
{
    public class Stack<T>
    {
        private List<T> StackArray = new List<T>();

        public void Push(T element)
        {
            StackArray.Add(element);
        }

        public T Pop()
        {
            T tmp = StackArray[StackArray.Count-1];
            StackArray.RemoveAt(StackArray.Count-1);
            return tmp;
        }

        public bool Empty()
        {
            return (StackArray.Count == 0);
        }

        public int Size => StackArray.Count;
    }
}
