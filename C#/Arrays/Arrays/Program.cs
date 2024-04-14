// See https://aka.ms/new-console-template for more information
using System.Text;

var arr = new int[] { 1, 1, 1, 2, 2, 3 };
var list = new List<string> { "Hello", "World" };
var res = Encode(list);
var dec = Decode(res);

Console.WriteLine( );

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