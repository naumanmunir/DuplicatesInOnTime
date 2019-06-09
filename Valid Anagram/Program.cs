using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valid_Anagram
{
    class Program
    {
        static void Main(string[] args)
        {
            IsAnagram("a", "b");
        }

        public static bool IsAnagram(string s, string t)
        {

            Dictionary<char, int> word = new Dictionary<char, int>();

            for (int i = 0; i < s.Length; i++)
            {
                if (word.ContainsKey(s[i]))
                    word[s[i]] += 1;
                else
                    word.Add(s[i], 1);
            }


            for (int i = 0; i < t.Length; i++)
            {
                if (word.ContainsKey(t[i]))
                    word[t[i]] -= 1;
                else
                    return false;
            }

            foreach (var c in word)
            {
                if (c.Value != 0)
                    return false;
            }

            return true;
        }
    }
}
