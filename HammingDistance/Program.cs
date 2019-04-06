using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HammingDistance
{
    class Program
    {
        //461. Hamming Distance
        static void Main(string[] args)
        {
            var result = HammingDistance(1, 7);

        }

        static int HammingDistance(int x, int y)
        {
            var xorResult = x ^ y;

            return countSetBits(g);
        }

        static int countSetBits(int n)
        {
            int count = 0;
            while (n > 0)
            {
                count += n & 1;
                n = n >> 1;
            }
            return count;
        }
    }
}
