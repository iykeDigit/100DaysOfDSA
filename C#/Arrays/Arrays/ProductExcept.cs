using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class ProductExcept
    {
        public int[] ProductExceptSelf(int[] nums)
        {
            int temp = 1;
            var res = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                res[i] = temp;
                temp = temp * nums[i];
            }

            temp = 1;
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                res[i] = temp * res[i];
                temp = temp * nums[i];
            }

            return res;
        }
    }
}
