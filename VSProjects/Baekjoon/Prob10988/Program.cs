namespace Prob10988
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            char[] charArr = str.ToCharArray();
            Array.Reverse(charArr);
            string nstr = new String(charArr);

            Console.WriteLine(str == nstr ? 1 : 0);



        }
    }
}
