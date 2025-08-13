namespace Prob2720
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());




            for (int i = 0; i < n; i++)
            {
                int input = int.Parse(Console.ReadLine());

                //쿼터 0.25 , 다임 0.01 / 니켈 0.05 / 페니 0.01

                //124를 거슬러 줘야 할때

                int q = 0;
                int d = 0;
                int k = 0;
                int p = 0;


                if (input % 25 == 0) // 25로 거슬러 줘야 되는 금액을 맞췄을때
                {
                    q = input / 25;
                    Console.WriteLine($"{q} {d} {k} {p}");
                    continue;
                }

                else  // 25로 모두 거슬러 줄수 없을때
                {
                    q = input / 25; // 25로 가능한 쿼터를 챙겨놓고

                    if (((input - (q * 25)) % 10) == 0) // 전체 거스름 돈에서 25로 챙겨놓은 잔돈금액을 뺀 액수를 다임으로 모두 줄수 있을때
                    {
                        d = (input - (q * 25)) / 10; // 10으로 가능한 다임을 챙겨 놓고
                        break; //종료
                    }
                    else // 다임으로 모두 챙겨 줄수 없을때
                    {
                        d = (input - (q * 25)) / 10; // 10으로 가능한 다임을 챙겨 놓고

                        if ((input - (q * 25) + (d * 10)) % 5 == 0) // 전체 거스름 돈에서 쿼터와 다임을 제외한 거슬러줄 돈을 니켈로 모두 줄수 있을 경우
                        {
                            k = (input - (q * 25) + (d * 10)) / 5; // 남은 금액에서 5로 나눠서 니켈을 챙겨놓기
                            break;
                        }
                        else // 5로 나누어 지지 않을 경우
                        {
                            k = (input - (q * 25) + (d * 10)) / 5; // 5로 나눠지는 만큼 챙겨놓고

                            p = (input - (q * 25) + (d * 10) + (p * 5)) / 1;
                        }
                    }

                }

                Console.WriteLine($"{q} {d} {k} {p}");
            }

        }
    }
}
