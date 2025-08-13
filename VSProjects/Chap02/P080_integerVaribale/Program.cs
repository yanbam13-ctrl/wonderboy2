namespace P080_integerVaribale
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 273;
            int b = 52;

            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(a * b);
            Console.WriteLine(a / b);
            Console.WriteLine(a % b);

            a = 2147483647;
            b = 1;

            Console.WriteLine(a + b);

            a = -2147483648;
            b = 1;

            Console.WriteLine(a - b);

            long C = 2_000_000_000; 
            long D = 1_000_000_000; // 8Byte = 64bit

            Console.WriteLine(C+b);

            sbyte sbyteVar = 127; // 1byte _ -128 ~ 127
            short shortVar = 32767; // 2byte -32,768 ~ 32,767
            int intVar = 2147483647; // 4byte -2147483648 ~ 2147483647
            long lonVar = 9223372036854775807; //8byte -9223372036854775808 ~ 9223372036854775807
            byte byteVar = 255; // 1byte 255
            ushort ushortVar = 65535; // 2byte 65535
            uint uintVar = 4294967295; // 4byte 4294967295
            ulong ulongVar = 18446744073709551615; // 8byte 18446744073709551615

            Console.WriteLine(int.MaxValue);
            Console.WriteLine(int.MinValue);
            Console.WriteLine(long.MaxValue);
            Console.WriteLine(long.MinValue);
        }
    }
}
