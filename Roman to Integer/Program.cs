using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roman_to_Integer
{
    class Program
    {
        static void Main(string[] args)
        {
            RomanToInt("III");

            Console.ReadLine();
        }

        public static int RomanToInt(string s)
        {

            Dictionary<char, int> rep = new Dictionary<char, int>();

            rep.Add('I', 1);
            rep.Add('V', 5);
            rep.Add('X', 10);
            rep.Add('L', 50);
            rep.Add('C', 100);
            rep.Add('D', 500);
            rep.Add('M', 1000);

            int ret = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'I' && (i + 1 < s.Length) && s[i + 1] == 'V')
                {
                    ret += 4;
                    i++;
                }
                else if (s[i] == 'I' && i + 1 < s.Length && s[i + 1] == 'X')
                {
                    ret += 9;
                    i++;
                }
                else if (s[i] == 'X' && i + 1 < s.Length && s[i + 1] == 'L')
                {
                    ret += 40;
                    i++;
                }
                else if (s[i] == 'X' && i + 1 < s.Length && s[i + 1] == 'C')
                {
                    ret += 90;
                    i++;
                }
                else if (s[i] == 'C' && i + 1 < s.Length && s[i + 1] == 'D')
                {
                    ret += 400;
                    i++;
                }
                else if (s[i] == 'C' && i + 1 < s.Length && s[i + 1] == 'M')
                {
                    ret += 900;
                    i++;
                }
                else
                {
                    ret += rep[s[i]];
                }
            }

            return ret;
        }
    }
}
