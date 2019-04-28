using References;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Middle_of_the_Linked_List
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode listNode = new ListNode(1);
            listNode.next = new ListNode(2);
            listNode.next.next = new ListNode(3);
            listNode.next.next.next = new ListNode(4);
            listNode.next.next.next.next = new ListNode(5);
            listNode.next.next.next.next.next = new ListNode(6);

            var res = MiddleNode(listNode);

            Console.ReadLine();
        }

        static ListNode MiddleNode(ListNode head)
        {

            int length = 0;

            ListNode curr = head;
            ListNode curr2 = head;

            while (curr != null)
            {
                length++;
                curr = curr.next;
            }

            int mid = length / 2;


            while (curr2 != null && mid > 0)
            {
                mid--;
                curr2 = curr2.next;
            }


            return curr2;
        }
    }
}
