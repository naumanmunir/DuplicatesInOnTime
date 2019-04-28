using References;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remove_Duplicates_from_Sorted_List
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode listNode = new ListNode(1);
            listNode.next = new ListNode(1);

            var res = DeleteDuplicates(listNode);

            Console.ReadLine();
        }

        private static ListNode DeleteDuplicates(ListNode head)
        {
            if (head == null) return null;

            ListNode curr = head;

            while (curr != null && curr.next != null)
            {
                var tmpNext = curr.next;

                if (curr.val == curr.next.val)
                {
                    curr.next = curr.next.next;
                }
                else
                {
                    curr = curr.next;
                }

            }

            return head;
        }
    }


}
