using System;

namespace Grades_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());
            PrintInWords(grade);


        }

        private static void PrintInWords(double grade)
        {
            if(grade >= 2.00 && grade <= 2.99)
            {
                Console.WriteLine("Fail");
            }
            else if (grade >= 3.00 && grade <= 3.49)
            {
                Console.WriteLine("Poor");
            }
            if (grade >= 3.50 && grade <= 4.49)
            {
                Console.WriteLine("Good");
            }
            if (grade >= 4.50 && grade <= 5.49)
            {
                Console.WriteLine("Very good");
            }
            if (grade >= 5.50 && grade <= 6.00)
            {
                Console.WriteLine("Excellent");
            }
        }
    }
}
