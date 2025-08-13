using System.Numerics;

namespace P142_ConditionOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {        
            int number = int.Parse(Console.ReadLine());

            string res = number > 0 ? "자연수 입니다." : "자연수가 아닙니다.";
            Console.WriteLine(res);
        }
    }
}
