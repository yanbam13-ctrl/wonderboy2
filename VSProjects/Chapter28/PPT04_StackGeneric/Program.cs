using System;
using System.Collections;

namespace PPT04_StackGeneric
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<string> stack = new Stack<string>();

            stack.Push("First");
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Count);

            stack.Push("Second");
            stack.Push("Third");
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Count);

            stack.Clear();
            Console.WriteLine(stack.Count);


        }
    }
}
