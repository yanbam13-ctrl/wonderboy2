namespace Prob2525
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] input_a = Console.ReadLine().Split();

            int inputHour = int.Parse(input_a[0]);
            int inputMin = int.Parse(input_a[1]);

            int cookMin = int.Parse(Console.ReadLine());            

            int hour = inputHour;
            int min = inputMin + cookMin;

            int totalMin = inputMin + cookMin;
            inputHour += totalMin / 60;
            int resultMin = totalMin % 60;
            int resultHour = inputHour % 24;


            Console.WriteLine($"{resultHour} {resultMin}");
        }
    }
}
