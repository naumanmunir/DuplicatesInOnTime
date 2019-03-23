using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_String_Match
{
    class Program
    {
        //Given a string S that only contains "I" (increase) or "D" (decrease), let N = S.length.

        //Return any permutation A of[0, 1, ..., N] such that for all i = 0, ..., N-1:

        //If S[i] == "I", then A[i] < A[i + 1]
        //If S[i] == "D", then A[i] > A[i + 1]

        static void Main(string[] args)
        {
            DiStringMatch("IIDID");

            Console.ReadLine();
        }

        public static int[] DiStringMatch(string S)
        {
            int size = S.Length;
            int low = 0;
            int hi = size;

            int[] output = new int[size+1];

            for (int i = 0; i < S.Length; i++)
            {
                if (S[i] == 'I')
                {
                    output[i] = low++;
                }
                else if (S[i] == 'D')
                {
                    output[i] = hi--;
                }
            }

            output[size] = hi;
            return output;
        }

        public static int Factorial(int number)
        {

            int ret = number;
            while (number > 1)
            {
                ret = ret * (number-1);
                number -=1;
            }

            return ret;
        }

        public static int FactorialRecursive(int number)
        {
            int ret;
            if (number == 1)
                return 1;

            ret = FactorialRecursive(number - 1) * number;

            return ret;
        }
    }
}
