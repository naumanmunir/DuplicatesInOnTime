using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ReverseLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList ll = new LinkedList();

            //ll.Add(1);
            //ll.Add(2);
            //ll.Add(3);


            //ReverseList(ll.Head);
            ll.AddAtHead(1);
            ll.AddAtIndex(1, 2);
            ll.Get(1);
            ll.Get(0);
            ll.Get(2);

            var head = ll.Head;
        }

        public static ListNode ReverseList(ListNode head)
        {

            var curr = head;
            ListNode next = null;
            ListNode prev = null;

            while (curr != null)
            {
                next = curr.next;
                curr.next = prev;
                prev = curr;
                curr = next;

            }

            curr = prev;

            return curr;

        }

        
    }

    public class LinkedList
    {
        public ListNode Head { get; set; }

        public int Get(int index)
        {
            if (Head == null || index < 0) return -1;
            if (index == 0) return Head.val;

            int counter = 1;

            var curr = Head;

            while (curr != null && counter < index)
            {
                curr = curr.next;
                counter++;
            }

            if (curr != null && curr.next != null)
            {
                return curr.next.val;
            }

            return -1;
        }

        public void AddAtHead(int val)
        {

            ListNode n = new ListNode(val);
            if (Head == null)
            {
                Head = n;
                return;
            }

            n.next = Head;
            Head = n;

        }

        public void Add(int val)
        {
            ListNode n = new ListNode(val);

            if (Head == null)
            {
                Head = n;
                return;
            }

            var curr = Head;

            while (curr.next != null)
            {
                curr = curr.next;
            }

            curr.next = n;
        }

        public void AddAtIndex(int index, int val)
        {

            ListNode n = new ListNode(val);
            if (index == 0 || index < 0)
            {
                AddAtHead(val);
                return;
            }

            int counter = 1;
            var curr = Head;
            while (counter < index && curr != null)
            {
                curr = curr.next;
                counter++;
            }

            if (curr != null)
            {
                n.next = curr.next;
                curr.next = n;
            }

        }

        public void DeleteAtIndex(int index)
        {
            int counter = 1;

            if ((Head == null && index != 0) || index < 0) return;

            if (index == 0)
            {
                Head = Head.next;
                return;
            }

            var curr = Head;

            while (curr != null && counter < index)
            {
                curr = curr.next;
                counter++;
            }

            if (curr != null && curr.next != null)
            {
                curr.next = curr.next.next;
            }

        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }
}
