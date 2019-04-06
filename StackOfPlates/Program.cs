using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOfPlates
{
    class Program
    {
        static void Main(string[] args)
        {
            MyStack<int> s = new MyStack<int>();
            Node n = new Node(5);
            Node n1 = new Node(1);
            Node n2 = new Node(4);
            Node n3 = new Node(2);

            s.Push(n);
            s.Push(n1);
            s.Push(n2);
            s.Push(n3);

        }
    }

    public class SetOfStack
    {
        public MyStack<MyStack<int>> stacks { get; set; } = new MyStack<MyStack<int>>();
        private int Threshold = 4;
        private int currSize = 0;

        public void Push(Node n)
        {
            if (currSize == Threshold)
            {
                MyStack<int> s = new MyStack<int>();
                s.Push(n);
            }
            else
            {

            }
        }


    }

    public class MyStack<T>
    {
        private Node Top;

        public void Push(Node n)
        {
            n.Next = Top;
            Top = n;
        }

        public int Pop()
        {
            if (Top == null) throw new ArgumentNullException();

            var ret = Top.Data;
            Top = Top.Next;

            return ret;

        }

        public int Peek()
        {
            if (Top == null) throw new ArgumentNullException();

            return Top.Data;
        }

        public bool IsEmpty()
        {
            return Top == null ? true : false;
        }
    }

    public class Node
    {
        public int Data;
        public Node Next;

        public Node(int data)
        {
            Data = data;
        }
    }
}
