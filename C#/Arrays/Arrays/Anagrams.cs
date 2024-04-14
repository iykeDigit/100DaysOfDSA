using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class Anagrams
    {
        IList<IList<string>> GroupAnagrams(string[] strs)
        {
            var dict = new Dictionary<string, IList<string>>();

            foreach (var s in strs)
            {
                var arr = new char[26];
                for (int i = 0; i < s.Length; i++)
                {
                    arr[s[i] - 'a']++;
                }

                var str = new string(arr);
                if (dict.ContainsKey(str))
                {
                    dict[str].Add(s);
                }
                else
                {
                    dict[str] = new List<string> { s };
                }
            }
            return dict.Values.ToList();
        }
    }
}
