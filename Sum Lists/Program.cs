using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> ll1 = new LinkedList<int>();
            ll1.AddFirst(8);
            ll1.AddFirst(7);
            ll1.AddFirst(9);

            LinkedList<int> ll2 = new LinkedList<int>();
            ll2.AddFirst(5);
            ll2.AddFirst(8);
            ll2.AddFirst(6);

            //SumLists(ll1, ll2);

            int[] arr = new int[] { 3, 9, 2, 6, 4, 3, 1 };

            //MergeSort(arr);

            var g = multiply(2, "5");
        }

        static LinkedList<int> SumLists(LinkedList<int> input1, LinkedList<int> input2)
        {
            LinkedList<int> ret = new LinkedList<int>();
            int remainder = 0;
            int firstNum = 0;

            var tempHead1 = input1.First;
            var tempHead2 = input2.First;

            while (tempHead1 != null && tempHead2 != null)
            {
                var sum = tempHead1.Value + tempHead2.Value + remainder;
                remainder = sum / 10;
                firstNum = sum % 10;

                ret.AddLast(firstNum);

                tempHead1 = tempHead1.Next;
                tempHead2 = tempHead2.Next;

                if (tempHead1 == null && tempHead2 == null)
                {
                    ret.AddLast(remainder);
                }
            } 


            return ret;
        }

        static int[] MergeSort(int[] arr)
        {
            int[] left = new int[arr.Length / 2];
            int[] right = new int[arr.Length - left.Length];

            for (int i = 0; i < left.Length; i++)
            {
                left[i] = arr[i];
            }

            for (int i = 0; i < right.Length; i++)
            {
                right[i] = arr[left.Length + i];
            }

            return arr;
        }

        static int[] Sort(int[] left, int[] right)
        {
            int i, j, k;

            //if (left[i] )
            //{

            //}

            return left;
        }

        public static int multiply(int a, string b)
        {

            int outNum;

            int.TryParse(b, out outNum);

            return a * outNum;
        }

    }
}
