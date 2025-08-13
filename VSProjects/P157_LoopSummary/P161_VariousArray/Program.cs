namespace P161_VariousArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = a;
            a = 20;
            Console.WriteLine($"{a} {b}");


            int[] arrA = { 10 };
            int[] arrB = arrA; // 주소값 전체를 초기화 했기 때문에 변수 이름만 다르고 같은 값을 가진다

            arrA[0] = 20;
            Console.WriteLine($"{arrA[0]} {arrB[0]}");

            int[] intArray = new int[100];

            Console.WriteLine(intArray[0]);
            Console.WriteLine(intArray[99]);
        }
    }
}
