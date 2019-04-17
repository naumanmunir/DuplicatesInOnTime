using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intersection_of_Two_Linked_List
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode listNode = new ListNode(2);
            listNode.next = new ListNode(9);
            listNode.next.next = new ListNode(1);
            listNode.next.next.next = new ListNode(2);
            listNode.next.next.next.next = new ListNode(4);

            ListNode listNode2 = new ListNode(2);
            listNode2.next = new ListNode(3);
            listNode2.next.next = new ListNode(2);
            listNode2.next.next.next = new ListNode(4);

            var res = GetIntersectionNode(listNode, listNode2);
        }

        static ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {

            if (headA == null || headB == null) return null;

            var currA = headA;
            var currB = headB;

            Dictionary<ListNode,int> map = new Dictionary<ListNode,int>();
            List<ListNode> hs = new List<ListNode>();
            List<ListNode> hs2 = new List<ListNode>();
            ListNode intersect = null;

            while(currA != null)
            {
                map.Add(currA,currA.val);
                hs.Add(currA);
                currA = currA.next;
            }

            while (currB != null)
            {
                hs2.Add(currB);
                currB = currB.next;
            }

            for (int i = 0; i < hs.Count; i++)
            {
                if (hs[i].val == )
                {

                }
            }


            //while (currB != null)
            //{
            //    if (hs.Contains(currB.val))
            //    {
            //        intersect = currB;
            //        break;
            //    }
            //    else
            //    {
            //        currB = currB.next;
            //    }
            //}

            //var reversedHeadA = ReverseLinkedList(headA);
            //var reversedHeadB = ReverseLinkedList(headB);

            //ListNode intersectNode = null;

            //int matchIndex = 0;

            //while (reversedHeadA != null || reversedHeadB != null)
            //{
            //    if (reversedHeadA.val == reversedHeadB.val)
            //    {
            //        matchIndex++;
            //        reversedHeadA = reversedHeadA.next;
            //        reversedHeadB = reversedHeadB.next;

            //        intersectNode = reversedHeadA;
            //    }
            //    else
            //    {
            //        break;
            //    }
            //}

            //var test = headA;

            //Console.ReadLine();

            return intersect;
        }

        static ListNode ReverseLinkedList(ListNode head)
        {
            var curr = head;
            ListNode prev = null;
            ListNode next = null;

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

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }
}
