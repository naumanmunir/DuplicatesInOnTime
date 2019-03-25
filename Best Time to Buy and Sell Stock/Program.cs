using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Best_Time_to_Buy_and_Sell_Stock
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] prices = { 1,2};

            MaxProfit(prices);
        }

        //Naive way of doing it
        //Time complexity: O(n^2), because of 2 nested loops
        //Space complexity: O(1), only one variable is used
        static int MaxProfit(int[] prices)
        {
            int profit = 0;

            for (int i = 0; i < prices.Length; i++)
            {
                for (int j = i+1; j < prices.Length; j++)
                {
                    if (prices[j] - prices[i] > profit)
                    {
                        profit = prices[j] - prices[i];
                    }
                }
            }

            return profit;
        }
    }
}
