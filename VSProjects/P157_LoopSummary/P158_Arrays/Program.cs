namespace P158_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = { 52, 273, 32, 65, 103 };
            long[] longArray = { 52, 273, 32, 65, 103 };
            float[] floatArray = { 1.0f, 2.0f, 3.0f, 4.0f, 5.0f };
            double[] doubleArray = { 1.0, 2.0, 3.0, 4.0, 5.0 };
            char[] charArray = { '가', '나', '다', '라' };
            string[] stringArray = { "윤인성", "연하진", "윤아린" };

            //char배열 -> 문자열
            string str = new string(charArray);

            //문자열 ->char배열
            char[] newCharArray = str.ToCharArray();
        }
    }
}
