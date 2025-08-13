namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Compare = a, b 일때 a가 b보다 사전순으로 빠르면 -1 아니면 1 같으면0

            Console.WriteLine("i가 1일 때");
            Console.WriteLine("j가 i+1일 때");

            //for문 한바퀴 i가 1일때 
            //
            string str = "arrested";
            string min = null;

            string part1 = new string(str.Substring(0, 1).Reverse().ToArray());
            string part2 = new string(str.Substring(1, (2 - 1)).Reverse().ToArray());
            string part3 = new string(str.Substring(2).Reverse().ToArray());

            string combined = part1 + part2 + part3;
            Console.WriteLine(part1);
            Console.WriteLine(part2);
            Console.WriteLine(part3);
            Console.WriteLine(combined);
            Console.WriteLine(string.Compare(combined, min) < 0); // a, b보다 사전순으로 빠르면
            //ardetser, arrested

            //string.Compare(combined, min) < 0 true
            //ardetser
            min = combined;

            //Compare = a, b 일때 a가 b보다 사전순으로 빠르면 -1 아니면 1 같으면0


            Console.WriteLine();
            Console.WriteLine("i가 2일 때");
            Console.WriteLine("j가 i+1일 때");

            //for문 한바퀴 i가 1일때 
            //
             str = "arrested";
             min = null;

             part1 = new string(str.Substring(0, 1).Reverse().ToArray());
             part2 = new string(str.Substring(2, (3 - 2)).Reverse().ToArray());
             part3 = new string(str.Substring(3).Reverse().ToArray());

             combined = part1 + part2 + part3;
            Console.WriteLine(part1);
            Console.WriteLine(part2);
            Console.WriteLine(part3);
            Console.WriteLine(combined);
            Console.WriteLine(string.Compare(combined, min) < 0); // a, b보다 사전순으로 빠르면
            //ardetser, arrested

            //string.Compare(combined, min) < 0 true
            //ardetser
            min = combined;




            //Console.WriteLine();
            ////for문 두바퀴 i가 2일때
            //Console.WriteLine("i가 2일 때");

            //part1 = new string(str.Substring(0, 2).Reverse().ToArray());
            //part2 = new string(str.Substring(2, (3 - 2)).Reverse().ToArray());
            //part3 = new string(str.Substring(3).Reverse().ToArray());


            //combined = part1 + part2 + part3;
            //Console.WriteLine(part1);
            //Console.WriteLine(part2);
            //Console.WriteLine(part3);
            //Console.WriteLine(combined);
            //Console.WriteLine(string.Compare(combined, min) < 0);

            ////Compare(rardetse, ardetser)  = 1 < 0 = false
            //// min = 그대로 ardetser

            //Console.WriteLine();
            ////for문 두바퀴 i가 3일때
            //Console.WriteLine("i가 3일 때");

            //part1 = new string(str.Substring(0, 3).Reverse().ToArray());
            //part2 = new string(str.Substring(3, (4 - 3)).Reverse().ToArray());
            //part3 = new string(str.Substring(4).Reverse().ToArray());


            //combined = part1 + part2 + part3;
            //Console.WriteLine(part1);
            //Console.WriteLine(part2);
            //Console.WriteLine(part3);
            //Console.WriteLine(combined);
            //Console.WriteLine(string.Compare(combined, min) < 0);

            ////Compare(rardetse, ardetser)  = 1 < 0 = false
            //// min = 그대로 ardetser

            //Console.WriteLine();
            ////for문 두바퀴 i가 4일때
            //Console.WriteLine("i가 4일 때");

            //part1 = new string(str.Substring(0, 4).Reverse().ToArray());
            //part2 = new string(str.Substring(4, (5 - 4)).Reverse().ToArray());
            //part3 = new string(str.Substring(5).Reverse().ToArray());


            //combined = part1 + part2 + part3;
            //Console.WriteLine(part1);
            //Console.WriteLine(part2);
            //Console.WriteLine(part3);
            //Console.WriteLine(combined);
            //Console.WriteLine(string.Compare(combined, min) < 0);

            ////Compare(rardetse, ardetser)  = 1 < 0 = false
            //// min = 그대로 ardetser

            //Console.WriteLine();
            ////for문 두바퀴 i가 5일때
            //Console.WriteLine("i가 5일 때");

            //part1 = new string(str.Substring(0, 5).Reverse().ToArray());
            //part2 = new string(str.Substring(5, (6 - 5)).Reverse().ToArray());
            //part3 = new string(str.Substring(6).Reverse().ToArray());


            //combined = part1 + part2 + part3;
            //Console.WriteLine(part1);
            //Console.WriteLine(part2);
            //Console.WriteLine(part3);
            //Console.WriteLine(combined);
            //Console.WriteLine(string.Compare(combined, min) < 0);

            ////Compare(rardetse, ardetser)  = 1 < 0 = false
            //// min = 그대로 ardetser

            //Console.WriteLine();
            ////for문 두바퀴 i가 6일때
            //Console.WriteLine("i가 6일 때");

            //part1 = new string(str.Substring(0, 6).Reverse().ToArray());
            //part2 = new string(str.Substring(6, (7 - 6)).Reverse().ToArray());
            //part3 = new string(str.Substring(7).Reverse().ToArray());


            //combined = part1 + part2 + part3;
            //Console.WriteLine(part1);
            //Console.WriteLine(part2);
            //Console.WriteLine(part3);
            //Console.WriteLine(combined);
            //Console.WriteLine(string.Compare(combined, min) < 0);
            //Console.WriteLine(min);

            ////Compare(rardetse, ardetser)  = 1 < 0 = false
            //// min = 그대로 ardetser
        }
    }
}
