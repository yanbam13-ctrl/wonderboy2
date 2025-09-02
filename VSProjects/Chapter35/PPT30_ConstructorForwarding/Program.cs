namespace PPT30_ConstructorForwarding
{

    class Money
    {
        public Money() : this(1000){ }

        public Money(int money) => Console.WriteLine("Money : {0:#,###}", money);
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Money basic = new Money();
            Money bonus = new Money(2000);
        }
    }
}
