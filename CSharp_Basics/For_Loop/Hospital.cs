using System;

namespace Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int treatedPatients = 0;
            int untreated = 0;
            int doctors = 7;

            for (int i = 1; i <=n; i++)
            {
                int patient = int.Parse(Console.ReadLine());
                
                if (i % 3 == 0 && untreated > treatedPatients)
                {
                    doctors++;
                }
                if (patient > doctors)
                {
                    untreated += patient - doctors;
                    treatedPatients += doctors;
                }

                else
                {
                    treatedPatients += patient;
                }
            }
            

            Console.WriteLine($"Treated patients: {treatedPatients}.");
            Console.WriteLine($"Untreated patients: {untreated}.");
        }
    }
}
