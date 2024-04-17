// See https://aka.ms/new-console-template for more information
using System.Text;

var arr = new int[] {1,2,3};
var list = new List<string> { "Hello", "World" };
var strs = new string[] { "flower", "flow", "flight" };
var str = "aabca";
var m = CountPalindromicSubsequence(str);


Console.WriteLine( );

static int CountPalindromicSubsequence(string s)
{
    //Time: O(m) => where n is the length of the set
    //space: O(n) => where n is the length of the string, worse case we may have all unique items in S
    var set = new HashSet<char>(s);
    int count = 0;
    foreach (var item in set)
    {
        int first = s.IndexOf(item);
        int second = s.LastIndexOf(item);

        if (first < second)
        {
            var m = new HashSet<char>(s.Substring(first + 1, second - first - 1));
            count += new HashSet<char>(s.Substring(first + 1, second - first - 1)).Count;
        }
    }
    return count;
}




