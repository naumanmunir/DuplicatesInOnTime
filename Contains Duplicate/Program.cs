using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contains_Duplicate
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = {1,1,1,3,3,4,3,2,4,2};

            ContainsDuplicate(nums);
        }

        static bool ContainsDuplicate(int[] nums)
        {

            if (nums.Length <= 1)
                return false;

            Dictionary<int, int> numsCount = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (numsCount.ContainsKey(nums[i]))
                {
                    numsCount[nums[i]] = 2;
                }
                else
                {
                    numsCount.Add(nums[i], 1);
                }
            }



            return numsCount.Any(x => x.Value == 2);
        }
    }
}
