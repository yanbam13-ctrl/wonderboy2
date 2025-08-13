namespace Prob2439
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            for (int i = 1; i <= count; i++) {
                Console.WriteLine(new string(' ', count -i) + new string('*',i));
            }
        }
    }
}


//int count = int.Parse(Console.ReadLine());
//string star = "*";
//string space = "";
//int spaceCount = count;


//for (int j = 0; j < count; j++)
//{
//    for (int i = 0; i < spaceCount; i++)
//    {
//        space += " ";

//    }

//    Console.WriteLine(space + star);
//    star += "*";
//    space = "";
//    spaceCount -= 1;
//}