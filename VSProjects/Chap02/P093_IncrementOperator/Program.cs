namespace P093_IncrementOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 10;
            ++number;
            Console.WriteLine(number); //11
            --number;
            Console.WriteLine(number); //10
            //number++;
            //Console.WriteLine(number); //11
            //number--;
            //Console.WriteLine(number); //10

            //===========

            number = 10;

            Console.WriteLine(number); //10
            Console.WriteLine(number++); //10
            Console.WriteLine(number--); //11 
            Console.WriteLine(number); //11 - 1 = 10

            number = 10;

            Console.WriteLine(number++); //10
            Console.WriteLine(++number); //11 + 1 = 12
            Console.WriteLine(number--); //12 
            Console.WriteLine(number); //12 - 1 = 11
        }
    }
}
