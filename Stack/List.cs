using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Stack
{
    public class List<T>
        where T : ICloneable
    {
        private T def = default(T);
        Node<T> head;
        public int count { get; private set; }
        private string mes_em = "Stack is Empty.";

       public void Push(T data)
        {
            Node<T> temp = new Node<T>(data);
            temp.Next = head;
            head = temp;
            ++count;
        }
        public T Pop()
        {
            if (count == 0) Console.WriteLine(mes_em);
            else
            {
                Node<T> temp = head;
                head = head.Next;
                --count;
                return temp.Data;
            }
            return def;
        }
        public T Top()
        {
            if (count == 0) Console.WriteLine(mes_em);
            else 
            {
                return (T) head.Data.Clone();
            }
            return def;
        }
        public void Print()
        {
            Node<T> temp = head;
            if (count == 0) Console.WriteLine(mes_em);
            while (temp != null)
            {
                Console.WriteLine(temp.Data);
                temp = temp.Next;
            }
        }

        public class Node<TElement>
        {
            public TElement Data { get; set; }
            public Node<TElement> Next { get; set; }
            public Node(TElement data)
            {
                Data = data;
            }
 
        }
    }
}

