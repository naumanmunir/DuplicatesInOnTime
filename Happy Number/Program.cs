using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Happy_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var res = IsHappy(7);

        }

        static bool IsHappy(int n)
        {
            List<int> sumSeen = new List<int>();

            if (n == 0) return false;

            int sum = n;

            while (sum != 1)
            {

                if (sum >= 10 && sum < 100)
                {
                    var rightNum = sum % 10;
                    var leftNum = sum / 10;

                    sum = (rightNum * rightNum) + (leftNum * leftNum);

                    if (sum == 1) break;

                    if (!sumSeen.Contains(sum))
                    {
                        sumSeen.Add(sum);
                    }
                    else return false;
                }
                if (sum < 10)
                {
                    sum *= sum;
                    if (sum == 1) break;

                    if (!sumSeen.Contains(sum))
                    {
                        sumSeen.Add(sum);
                    }
                    else return false;
                }
                if (sum >= 100)
                {

                    int tmp = 0;

                    while (sum > 0)
                    {
                        var num = sum % 10;

                        sum = sum / 10;

                        tmp += num * num;

                    }

                    sum = tmp;
                    if (sum == 1) break;
                    if (!sumSeen.Contains(sum))
                    {
                        sumSeen.Add(sum);
                    }
                    else return false;
                }

            }


            return true;
        }
    }
}
