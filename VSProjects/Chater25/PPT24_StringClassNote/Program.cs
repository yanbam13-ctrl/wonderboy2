namespace PPT24_StringClassNote
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "";
            str = string.Empty;

            Console.WriteLine("**" + str + "**");

            str = " Abc Def Fed Cba ";
            Console.WriteLine("**" + str + "**");

            Console.WriteLine(str.Length);
            Console.WriteLine(str[6 - 1]);

            //원본 데이터를 바꾸지 않음
            Console.WriteLine(str.ToUpper());
            Console.WriteLine(str.ToLower());

            Console.WriteLine("**" + str.Trim() + "**");
            Console.WriteLine("**" + str.TrimStart() + "**");
            Console.WriteLine("**" + str.TrimEnd() + "**");

            Console.WriteLine("**" + str.Replace("Def", "디이에프") + "**");

            Console.WriteLine(str.Replace("Def", "디이에프").Replace("Fed", "XYZ").ToLower());

            Console.WriteLine(str.IndexOf('e'));
            Console.WriteLine(str.Substring(5, 3));

            Console.WriteLine("A" == "C");
            Console.WriteLine(string.Compare("A","C"));
            Console.WriteLine("A".CompareTo("C"));
            Console.WriteLine("Abc".Equals("Abc"));
            Console.WriteLine(string.Equals("Abc","aBc"));

            "http://www.dotnetkorea.com".StartsWith("http");
            "http://www.dotnetkorea.com".EndsWith(".com");


            string hi1 = "안녕";
            string hi2 = "하세요.";

            Console.WriteLine(string.Concat(hi1,hi2));

            Console.WriteLine(string.Format("{0} {1} {0}", hi1, hi2));
            Console.WriteLine($"{hi1} {hi2}");

            Console.WriteLine(String.Format("{0:C}",1000));
            Console.WriteLine(String.Format("{0:#,###}",1000));
            Console.WriteLine(String.Format("{0:00000000.00}",1000));

            string[] strArray = str.Trim().Split();
            foreach (string s in strArray) {
                Console.WriteLine(s);
            }

            string original = "Hello";
            string modified = original.Insert(3,"world");

            Console.WriteLine(modified);

            string number = "1234";
            Console.WriteLine(number.PadLeft(10, '0'));
            Console.WriteLine(number.PadRight(10, '_'));
            

        }
    }
}
