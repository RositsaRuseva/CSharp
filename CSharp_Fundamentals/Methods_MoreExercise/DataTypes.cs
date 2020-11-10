using System;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();


            string input = Console.ReadLine();
            Type(type, input);
            
        }

        static void Type(string type, string input)
        {
            var result = 0;
            if (type == "int")
            {
                result = int.Parse(input) * 2;
                 Console.WriteLine(result);

            }
            else if (type == "real")
            {
                double result1 = double.Parse(input) * 1.5;
                Console.WriteLine($"{result1:F2}");
                 
            }
            else if(type == "string")
            {
                //string result2 = input;
                Console.WriteLine($"${input}$");
            }
            }
        }
    }

