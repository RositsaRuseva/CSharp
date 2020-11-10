using System;

namespace Grades3
{
    class Program
    {
        static void Main(string[] args)
        {
            int students = int.Parse(Console.ReadLine());

            double morethan5 = 0;
            double between4and5 = 0;
            double between3and4 = 0;
            double lessThan3 = 0;

            double averageGrade = 0;

            for (int i = 1; i <= students; i++)
            {
                double grade = double.Parse(Console.ReadLine());

                if (grade >= 5)
                {
                    morethan5++;
                }
                if (grade >= 4.00 && grade<= 4.99)
                {
                    between4and5++;
                }
                if(grade>=3.00 && grade<=3.99)
                {
                    between3and4++;
                }
                if(grade<3)
                {
                    lessThan3++;
                }
                averageGrade += grade;
            }
            Console.WriteLine("Top students: {0:f2}%", (morethan5 / students) * 100);
            Console.WriteLine("Between 4.00 and 4.99: {0:f2}%", (between4and5 / students) * 100);
            Console.WriteLine("Between 3.00 and 3.99: {0:f2}%", (between3and4 / students) * 100);
            Console.WriteLine("Fail: {0:f2}%", (lessThan3 / students) * 100);
            Console.WriteLine("Average: {0:f2}", averageGrade / students);
        }
    }
}
