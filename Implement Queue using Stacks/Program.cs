using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implement_Queue_using_Stacks
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue q = new Queue();

            q.Push(1);
            q.Push(2);
            Console.WriteLine(q.Peek());
            q.Pop();
            q.Empty();

            Console.ReadLine();
        }
    }

    public class Queue
    {
        public List<int> stack { get; set; } = new List<int>();

        public Queue()
        {

        }

        /** Push element x to the back of queue. */
        public void Push(int x)
        {
            stack.Add(x);
        }

        /** Removes the element from in front of queue and returns that element. */
        public int Pop()
        {
            var res = stack[0];

            stack.RemoveAt(0);

            return res;
        }

        /** Get the front element. */
        public int Peek()
        {
            return stack[0];
        }

        /** Returns whether the queue is empty. */
        public bool Empty()
        {
            return stack.Count == 0 ? true : false;
        }
    }
}
