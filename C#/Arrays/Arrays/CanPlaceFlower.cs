using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class CanPlaceFlower
    {
        public bool CanPlaceFlowers(int[] flowerbed, int n)
        {
            for (int i = 0; i < flowerbed.Length; i++)
            {
                if ((i == 0 || flowerbed[i - 1] == 0) && flowerbed[i] == 0 && (i == flowerbed.Length - 1 || flowerbed[i + 1] == 0) && n != 0)
                {
                    flowerbed[i] = 1;
                    n--;
                    if (n == 0) return true;
                }
            }
            return n == 0;
        }
    }
}
