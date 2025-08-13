namespace Prob2997
{
    internal class Program
    {
        static void Main(string[] args)
        {


            string[] input = Console.ReadLine().Split();
            //int[] arr = new int[input.Length];

            //for (int i = 0; i < input.Length; i++)
            //{
            //    arr[i] = int.Parse(input[i]);
            //}

            int a = int.Parse(input[0]);
            int b = int.Parse(input[1]);
            int c = int.Parse(input[2]);

            int tmp = a;

            if (a > b)
            { // a가 b보다 크면 두수를 바꿈
                tmp = a;
                a = b;
                b = tmp;
            }

            if (a > c)
            { //a가 c보다 크면 두수를 바꿈                
                tmp = a;
                a = c;
                c = tmp;
            }

            if (b > c)
            { //b가 c 보다 크면 두수를 바꿈
                tmp = b;
                b = c;
                c = tmp;
            }

            //Console.WriteLine($"{a} {b} {c}");

            int x = b - a;
            int y = c - b;
            int result = 0;
            //Console.WriteLine($"{x} {y}");

            if (x < y)
            {
                // b중간에 숫자가 빠짐
                result = b + (x);
            }
            else if (x == y)
            {
                //정상적으로 등차수열 진행중
                result = c + x;
            }
            else
            {
                result = a + y;

            }

            Console.WriteLine(result);
        }
    }

}

//string[] a = Console.ReadLine().Split();

//int min = int.Parse(a[0]);
//int mid = int.Parse(a[0]);
//int max = int.Parse(a[0]);

//if (min > int.Parse(a[1])) // 7, 6, 3 => ok, 3, 6, 1 => x
//{
//    max = min;
//    min = int.Parse(a[1]);
//    mid = int.Parse(a[2]);

//    if (min > int.Parse(a[1]))
//    {
//        max = min;
//        min = int.Parse(a[2]);
//        mid = int.Parse(a[1]);
//    }
//}
//else if (min > int.Parse(a[2])) // 3, 6, 1 => ok
//{
//    max = min;
//    min = int.Parse(a[2]);
//    mid = int.Parse(a[1]);

//    if (min > int.Parse(a[1]))
//    {
//        max = min;
//        min = int.Parse(a[1]);
//        mid = int.Parse(a[0]);
//    }
//}
//else if ((int.Parse(a[1])) > int.Parse(a[2]))
//{
//    max = int.Parse(a[1]);
//    mid = int.Parse(a[2]);
//}
//else
//{
//    max = int.Parse(a[2]);
//    mid = int.Parse(a[1]);
//}

////Console.WriteLine(min);
////Console.WriteLine(mid);
////Console.WriteLine(max);

//if ((mid - min) == (max - mid))
//{
//    Console.WriteLine(max + (mid - min));
//}
//else
//{
//    if ((max - min) > (max - mid))
//    { //10 - 1 > 10 - 4
//        Console.WriteLine(max - (mid - min));
//    }
//}
