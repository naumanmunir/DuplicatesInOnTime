using References;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remove_Linked_List_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode listNode = new ListNode(1);
            listNode.next = new ListNode(1);
            listNode.next.next = new ListNode(12);
            listNode.next.next.next = new ListNode(3);
            listNode.next.next.next.next = new ListNode(9);
            listNode.next.next.next.next.next = new ListNode(1);

            var res = RemoveElements(listNode, 1);

            int num = 5 / 2;
            int num2 = 6 / 2;


            Console.ReadLine();

        }
        static ListNode RemoveElements(ListNode head, int val)
        {
            var curr = head;

            while (curr != null && curr.val == val)
            {
                curr = curr.next;
            }

            while (head != null)
            {
                if (head.next != null && head.next.val == val)
                {
                    head.next = head.next.next;
                    head = head.next;
                }
                else
                {
                    head = head.next;
                }

            }

            return curr;
        }
    }


}
