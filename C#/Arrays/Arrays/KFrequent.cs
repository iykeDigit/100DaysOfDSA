using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class KFrequent
    {
        int[] TopKFrequent(int[] nums, int k)
        {
            var dict = new Dictionary<int, int>();
            int max = 0;
            foreach (var item in nums)
            {
                if (dict.ContainsKey(item))
                {
                    dict[item]++;
                }
                else
                {
                    dict[item] = 1;
                }
                max = Math.Max(max, dict[item]);
            }

            var newDict = new Dictionary<int, List<int>>();
            foreach (var item in dict)
            {
                if (newDict.ContainsKey(item.Value))
                {
                    newDict[item.Value].Add(item.Key);
                }
                else
                {
                    newDict[item.Value] = new List<int> { item.Key };
                }
            }

            var index = 0;
            var res = new int[k];

            for (int i = max; i >= 0; i--)
            {
                if (newDict.ContainsKey(i))
                {
                    foreach (var element in newDict[i])
                    {
                        res[index] = element;
                        index++;
                        if (index == k) return res;
                    }
                }
            }
            return res;
        }
    }
}
