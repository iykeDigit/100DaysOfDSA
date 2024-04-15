using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class LongestCommon
    {
        //https://leetcode.com/problems/longest-common-prefix/description/
        public string LongestCommonPrefix(string[] strs)
        {
            var index = 0;
            var res = "";

            while (index < strs[0].Length)
            {
                var item = strs[0][index];
                for (int i = 1; i < strs.Length; i++)
                {
                    if (index == strs[i].Length || item != strs[i][index])
                    {
                        return res;
                    }
                }
                res += item.ToString();
                index++;
            }
            return res;

        }
    }
}
