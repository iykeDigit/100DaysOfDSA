using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class EncodeDecode
    {
        static string Encode(IList<string> strs)
        {
            var delimeter = "#";
            var str = "";
            foreach (var item in strs)
            {
                str += item;
                str += delimeter;

            }
            return str;
        }

        // Decodes a single string to a list of strings.
        static IList<string> Decode(string s)
        {
            var delimeter = "#";
            var arr = s.Split(delimeter).ToList();
            if (arr.Count > 1) arr.RemoveAt(arr.Count - 1);
            return arr;
        }
    }
}
