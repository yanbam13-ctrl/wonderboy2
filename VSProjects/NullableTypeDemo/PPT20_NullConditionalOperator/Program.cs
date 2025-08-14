using System.Numerics;

namespace PPT20_NullConditionalOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double? d = 1.0;
            Console.WriteLine(d?.ToString("#.00"));

            List<string> list = null;
            int? numberOflist;

            numberOflist = list?.Count;
            Console.WriteLine(numberOflist);

            numberOflist = list?.Count ?? 0;
            Console.WriteLine(numberOflist);

            list = new List<string>();
            list.Add("안녕하세요");
            list.Add("반갑습니다.");
            numberOflist = list?.Count;
            Console.WriteLine(numberOflist);

            numberOflist = list?.Count ?? 0;
            Console.WriteLine(numberOflist);
        }
    }
}
