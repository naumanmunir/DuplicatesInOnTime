using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implement_Stack_Using_LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack s = new Stack();

            s.Push(5);
            s.Push(2);
            s.Push(1);
            s.Push(7);

            Queue<int> q = new Queue<int>();

            q.Enqueue(1);
            q.Enqueue(2);

            var p = q.Peek();
            var tmp1 = q.Dequeue();
            var tmp2 = q.Dequeue();
            var res = q.Count;
            Console.WriteLine(s.Peek());
        }
    }

    public class Stack
    {
        public LinkedList<int> head { get; set; } = new LinkedList<int>();

        public void Push(int v)
        {
            head.AddFirst(v);
        }

        public int Pop()
        {
            var res = head.First();
            head.RemoveFirst();

            return res;
        }

        public int Peek()
        {
            return head.First();
        }

        public bool IsEmpty()
        {
            return head.Count == 0 ? true : false;
        }
    }
}
