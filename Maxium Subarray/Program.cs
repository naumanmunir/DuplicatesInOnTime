using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maxium_Subarray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Input = new int[] { 8, -19, 5, -4, 20};

            MaxSubArray(Input);

            Console.ReadLine();
        }

        static int MaxSubArray(int[] nums)
        {
            int largest = nums.Sum();

            for (int i = 1; i < nums.Length; i++)
            {
                if (true)
                {

                }

            }



            return largest;
        }
    }
}
