namespace Prob2997_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            int a = int.Parse(input[0]);
            int b = int.Parse(input[1]);
            int c = int.Parse(input[2]);

            int temp = a;

            if (a > b) // 3 9 6 12
            {
                temp = a;
                a = b;
                b = temp;
            }

            if (a > c) 
            {
                temp = a;
                a = c;
                c = temp;
            }

            if (b > c) {
                temp = b;
                b = c;
                c = temp;
            }

            Console.WriteLine($"{a} {b} {c}");
           

        }
    }
}


/*

 string[] input = Console.ReadLine().Split();
            int[] arr = Array.ConvertAll(input, int.Parse);

            Array.Sort(arr);

            int a = arr[0];
            int b = arr[1];
            int c = arr[2];

            int x = b - a;
            int y = c - b;

            int result;

            if (x > y) // 1 7 10 // x = 6, y = 3;
            {
                result = a + y;
            }
            else if (x < y) //1 4 10 // x = 3, y= 6;
            {
                result = b + x;
            }
            else { // 2 4 6 // x = 2, y = 2;
                result = c + x;
            }

            Console.WriteLine(result); 

 */