using System;

namespace TrainTheTrainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int juryCount = int.Parse(Console.ReadLine());
            int presentationCount = 0;
            double studentsFinalAssessment = 0;

            while(true)
            {
                string presentation = Console.ReadLine();
                 
                if(presentation == "Finish")
                {
                    break;
                }

                presentationCount++;
                double gradeForPresentation = 0;
                for (int i = 0; i < juryCount; i++)
                {
                    double juryGrade = double.Parse(Console.ReadLine());
                    gradeForPresentation += juryGrade;

                }
                gradeForPresentation /= juryCount;
                studentsFinalAssessment += gradeForPresentation;
                
                Console.WriteLine($"{presentation} - {gradeForPresentation:f2}.");

            }
            studentsFinalAssessment /= presentationCount;

            Console.WriteLine($"Student's final assessment is {studentsFinalAssessment:f2}.");
        }
    }
}
