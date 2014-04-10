using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP5
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    #region MyQueue
    class MyQueue<T>
    {
        protected List<T> _queue;
        protected int _capacity;
        public bool IsFull { get { return _queue.Count == _capacity; } }
        public bool IsEmpty { get { return _queue.Count == 0; } }
        public MyQueue(int capacity) //Constructor
        {
            if (capacity <= 0)
                throw new ArgumentException("Capacity must be greater than zero");
            this._capacity = capacity;
            _queue = new List<T>();
        }

        public virtual void Enqueue(T obj)
        {
            if (isFull)
                throw new QueueFullException(this._capacity);
            _queue.Add(obj);
        }
        public T Dequeue()
        {
            if (isEmpty)
                throw new QueueException("Queue is empty");
            T tmp = _queue[0];
            _queue.RemoveAt(0);
            return tmp;
        }
        public T Head
        {
            get
            {
                if (IsEmpty)
                    throw new QueueException("Queue is empty");
                return _queue.First();
            }
        }
        public T Tail
        {
            get
            {
                if (IsEmpty)
                    throw new QueueException("Queue is empty");
                return _queue.Last();
            }
        }

    }
    #endregion
}