namespace Prob2530
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //14 30 0
            //200 -> 200 / 60 => 몫 = 3 , 나머지 20
            // = 14 33 20

            string[] currentTime = Console.ReadLine().Split();

            int hour = int.Parse(currentTime[0]);
            int min = int.Parse(currentTime[1]);
            int second = int.Parse(currentTime[2]);

            string inputTime = Console.ReadLine(); // 200sec => 3분 20초 
            // 5000sec => 83분 20초 -> 1시간 23분 20초 

            int cookTimeInput = int.Parse(inputTime);

            int cookTimeMin = cookTimeInput / 60;
            int cookTimeSec = cookTimeInput % 60;

            if ((cookTimeMin + min) >= 60) {
                min = ((cookTimeMin + min) % 60); 
                //hour += ((cookTimeMin + min) / 60);
                int test = ((cookTimeMin + min) / 60);
                Console.WriteLine("test:" + test);
            }

            // ex) 14 30 0 일때 5000초 -> 15 53

            Console.WriteLine("{0} {1} {2}",hour,min,second);




        }
    }
}
