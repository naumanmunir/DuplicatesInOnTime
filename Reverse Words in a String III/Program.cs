using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_Words_in_a_String_III
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = "";

            var res = ReverseWords(sentence);

            List<string> rest = new List<string>();
            List<string> rest2 = new List<string>();

            rest.Intersect(rest2).FirstOrDefault().ToArray();

            string[] arr = new string[1];

            //arr.


            Console.ReadLine();
        }

        static string ReverseWords(string s)
        {
            if (s.Length <= 1) return s;

            var words = s.Split(' ');

            StringBuilder sb = new StringBuilder();

            foreach (string word in words)
            {
                var chars = word.Reverse().ToArray();
                var reversed = new string(chars);
                

                sb.Append(reversed + " ");
            }

            return sb.ToString().TrimEnd();
        }
    }
}
