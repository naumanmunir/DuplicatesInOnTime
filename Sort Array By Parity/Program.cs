using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_Array_By_Parity
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[] {7, 10, 5, 2, 2, 9};
            SortArrayByParity(A);
        }

        static int[] SortArrayByParity(int[] A)
        {
            LinkedList<int> ret = new LinkedList<int>();

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] % 2 == 0)
                {
                    ret.AddFirst(A[i]);
                }
                else if (A[i] % 1 == 0)
                {
                    ret.AddLast(A[i]);
                }
            }

            return ret.ToArray();
        }
    }
}
