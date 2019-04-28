using References;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remove_Duplicates_from_Sorted_List_II
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode listNode = new ListNode(1);
            listNode.next = new ListNode(1);
            listNode.next.next = new ListNode(1);
            listNode.next.next.next = new ListNode(2);
            listNode.next.next.next.next = new ListNode(3);

            var res = DeleteDuplicates(listNode);

            Console.ReadLine();
        }

        static ListNode DeleteDuplicates(ListNode head)
        {
            if (head == null) return null;

            var curr = head;
            var tmp = head;
            while (curr.next != null)
            {
                if (tmp.val == tmp.next.val)
                {
                    tmp = tmp.next;

                }
                else
                {
                    curr = tmp.next;
                }
            }


            return head;
        }
    }
}
