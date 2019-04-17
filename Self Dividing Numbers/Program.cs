using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Self_Dividing_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var t = SelfDividingNumbers(1, 10);

            Console.ReadLine();
        }

        public static IList<int> SelfDividingNumbers(int left, int right)
        {
            List<int> l = new List<int>();

            for (; left <= right; left++)
            {
                int orig = left;
                int t = left;

                bool selfDividing = false;

                while (t > 0)
                {
                    int res = t % 10;

                    if (res != 0)
                    {
                        if (orig % res != 0)
                        {
                            selfDividing = false;
                            break;
                        }
                        else
                        {
                            selfDividing = true;
                            t /= 10;
                        }
                    }
                    else
                    {
                        selfDividing = false;
                        break;
                    }
                }

                if (selfDividing)
                    l.Add(orig);

            }


            return l;
        }
    }
}
