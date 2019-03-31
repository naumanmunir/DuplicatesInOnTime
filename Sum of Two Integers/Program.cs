using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_of_Two_Integers
{
    class Program
    {
        //in binary
        static void Main(string[] args)
        {
            GetSum(-2, 3);

            Console.ReadLine();
        }

        static int GetSum(int a, int b)
        {
            var res = a | b;
            return a ^ b;
        }

    }

}
