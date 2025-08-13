namespace PPT23_DictionaryGeneric
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> data = new Dictionary<string, string>();
            //var data = new Dictionary<string, int>();

            data.Add("cs", "C#");
            data.Add("aspx", "ASP.NET");

            

            data.Remove("aspx");
            data["cshtml"] = "ASP.NET MVC";

            try
            {
                data.Add("cs", "CSharp");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            data["cs"] = "CSharp";

            foreach (var item in data)
            {

                Console.WriteLine("{0}은(는) {1}의 확장자 입니다.",
                    item.Key, item.Value);
            }

            try
            {
                if (data.ContainsKey("vb"))
                    Console.WriteLine(data["vb"]);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            if (data.TryGetValue("cs", out var value))
                Console.WriteLine(value);
            else
                Console.WriteLine("vb 키가 없습니다.");

            if (!data.ContainsKey("json"))
            {
                data.Add("json", "JSON");
                Console.WriteLine(data["json"]);
            }
            else
                Console.WriteLine(data["json"]);


            var values = data.Values;
            foreach(var val in values)
                Console.WriteLine(val);

            var keys = data.Keys;
            foreach(var key in keys)
                Console.WriteLine( key);

            Console.WriteLine("***********************");

            List<int> testL = new List<int>();

            testL.Add(1);
            testL.Add(2);
            testL.Add(3);

            testL.RemoveAt(0);
            Console.WriteLine(testL.Count);

            int a = 10;
            string b = "10";

            Console.WriteLine( a.ToString() == b);
        }

    }
}
