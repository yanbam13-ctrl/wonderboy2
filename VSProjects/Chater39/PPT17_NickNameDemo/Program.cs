namespace PPT17_NickNameDemo
{
    internal class Program
    {
        public class NickName
        {
            private Dictionary<string, string> _names = new Dictionary<string, string>();

            public string this[string key]
            {
                get { return _names[key].ToString(); }
                set { _names[key] = value; }
            }
        }
        static void Main(string[] args)
        {
            NickName nick = new NickName();

            nick["박용준"] = "RedPlus";
            nick["김태영"] = "Taeyo";

            Console.WriteLine($"{nick["박용준"]}, {nick["김태영"]}");
        }
    }
}
