using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class BrickWall
    {
        //https://leetcode.com/problems/brick-wall/
        public int LeastBricks(IList<IList<int>> wall)
        {
            //Time: O(n)
            //Space: O(n)
            var dict = new Dictionary<int, int>();
            var max = 0;
            foreach (var item in wall)
            {
                var sum = 0;
                for (int i = 0; i < item.Count - 1; i++)
                {
                    sum += item[i];
                    if (!dict.ContainsKey(sum)) dict[sum] = 1;
                    else dict[sum]++;
                    max = Math.Max(dict[sum], max);
                }
            }
            return wall.Count - max;
        }

    }
}
