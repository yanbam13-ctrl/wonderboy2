using System;
using static System.Console;

namespace PPT76_PatternMatchingWithIf
{
    class PatternMatchingWithIf
    {
        static void PrintStart(object o)
        {
            if (o is null)
            {
                return;
            }

            if (o is string)
            {
                return;
            }

            if (!(o is int number))
            {
                return;
            }

            WriteLine(new String('*', number));
        }
        static void Main(string[] args)
        {
            PrintStart(null);
            PrintStart("하나");
            PrintStart(5);
        }
    }
}
