using System;

namespace GraduationPt._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string studentName = Console.ReadLine();
            int klass = 1;
            int failed = 0;

            double total = 0;
            

            while(klass <=12)
            {
                double grade = double.Parse(Console.ReadLine());
                
                if(grade >=4)
                {
                    total += grade;
                    klass++;
                }
                else
                {
                    failed++;
                    if (failed == 2)
                    {
                        Console.WriteLine($"{studentName} has been excluded at {klass} grade");
                        break;
                    }
                }

                

            }
            if (klass == 13)
            {
                double average = total / 12;

                Console.WriteLine($"{studentName} graduated. Average grade: {average:f2}");
            }

        }
    }
}
