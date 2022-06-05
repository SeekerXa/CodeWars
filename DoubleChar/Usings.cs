global using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
public class Kata
{
    public static string DoubleChar(string s)
    {
        StringBuilder sb = new StringBuilder();
        foreach (char c in s)
        {
            sb.Append(c, 2);
        }
        // your code here

        return sb.ToString();


        // other options

        return string.Join("", s.Select(x => "" + x + x));

        return string.Concat(s.Select(x => $"{x}{x}"));
        return Regex.Replace(s, ".", "$&$&");
        return s.Aggregate("", (str, c) => str + c + c);
        return string.Join("", s.Select(p => $"{p}{p}"));
        return string.Concat(s.Select(x => new string(x, 2)));
    }

}