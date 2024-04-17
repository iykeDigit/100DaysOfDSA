using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class SubArray
    {
        //https://leetcode.com/problems/subarray-sum-equals-k/description/
        static int SubarraySum(int[] nums, int k)
        {
            var dict = new Dictionary<int, int>();
            int sum = 0, count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                if (sum == k) count++;

                int diff = sum - k;
                count += dict.ContainsKey(diff) ? dict[diff] : 0;
                if (dict.ContainsKey(sum)) dict[sum]++;
                else dict[sum] = 1;
            }
            return count;
        }
    }
}
