namespace PPT70_As
{
    internal class Program
    {
        static void Main(string[] args)
        {
            object x = 1234;

            //string s = x as string;

            Console.WriteLine(x as string == null ? "null" : x);

            //string s;
            //if (x is string)
            //    s = (string)x;
            //else
            //    s = null;

            //Console.WriteLine(s == null? "null" : s);

        }
    }
}
