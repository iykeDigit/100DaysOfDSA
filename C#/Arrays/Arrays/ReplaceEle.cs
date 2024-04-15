using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class ReplaceEle
    {
        //https://leetcode.com/problems/replace-elements-with-greatest-element-on-right-side/
        public int[] ReplaceElements(int[] arr)
        {
            var res = new int[arr.Length];
            var max = arr[arr.Length - 1];
            for (int i = arr.Length - 2; i >= 0; i--)
            {
                max = Math.Max(max, arr[i + 1]);
                res[i] = max;
            }

            res[res.Length - 1] = -1;
            return res;
        }
    }
}
