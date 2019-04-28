using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Add_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            var res = AddStrings("408", "5");

            Console.ReadLine();
        }

        static string AddStrings(string num1, string num2)
        {
            if (num1.Length == 0 || num2.Length == 0)
                return string.Empty;

            if (num1.Length == 1 && num2.Length == 1)
            {
                var res = (num1[0] - '0') + (num2[0] - '0');
                return res.ToString();
            }

            num1 = num1.TrimStart('0');
            num2 = num2.TrimStart('0');

            StringBuilder sb = new StringBuilder();
            int carry = 0;

            int length = 0;

            if (num1.Length > num2.Length)
                length = num1.Length;
            else
                length = num2.Length;

            for (int i = 0; i < length; i++)
            {
                int currNum1 = 0;
                int currNum2 = 0;

                if (num1.Length - i - 1 >= 0)
                    currNum1 = num1[num1.Length-i-1] - '0';


                if (num2.Length - i - 1 >= 0)
                    currNum2 = num2[num2.Length-i-1] - '0';


                var sum = currNum1 + currNum2 + carry;
                carry = 0;
                if (sum > 9 && length >=2)
                {
                    carry = sum / 10;
                    sum = sum % 10;
                }

                sb.Insert(0, sum);
            }

            if (carry > 0)
            {
                sb.Insert(0, carry);
            }

            return sb.ToString();
        }
    }
}
