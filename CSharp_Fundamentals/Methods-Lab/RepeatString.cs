using System;
using System.Text;

namespace RepeatString
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(RepeatString(input, n));


        }
        private static string RepeatString(string input, int n)
        {
            StringBuilder result = new StringBuilder(input, n); 
            

            for (int i = 1; i < n; i++)
            {
                result.Append(input);
            }
            return result.ToString();
        }
    }
}
