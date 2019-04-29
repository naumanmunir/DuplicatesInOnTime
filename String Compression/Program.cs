using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Compression
{
    class Program
    {
        static void Main(string[] args)
        {
            Compress(new char {'' });
        }

        static int Compress(char[] chars)
        {

            int count = 1;

            for (int i = 0; i < chars.Length - 1; i++)
            {
                if (chars[i + 1] == chars[i])
                    count++;
                else
                {
                    if (count > 1)
                        chars[i] = Convert.ToChar(count);

                    count = 1;
                }
            }


            return chars.Length;
        }
    }
}
