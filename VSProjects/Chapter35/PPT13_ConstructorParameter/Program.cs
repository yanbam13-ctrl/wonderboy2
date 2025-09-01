namespace PPT13_ConstructorParameter
{
    class My
    {
        private string? _name;
        private int _age;

        public My()
        {
            this._name = default;
            this._age = default;
        }
        public My(string name, int age)
        {
            this._name = name;
            this._age = age;
        }

        public void PrintMy()
        {
            Console.WriteLine($"이름 : {this._name}, 나이 : {this._age}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            My my = new My("백승수", 21);
            my.PrintMy();

            My my_02 = new My();

            my_02.PrintMy();
        }
    }
}
