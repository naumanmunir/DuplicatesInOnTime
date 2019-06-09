using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shortest_Distance_to_a_Character
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "loveleetcode";
            char c = 'e';

            var res = ShortestToChar(word, c);

            Console.ReadLine();

        }

        static int[] ShortestToChar(string S, char C)
        {

            List<int> res = new List<int>();

            Dictionary<int, int> vals = new Dictionary<int, int>();

            for (int i = 0; i < S.Length; i++)
            {
                if (S[i] == C)
                {
                    vals.Add(i, 0);
                }
                else
                {
                    vals.Add(i, -1);
                }
                
            }

            var split = S.Split(C);

            foreach (var item in split)
            {
                if (!string.IsNullOrEmpty(item))
                {
                    for (int i = item.Length; i > 0; i--)
                    {
                        res.Add(i);
                    }
                    res.Add(0);
                }

            }

            return new int[1];
        }
    }
}
