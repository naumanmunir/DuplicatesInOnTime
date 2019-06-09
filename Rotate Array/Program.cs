using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rotate_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 1, 2};

            Rotate(nums, 3);

            Console.ReadLine();
        }

        public static void Rotate(int[] nums, int k)
        {
            if (nums.Length == 0 || nums.Length == 1 || k == 0 || nums.Length == k) return;

            int fromRemoveIndex = Math.Abs(nums.Length - k);


            List<int> tmp = new List<int>();

            for (int i = fromRemoveIndex; i < nums.Length; i++)
            {
                tmp.Add(nums[i]);
            }
            for (int i = 0; i <= nums.Length - k; i++)
            {
                tmp.Add(nums[i]);
            }
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = tmp[i];
            }

            /*int prev;

            while(k != 0)
            {
                prev = nums[nums.Length - 1];

                for(int i=0; i < nums.Length; i++)
                {
                    var tmp = nums[i];
                    nums[i] = prev;
                    prev = tmp;
                }


                k--;
            }*/

        }
    }
}
