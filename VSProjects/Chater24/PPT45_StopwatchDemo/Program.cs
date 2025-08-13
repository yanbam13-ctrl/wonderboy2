using System;
using System.Diagnostics;
using System.Threading;

namespace PPT45_StopwatchDemo
{
     class StopwatchDemo
    {
        static void Main(string[] args)
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();
            LongTimeProcess();
            timer.Stop();

            Console.WriteLine("경과 시간: {0}밀리초", timer.Elapsed.TotalMilliseconds);
            
            Console.WriteLine("경과 시간: {0}초", timer.Elapsed.Seconds);

            
        }

        static void LongTimeProcess() {
            Thread.Sleep(3000);
        }

    }

}
