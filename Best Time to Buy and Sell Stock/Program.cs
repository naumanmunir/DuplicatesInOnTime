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
            int[] prices = { 7, 1, 5, 3, 6, 4 };

            MaxProfit(prices);
        }

        static int MaxProfit(int[] prices)
        {
            int profit = 0;
            int size = prices.Length;

            for (int i = 0; i < size; i++)
            {
                for (int j = i+1; j < size - 1; j++)
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
