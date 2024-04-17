using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class PalindromicSequence
    {
        //https://leetcode.com/problems/unique-length-3-palindromic-subsequences/description/
        public int CountPalindromicSubsequence(string s)
        {
            var set = new HashSet<char>(s);
            int count = 0;
            foreach (var item in set)
            {
                int first = s.IndexOf(item);
                int last = s.LastIndexOf(item);
                if (first < last)
                {
                    count += new HashSet<char>(s.Substring(first + 1, last - first - 1)).Count;
                }
            }
            return count;
        }
    }
}
