namespace PPT04_Obsolete
{
    internal class Program
    {
        [Obsolete("Using New Member Method", true)]
        static void OldMember() => Console.WriteLine("Old Method");
        static void NewMember() => Console.WriteLine("New Method");
        static void Main(string[] args)
        {
            OldMember();
            NewMember();
        }
    }
}
