using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuplicatesInOnTime
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr2 = { 1, 2, 3, 1, 3, 6, 6 };

            //FindDuplicates(arr2);

            Console.ReadLine();
        }

        public static int[] FindDuplicates(int[] arr)
        {
            List<int> dups = new List<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[Math.Abs(arr[i])] >= 0)
                {
                    arr[Math.Abs(arr[i])] = -arr[Math.Abs(arr[i])];
                }
                else
                {
                    dups.Add(Math.Abs(arr[i]));
                }
            }


            return dups.ToArray();
        }
    }
}
