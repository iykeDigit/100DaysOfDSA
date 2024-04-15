// See https://aka.ms/new-console-template for more information
using System.Text;

var arr = new int[] { 1, 0, 1, 0, 1, 0, 1 };
var list = new List<string> { "Hello", "World" };
var strs = new string[] { "flower", "flow", "flight" };
var res = CanPlaceFlowers(arr,2);

Console.WriteLine( );


static bool CanPlaceFlowers(int[] flowerbed, int n)
{
    for (int i = 0; i < flowerbed.Length; i++)
    {
        //if ((i == 0 || flowerbed[i - 1] == 0) && flowerbed[i] == 0 && (i == flowerbed.Length - 1 || flowerbed[i + 1] == 0))
        if ((i == 0 || flowerbed[i - 1] == 0) && flowerbed[i] == 0 && (i == flowerbed.Length - 1 || flowerbed[i + 1] == 0))
        {
            flowerbed[i] = 1;
            n--;
            if (n == 0) return true;
        }
    }
    return false;
}
