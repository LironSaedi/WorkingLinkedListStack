using System;
using System.Text;

namespace LSTACK
{
    class Stack<T>
    {
        public int Count { get; private set; }  
        private LinkedList<T> list = new LinkedList<T>();

        public void Push(T value)
        {
            list.AddFirst(value);
        }

        public T Pop()
        {
            T value = Peek();
            list.RemoveFirst();
            
            return value;
        }

        public T Peek()
        {
            return list.Head.Value;
        }
    }
}
