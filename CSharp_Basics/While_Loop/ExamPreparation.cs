using System;

namespace ExamPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int failedThreshold = int.Parse(Console.ReadLine());

            double counterFailedTimes = 0;
            double conterSolved = 0;
            double sumGrades = 0;
            string lastProblem = string.Empty;
            bool isFailed = true;

            while (counterFailedTimes < failedThreshold)
            {
                string problemName = Console.ReadLine();
                if("Enough" == problemName)
                {
                    isFailed = false;
                    break;
                }
                int grade = int.Parse(Console.ReadLine());
                if(grade <= 4)
                {
                    counterFailedTimes++;
                }
                sumGrades += grade;
                conterSolved++;
                lastProblem = problemName;
            }

            if (isFailed)
            {
                Console.WriteLine($"You need a break, {failedThreshold} poor grades.");
            }
            else
            {
                Console.WriteLine($"Average score: {(sumGrades / conterSolved):f2}");
                Console.WriteLine($"Number of problems: {conterSolved}");
                Console.WriteLine($"Last problem: {lastProblem}");
            }
        }
    }
}
