using System;
using System.Collections;

namespace PPT_QueueNote
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue q = new Queue();

            q.Enqueue(10);
            q.Enqueue(20);
            q.Enqueue(30);

            Console.WriteLine(q.Dequeue()); 
            Console.WriteLine(q.Dequeue()); 
            Console.WriteLine(q.Dequeue()); 

            //q.Dequeue();


        }
    }
}
