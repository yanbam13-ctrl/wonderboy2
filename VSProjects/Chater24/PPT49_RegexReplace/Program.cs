using System;
using System.Text.RegularExpressions;

namespace PPT49_RegexReplace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "안녕하세요.     반갑습니다.    또 만나요.";

            var regex = new Regex("\\s+");
            string r = regex.Replace(s, " ");
            Console.WriteLine(s);
            Console.WriteLine(r);
        }
    }
}
