namespace PPT29_CountFunc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool[] blns = { true, false, true, false, true };

            Console.WriteLine(blns.Count());
            Console.WriteLine(blns.Count(bln => bln == true));
            Console.WriteLine(blns.Count(bln => bln == false));
        }
    }
}
