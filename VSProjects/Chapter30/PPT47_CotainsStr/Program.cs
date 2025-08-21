namespace PPT47_CotainsStr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var colors = new List<string> { "Red", "Green", "Blue" };
            var newColors = colors.Where(c => c.Contains("ee")).ToList();
            //var newColors = colors.Where(c => c.Contains("ee")).ToList();

            foreach (var v in newColors)
                Console.WriteLine(v);
        }
    }
}

