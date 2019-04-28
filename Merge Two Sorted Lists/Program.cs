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
            string num1 = "25";
            string num2 = "10";

            int num1Rep = 0;

            for (int i = 0; i < num1.Length; i++)
            {
                num1Rep +
            }
            


            ListNode listNode = new ListNode(1);
            listNode.next = new ListNode(2);
            listNode.next.next = new ListNode(4);

            ListNode listNode2 = new ListNode(3);
            listNode2.next = new ListNode(5);


            var res = MergeTwoLists(listNode, listNode2);

            Console.ReadLine();
        }

        static ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {

            var lcurr = l1;
            var l2curr = l2;
            ListNode result = new ListNode(l1.val);

            var res = result;

            while (lcurr.next != null || l2curr.next != null)
            {
                if (lcurr.val <= l2curr.val && l2curr.val <= lcurr.next.val)
                {
                    ListNode node = new ListNode(l2curr.val);
                    res.next = node;
                    res = res.next;
                    l2curr = l2curr.next;
                }
                else if(lcurr.val <= l2curr.val && l2curr.val <= lcurr.next.val)
                {
                    ListNode node = new ListNode(lcurr.val);
                    res.next = node;
                    res = res.next;
                    lcurr = lcurr.next;
                }

            }

            return result;
        }
    }
}
