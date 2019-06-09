using References;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merge_Two_Sorted_Lists
{
    class Program
    {
        static void Main(string[] args)
        {

            ListNode listNode = new ListNode(5);

            ListNode listNode2 = new ListNode(1);
            listNode2.next = new ListNode(2);
            listNode2.next.next = new ListNode(4);
            listNode2.next.next.next = new ListNode(5);

            var res = MergeTwoLists(listNode, listNode2);

            Console.ReadLine();
        }

        static ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            if (l1 == null && l2 == null) return null;
            if (l1 == null) return l2;
            if (l2 == null) return l1;
            if ((l1.next == null && l2.next == null) && (l2.val <= l1.val)) { l2.next = l1; return l2; }

            var curr = l1;
            var curr2 = l2;
            ListNode prev = curr;
            while (curr.next != null && curr2.next != null)
            {
                if (curr2.val <= curr.val)
                {
                    ListNode n = new ListNode(curr2.val);
                    var tmp = curr.next;
                    curr.next = n;
                    n.next = tmp;

                    prev = curr;
                    curr2 = curr2.next;
                    curr = curr.next;

                }
                else
                {
                    prev = curr;
                    curr = curr.next;

                }

            }


            while (curr2 != null)
            {
                if (curr2.val <= curr.val)
                {
                    var tmp = curr;
                    curr = new ListNode(curr2.val);
                    curr.next = tmp;

                    curr2 = curr2.next;
                }
                else
                {
                    curr.next = curr2;
                    curr = curr.next;
                    curr2 = curr2.next;
                }
                
            }


            if (curr2.val <= prev.val)
            {
                var tmp = prev.next;
                prev.next = curr2;

                while (prev.next != null)
                {
                    prev = prev.next;
                }

                prev.next = tmp;
            }

            return l1;
        }
    }
}
