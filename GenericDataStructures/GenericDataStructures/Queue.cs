using System.Collections.Generic;

namespace GenericDataStructures
{
    class Queue<T>
    {
        private List<T> QueueArray = new List<T>();

        public void Push(T element)
        {
            QueueArray.Add(element);
        }

        public T Pop()
        {
            T tmp = QueueArray[0];
            QueueArray.RemoveAt(0);
            //for (int i = 1; i < QueueArray.Count; i++) QueueArray[i - 1] = QueueArray[i];
            return tmp;
        }

        public bool Empty()
        {
            return (QueueArray.Count == 0);
        }

        public int Size => QueueArray.Count;
    }
}
