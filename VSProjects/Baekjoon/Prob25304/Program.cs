namespace Prob25304
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int totalPurchase = 0;

            int totalPrice = int.Parse(Console.ReadLine());
            int totalAmount = int.Parse(Console.ReadLine());

            for (int i = 0; i < totalAmount; i++)
            {
                string[] input = Console.ReadLine().Split();
                totalPurchase += int.Parse(input[0]) * int.Parse(input[1]);
            }

            Console.WriteLine(totalPrice == totalPurchase ? "Yes" : "No");

            //if (totalPrice == totalPurchase)
            //{
            //    Console.WriteLine("Yes");
            //}
            //else
            //{
            //    Console.WriteLine("No");
            //}


            //test//
            //int totalPrice = 250000;

            //int totalAmount = 4;

            //int aPrice = 20000;
            //int aAmount = 5;

            //int bPrice = 30000;
            //int bAmount = 2;

            //int cPrice = 10000;
            //int cAmount = 6;

            //int dPrice = 5000;
            //int dAmount = 8;

            //int TotalPurchase = 0;

            //TotalPurchase += aPrice * aAmount;
            //TotalPurchase += bPrice * bAmount;
            //TotalPurchase += cPrice * cAmount;
            //TotalPurchase += dPrice * dAmount;

        }
    }
}
