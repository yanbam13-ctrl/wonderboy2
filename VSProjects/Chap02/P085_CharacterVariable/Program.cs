namespace P085_CharacterVariable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char a = 'a';
            Console.WriteLine(a);

            Console.WriteLine("char : " + sizeof(char));
            Console.WriteLine("in :" + sizeof(int));
            Console.WriteLine("long : " + sizeof(long));
            Console.WriteLine("float : " +sizeof(float));
            Console.WriteLine("double : " + sizeof(double));
            Console.WriteLine("bool : " + sizeof(bool));
            //Console.WriteLine(sizeof(string));            
            //string은 입력된 문자열에 따라 크기가 달라지는 자료형으로 sizeof로 크기를 알아낼수 없음

            Console.WriteLine((char)(a+1));


        }
    }
}
