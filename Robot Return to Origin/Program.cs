using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot_Return_to_Origin
{
    class Program
    {
        static void Main(string[] args)
        {
            var res = JudgeCircle("UDLLDR");
        }

        static bool JudgeCircle(string moves)
        {
            int x = 0;
            int y = 0;

            for (int i = 0; i < moves.Length; i++)
            {
                if (moves[i] == 'U')
                    y++;
                else if (moves[i] == 'D')
                    y--;
                else if(moves[i] == 'L')
                    x--;
                else if(moves[i] == 'R')
                    x++;
            }

            if (x == 0 && y == 0)
                return true;
            else
                return false;
        }
    }
}
