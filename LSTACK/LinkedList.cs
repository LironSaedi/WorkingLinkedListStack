using System;
using System.Collections.Generic;
using System.Text;

namespace LSTACK
{
    class LinkedList<T>
    {
        public Node<T> Head;
        public int Count;
        
        public void AddFirst(T value)
        {
            if (Head == null)
            {
                Node<T> node = new Node<T>(value);
                Head = node;               
                Count++;
            }

            else
            {
                Node<T> nodeToInsert = new Node<T>(value);
                nodeToInsert.Next = Head;
                Head = nodeToInsert;

                Count++;
            }

        }


        public bool RemoveFirst()
        {
            if (Head == null)
            {
                return false;
            }
            else
            {
                Head = Head.Next;
                Count--;

                return true;
            }
        }

    }
}
