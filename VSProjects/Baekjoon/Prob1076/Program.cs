namespace Prob1076
{
    internal class Program
    {
        static int GetValue(string color)
        {

            if (color == "black") return 0;
            else if (color == "brown") return 1;
            else if (color == "red") return 2;
            else if (color == "orange") return 3;
            else if (color == "yellow") return 4;
            else if (color == "green") return 5;
            else if (color == "blue") return 6;
            else if (color == "violet") return 7;
            else if (color == "grey") return 8;
            else return 9;
        }

        static int getMultValue(string color)
        {

            if (color == "black") return 1;
            else if (color == "brown") return 10;
            else if (color == "red") return 100;
            else if (color == "orange") return 1000;
            else if (color == "yellow") return 10000;
            else if (color == "green") return 100000;
            else if (color == "blue") return 1000000;
            else if (color == "violet") return 10000000;
            else if (color == "grey") return 100000000;
            else return 1000000000;
        }


        static void Main(string[] args)
        {
            string color1 = Console.ReadLine();
            string color2 = Console.ReadLine();
            string color3 = Console.ReadLine();

            long result = (10 * GetValue(color1)) + GetValue(color2);
            result *= getMultValue(color3);

            Console.WriteLine(result);
        }
    }
}
