namespace Prob5354
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //테스트 케이스 갯수 n

            int n = int.Parse(Console.ReadLine());

            for (int k = 0; k < n; k++)
            {
                int box = int.Parse(Console.ReadLine());

                for (int i = 0; i < box; i++)
                {
                    for (int j = 0; j < box; j++)
                    {
                        if (i == 0 || j == box - 1 || j == 0 || i == box - 1)
                        {
                            Console.Write("#");
                        }
                        else
                        {
                            Console.Write("J");

                        }
                        //Console.Write($"({i},{j})");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }

            /*
             3일때              
            1.첫째줄 # 3개 출력
            2.두번째줄 # 1개 출력, J 1개 출력, # 1개 출력 줄 바꿈
            3.세번째줄 # 3개 출력 후 종료

             ###
             #J#
             ###

             5일때
            1.첫째줄 # 5개 출력
            2.두번째줄 # 1개 출력, J 3개 출력, # 1개 출력 줄 바꿈
            3.세번째줄 # 1개 출력, J 3개 출력, # 1개 출력 줄 바꿈
            4.네번째줄 # 1개 출력, J 3개 출력, # 1개 출력 줄 바꿈
            5.5번째 # 5개 출력 후 종료

             #####
             #JJJ#
             #JJJ#
             #JJJ#
             #####

             4일때
            1.첫째줄 # 4개 출력
            2.두번째줄 # 1개 출력, J 2개 출력, # 1개 출력 줄 바꿈
            3.세번째줄 # 1개 출력, J 2개 출력, # 1개 출력 줄 바꿈
            4.4번째 # 4개 출력 후 종료

             ####
             #JJ#
             #JJ#
             ####

             
             */

        }
    }
}
