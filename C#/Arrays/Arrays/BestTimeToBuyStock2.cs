using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class BestTimeToBuyStock2
    { 
        //https://leetcode.com/problems/best-time-to-buy-and-sell-stock-ii/description/
        public int MaxProfit(int[] prices)
        {
            int max = 0;
            int current = 0, next = 1;
            while (next < prices.Length)
            {
                if (prices[current] < prices[next])
                {
                    max += prices[next] - prices[current];
                }
                next++;
                current++;
            }
            return max;
        }
    }
}
