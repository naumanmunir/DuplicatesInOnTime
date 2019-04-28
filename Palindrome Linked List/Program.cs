using References;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome_Linked_List
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode listNode2 = new ListNode(1);
            listNode2.next = new ListNode(2);
            listNode2.next.next = new ListNode(1);


            var res = IsPalindrome(listNode2);

            Console.ReadLine();
        }
        static bool IsPalindrome(ListNode head)
        {

            var curr = head;
            ListNode reversed = ReverseList(curr);

            while (curr != null && reversed != null)
            {
                if (curr.val != reversed.val)
                    return false;
                else
                    curr = curr.next;
            }

            return true;
        }

        static ListNode ReverseList(ListNode head)
        {
            var curr = head;
            ListNode prev = null;
            ListNode next = curr;

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
}
