using System;
using System.Collections;

namespace PPT19_StackNote
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();

            stack.Push("첫 번째");
            stack.Push("두 번째");
            Console.WriteLine(stack.Count);
            stack.Push("세 번째");

            Console.WriteLine(stack.Count);

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());

            try
            {
                Console.WriteLine(stack.Pop());// 언더플로 에러
            }
            catch (Exception ex)
            {
                Console.WriteLine($"예외 내용 {ex.Message}");
            }
        }
    }
}

