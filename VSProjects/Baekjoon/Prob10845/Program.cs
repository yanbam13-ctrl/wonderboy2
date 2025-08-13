using System;
using System.Collections;
using System.Text;
using System.Threading.Channels;

namespace Prob10845
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int n = int.Parse(input);
            int back = -1;

            Queue<int> queue = new Queue<int>();
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine();
                string[] arrInput = input.Split();
                string operation = arrInput[0];

                if (operation == "push")
                {
                    string value = arrInput[1];
                    queue.Enqueue(int.Parse(value));
                    back = int.Parse(value);
                }
                else if (operation == "front")
                {
                    if (queue.Count == 0)
                    {
                        sb.AppendLine("-1");
                    }
                    else
                    {
                        sb.AppendLine(queue.Peek().ToString());
                    }
                }
                else if (operation == "back")
                {
                    if (queue.Count == 0)
                    {
                        sb.AppendLine("-1");
                    }
                    else
                    {
                        sb.AppendLine(back.ToString());
                    }
                }
                else if (operation == "pop")
                {
                    if (queue.Count == 0)
                    {
                        sb.AppendLine("-1");
                    }
                    else
                    {
                        sb.AppendLine(queue.Dequeue().ToString());
                    }
                }
                else if (operation == "size")
                {
                    sb.AppendLine(queue.Count.ToString());
                }
                else if (operation == "empty")
                {
                    if (queue.Count == 0)
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
