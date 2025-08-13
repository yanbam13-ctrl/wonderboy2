using System;

namespace Prob25206
{
    internal class Program
    {
        struct gradeStr
        {
            public string obj;
            public float credit;
            public string grade;
            public float gradeFloat;
        }

        static void Input(gradeStr[] grs)
        {
            for (int i = 0; i < grs.Length; i++)
            {
                string[] input = Console.ReadLine().Split();

                grs[i].obj = input[0];
                grs[i].credit = float.Parse(input[1]);
                grs[i].grade = input[2];
            }
        }

        static void ConvertGrade(gradeStr[] grs)
        {
            for (int i = 0; i < grs.Length; i++)
            {
                switch (grs[i].grade)
                {
                    case "A+":
                        grs[i].gradeFloat = 4.5f;
                        break;
                    case "A0":
                        grs[i].gradeFloat = 4.0f;
                        break;
                    case "B+":
                        grs[i].gradeFloat = 3.5f;
                        break;
                    case "B0":
                        grs[i].gradeFloat = 3.0f;
                        break;
                    case "C+":
                        grs[i].gradeFloat = 2.5f;
                        break;
                    case "C0":
                        grs[i].gradeFloat = 2.0f;
                        break;
                    case "D+":
                        grs[i].gradeFloat = 1.5f;
                        break;
                    case "D0":
                        grs[i].gradeFloat = 1.0f;
                        break;
                    case "F":
                        grs[i].gradeFloat = 0.0f;
                        break;
                    default:
                        break;
                }
            }
        }
        static float Solve(gradeStr[] grs)
        {
            float sum = 0;
            float creditSum = 0;

            for (int i = 0; i < grs.Length; i++)
            {
                sum += grs[i].gradeFloat * grs[i].credit;

                if (grs[i].grade != "P") creditSum += grs[i].credit;
            }

            return sum / creditSum;
        }

        static void Main(string[] args)
        {
            gradeStr[] grs = new gradeStr[20];

            Input(grs);
            ConvertGrade(grs);            
            Console.WriteLine(Solve(grs));



        }
    }
}
