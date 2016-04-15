using System.Collections.Generic;

namespace GenericDataStructures
{
    internal class Queue<T>
    {
        private readonly List<T> QueueArray = new List<T>();

        public int Size => QueueArray.Count;

        public void Push(T element)
        {
            QueueArray.Add(element);
        }

        public T Pop()
        {
            var tmp = QueueArray[0];
            QueueArray.RemoveAt(0);
            //for (int i = 1; i < QueueArray.Count; i++) QueueArray[i - 1] = QueueArray[i];
            return tmp;
        }

        public bool Empty()
        {
            return QueueArray.Count == 0;
        }
    }
}