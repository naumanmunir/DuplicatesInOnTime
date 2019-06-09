using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_and_Say
{
    class Program
    {
        static void Main(string[] args)
        {
            var res = CountAndSay(4);

            Console.ReadLine();
        }

        static string CountAndSay(int n)
        {

            StringBuilder sb = new StringBuilder("1");
            char prev = sb[0];

            int count = 1;
            int anchor = 0;
            for (int i = 0; i < n; i++)
            {
                
                for (int j = 0; j < sb.Length-1; j++)
                {

                    if (sb[j] != sb[j+1])
                    {
                        sb.Insert(anchor, count.ToString());

                        count = 1;
                        
                    }
                    else
                        count++;

                    anchor++;
                }

                if (count > 1)
                {
                    sb[anchor] = Convert.ToChar(count.ToString());
                    anchor++;

                    count = 1;
                }
                else
                    sb.Insert(0, count.ToString());
            }

            return string.Empty;
        }
    }
}
