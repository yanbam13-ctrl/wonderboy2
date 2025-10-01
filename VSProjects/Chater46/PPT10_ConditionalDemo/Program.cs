using System.Diagnostics;

namespace PPT10_ConditionalDemo
{
    internal class Program
    {
        [Conditional("DEBUG")]
        static void DebugMethod() => Console.WriteLine("디버그 환경에서만 표시");

        [Conditional("RELEASE")]
        static void ReleaseMethod() => Console.WriteLine("릴리즈 환경에서만 표시");
        static void Main(string[] args)
        {
            DebugMethod();
            ReleaseMethod();
        }
    }
}
