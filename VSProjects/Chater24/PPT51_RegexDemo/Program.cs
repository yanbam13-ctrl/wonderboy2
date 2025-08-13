using System;
using System.Text.RegularExpressions;

namespace PPT51_RegexDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string email = "abcd@aaa.com";
            Console.WriteLine(IsEmail(email));

        }

        static bool IsEmail(string email)
        {
            bool result = false;

            Regex regex = new Regex(
                @"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)" +
                @"(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$");

            result = regex.IsMatch(email);

            return result;
        }
    }
}
