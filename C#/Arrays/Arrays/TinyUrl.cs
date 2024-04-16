using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class TinyUrl
    {
        //https://leetcode.com/problems/encode-and-decode-tinyurl/
        // Encodes a URL to a shortened URL
        Dictionary<string, string> dict = new Dictionary<string, string>();
        public string encode(string longUrl)
        {
            var last = longUrl.LastIndexOf('/');
            var x = longUrl.Substring(last + 1);
            dict[x] = longUrl;
            return $"http://tinyurl.com/{x}";
        }

        // Decodes a shortened URL to its original URL.
        public string decode(string shortUrl)
        {
            var last = shortUrl.LastIndexOf('/');
            var x = shortUrl.Substring(last + 1);
            return dict[x];
        }
    }
}
