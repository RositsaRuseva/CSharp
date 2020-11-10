using System;
using System.Collections.Generic;
using System.Linq;

namespace SeizeTheFire
{
    class Program
    {
        static void Main(string[] args)
        {
            var fire = Console.ReadLine().Split("#").ToList();
            int water = int.Parse(Console.ReadLine());

            double effort = 0;
           double totalFire = 0;
            //bool isValid = true;
            var newList= new List<int>();

            for (int i = 0; i <= fire.Count - 1; i++)
            {
                
                string type = fire[i].Split(" = ")[0];
                int cell = int.Parse(fire[i].Split(" = ")[1]);
                switch (type)
                {
                    case "High":
                        {
                            if(cell >= 81 && cell <= 125 && water >= cell)
                            {
                                newList.Add(cell);
                                water -= cell;
                                effort += cell * 0.25;
                                totalFire += cell;
                            }
                        }
                        break;
                    case "Medium":
                        {
                            if(cell >= 51 && cell <= 80 && water >= cell)
                            {
                                newList.Add(cell);
                                water -= cell;
                                effort += cell * 0.25;
                                totalFire += cell;

                            }
                        }
                        break;
                    case "Low":
                        {
                            if (cell >= 1 && cell <= 50 && water >= cell)
                            {
                                newList.Add(cell);
                                water -= cell;
                                effort += cell * 0.25;
                                totalFire += cell;

                            }
                        }
                        break;
                }

            }
            Console.WriteLine("Cells:");
            foreach (var item in newList)
            {
                Console.WriteLine($" - {item}");
            }
            Console.WriteLine($"Effort: {effort:f2}");
            Console.WriteLine($"Total Fire: {totalFire}");
            
        }
    }
}
