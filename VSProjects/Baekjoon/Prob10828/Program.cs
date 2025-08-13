using System;
using System.Collections;
using System.Text;
using System.Threading.Channels;

namespace Prob10828
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int n = int.Parse(input);

            Stack<int> stack = new Stack<int>();
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine();
                string[] arrInput = input.Split();
                string operation = arrInput[0];

                if (operation == "push")
                {
                    string value = arrInput[1];
                    stack.Push(int.Parse(value));
                }
                else if (operation == "top")
                {
                    if (stack.Count == 0)
                    {
                        sb.AppendLine("-1");
                    }
                    else
                    {
                        sb.AppendLine(stack.Peek().ToString());
                    }
                }
                else if (operation == "pop")
                {
                    if (stack.Count == 0)
                    {
                        sb.AppendLine("-1");
                    }
                    else
                    {
                        sb.AppendLine(stack.Pop().ToString());
                    }
                }
                else if (operation == "size")
                {
                    sb.AppendLine(stack.Count.ToString());
                }
                else if (operation == "empty")
                {
                    if (stack.Count == 0)
                    {
                        sb.AppendLine("1");
                    }
                    else
                    {
                        sb.AppendLine("0");
                    }
                }


            }

            Console.WriteLine(sb.ToString());
        }
    }
}
