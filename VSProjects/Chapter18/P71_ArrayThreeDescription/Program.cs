namespace P71_ArrayThreeDescription
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,,] names = new string[2, 2, 2];

            names[0, 0, 0] = "C#";
            names[0, 0, 1] = "ASP.NET";

            names[0, 1, 0] = "Windows Forms";
            names[0, 1, 1] = "WPF";

            names[1, 0, 0] = "Xamarin";
            names[1, 0, 1] = "Unity";

            names[1, 1, 0] = "UWP";
            names[1, 1, 1] = "Azure";

            Console.WriteLine("0층");
            Console.WriteLine($"{names[0, 0, 0],20}, {names[0, 0, 1],20}");
            Console.WriteLine($"{names[0, 1, 0],20}, {names[0, 1, 1],20}");
            Console.WriteLine();
            Console.WriteLine("1층");            
            Console.WriteLine($"{names[1, 0, 0],20}, {names[1, 0, 1],20}");
            Console.WriteLine($"{names[1, 1, 0],20}, {names[1, 1, 1],20}");
        }
    }
}

/*
 * 
 {1, 2, 3}
 

 {
  {1, 2, 3}
  {4, 5, 6}
 }


     {
        {1, 2},    // 0층, 0행
        {3, 4}     // 0층, 1행
    },

    {
        {5, 6},    // 1층, 0행
        {7, 8}     // 1층, 1행
    }

 */