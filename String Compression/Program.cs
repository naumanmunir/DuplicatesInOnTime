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
            var res = Compress(new char[] { 'a', 'a', 'a', 'b', 'b', 'a', 'a'});

            Console.ReadLine();
        }

        static int Compress(char[] chars)
        {
            if (chars.Length <= 1) return chars.Length;
            if (chars.Length == 2 && chars[0] == chars[1])
            {
                chars[1] = Convert.ToChar(2.ToString());
                return chars.Length;
            }
            if (chars.Length == 2 && chars[0] != chars[1])
            {
                return chars.Length;
            }

            int count = 1;

            char prev = chars[0];
            int j = 0;
            
            for (int i = 1; i < chars.Length; i++)
            {
                if (chars[i] != prev)
                {
                    chars[j] = prev;
                    j++;

                    if (count > 1)
                    {
                        string intStr = count.ToString();
                        for (int g = 0; g < intStr.Length; g++)
                        {
                            chars[j] = intStr[g];
                            j++;
                        }

                    }

                    count = 1;
                }
                else
                    count++;

                prev = chars[i];

            }

            chars[j] = prev;
            j++;

            if (count > 1)
            {
                string intStr = count.ToString();
                for (int g = 0; g < intStr.Length; g++)
                {
                    chars[j] = intStr[g];
                    j++;
                }

            }


            return j;
        }
    }
}
