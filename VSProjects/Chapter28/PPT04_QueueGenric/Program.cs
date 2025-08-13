using System;
using System.Collections;

namespace PPT04_QueueGenric
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();

            queue.Enqueue(10);
            queue.Enqueue(20);
            Console.WriteLine(queue.Count); // 2
            Console.WriteLine(queue.Dequeue()); // 10

            queue.Enqueue(30);
            Console.WriteLine(queue.Dequeue());//20
            Console.WriteLine(queue.Count);//1

            Console.WriteLine(queue.Dequeue()); //30
            Console.WriteLine(queue.Count); // 0
            queue.Clear();
            Console.WriteLine(queue.Count); //0



        }

    }
}
