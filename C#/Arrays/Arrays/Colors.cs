using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class Colors
    {
        //https://leetcode.com/problems/sort-colors/description/
        public void SortColors(int[] nums)
        {
            int low = 0, mid = 0, high = nums.Length - 1;
            while (mid <= high)
            {
                switch (nums[mid])
                {
                    case 0:
                        int tmp = nums[mid];
                        nums[mid++] = nums[low];
                        nums[low++] = tmp;
                        break;
                    case 2:
                        int temp = nums[mid];
                        nums[mid] = nums[high];
                        nums[high--] = temp;
                        break;
                    case 1:
                        mid++;
                        break;
                }
            }
        }


    }
}
