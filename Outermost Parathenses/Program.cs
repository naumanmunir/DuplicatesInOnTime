using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Outermost_Parathenses
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = RemoveOuterParentheses("(()())(())");

            Console.ReadLine();
        }

        static string RemoveOuterParentheses(string S)
        {
            StringBuilder sb = new StringBuilder();
            int opIndex = 0;
            int cpIndex = 0;
            int sum = 0;

            for (int i = 0; i < S.Length; i++)
            {
                if (S[i] == '(')
                {
                    sum++;
                    if (sum == 1)
                    {
                        opIndex = i;
                    }
                }
                else if(S[i] == ')')
                {
                    sum--;
                    if (sum == 0)
                    {
                        cpIndex = i;

                        int start = opIndex + 1;
                        int length = cpIndex - start;

                        sb.Append(S.Substring(start, length));
                    }
                }
            }

            return sb.ToString();
        }
    }
}
